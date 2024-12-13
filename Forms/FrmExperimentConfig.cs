using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Extensions;

namespace UR_MTrack
{
    public partial class FrmExperimentConfig : Form
    {
        #region WinApi import stuff
        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;
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
       

        #region Properties
        public ExperimentSettings Settings { get { return _expsettings; } }

        #endregion

        #region Events

        public event EventHandler ExperimentConfigChanged;

        #endregion

        #region Methods

        public void Show(ExperimentSettings _settings)
        {
            _expsettings = _settings;
            BindControls();
            Initialize();
            ShowDialog();
        }

        void BindControls()
        {
            cmbSerialPort.Items.Clear();
            cmbSerialPort.DataSource = new SerialInterface().PortNames;
            cmbDMSType.DataSource = Extension.BindEnumDescription(typeof(DMSType));
            cmbDMSType.DisplayMember = "Description";
            cmbDMSType.ValueMember = "value";
            cmbScope.DataSource = Extension.BindEnumDescription(typeof(Scope));
            cmbScope.DisplayMember = "Description";
            cmbScope.ValueMember = "value";
        }


        void Initialize()
        {
            tbDataPath.Text = _expsettings.Datapath;
            _periodsView = new FrmPeriodsView();
            _periodsView.PeriodsConfigured += _periodsView_PeriodsConfigured;
        }


        void CollectData()
        {
            _expsettings.Datapath = tbDataPath.Text;
            _expsettings.ExperimentDescription = rtbDescription.Text;
            _expsettings.COMPort = cmbSerialPort.SelectedItem.ToString();
            _expsettings.ORCID = tbOrcID.GetUlongValue();
            _expsettings.FirstName = tbFirstName.Text;
            _expsettings.LastName = tbLastName.Text;
            _expsettings.FlyName = tbFlyName.Text;
            _expsettings.FlyDescription = tbFlyDescription.Text;
            _expsettings.Recording = tbRecording.Text;
            _expsettings.Analysis = tbAnalysis.Text;
            _expsettings.DataModel = tbDataModel.Text;
            _expsettings.DMSType = cmbDMSType.SelectedItem.ToEnum<DMSType>();
            _expsettings.Scope = cmbScope.ToEnum<Scope>();

        }
        #endregion

        private void _periodsView_PeriodsConfigured(object sender, System.Collections.Generic.IEnumerable<PeriodValues> e)
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
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                CollectData();

            }
            catch (Exception ex) { Logging.Log(ex); }
            finally
            {
                ExperimentConfigChanged?.Invoke(this, EventArgs.Empty);
            }
        }


        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            try
            {
                new SerialInterface().CheckPort(new SerialPortSettings() { Portname = cmbSerialPort.SelectedItem.ToString() });
            }
            catch (Exception ex) { Logging.Log(ex); }
        }

        private void btnChangePath_Click(object sender, EventArgs e)
        {
            var path = new FileFactory().SelectFolderPath("Select new data folder", _expsettings.Datapath);
            _expsettings.Datapath = path;
            tbDataPath.Text = path;
        }

        private void btnLoadPeriod_Click(object sender, EventArgs e)
        {
            var path = new FileFactory().SelectFilePath("Open file", "XML files(.xml) | *.xml", _expsettings.Datapath);
            var periodscollection = new XmlFileFactory().ReadPeriodsFromXml(path);
            _periodsView.Show(periodscollection);
        }

        private void btnCreatePeriod_Click(object sender, EventArgs e)
        {
            using (new CenterDialog(this))
            {
                var dlg = new FrmInput(InputType.PeriodCount);
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    _periodsView.Show(dlg.PeriodsCount);
                }
            }
        }
    }
}
