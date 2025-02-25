
using Extensions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Logging;
using UR_MTrack.Controls;


namespace UR_MTrack
{
    public partial class Main : Form
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

        
        public int nextValueIndex = 0;

        SerialInterface _serialCom;
        XmlFileFactory _xmlBuilder;
        SerialPortSettings _serialPortSettings;
        ExperimentSettings _currentExperimentSettings;
        DataHandler _datahandler;
        UCtrlChart _chart;
        UCtrlExpAdjust _ctrlExpAdjust;
        FrmExperimentConfig _experimentConfig;
        FrmExperimentControl _experimentCtrl;
        FrmPeriodsView _periodsView;



        public Main()
        {            
            InitializeComponent();
            InitializeControl();
//#if DEBUG
//            new TraceView().Show();
//#endif
        }

        protected override void OnResizeBegin(EventArgs e)
        {
            SuspendLayout();
            base.OnResizeBegin(e);
        }

        protected override void OnResizeEnd(EventArgs e)
        {
            base.OnResizeEnd(e);
            ResumeLayout();
        }
        protected override void OnLoad(EventArgs e)
        {
            //Thread t = new Thread(new ThreadStart(Splash));
            //t.Start();
            //Thread.Sleep(3000);
            base.OnLoad(e);
            //t.Abort();
            
        }

        protected override void OnShown(EventArgs e)
        {
            // BackgroundImage = Properties.Resources._6.SetImgOpacity(40);
            base.OnShown(e);
            using (new CenterDialog(this))
            {
                var dlg = new FrmInput(InputType.ExperimentCreation);
                var res = dlg.ShowDialog();
                if(res != DialogResult.OK) { return; }
                else if (res == DialogResult.OK && dlg.CreationType == InputType.Open)
                {
                    _currentExperimentSettings = new FileFactory().LoadSettings();
                }
                ShowExperimentConfig();
            }
        }
        public void Splash()
        {
            Application.Run(new FrmSplashScreen());
        }

        private void _serialCom_DataReceived(object sender, DataReceivedEventArgs e)
        {
            _datahandler.AddMValues(e.Bytes);
            foreach (byte b in e.Bytes)
            {
                Log.Append(string.Format("Received data on serial port - \"{0}\"", b.ToString()), LogType.Info);
            }
        }

        private void _ctrlExpAdjust_Rotate(object sender, RotateEventArgs e)
        {
            Log.Append(string.Format("Arena rotation requested - \"{0}\"", e.Rotation.ToDescriptionString<RotationMode>()), LogType.Info);
            if (_serialCom.Connected) { _serialCom.SendData(new FPGACom().GetRotateCommand(e.Rotation, (byte)e.Angle)); }
        }

        private void _ctrlExpAdjust_SerialConnect(object sender, string e)
        {
            Log.Append(string.Format("Serial connection requested to port \"{0}\"", e), LogType.Info);
            _serialPortSettings.Portname = e;
            ConnectToSerialPort();
        }

        private void _ctrlExpAdjust_SetPattern(object sender, PatternEventArgs e)
        {
            Log.Append(string.Format("Arena pattern change requested - \"{0}\"", e.Pattern.ToDescriptionString<DisplayPattern>()), LogType.Info);
            if (_serialCom.Connected) { _serialCom.SendData(new FPGACom().GetPatternCommand(e.Pattern, e.Color)); }
        }

        private void _ctrlExpAdjust_LaserSwitch(object sender, int e)
        {
            Log.Append(string.Format("Laser triggered - PWM (0-100): \"{0}\"", e), LogType.Info);
            if (_serialCom.Connected) { _serialCom.SendData(new FPGACom().GetLaserCommand(e)); }
            if (e > 0) { _currentExperimentSettings.LaserPWMValue = e; }
        }

        private void _ctrlExpAdjust_AdjustmentFinished(object sender, EventArgs e)
        {
            Log.Append(string.Format("Adjustment finished."), LogType.Info);
            ShowHistogram();
            ShowExperimentControl();
        }

        private void _experimentCtrl_ExpStateChanged(object sender, ExpControlEventArgs e)
        {
            Log.Append(string.Format("Experiment status change requested - \"{0}\"", e.ExState.ToDescriptionString<ExperimentState>()), LogType.Info);
            switch (e.ExState)
            {
                case ExperimentState.start:
                    {
                        try
                        {
                            new FileFactory().CreateMeasurementFile(_currentExperimentSettings);
                        }
                        catch (Exception ex) { Log.Append(ex); }
                        break;
                    }
                case ExperimentState.suspend:
                    { break; }
                case ExperimentState.resume:
                    { break; }
                case ExperimentState.stop:
                    { break; }
                case ExperimentState.punish:
                    { break; }
                default: break;
            }
        }

