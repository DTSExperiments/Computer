using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using (var sp = new FrmSplashScreen())
            {
                sp.Show();
                try
                {
                    Log.CheckDirPath(Properties.Settings.Default.LogfilePath);
                }catch (Exception ex) {sp.Message = ex.Message;}
            }
            Application.Run(new Main());
        }
    }
}
