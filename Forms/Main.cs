
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
using System.ComponentModel;


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


        SerialInterface _serialCom;
        SerialPortSettings _serialPortSettings;
        ExperimentSettings _currentExperimentSettings;
        DataHandler _datahandler;
        FileFactory _filehandler;

        ExperimentDirector _measDirector;
        UCtrlChart _chart;
        UCtrlDevControl _ctrlExpAdjust;
        FrmExperimentControl _experimentCtrl;



        public Main()
        {
            InitializeComponent();
            Initialize();

            //#if DEBUG
            //            new TraceView().Show();
            //#endif
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            ///if software crashes make sure the laser is turned off.
            if (_serialCom != null && _serialCom.Connected)
            {
                _serialCom.SendData(new FPGACom().GetLaserCommand(0));
                _serialCom.SendData(new FPGACom().GetPatternCommand(DisplayPattern.noPattern, ColorPattern.W));
                _serialCom.SendData(new FPGACom().GetRotateCommand(RotationMode.s, 0));
            }
            base.OnClosing(e);
        }

        protected override void OnShown(EventArgs e)
        {
            // BackgroundImage = Properties.Resources._6.SetImgOpacity(40);
            base.OnShown(e);
            using (new CenterDialog(this))
            {
                var dlg = new FrmInput(InputType.ExperimentCreation);
                var res = dlg.ShowDialog();
                if (res == DialogResult.OK)
                {
                    try
                    {
                        _currentExperimentSettings = new FileFactory().LoadExperimentSettings(dlg.CreationType.Equals(InputType.New));
                        if (ShowExperimentConfig() == DialogResult.OK) { return; }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + "\nPlease reinstall application and try again.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Log.Append("Default Experiment settings not found.");
                    }
                }
                using (new CenterDialog(this))
                {
                    MessageBox.Show(this, "Without a valid configuration, no experiment can be started." +
                                    " To complete this step later, please use the corresponding entry under 'Files' from the menu bar.", "Questionable Choice",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        public void Splash()
        {
            Application.Run(new FrmSplashScreen());
        }

        private void _datahandler_ChartValuesPrepared(object sender, DataHandlerEventArgs e)
        {
            if (_chart != null)
            {
                _chart.AddValues(e.TimeStamp, e.Torque, e.Location);
            }
        }

        private void _datahandler_MValuesReceived(object sender, MeasurementEventArgs e)
        {
            if (_currentExperimentSettings != null)
            {
                ///save values to xml file.
                _filehandler.AppendPeriodValues(e.Values.ToString());              
            }
        }

        private void _serialCom_DataReceived(object sender, DataReceivedEventArgs e)
        {
            _datahandler.EnqueueRawValues(e.Bytes);
            foreach (byte b in e.Bytes)
            {
                Log.Append(string.Format("Received data on serial port - \"{0}\"", b.ToString()), LogType.Info);
            }
        }

        private void _ctrlExpAdjust_Rotate(object sender, RotateEventArgs e)
        {
            Log.Append(string.Format("Arena rotation requested - \"{0}\"", e.Rotation.ToDescriptionString<RotationMode>()), LogType.Info);
            if (_serialCom.Connected) { _serialCom.SendData(new FPGACom().GetRotateCommand(e.Rotation, (byte)e.Velocity)); }
            Program.Settings.Velocity = e.Velocity;
            Program.Settings.RotationMode = e.Rotation;
        }

        private void _ctrlExpAdjust_SerialConnect(object sender, SerialPortSettings e)
        {
            Log.Append(string.Format("Serial connection requested to port \"{0}\"", e.ToString(), LogType.Info));
            ConnectToSerialPort(e);
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
            if (e > 0) { Program.Settings.LaserPWMValue = e; }
        }

        private void _ctrlExpAdjust_AdjustmentFinished(object sender, EventArgs e)
        {
            Log.Append("Adjustment finished.", LogType.Info);
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
                            _filehandler.CreateMeasurementFile();
                            _measDirector.StartExperiment();
                        }
                        catch (Exception ex) { Log.Append(ex); }
                        break;
                    }
                case ExperimentState.suspend:
                    {
                        _measDirector.Suspend();
                        break;
                    }
                case ExperimentState.resume:
                    {
                        _measDirector.Resume();
                        break;
                    }
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
            ShowChart();
            Log.Append("Experiment metadata changed", LogType.Info);
        }

        void Initialize()
        {
            tBarMain.Titel = new AboutBox().AssemblyTitle;

            Log.Append("Initializing Objects", LogType.Info);
            _serialPortSettings = new SerialPortSettings();
            _currentExperimentSettings = new ExperimentSettings();
            _filehandler = new FileFactory();
            _datahandler = new DataHandler();
            _datahandler.MValuesPrepared += _datahandler_MValuesReceived;
            _datahandler.ChartValuesPrepared += _datahandler_ChartValuesPrepared;
            _measDirector = new ExperimentDirector(ref _currentExperimentSettings, _datahandler);
            _measDirector.SetRotation += _ctrlExpAdjust_Rotate;
            _measDirector.SetPattern += _ctrlExpAdjust_SetPattern;
            Log.Append("Initializing Controls", LogType.Info);
            _experimentCtrl = new FrmExperimentControl();
            _experimentCtrl.ExpStateChanged += _experimentCtrl_ExpStateChanged;
            HookUpEvents();
            Log.Append("Finished Initialization", LogType.Info);
        }



        void ConnectToSerialPort(SerialPortSettings settings)
        {
            if (_serialCom != null && _serialCom.Connected)
            { _serialCom.Disconnect(); _ctrlExpAdjust.ConnectBtnState = false; }
            else
            {
                _serialCom = new SerialInterface(settings);
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

        void HookUpEvents()
        {
            _ctrlExpAdjust = new UCtrlDevControl();
            Signals.LaserSwitch += _ctrlExpAdjust_LaserSwitch;
            Signals.SetPattern += _ctrlExpAdjust_SetPattern;
            Signals.SerialConnect += _ctrlExpAdjust_SerialConnect;
            Signals.Rotate += _ctrlExpAdjust_Rotate;            
        }

        void ShowExperimentControl()
        {
            var globalcoords = PointToScreen(tblControlHost.Location);
            _experimentCtrl.Show(new Point(globalcoords.X + (tblControlHost.Size.Width / 2), globalcoords.Y));
        }

        DialogResult ShowExperimentConfig()
        {
            using (new CenterDialog(this))
            {
                using (var exc = new FrmExperimentConfig())
                {
                    exc.ExperimentConfigChanged += Main_ExperimentConfigChanged;
                    return exc.ShowDialog(_currentExperimentSettings);
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
            _currentExperimentSettings = new FileFactory().LoadExperimentSettings();
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