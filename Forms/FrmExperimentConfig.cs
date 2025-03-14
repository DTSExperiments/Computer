﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Extensions;
using Logging;

namespace UR_MTrack
{
    public partial class FrmExperimentConfig : Form
    {
        #region WinApi import stuff
        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;
        const int CS_DROPSHADOW = 0x20000;

        [DllImportAttribute("user32.dll")]
        static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        static extern bool ReleaseCapture();

       
        #endregion

        ExperimentSettings _expsettings;
        FrmPeriodsView _periodsView;
        public FrmExperimentConfig()
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

        #region Properties
        public ExperimentSettings Settings { get { return _expsettings; } }

        #endregion

        #region Events

        public event EventHandler ExperimentConfigChanged;

        #endregion

        #region Methods

        public DialogResult ShowDialog(ExperimentSettings _settings)
        {
            _expsettings = _settings;
            if (!DesignMode) { BindControls(); }
            Initialize();
            return ShowDialog();
        }

        void BindControls()
        {            
            cmbDMSType.DataSource = Extension.BindEnumDescription(typeof(DMSType));
            cmbDMSType.DisplayMember = "Description";
            cmbDMSType.ValueMember = "value";
            cmbScope.DataSource = Extension.BindEnumDescription(typeof(ArenaType));
            cmbScope.DisplayMember = "Description";
            cmbScope.ValueMember = "value";
        }


        void Initialize()
        {
            _periodsView = new FrmPeriodsView();
            _periodsView.PeriodsConfigured += _periodsView_PeriodsConfigured;
            if (_expsettings != null)
            {
                tbDataPath.Text = _expsettings.Datapath;
                tbSamplingRate.Text = _expsettings.SamplingRate.ToString();
                tbFirstName.Text = _expsettings.FirstName;
                tbLastName.Text = _expsettings.LastName;
                tbOrcID.Text = _expsettings.ORCID;
                tbFlyName.Text = _expsettings.FlyName;
                tbFlyDescription.Text = _expsettings.FlyDescription;
                tbFlyBase.Text = _expsettings.FlyBase;
                rtbDescription.Text = _expsettings.ExperimentDescription;
                tbRecording.Text = _expsettings.Recording;
                tbAnalysis.Text = _expsettings.Analysis;
                tbDataModel.Text = _expsettings.DataModel;
            }
        }

        bool IsComplete()
        {
            var list = new List<bool>();
            foreach (Control control in tblConfig.Controls)
            {
                if (control is WMTextBox&&string.IsNullOrEmpty(control.Text))
                {
                    list.Add(false);
                    (control as WMTextBox).Highlight();
                }
                else if (control is RichTextBox&&string.IsNullOrEmpty(control.Text))
                {
                    list.Add(false);
                    (control as RichTextBox).BackColor = Color.FromArgb(255, 192, 128);
                }
            }
            return !list.Contains(false);
        }

        void CollectData()
        {
            _expsettings.TimeStamp = DateTime.Now;
            _expsettings.Datapath = tbDataPath.Text;
            _expsettings.ExperimentDescription = rtbDescription.Text;
            _expsettings.SamplingRate = tbSamplingRate.GetIntValue();
            _expsettings.ORCID = tbOrcID.Text;
            _expsettings.FirstName = tbFirstName.Text;
            _expsettings.LastName = tbLastName.Text;
            _expsettings.FlyName = tbFlyName.Text;
            _expsettings.FlyDescription = tbFlyDescription.Text;
            _expsettings.FlyBase = tbFlyBase.Text;
            _expsettings.Recording = tbRecording.Text;
            _expsettings.Analysis = tbAnalysis.Text;
            _expsettings.DataModel = tbDataModel.Text;
            _expsettings.DMSType = cmbDMSType.SelectedItem.ToEnum<DMSType>();
            _expsettings.Arena = cmbScope.ToEnum<ArenaType>();

        }

        #endregion

        private void _periodsView_PeriodsConfigured(object sender, IEnumerable<PeriodValues> e)
        {
            _expsettings.PeriodCollection = e;
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
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                var check = IsComplete();
                if (check)
                {
                    CollectData();
                    new FileFactory().SaveSettings(_expsettings);
                    ExperimentConfigChanged?.Invoke(this, EventArgs.Empty);
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    using (new CenterDialog(this))
                    {
                        MessageBox.Show("Please add the missing information to the highlighted fields.", "Missing Data",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex) { Log.Append(ex); }
        }


        private void btnChangePath_Click(object sender, EventArgs e)
        {
            var path = new FileFactory().SelectFolderPath("Select new data folder", _expsettings.Datapath);
            _expsettings.Datapath = path;
            tbDataPath.Text = path;
        }

        private void btnShowPeriod_Click(object sender, EventArgs e)
        {
            _periodsView.Show(_expsettings.PeriodCollection);
        }

        private void rtbDescription_MouseDown(object sender, MouseEventArgs e)
        {
            rtbDescription.BackColor = Color.WhiteSmoke;
        }

    }
}
