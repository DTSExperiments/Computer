using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace UR_MTrack
{


    public partial class FrmPeriodsView : Form
    {
        #region Move Borderless Frame
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

        public event EventHandler<IEnumerable<PeriodValues>> PeriodsConfigured;
        public FrmPeriodsView()
        {
            InitializeComponent();
        }
       
        private void PeriodValuesChanged(object sender, PeriodChangedEventArgs e)
        {
            UpdatePeriods(e.Values);
        }

        public void Show(int cnt)
        {
            BuildPeriods(cnt);
            ShowDialog();
        }
        public void Show(IEnumerable<PeriodValues> pvalues)
        {
             BuildPeriods(pvalues);
             ShowDialog();
        }
        

        void BuildPeriods(int cnt)
        {
            flpCtrlHost.SuspendLayout();
            for(int i=1; i<=cnt; i++) 
            {
                var ctrl = new UCtrlPeriod(i);
                ctrl.PeriodChanged += PeriodValuesChanged;
                flpCtrlHost.Controls.Add(ctrl);
            }
            flpCtrlHost.ResumeLayout();
        }

        void BuildPeriods(IEnumerable<PeriodValues> valuecollection)
        {
            flpCtrlHost.SuspendLayout();
            foreach(var values in valuecollection)
            { 
                var ctrl = new UCtrlPeriod(values);
                ctrl.PeriodChanged += PeriodValuesChanged;
                flpCtrlHost.Controls.Add(ctrl);
            }
            flpCtrlHost.ResumeLayout();
        }

        void UpdatePeriods(PeriodValues values)
        {
            foreach (UCtrlPeriod ctrl in flpCtrlHost.Controls)
            {
                if (ctrl.Period.Number >= values.Number)
                { ctrl.UpdateControls(values); }
            }
        }

        IEnumerable<PeriodValues> GetPeriodValueCollection()
        {
            var collection= new List<PeriodValues>();
            foreach (UCtrlPeriod ctrl in flpCtrlHost.Controls)
            {
               collection.Add(ctrl.Period); 
            }
            return collection;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            PeriodsConfigured?.Invoke(this,GetPeriodValueCollection());
        }
    }
}
