using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace UR_MTrack
{
    public partial class FrmProcessControl : Form
    {
        #region WinApi to enable FormMovement
        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        static extern bool ReleaseCapture();

        private void MoveFrame_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        ExecutionControl _currentState = ExecutionControl.stop;

        public FrmProcessControl()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        public void Show(Point center)
        {
            Location = new Point(center.X - Width / 2, center.Y);
            Show();
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (_currentState == ExecutionControl.stop)
            {
                new Signals().OnAquisitionControl(this, ExecutionControl.start);
                _currentState = ExecutionControl.start;
                btnStartResume.BackgroundImage = Properties.Resources.Pause;
                btnStartResume.BackColor = Color.Green;
            }
            else
            {
                new Signals().OnAquisitionControl(this, ExecutionControl.suspend);
                _currentState = ExecutionControl.suspend;
                btnStartResume.BackgroundImage = Properties.Resources.Play;
                btnStartResume.BackColor = Color.Transparent;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (_currentState == ExecutionControl.start || _currentState == ExecutionControl.suspend)
            {
                new Signals().OnAquisitionControl(this, ExecutionControl.stop);
                _currentState = ExecutionControl.stop;
                btnStartResume.BackgroundImage = Properties.Resources.Play;
                btnStartResume.BackColor = Color.Transparent;
            }
        }

        private void btnPunish_Click(object sender, EventArgs e)
        {
            new Signals().OnAquisitionControl(this, ExecutionControl.punish);
        }
    }
}
