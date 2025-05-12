using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Xml.Linq;
using Logging;
using System.Linq;
using Extensions;

namespace UR_MTrack
{
    public class FileFactory
    {
        ExperimentSettings _settings;
        XmlFileFactory _xmlFileHandler;
        public FileFactory()
        { }
        public FileFactory(ExperimentSettings settings)
        {
            _settings = settings;
            _xmlFileHandler = new XmlFileFactory(_settings);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DirectoryNotFoundException"></exception>
        public void CheckDefaultDirectories()
        {
            if (!Directory.Exists(Properties.Settings.Default.SettingsPath))
            { throw new DirectoryNotFoundException("AppSettings Directory"); }
            if (!Directory.Exists(Properties.Settings.Default.LogfilePath))
            { throw new DirectoryNotFoundException("LogFile Directory"); }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public AppSettings LoadAppSettings()
        {
            var path = Path.Combine(Properties.Settings.Default.SettingsPath, Properties.Settings.Default.AppSettings);
            if (File.Exists(path))
            {
                return DeserializeSettings<AppSettings>(OpenFile(path));
            }
            else
            {
                Log.Append("Appsettings not found.");
                MessageBox.Show("Appsettings not found.","File Not Found",MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }            
            return new AppSettings();
        }


        public void SaveAppSettings(AppSettings settings)
        {
            var filepath = Path.Combine(Properties.Settings.Default.SettingsPath, Properties.Settings.Default.AppSettings);
            if (!string.IsNullOrEmpty(filepath))
            { WriteFile(filepath, SerializeToJSON(settings)); }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ExperimentSettings LoadExperimentSettings(bool defsettings = false)
        {
            var content = string.Empty;
            var path = string.Empty;
            try
            {
                if (defsettings) { path = Path.Combine(Properties.Settings.Default.SettingsPath, Properties.Settings.Default.DefExperimentSettings); }

                if (File.Exists(path))
                {
                    content = OpenFile(path);
                }
                else
                {
                    throw new FileNotFoundException("Experiment settings not found.");
                }
                return DeserializeSettings<ExperimentSettings>(content);
            }
            catch (Exception ex)
            {
                Log.Append(ex);
                return new ExperimentSettings();
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="settings">Object that holds the value collection.</param>
        /// <param name="defvalues">True if settings should be saved as default </param>
        /// /// <param name="usedlg">True if a dialog should be used for user defined path and/or filename.</param>
        public void SaveSettings(ExperimentSettings settings, bool defvalues = false, bool usedlg = false)
        {
            var filepath = Path.Combine(Properties.Settings.Default.SettingsPath, Properties.Settings.Default.DefExperimentSettings);
            if (!defvalues)
            {
                filepath = GetSettingsFileName(settings);
                if (usedlg)
                {
                    filepath = SaveFileDialog(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                                                    , "Save Experiment Settings"
                                                    , "Json(*.json)|*.json|All Files (*.*)|*.*");
                }
            }
            if (!string.IsNullOrEmpty(filepath))
            {
                WriteFile(filepath, SerializeToJSON(settings));
            }
        }


        public void CreateMeasurementFile()
        {
            try
            {
                new XmlFileFactory().BuildMeasFile().Save(_settings.Filepath);
                Log.Append("XML file created successfully.", LogType.Success, false);
            }
            catch (Exception ex)
            {
                Log.Append("Failed to create XML file.", LogType.Fail, true, ex.StackTrace);
            }
        }


        public void AppendPeriodValues(string line)
        {
            try
            {
                XDocument doc = XDocument.Load(_settings.Filepath);
                XElement element = doc.Descendants("csv_data").FirstOrDefault();

                if (!element.Equals(@""))
                {
                    element.Value = element.Value + line + Environment.NewLine;
                    doc.Save(_settings.Filepath);
                }
                else
                {
                    Log.Append(string.Format("XElement \"{0}\" not found.", "csv_data"));
                }
            }
            catch (Exception ex)
            {
                Log.Append(string.Format("An error occurred while changing value for XElement \"{0}\"\nStacktrace:\n{1}", "csv_data", ex.StackTrace));
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        public string CreateDirectory(string path)
        {
            if (!string.IsNullOrEmpty(path))
            {
                try
                {
                    Directory.CreateDirectory(path);
                    return path;
                }
                catch (Exception)
                {
                    Log.Append("Failed to create directory.");
                    MessageBox.Show("Failed to create directory.\n"+path, "Directory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return string.Empty;
        }


        /// <summary>
        /// select  a file. The initial directory is Desktop
        /// </summary>
        /// <returns>path to a Folder as string</returns>
        public string SelectFolderPath(string dlgTitle = "", string inidir = "")
        {

            var dlg = new FolderBrowserDialog()
            {
                ShowNewFolderButton = true,
            };

            if (string.IsNullOrEmpty(inidir))
            { dlg.RootFolder = Environment.SpecialFolder.Desktop; }

            using (var centerdlg = new CenterDialog())
            {
                if (DialogResult.OK == dlg.ShowDialog())
                {
                    return dlg.SelectedPath;
                }
                return string.Empty;
            }
        }


        /// <summary>
        /// Open a file and read its content without a filedialog.
        /// </summary>
        /// <param name="path">the absolute path to the file.</param>
        /// <returns>file content as string</returns>
        public string OpenFile(string path)
        {
            try
            { return File.ReadAllText(path); }
            catch (Exception ex)
            { Log.Append(ex); }
            return string.Empty;
        }


        /// <summary>
        /// Select a file from a dialog, open it and read its content.
        /// </summary>
        /// <param name="dlgTitle">the title shown in the title bar of the dialog.</param>
        /// <param name="extfilter">show only defined list of extensions.
        ///                         example: Text(*.txt)|*.txt|All Files (*.*)|*.*</param>
        /// <returns>filecontent as string</returns>
        public string OpenFile(string inidir, string dlgTitle = "", string extfilter = "")
        {
            var ofdlg = new OpenFileDialog()
            {
                CheckFileExists = true,
                CheckPathExists = true,
                Multiselect = false,
                ReadOnlyChecked = true,
                ShowReadOnly = false,
                SupportMultiDottedExtensions = true,
                Filter = extfilter,
                Title = dlgTitle,
                ValidateNames = true,
                InitialDirectory = inidir//Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            };
            using (var centerdlg = new CenterDialog())
            {
                try
                {
                    if (DialogResult.OK == ofdlg.ShowDialog())
                    {
                        return File.ReadAllText(ofdlg.FileName);
                    }
                }
                catch (Exception ex)
                { Log.Append(ex); }
                return string.Empty;
            }
        }


        /// <summary>
        /// Select the destination path for a file using a dialog.
        /// </summary>
        /// <param name="dlgTitle">the title shown in the title bar of the dialog.</param>
        /// <param name="extfilter">show only defined list of extensions.
        ///                         example: Text(*.txt)|*.txt|All Files (*.*)|*.*</param>
        /// <returns>filecontent as string</returns>
        string SaveFileDialog(string inidir, string dlgTitle = "", string extfilter = "")
        {
            var sfdlg = new SaveFileDialog()
            {
                CheckFileExists = true,
                CheckPathExists = true,
                SupportMultiDottedExtensions = true,
                Filter = extfilter,
                Title = dlgTitle,
                ValidateNames = true,
                InitialDirectory = inidir//Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            };
            using (var centerdlg = new CenterDialog())
            {
                try
                {
                    if (DialogResult.OK == sfdlg.ShowDialog())
                    {
                        return sfdlg.FileName;
                    }
                }
                catch (Exception ex)
                { Log.Append(ex); }
                return string.Empty;
            }
        }


        /// <summary>
        /// Select  a file using the openfiledialog. The initial directory is Desktop
        /// </summary>
        /// <param name="extfilter">show only defined list of extensions.
        ///                         example: Text(*.txt)|*.txt|All Files (*.*)|*.*</param>
        ///                         default is licensefile extension.
        /// <returns>file path as string</returns>
        public string SelectFilePath(string dlgTitle = "", string extfilter = "", string inidir = "")
        {
            var ofdlg = new OpenFileDialog()
            {
                InitialDirectory = inidir,
                CheckFileExists = true,
                CheckPathExists = true,
                Multiselect = false,
                ReadOnlyChecked = true,
                ShowReadOnly = false,
                SupportMultiDottedExtensions = true,
                Filter = extfilter,
                Title = dlgTitle,
                ValidateNames = true
            };
            if (string.IsNullOrEmpty(inidir))
            { ofdlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); }

            using (var centerdlg = new CenterDialog())
            {
                if (DialogResult.OK == ofdlg.ShowDialog())
                {
                    return ofdlg.FileName;
                }
                return string.Empty;
            }
        }


        /// <summary>
        /// serialize data to json string.
        /// </summary>
        /// <param name="obj"></param>e
        /// <returns></returns>
        public string SerializeToJSON<T>(T obj)
        {
            try
            {
                return JsonConvert.SerializeObject(obj, Formatting.Indented);
            }
            catch (Exception ex) { Log.Append(ex); return string.Empty; }
        }


        /// <summary>
        /// deserialize  data from json string
        /// </summary>
        /// <param name="filecontent"></param>
        T DeserializeSettings<T>(string filecontent)
        {
            try
            {
                if (string.IsNullOrEmpty(filecontent))
                { return default(T); }
                else
                {
                    var data = JsonConvert.DeserializeObject<T>(filecontent);
                    return data;
                }
            }
            catch (Exception ex) { Log.Append(ex); return default(T); }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="exsettings"></param>
        /// <returns></returns>
        string GetSettingsFileName(ExperimentSettings exsettings)
        {
            var filename = string.Format("{0}_{1}{2}_ExpConfig_{3}{4}", DateTime.Now.ToString("yyMMdd_HHmm"),
                                                                  exsettings.FirstName,
                                                                  exsettings.LastName,
                                                                  exsettings.FlyName, ".json");
            return Path.Combine(exsettings.DataFolderpath, filename);
        }


        /// <summary>
        /// save string to file. 
        /// Attention: this method overwrites a file 
        /// without promt if it already exists.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="content"></param>
        public void WriteFile(string path, string content)
        {
            try
            {
                File.WriteAllText(path, content);
            }
            catch (Exception) { Log.Append("Failed to save file.", LogType.Fail); }
        }


        /// <summary>
        /// save string collection (lines) to file. 
        /// Attention: this method overewrites a file 
        /// without promt if it already exists.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="content"></param>
        void WriteFile(string path, IEnumerable<string> content)
        {
            try
            {
                File.WriteAllLines(path, content);
            }
            catch (Exception) { Log.Append("Failed to save file.", LogType.Fail); }
        }

        void DeleteFile(string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }
    }
}




