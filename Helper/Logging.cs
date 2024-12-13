using System;
using System.Diagnostics;
using System.Collections.Concurrent;
using System.IO;
using System.Windows.Forms;
using Extensions;

namespace UR_MTrack

{
    /// <summary>
    /// Class for logging the events
    /// </summary>
    public static class Logging
    {
        static string _logfilepath;


        #region Events
        public static event EventHandler<LogEventArgs> LogMessageReceive;
        #endregion

        /// <summary>
        /// Path to the current log file.
        /// </summary>
        public static string LogFilePath
        {
            get
            {
                return _logfilepath;
            }
        }

        /// <summary>
        /// write statement to logfile.
        /// </summary>
        /// <param name="line"></param>
        static void WriteToFile(string line)
        {
            if (!Directory.Exists(Properties.Settings.Default.Logfilepath)) { return; }
            if (string.IsNullOrEmpty(_logfilepath)) { CreateLogFile(); }

            try
            {
                using (var sw = new StreamWriter(_logfilepath, true))
                {
                    sw.Write(line);
                    sw.Flush();
                }
            }
            catch (Exception) { }
        }

        public static void Log(string logMessage, LogType logtype = LogType.Info, bool showmsgbox = false, string exceptionMessage = null)
        {
            var tag = logtype.ToString();
            var line = string.Format("\n{0} {1} {2}", DateTime.Now.ToLongTimeString() + "  -  ", tag + " - ", logMessage);
            switch (logtype)
            {
                case LogType.Success:
                case LogType.Info:
                case LogType.Warning:
                    {
                        WriteToFile(line);
                        LogMessageReceive?.Invoke(null, new LogEventArgs(line, logtype, showmsgbox));
                        break;
                    }
                case LogType.Error:                 
                case LogType.Fail:
                    {
#if DEBUG
                        Debug.WriteLine(exceptionMessage + Environment.NewLine +line );
#endif
                        WriteToFile(logtype.ToDescriptionString<LogType>()+Environment.NewLine+ exceptionMessage + Environment.NewLine + line);
                        break;
                    }
            }
        }

        public static void Log(Exception ex)
        {
            var line = string.Format("\n{0} {1} {2}", DateTime.Now.ToLongTimeString() + "  -  ", 
                                     ex.Message + "\n", ex.StackTrace);
        }

        /// <summary>
        /// Creates a new filename for Logfiles and returns the full path.
        /// </summary>
        /// <returns>fully qualified path to file</returns>
        public static void CreateLogFile()
        {
            var filename = "ApplicationLog_" + DateTime.Now.ToString("ddMMyy_HHmmssf") + ".log";
            _logfilepath = Path.Combine(Properties.Settings.Default.Logfilepath, filename);
        }
    }
}