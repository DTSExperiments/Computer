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
        public FileFactory()
        { }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DirectoryNotFoundException"></exception>
        public void CheckDefaultDirectories()
        {
            if (!Directory.Exists(Properties.Settings.Default.AppSettingsPath))
            { throw new DirectoryNotFoundException("AppSettings Directory"); }
            if (!Directory.Exists(Properties.Settings.Default.LogfilePath))
            { throw new DirectoryNotFoundException("LogFile Directory"); }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="settings"></param>
        /// <param name="usedlg"></param>
        public void SaveSettings(ExperimentSettings settings, bool usedlg = false)
        {
            var filepath = GetSettingsFileName(settings);
            if (usedlg)
            {
                filepath = SaveFileDialog(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                                                , "Save Experiment Settings"
                                                , "Json(*.json)|*.json|All Files (*.*)|*.*");
            }
            if (!string.IsNullOrEmpty(filepath))
            {
                WriteFile(filepath, SerializeToJSON(settings));
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ExperimentSettings LoadSettings(bool defsettings = false)
        {
            var content = string.Empty;
            try
            {
                if (defsettings)
                {
                    content = OpenFile(Path.Combine(Properties.Settings.Default.AppSettingsPath,
                                                    Properties.Settings.Default.AppSettingsFilename));
                }
                else
                {
                    content = OpenFile(Properties.Settings.Default.AppSettingsPath, "Load Experiment", "Settings(*.JSON)|*.Json|All Files (*.*)|*.*");
                }
                return DeserializeSettings<ExperimentSettings>(content);
            }
            catch (Exception ex)
            {
                Log.Append(ex);
                return new ExperimentSettings();
            }
        }

        public void CreateMeasurementFile(ExperimentSettings settings)
        {
            using (var xmlFactory = new XmlFileFactory(settings))
            {
                try
                {
                    xmlFactory.BuildMeasFile().Save(settings.Filepath);
                    Log.Append("XML file created successfully.", LogType.Success, false);
                }
                catch (Exception ex)
                {
                    Log.Append("Failed to create XML file.", LogType.Fail, true, ex.StackTrace);
                }
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
                catch (Exception ex)
                {
                    throw new Exception("Failed to create directory " + path, ex);
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
                catch (Exception)
                { throw; }
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
            return Path.Combine(exsettings.Datapath, filename);
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




