using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using Extensions;

namespace UR_MTrack
{
    public class FileFactory
    {
        public FileFactory()
        { }

        public void CheckDefaultDirectories()
        {
            if (!Directory.Exists(Properties.Settings.Default.Datapath))
            { throw new DirectoryNotFoundException("Program Data Directory"); }
            if (!Directory.Exists(Properties.Settings.Default.DefaultPeriodPath))
            { throw new DirectoryNotFoundException("Default Data Directory"); }
            if (!Directory.Exists(Properties.Settings.Default.Logfilepath))
            { throw new DirectoryNotFoundException("LogFile Directory"); }
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
        /// open file and read its content. The initial directory is Desktop
        /// </summary>
        /// <param name="dlgTitle">the title shown in the title bar of the dialog.</param>
        /// <param name="extfilter">show only defined list of extensions.
        ///                         example: Text(*.txt)|*.txt|All Files (*.*)|*.*</param>
        /// <returns>filecontent as string</returns>
        public string OpenFile(bool usedlg = true, string dlgTitle = "", string extfilter = "", string filepath = "")
        {
            var path = filepath;
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
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            };
            using (var centerdlg = new CenterDialog())
            {
                if (DialogResult.OK == ofdlg.ShowDialog())
                { path = ofdlg.FileName; }
            }
            try
            { return File.ReadAllText(path); }
            catch (Exception)
            { throw; }
        }


        /// <summary>
        /// select  a file. The initial directory is Desktop
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
            catch (Exception ex) { Logging.Log(ex); return string.Empty; }
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
            catch (Exception ex) { Logging.Log(ex); return default(T); }
        }


        /// <summary>
        /// save string to file. 
        /// Attention: this method overewrites a file 
        /// without promt if it already exists.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="content"></param>
        public void SaveFile(string path, string content)
        {
            try
            {
                File.WriteAllText(path, content);
            }
            catch (Exception) { Logging.Log("Failed to save file.", LogType.Fail); }
        }

        /// <summary>
        /// save string collection (lines) to file. 
        /// Attention: this method overewrites a file 
        /// without promt if it already exists.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="content"></param>
        public void SaveFile(string path, IEnumerable<string> content)
        {
            try
            {
                File.WriteAllLines(path, content);
            }
            catch (Exception) { Logging.Log("Failed to save file.", LogType.Fail); }
        }
    }
}




