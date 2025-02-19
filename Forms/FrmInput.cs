using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Extensions;

namespace UR_MTrack
{
    public enum InputType
    {
        PeriodCount,
        ExperimentCreation,
        Open,
        New
    }

    public partial class FrmInput : Form
    {

        #region WinApi import stuff
        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        static extern bool ReleaseCapture();
        #endregion


        InputType _currenttype;
        InputType _experimentCreation;
        
        public FrmInput(InputType type)
        {
            _currenttype=type;
            InitializeComponent();
            Initialize();
        }

        #region Properties

        public int PeriodsCount { get; set; }
        public InputType CreationType { get; set; }

        public new string Text { get { return tBar.Titel; }set { tBar.Titel = value; } }

        #endregion
               

        void Initialize()
        {
            Text = _currenttype.ToString();
            SuspendLayout();
            switch (_currenttype)
            {
                case InputType.PeriodCount:
                    {
                        tblPeriodCnt.Visible = true;
                        tbPeriodCnt.Focus();
                        break; 
                    }
                case InputType.ExperimentCreation: 
                    { 
                        tblPrjType.Visible = true;
                        btnOk.Visible = false;
                        btnCancel.Visible = false;
                        break; 
                    }
            }
            ResumeLayout();
        }

        private void btApply_Click(object sender, EventArgs e)
        {
            switch (_currenttype)
            {
                case InputType.PeriodCount:
                    {
                        if (!string.IsNullOrEmpty(tbPeriodCnt.Text))
                        {
                            PeriodsCount=tbPeriodCnt.GetIntValue();
                            DialogResult = DialogResult.OK;
                            Close();
                        }
                        else 
                        {  
                            tbPeriodCnt.Highlight();
                        }
                        break;
                    }
                case InputType.ExperimentCreation:
                    { 
                        break; 
                    }
            }
        }

        private void MoveFrame_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Return)) { btApply_Click(null, null); }
            if (e.KeyCode.Equals(Keys.Escape)) { btnCancel_Click(null, null); }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            
            CreationType=InputType.New;
            DialogResult= DialogResult.OK;  
        }

        private void curveButton2_Click(object sender, EventArgs e)
        {
            CreationType = InputType.Open;
            DialogResult = DialogResult.OK;

        }

    }
}