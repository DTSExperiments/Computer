
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


        private double[] liveDataAD = new double[1080];
        private double[] liveDataPIX = new double[1080];

        private List<byte> list = new List<byte>();

        public int nextValueIndex = 0;

        SerialInterface _serialCom;
        XmlFileFactory _xmlBuilder;
        SerialPortSettings _serialPortSettings;
        ExperimentSettings _currentExperimentSettings;
        DataHandler _datahandler;

        UCtrlExpAdjust _ctrlExpAdjust;
        FrmExperimentConfig _experimentConfig;
        FrmExperimentControl _experimentCtrl;
        FrmPeriodsView _periodsView;


       
        public Main()
        {
            InitializeComponent();
            _datahandler = new DataHandler();
            InitializeControl();
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

        protected override void OnShown(EventArgs e)
        {
           // BackgroundImage = Properties.Resources._6.SetImgOpacity(40);
            base.OnShown(e);
            using (new CenterDialog(this))
            {
                var dlg = new FrmInput(InputType.ExperimentCreation);
                var res= dlg.ShowDialog();  
                    if (res== DialogResult.OK&& dlg.CreationType==InputType.New)
                    {
                        ShowExperimentConfig();
                    }
                    else if(res == DialogResult.OK&& dlg.CreationType==InputType.Open)
                    {
                    _currentExperimentSettings = new FileFactory().LoadSettings();
                    }
            }
        }
        

        private void _serialCom_DataReceived(object sender, DataReceivedEventArgs e)
        {
            _datahandler.AddMValues(e.Bytes);
            Log.Append(string.Format("Received data on serial port - \"{0}\"", e.Bytes.Count()), LogType.Info);
        }

        private void _ctrlExpAdjust_Rotate(object sender, RotateEventArgs e)
        {
            Log.Append(string.Format("Arena rotation requested - \"{0}\"", e.Rotation.ToDescriptionString<RotationValue>()), LogType.Info);
        }

        private void _ctrlExpAdjust_SerialConnect(object sender, string e)
        {
            Log.Append(string.Format("Serial connection requested to port \"{0}\"", e), LogType.Info);
        }

        private void _ctrlExpAdjust_SetPattern(object sender, PatternEventArgs e)
        {
            Log.Append(string.Format("Arena pattern change requested - \"{0}\"", e.Pattern.ToDescriptionString<DisplayPattern>()), LogType.Info);
        }

        private void _ctrlExpAdjust_LaserSwitch(object sender, int e)
        {
            Log.Append(string.Format("Laser triggered - PWM (0-100): \"{0}\"", e), LogType.Info);
        }

        private void _ctrlExpAdjust_AdjustmentFinished(object sender, EventArgs e)
        {
            Log.Append(string.Format("Adjustment finished."), LogType.Info);
            _datahandler.ResetChart();
            ShowHistogram();
            ShowExperimentControl();
        }

        private void _experimentCtrl_ExpStateChanged(object sender, ExpControlEventArgs e)
        {
            Log.Append(string.Format("Experiment status change requested - \"{0}\"", e.ExState.ToDescriptionString<ExperimentState>()), LogType.Info);
            switch (e.ExState)
            {
                case ExperimentState.start:
                    { break; }
                case ExperimentState.suspend:
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

        private void Logging_LogMessageReceive(object sender, LogEventArgs e)
        {
            rtbLogBox.AppendText(e.Message);
            rtbLogBox.ScrollToCaret();
        }


        void InitializeControl()
        {
            tBarMain.Titel = new AboutBox().AssemblyTitle;
            Log.LogMessageReceive += Logging_LogMessageReceive;
            Log.Append("Initializing Objects", LogType.Info);
            _serialPortSettings = new SerialPortSettings();
            _currentExperimentSettings = new ExperimentSettings();
            _serialCom = new SerialInterface();
            _serialCom.DataReceived += _serialCom_DataReceived;
            /*
             */
            Log.Append("Initializing Controls", LogType.Info);
            

            _datahandler = new DataHandler();
            _experimentCtrl = new FrmExperimentControl();
            _experimentCtrl.ExpStateChanged += _experimentCtrl_ExpStateChanged;
            /*
            */

            Log.Append("Finished Initialization", LogType.Info);          
        }

        

        void ShowChart()
        {
            try
            {
                _datahandler.ADValuesZGC.Dock = DockStyle.Fill;
                tblControlHost.Controls.Add(_datahandler.ADValuesZGC, 1, 0);
            }catch (Exception ex) 
            {
                MessageBox.Show("Failed to show chart control.\nPlease check logfile for further information.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Log.Append(ex);
            }
        }

        void ShowHistogram()
        {
            try
            {
                tblHisto.Controls.Add(_datahandler.Histogram,0,0);
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

        private void convertList()
        {
            short nextValueAD = 0;
            ushort nextValuePIX = 0;
            byte[] byteArray = new byte[4];

            while (list.Count >= 5)
            {
                try
                {
                    if (Convert.ToByte(list[4]) != 0x0A)
                    {
                        throw new Exception("LF not found");
                    }

                    byteArray = list.GetRange(0, 4).ToArray();
                    list.RemoveRange(0, 5);
                    BitArray nextValueADBit = new BitArray(byteArray);
                    if (nextValueADBit[11] == true)
                    {
                        nextValueADBit = nextValueADBit.Or(new BitArray(System.BitConverter.GetBytes(0x0000F000)));
                    }
                    nextValueADBit.CopyTo(byteArray, 0);
                    nextValueAD = BitConverter.ToInt16(byteArray, 0);
                    nextValuePIX = BitConverter.ToUInt16(byteArray, 2);

                    if (nextValueIndex >= liveDataAD.Length - 1)
                    {
                        //adLogger.Clear();
                        //pixLogger.Clear();
                        //laserLogger.Clear();
                        nextValueIndex = 0;
                    }
                    else
                    {
                        nextValueIndex++;
                    }

                    //Calculation AD-Values
                    liveDataAD[nextValueIndex] = Convert.ToDouble(nextValueAD * 244.14 * Math.Pow(10, -6));
                    liveDataPIX[nextValueIndex] = Convert.ToDouble(nextValuePIX);

                    //beginTime = DateTime.Now;

                    Debug.WriteLine(nextValueAD);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "SerialInterface Event");

                }
            }
        }


        private string GetNextFileName(string directory)
        {
            int maxNumber = 0;

            // Get all XML files in the directory
            var files = Directory.GetFiles(directory, "*.xml");

            foreach (var file in files)
            {
                // Extract the file name without extension
                var fileBaseName = Path.GetFileNameWithoutExtension(file);

                // Parse the number at the end of the file name
                if (int.TryParse(fileBaseName, out int fileNumber))
                {
                    if (fileNumber > maxNumber)
                    {
                        maxNumber = fileNumber;
                    }
                }
            }

            // Increment the highest number found and format as "NN.xml"
            return (maxNumber + 1).ToString("D2") + ".xml";
        }



        #region ToolStripClickEvents

        private void tsmNew_Click(object sender, EventArgs e)
        {
            using (new CenterDialog(this))
            { new FrmExperimentConfig().ShowDialog(); }
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

        private void btnCollapseLog_Click(object sender, EventArgs e)
        {
            rtbLogBox.Visible = !rtbLogBox.Visible;
        }
    }
}