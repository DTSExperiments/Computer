using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Logging;


namespace UR_MTrack
{
    internal static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ThreadExceptionHandler thExHandler = new ThreadExceptionHandler();
            Application.ThreadException += new ThreadExceptionEventHandler(thExHandler.Application_ThreadException);
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            
            try
            {
                Log.CheckDirPath(Properties.Settings.Default.LogfilePath);
                Application.Run(new Main());
            }
            catch (Exception ex) { MessageBox.Show(ex.StackTrace, ex.Message, MessageBoxButtons.OK); }
        }

    }
}
