
using Extensions;
using Logging;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;


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

        EventWaitHandle _wait;
        ComInterface _serialCom;
        ExperimentSettings _currExpSettings;
        DataHandler _datahandler;
        FileFactory _filehandler;

        MeasurementDirector _measDirector;
        UCtrlChart _chart;
        FrmProcessControl _procCtrl;


        public Main()
        {
            InitializeComponent();
            _wait = new EventWaitHandle(true, EventResetMode.ManualReset); //true --> signaled >>thread can continue<<
            Initialize();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            ///if software crashes make sure the laser is turned off.
            if (_serialCom != null)
            {
                _serialCom.SendData("L");
                _serialCom.SendData(FPGACom.GetLaserCommand(0).ToArray());
                _serialCom.SendData(FPGACom.GetPatternCommand(DisplayPattern.noPattern, ColorPattern.W));                
                _serialCom.SendData(RotationMode.s.ToString());
                _serialCom.SendData(Convert.ToChar(0).ToString());
            }
            base.OnClosing(e);
        }

        protected override void OnShown(EventArgs e)
        {
            // BackgroundImage = Properties.Resources._6.SetImgOpacity(40);
            base.OnShown(e);
            if (Program.Settings.AutoConnect)
            {
                new Signals().OnConnectRequest(this, Program.Settings.COMPortSettings);
            }
        }

        public void Splash()
        {
            Application.Run(new FrmSplashScreen());
        }

        /// <summary>
        /// Block the worker thread from execution.
        /// </summary>
        void SuspendEvent()
        {
            _wait.Reset();
        }

        /// <summary>
        /// Resume from a previously block signal.
        /// </summary>
        void ResumeEvent()
        {
            _wait.Set();
        }

        private void signal_ChartValuesPrepared(object sender, DataHandlerEventArgs e)
        {
            stLbl.Text = string.Format("Time[s]: {0:0.00}, Torque: {1:0.00} Nm, Location: {2:0.00} mm", e.TimeStamp, e.Torque, e.Location);
            //_wait.Set();
            if (_chart != null)
            {
                _chart.AddValues(e.TimeStamp, e.Torque, e.Location);
            }
        }

        private void signal_MValuesReceived(object sender, MeasurementEventArgs e)
        {
            if (_currExpSettings != null)
            {
                _chart.AddValues(e.Values.Timestamp, e.Values.Torque, e.Values.Location);
                ///save values to xml file.
                _filehandler.AppendPeriodValues(_currExpSettings.Filepath, e.Values.ToString());
            }
        }


        private void signal_Rotate(object sender, RotateEventArgs e)
        {
            Log.Append(string.Format("Arena rotation requested - \"{0}\"", e.Rotation.ToDescriptionString<RotationMode>()), LogType.Info);
            if (_serialCom != null) 
            {
                _serialCom.SendData(e.Rotation.ToString()); 
                _serialCom.SendData(Convert.ToChar(e.Velocity).ToString()); 
            }
            Program.Settings.Velocity = e.Velocity;
            Program.Settings.RotationMode = e.Rotation;
        }


        private void signal_ConnectRequest(object sender, SerialPortSettings e)
        {
            Log.Append(string.Format("Serial connection requested to port \"{0}\"", e.ToString()), LogType.Info);
            if (_serialCom != null && _serialCom.Connected)
            { _serialCom.Disconnect(); }
            else
            {
                _serialCom = new ComInterface();
                _serialCom.Connect(e);
            }
        }

        private void Signals_AquisitionControl(object sender, ExecutionControl e)
        {
            if (e.Equals(ExecutionControl.start))
            { StartAquisition(); }
            else
            { StopAquisition(); }
        }

        private void signal_SetPattern(object sender, PatternEventArgs e)
        {
            //Log.Append(string.Format("Arena pattern change requested - \"{0}\"", e.Pattern.ToDescriptionString<DisplayPattern>()), LogType.Info);
            if (_serialCom != null)
            { _serialCom.SendData(FPGACom.GetPatternCommand(e.Pattern, e.Color)); }
        }

        private void signal_LaserSwitch(object sender, int e)
        {
            Log.Append(string.Format("Laser triggered - PWM (0-100): \"{0}\"", e), LogType.Info);
            if (_serialCom != null)
            {                
                _serialCom.SendData("L");
                _serialCom.SendData(FPGACom.GetLaserCommand(e));
                if (e == 0) { new Signals().OnDeviceStatusChanged(null, DeviceStatus.off); }
                else { new Signals().OnDeviceStatusChanged(null, DeviceStatus.on); }
            }
            if (e > 0)
            { Program.Settings.LaserPWMValue = e; }
        }


        private void signal_ProcessControl(object sender, ExecutionControl e)
        {
            Log.Append(string.Format("Experiment status change requested - \"{0}\"", e.ToDescriptionString<ExecutionControl>()), LogType.Info);
            switch (e)
            {
                case ExecutionControl.start:
                    {
                        try
                        {
                            new FileFactory(_currExpSettings).CreateMeasurementFile();
                            _measDirector = new MeasurementDirector(_currExpSettings);
                            _measDirector.StartExperiment();
                        }
                        catch (Exception ex) { Log.Append(ex); }
                        break;
                    }
                case ExecutionControl.suspend:
                    { break; }
                case ExecutionControl.resume:
                    { break; }
                case ExecutionControl.stop:
                    { break; }
                case ExecutionControl.punish:
                    { break; }
                default: break;
            }
        }

        private void Signals_ExperimentConfigChanged(object sender, EventArgs e)
        {
            _currExpSettings = (sender as FrmExperimentConfig).Settings;
            _currExpSettings.Duration = _currExpSettings.PeriodCollection.Sum(pv => pv.Duration);
            _currExpSettings.Filepath = new XmlFileFactory().GetFileName(_currExpSettings.DataFolderpath, _currExpSettings.FlyName);
            _currExpSettings.FlyName = Path.GetFileNameWithoutExtension(_currExpSettings.Filepath);

            Log.Append("Experiment metadata changed", LogType.Info);
            ShowExperimentControl();
        }


        void Initialize()
        {
            tBarMain.Titel = new AboutBox().AssemblyTitle;
            ShowChart();
            _currExpSettings = new ExperimentSettings();
            _filehandler = new FileFactory();
            _datahandler = new DataHandler();
            _measDirector = new MeasurementDirector(_currExpSettings);
            Log.Append("Initializing Controls", LogType.Info);
            _procCtrl = new FrmProcessControl();
            HookUpEvents();
            Log.Append("Finished Initialization", LogType.Info);
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
            Signals.ConnectRequest += signal_ConnectRequest;
            Signals.LaserSwitch += signal_LaserSwitch;
            Signals.SetPattern += signal_SetPattern;
            Signals.Rotate += signal_Rotate;
            Signals.MValuesPrepared += signal_MValuesReceived;
            Signals.ChartValuesPrepared += signal_ChartValuesPrepared;
            Signals.ExperimentConfigChanged += Signals_ExperimentConfigChanged;
            Signals.ProcessControl += signal_ProcessControl;
            Signals.AquisitionControl += Signals_AquisitionControl;
        }



        void StartAquisition()
        {
            if (_serialCom != null) { }
        }
        void StopAquisition()
        {
            if (_serialCom != null)
            {
                _serialCom.SendData(FPGACom.GetStopCommand());
                _serialCom.SendData(FPGACom.GetStopCommand());
            }
        }

        void ShowExperimentControl()
        {
            var globalcoords = PointToScreen(tblControlHost.Location);
            _procCtrl.Show(new Point(globalcoords.X + (tblControlHost.Size.Width / 2), globalcoords.Y));
        }

        DialogResult ShowExperimentConfig()
        {
            using (new CenterDialog(this))
            {
                using (var exc = new FrmExperimentConfig())
                {
                    return exc.ShowDialog(_currExpSettings);
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
            SuspendEvent();
            using (new CenterDialog(this))
            {
                var dlg = new FrmInput(InputType.ExperimentCreation);
                var res = dlg.ShowDialog();
                if (res == DialogResult.OK)
                {
                    try
                    {
                        _currExpSettings = new FileFactory().LoadExperimentSettings(dlg.CreationType.Equals(InputType.New));
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
            ResumeEvent();
        }

        private void tsmSave_Click(object sender, EventArgs e)
        {
            try
            {
                new FileFactory().SaveSettings(_currExpSettings, true);
            }
            catch (Exception ex)
            {
                Log.Append(ex.ToString());
            }
        }

        private void tsmOpen_Click(object sender, EventArgs e)
        {
            _currExpSettings = new FileFactory().LoadExperimentSettings();
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
            throw new NotImplementedException();
        }

        private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowExperimentConfig();
        }

        private void periodsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPeriodsView();
        }
        private void resetChartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _datahandler.SuspendWorkerTh();
            _chart.ResetChart();
            _datahandler.StartTime = DateTime.Now;
            _datahandler.ResumeWorkerTh();
        }

        #endregion


    }
}