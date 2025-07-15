using System;
using System.Threading;
using System.Windows.Forms;

namespace UR_MTrack
{
    internal class ThreadExceptionHandler
    {
        public void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            try
            {
                DialogResult result = ShowThreadExceptionDialog(e.Exception);
                if (result == DialogResult.Abort)
                    Application.Exit();
            }
            catch
            {
                try
                {
                    MessageBox.Show("Fatal Error", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                finally
                {
                    Application.Exit();
                }
            }
        }


        private DialogResult ShowThreadExceptionDialog(Exception ex)
        {
            string errorMessage = "Unhandled Exception:\n\n" + ex.Message + "\n\n" + ex.GetType() + "\n\nStack Trace:\n" + ex.StackTrace;
            return MessageBox.Show(errorMessage, "Application Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Stop);
        }
    }
}
