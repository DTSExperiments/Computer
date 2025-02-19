using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logging;

namespace UR_MTrack
{
    public partial class TraceView : Form
    {
        public TraceView()
        {
            InitializeComponent();

            Log.LogMessageReceive += Logging_LogMessageReceive;
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
