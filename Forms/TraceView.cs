using Logging;
using System;
using System.Windows.Forms;

namespace UR_MTrack
{
    public partial class TraceView : Form
    {
        public TraceView()
        {
            InitializeComponent();

            Log.LogMessageReceived += Logging_LogMessageReceive;
        }


        private void Logging_LogMessageReceive(object sender, LogEventArgs e)
        {
            if (rtbLogBox.IsHandleCreated)
            {
                rtbLogBox.Invoke((MethodInvoker)(() => rtbLogBox.AppendText(e.Message)));
                rtbLogBox.Invoke((MethodInvoker)(() => rtbLogBox.ScrollToCaret()));
            }
        }

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            rtbLogBox.Clear();
        }
    }
}