        private void Main_ExperimentConfigChanged(object sender, EventArgs e)
        {
            _currentExperimentSettings = (sender as FrmExperimentConfig).Settings;
            if (_ctrlExpAdjust == null) { ShowExperimentAdjust(); }
            ShowChart();
            Log.Append("Experiment metadata changed", LogType.Info);
        }

        void InitializeControl()
        {
            tBarMain.Titel = new AboutBox().AssemblyTitle;
            Log.Append("Initializing Objects", LogType.Info);
            _serialPortSettings = new SerialPortSettings();
            _currentExperimentSettings = new ExperimentSettings();
            
            /*
             */
            Log.Append("Initializing Controls", LogType.Info);


            _datahandler = new DataHandler(ref _currentExperimentSettings);
            _experimentCtrl = new FrmExperimentControl();
            _experimentCtrl.ExpStateChanged += _experimentCtrl_ExpStateChanged;
           
            Log.Append("Finished Initialization", LogType.Info);
        }

        void ConnectToSerialPort()
        {
            if(_serialCom!=null&&_serialCom.Connected)
            { _serialCom.Disconnect(); _ctrlExpAdjust.ConnectBtnState = false; }
            else
            {
                _serialCom = new SerialInterface(_serialPortSettings);
                _serialCom.SerialInterfaceDataReceived += _serialCom_DataReceived;
                _ctrlExpAdjust.ConnectBtnState = _serialCom.Connect();
            }
        }

        void ShowChart()
        {
            try
            {
                _chart = new UCtrlChart();
                _chart.Dock = DockStyle.Fill;
                
                tblControlHost.Controls.Add(_chart, 1, 0);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to show chart control.\nPlease check logfile for further information.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Log.Append(ex);
            }
        }

        void ShowHistogram()
        {
            try
            {
                _chart.ShowHistogram();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to show histogram.\nPlease check logfile for further information.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Log.Append(ex);
            }
        }

        void ShowExperimentAdjust()
        {
            _ctrlExpAdjust = new UCtrlExpAdjust();
            _ctrlExpAdjust.LaserSwitch += _ctrlExpAdjust_LaserSwitch;
            _ctrlExpAdjust.SetPattern += _ctrlExpAdjust_SetPattern;
            _ctrlExpAdjust.SerialConnect += _ctrlExpAdjust_SerialConnect;
            _ctrlExpAdjust.Rotate += _ctrlExpAdjust_Rotate;
            _ctrlExpAdjust.AdjustmentFinished += _ctrlExpAdjust_AdjustmentFinished;
            tblControlHost.Controls.Add(_ctrlExpAdjust, 0, 0);
        }

        void ShowExperimentControl()
        {
            var globalcoords = PointToScreen(tblControlHost.Location);
            _experimentCtrl.Show(new Point(globalcoords.X + (tblControlHost.Size.Width / 2), globalcoords.Y));
        }

        void ShowExperimentConfig()
        {
            using (new CenterDialog(this))
            {
                using (var exc = new FrmExperimentConfig())
                {
                    exc.ExperimentConfigChanged += Main_ExperimentConfigChanged;
                    exc.Show(_currentExperimentSettings);
                }
            }
        }

        void ShowPeriodsView()
        {
            using (new CenterDialog(this))
            {
                using (var pv = new FrmPeriodsView())
                {
                    pv.ShowDialog();
                }
            }
        }

        #region ToolStripClickEvents

        private void tsmNew_Click(object sender, EventArgs e)
        {
            ShowExperimentConfig();
        }

        private void tsmSave_Click(object sender, EventArgs e)
        {
            try
            {
                new FileFactory().SaveSettings(_currentExperimentSettings, true);
            }
            catch (Exception ex)
            {
                Log.Append(ex.ToString());
            }
        }

        private void tsmOpen_Click(object sender, EventArgs e)
        {
            _currentExperimentSettings = new FileFactory().LoadSettings();
            ShowExperimentConfig();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //save Appsettings
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (new CenterDialog(this))
            {
                new AboutBox().ShowDialog();
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {

        }

        private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowExperimentConfig();
        }

        private void periodsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPeriodsView();
        }

        #endregion

    }
}