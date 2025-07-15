using Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace UR_MTrack
{


    public partial class FrmPeriodsView : Form
    {
        #region WinAPI import stuff
        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;
        const int CS_DROPSHADOW = 0x20000;
        [DllImportAttribute("user32.dll")]
        static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        static extern bool ReleaseCapture();


        #endregion


        public FrmPeriodsView()
        {
            InitializeComponent();
        }

        #region Overrides

        /// <summary>
        /// This gives the drop shadow behind the borderless form
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        #endregion

        private void PeriodValuesChanged(object sender, PeriodChangedEventArgs e)
        {
            UpdatePeriods(e.Values);
        }

        public void Show(int cnt)
        {
            if (!DesignMode)
            {
                PopulatePeriodCtrls(BuildPeriods(cnt));
                ShowDialog();
            }
        }
        public void Show(IEnumerable<PeriodValues> pvalues)
        {
            if (!DesignMode)
            {
                PopulatePeriodCtrls(pvalues);
                ShowDialog();
            }
        }


        IEnumerable<PeriodValues> BuildPeriods(int cnt)
        {
            var periods = new List<PeriodValues>();
            for (int i = 1; i <= cnt; i++)
            {
                periods.Add(new PeriodValues(i));
            }
            return periods;
        }


        void PopulatePeriodCtrls(IEnumerable<PeriodValues> valCollection)
        {
            flpCtrlHost.SuspendLayout();
            if (flpCtrlHost.Controls.Count > 0) { flpCtrlHost.Controls.Clear(); }
            foreach (var values in valCollection)
            {
                var ctrl = new UCtrlPeriod(values);
                ctrl.PeriodChanged += PeriodValuesChanged;
                flpCtrlHost.Controls.Add(ctrl);
            }
            flpCtrlHost.ResumeLayout();
        }


        /// <summary>
        /// Set same values for periods with greater Id
        /// </summary>
        /// <param name="values"></param>
        /// <param name="updmode"></param>
        void UpdatePeriods(PeriodValues values)
        {
            /// check if any of the controls are selected 
            if (flpCtrlHost.Controls.OfType<UCtrlPeriod>().Any(p => p.Selected))
            {
                ///grab controls that are selected      
                flpCtrlHost.Controls.ToList<UCtrlPeriod>().Where(ctrl => ctrl.Selected)
                                                          .Select(ctrl => { ctrl.UpdateControls(values); return ctrl; }).ToList();
            }
            else
            {
                ///grab controls with id greater than the sourcing valueset. 
                flpCtrlHost.Controls.ToList<UCtrlPeriod>().Where(ctrl => ctrl.Period.Number > values.Number)
                                                          .Select(ctrl => { ctrl.UpdateControls(values); return ctrl; }).ToList();
            }
            /// apply values to listed controls
            foreach (UCtrlPeriod ctrl in flpCtrlHost.Controls)
            {
                if (ctrl.Period.Number >= values.Number)
                { ctrl.UpdateControls(values); }
            }
        }


        IEnumerable<PeriodValues> GetPeriodValueCollection()
        {
            var collection = new List<PeriodValues>();
            foreach (UCtrlPeriod ctrl in flpCtrlHost.Controls)
            {
                collection.Add(ctrl.Period);
            }
            return collection;
        }


        void DeleteSelected()
        {
            var controls = flpCtrlHost.Controls.Cast<UCtrlPeriod>().ToList();
            controls.RemoveAll(p => p.Selected);
            controls.ForEach(p => p.Period.Number = controls.IndexOf(p) + 1);
            foreach (var ctrl in controls)
            { ctrl.BindControls(); }
            flpCtrlHost.Controls.Clear();
            flpCtrlHost.Controls.AddRange(controls.ToArray());
        }


        private void MoveFrame_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            new Signals().OnPeriodsConfigured(this, GetPeriodValueCollection());
        }

        private void btnCreatePeriod_Click(object sender, EventArgs e)
        {
            if (flpCtrlHost.Controls.Count > 0)
            {
                var dlgre = MessageBox.Show("Periods will be deleted. \nContinue?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dlgre == DialogResult.Yes) { flpCtrlHost.Controls.Clear(); }
                else { return; }
            }
            using (new CenterDialog(this))
            {
                var dlg = new FrmInput(InputType.PeriodCount);
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    PopulatePeriodCtrls(BuildPeriods(dlg.PeriodsCount));
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DeleteSelected();
            Invalidate();
        }

        private void btnLoadPeriod_Click(object sender, EventArgs e)
        {
            if (flpCtrlHost.Controls.Count > 0)
            {
                var dlgres = MessageBox.Show("Periods will be deleted. \nContinue?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dlgres == DialogResult.Yes) { flpCtrlHost.Controls.Clear(); }
                else { return; }
            }
            var path = new FileFactory().SelectFilePath("Open file", "XML files(.xml) | *.xml");
            if (!string.IsNullOrEmpty(path))
            {
                var periodscollection = new XmlFileFactory().ReadPeriodsFromXml(path);
                PopulatePeriodCtrls(periodscollection);
            }
        }
    }
}
