using System;
using System.Diagnostics;
using System.Collections.Concurrent;
using System.IO;
using System.Windows.Forms;
using Extensions;
using System.ComponentModel;
using System.Text;

namespace Logging
{
    public class LogEventArgs : EventArgs
    {
        /// <summary>
        /// Show a message box 
        /// </summary>
        public bool IsShowMsgBox { get; private set; }

        /// <summary>
        /// A title to the message for e.g. showing in messagebox
        /// </summary>
        public string Title { get; private set; }

        /// <summary>
        /// The message to be logged
        /// </summary>
        public string Message { get; private set; }
        public System.Windows.Forms.MessageBoxIcon Icon { get; set; }


        public LogEventArgs(string message, LogType messagetype, bool showmsgbox)
        {
            IsShowMsgBox = showmsgbox;
            Message = message;
            Title = messagetype.ToString();

            if (messagetype == LogType.Error) { Icon = System.Windows.Forms.MessageBoxIcon.Error; }
            else if (messagetype == LogType.Warning) { Icon = System.Windows.Forms.MessageBoxIcon.Warning; }
            else
            {
                Icon = System.Windows.Forms.MessageBoxIcon.Information;
            }
        }
    }

    /// <summary>
    /// scope of the logging facility.
    /// </summary>
    public enum LogType
    {
        [Description("Debug ")]
        Debug,
        [Description("Success ")]
        Success,
        [Description("Information: ")]
        Info,
        [Description("")]
        FileLog,
        [Description("Warning: ")]
        Warning,
        [Description("Error occured ")]
        Error,
        [Description("Failed ")]
        Fail
    }


    /// <summary>
    /// Class for logging the events
    /// </summary>
    public static class Log
    {
        #region Events
        public static event EventHandler<LogEventArgs> LogMessageReceived;
        #endregion



        /// <summary>
        /// Path to the current log file.
        /// </summary>
        public static string LogFilePath { get; private set; }

        public static bool CheckDirPath(string path)
        {
            if (!Directory.Exists(path)) { return false; }
            LogFilePath = CreateLogFile(path);
            return true;
        }

        public static void Append(string logMessage, LogType logtype = LogType.Info, bool showmsgbox = false, string exceptionMessage = null)
        {
            var tag = logtype.ToString();
            var line = string.Format("\n{0} {1} {2}\n{3}", DateTime.Now.ToLongTimeString() + "  -  ", tag + " - ", logMessage,exceptionMessage);
            WriteToFile(line);
            LogMessageReceived?.Invoke(null, new LogEventArgs(line, logtype, showmsgbox));
#if DEBUG
            Debug.WriteLine(exceptionMessage + Environment.NewLine + line);
#endif
        }


        public static void Append(Exception ex)
        {
            var line = string.Format("\n{0} {1} {2}", "Exeption [" + ex.Source + "]  -  ", ex.Message + "\n", ex.StackTrace);
            WriteToFile(line);

#if DEBUG
            LogMessageReceived?.Invoke(null, new LogEventArgs(line, LogType.Debug, false));
            Debug.WriteLine(line);
#endif
        }


        /// <summary>
        /// Creates a new filename for Logfiles and returns the full path.
        /// </summary>
        /// <returns>fully qualified path to file</returns>
        static string CreateLogFile(string folderpath)
        {
            var filename = "ApplicationLog_" + DateTime.Now.ToString("ddMMyy_HHmmssf") + ".log";
            return Path.Combine(folderpath, filename);
        }


        /// <summary>
        /// write statement to logfile.
        /// </summary>
        /// <param name="line"></param>
        static void WriteToFile(string line)
        {
            try
            {
                using (var sw = new StreamWriter(LogFilePath, true))
                {
                    sw.Write(line.Insert(0, DateTime.Now.ToLongTimeString()));
                    sw.Flush();
                }
            }
            catch (FileNotFoundException ex) { MessageBox.Show("File Not Found", "Logfile corrupted or deleted.\nAttempt restarting the software to resolve this issue."); }
        }




    }
}