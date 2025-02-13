using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UR_MTrack
{
    public partial class FrmExperimentControl : Form
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

        ExperimentState _currentState=ExperimentState.stop;
       
        public event EventHandler<ExpControlEventArgs> ExpStateChanged; 

        public FrmExperimentControl()
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
            if (_currentState == ExperimentState.suspend||_currentState == ExperimentState.stop)
            {                 
                _currentState = ExperimentState.start;
                btnStartResume.BackgroundImage=Properties.Resources.Pause;
                ExpStateChanged?.Invoke(this, new ExpControlEventArgs(ExperimentState.start));
                btnStartResume.BackColor = Color.Green;
            }
            else
            {                
                _currentState = ExperimentState.suspend;    
                btnStartResume.BackgroundImage=Properties.Resources.Play;
                ExpStateChanged?.Invoke(this, new ExpControlEventArgs(ExperimentState.suspend));
                btnStartResume.BackColor = Color.Transparent;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            _currentState = ExperimentState.stop;
            btnStartResume.BackgroundImage=Properties.Resources.Play;
            btnStartResume.BackColor = Color.Transparent;
            ExpStateChanged?.Invoke(this, new ExpControlEventArgs(ExperimentState.stop));            
        }

        private void btnPunish_Click(object sender, EventArgs e)
        {
            ExpStateChanged?.Invoke(this, new ExpControlEventArgs(ExperimentState.punish));
        }
    }
}
