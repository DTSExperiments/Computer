
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
                        MessageBox.Show("comes soon...", "",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                
            }
        }
        

        private void _serialCom_DataReceived(object sender, DataReceivedEventArgs e)
        {
            _datahandler.AddMValues(e.Bytes);
        }

        private void _ctrlExpAdjust_Rotate(object sender, RotateEventArgs e)
        {
            Logging.Log(string.Format("Arena rotation requested - \"{0}\"", e.Rotation.ToDescriptionString<RotationValue>()), LogType.Info);
        }

        private void _ctrlExpAdjust_SerialConnect(object sender, string e)
        {
            Logging.Log(string.Format("Serial connection requested to port \"{0}\"", e), LogType.Info);
        }

        private void _ctrlExpAdjust_SetPattern(object sender, PatternEventArgs e)
        {
            Logging.Log(string.Format("Arena pattern change requested - \"{0}\"", e.Pattern.ToDescriptionString<DisplayPattern>()), LogType.Info);
        }

        private void _ctrlExpAdjust_LaserSwitch(object sender, int e)
        {
            Logging.Log(string.Format("Laser triggered - PWM (0-100): \"{0}\"", e), LogType.Info);
        }

        private void _ctrlExpAdjust_AdjustmentFinished(object sender, EventArgs e)
        {
            Logging.Log(string.Format("Adjustment finished."), LogType.Info);
            _datahandler.ResetChart();
            ShowHistogram();
            ShowExperimentControl();
        }

        private void _experimentCtrl_ExpStateChanged(object sender, ExpControlEventArgs e)
        {
            Logging.Log(string.Format("Experiment status change requested - \"{0}\"", e.ExState.ToDescriptionString<ExperimentState>()), LogType.Info);
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
            Logging.Log("Experiment metadata changed", LogType.Info);
        }

        private void Logging_LogMessageReceive(object sender, LogEventArgs e)
        {
            rtbLogBox.AppendText(e.Message);
            rtbLogBox.ScrollToCaret();
        }


        void InitializeControl()
        {
            tBarMain.Titel = new AboutBox().AssemblyTitle;
            Logging.LogMessageReceive += Logging_LogMessageReceive;
            Logging.Log("Initializing Objects", LogType.Info);
            _serialPortSettings = new SerialPortSettings();
            _currentExperimentSettings = new ExperimentSettings();
            _serialCom = new SerialInterface();
            _serialCom.DataReceived += _serialCom_DataReceived;
            /*
             */
            Logging.Log("Initializing Controls", LogType.Info);
            

            _datahandler = new DataHandler();
            _experimentCtrl = new FrmExperimentControl();
            _experimentCtrl.ExpStateChanged += _experimentCtrl_ExpStateChanged;
            /*
            */

            Logging.Log("Finished Initialization", LogType.Info);
          
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
                Logging.Log(ex);
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
                Logging.Log(ex);
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
            updateData();
        }

        private void updateData()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(updateData));
            }
            else
            {

                //DateTime beginTime = DateTime.Now;

                //adLogger.Add(nextValueIndex, liveDataAD[nextValueIndex]);
                //pixLogger.Add(nextValueIndex, PixelToDegree(liveDataPIX[nextValueIndex]));

                ////convert bool to double
                //if (boLaser == true)
                //{
                //    laserLogger.Add(nextValueIndex, 1);
                //    formsPlot1.Plot.Style(figureBackground: Color.Red);
                //}
                //else
                //{
                //    laserLogger.Add(nextValueIndex, 0);
                //    formsPlot1.Plot.Style(figureBackground: Color.White);
                //}



                //Debug.WriteLine(liveDataAD[nextValueIndex].ToString() + " " + liveDataPIX[nextValueIndex].ToString()); //write ad and pix value to debug window
                //debug.Text = Math.Round(liveDataAD[nextValueIndex], 4).ToString() + ";" + liveDataPIX[nextValueIndex].ToString();
                //TimeSpan timeSpan = DateTime.Now - beginTime;
                //Debug.WriteLine(timeSpan.TotalMilliseconds.ToString());

                //formsPlot1.Refresh(!resolution.Checked);

                ////fileWriter.writeValue(liveDataAD[nextValueIndex].ToString() + ";" + liveDataPIX[nextValueIndex].ToString() + ";" + timeSpan.TotalMilliseconds.ToString());
            }

        }

        



        private void domainUpDown2_SelectedItemChanged(object sender, EventArgs e)
        {
            //DomainUpDown pattern = sender as DomainUpDown;
            //switch (pattern.Text)
            //{
            //    case "No pattern":
            //        patternDisplay = DisplayPattern.noPattern;
            //        break;
            //    case "One touch":
            //        patternDisplay = DisplayPattern.oneTouch;
            //        break;
            //    case "Multi touch":
            //        patternDisplay = DisplayPattern.multiTouch;
            //        break;
            //    case "T pattern":
            //        patternDisplay = DisplayPattern.tPattern;
            //        break;
            //    default:
            //        patternDisplay = DisplayPattern.noPattern;
            //        break;
            //}
        }

        private void patternButton_Click(object sender, EventArgs e)
        {
            //if (serialComOpen == true)
            //{
            //    try
            //    {
            //        //serialCom.sendValues(patternDisplay, patternColor);
            //    }
            //    catch (Exception ex)
            //    {
            //        //patternButton.Enabled = false;
            //        //MessageBox.Show(ex.ToString(), "Laser Event");
            //    }
            //}
            //else
            //{
            //    //patternButton.Enabled = false;
            //}
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            DomainUpDown rotation = sender as DomainUpDown;
            //switch (rotation.Text)
            //{
            //    case "Sample":
            //        valueRotation = RotationValue.sample;
            //        break;
            //    case "right":
            //        valueRotation = RotationValue.right;
            //        break;
            //    case "left":
            //        valueRotation = RotationValue.left;
            //        break;
            //    default:
            //        break;
            //}
        }

        private void rotation_Click(object sender, EventArgs e)
        {
            //if (serialComOpen == true)
            //{
            //    try
            //    {
            //        serialCom.sendValues(valueRotation, Convert.ToByte(numericUpDownRotation.Value));
            //    }
            //    catch (Exception ex)
            //    {
            //        rotation.Enabled = false;
            //        MessageBox.Show(ex.ToString(), "Laser Event");
            //    }
            //}
            //else
            //{
            //    rotation.Enabled = false;
            //}
        }

        private void fileDialog_Click(object sender, EventArgs e)
        {
            string directory = null;
            string fileName = null;

            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.ValidateNames = false;
                openFileDialog.CheckFileExists = false;
                openFileDialog.CheckPathExists = true;
                openFileDialog.FileName = "Select Folder";
                openFileDialog.Filter = "Folders|\n";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    directory = Path.GetDirectoryName(openFileDialog.FileName);
                    fileName = GetNextFileName(directory);

                    //label3.Text = Path.Combine(directory, fileName);
                    // fileWriter = new XmlFileManager(directory, fileName);
                }
                else
                {
                    //label3.Text = "No directory selected";
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




        private void textBox4_Leave(object sender, EventArgs e)
        {
            //xmlFileManager.UpdateFirstName("firstname", textBox4.Text);
        }


        private void saveXML_Click(object sender, EventArgs e)
        {
            /// TODO: move to periods view an config (lower end of the view)
            /// and pass an enumeration of perioddata to xmlfilefactory

            DateTimeOffset dto = new DateTimeOffset(DateTime.UtcNow);

            saveFileDialog1.Filter = "XML files(.xml) | *.xml";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.FileName = @"Periods-" + (new DateTimeOffset(DateTime.UtcNow)).ToString("yyyyMMdd_HHmmss");
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //fileWriter = new XmlFileFactory().CreateBasicSchemaPeriod(,saveFileDialog1.FileName);
            }
        }

        private void loadXML_Click(object sender, EventArgs e)
        {
            var filepath = string.Empty;
            try
            {
                filepath = new FileFactory().SelectFilePath("Select XML File",
                                                            "XML files(.xml) | *.xml",
                                                            Environment.GetFolderPath(Environment.SpecialFolder.Personal));
            }
            catch (Exception) { Logging.Log(""); }
            DateTimeOffset dto = new DateTimeOffset(DateTime.UtcNow);

            //if (openFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    bool validationSchema = new XmlFileFactory().ValidateXML(filepath);
            //    if (validationSchema == true)
            //    {
            //        var periods =new XmlFileFactory().ReadPeriodsFromXml(filepath);
            //        if (periods != null)
            //        {
            //            clearTableLayoutPanel();
            //            for (int i = 0; i < periods.Count(); i++)
            //            {
            //                CreateAndAddTableLayoutPanel(i + 1);
            //                foreach (Control control in tableLayoutPanel12.Controls)
            //                {
            //                    if (control is TableLayoutPanel)
            //                    {
            //                        foreach (Control control2 in control.Controls)
            //                        {
            //                            if (control2 is TextBox)
            //                            {
            //                                if (control2.Name == "textbox_2_" + (i + 1).ToString())
            //                                {
            //                                    control2.Text = periods[i].Type;
            //                                }
            //                                if (control2.Name == "textbox_4_" + (i + 1).ToString())
            //                                {
            //                                    control2.Text = periods[i].Duration.ToString();
            //                                }
            //                                if (control2.Name == "textbox_6_" + (i + 1).ToString())
            //                                {
            //                                    control2.Text = periods[i].Outcome.ToString();
            //                                }
            //                                if (control2.Name == "textbox_8_" + (i + 1).ToString())
            //                                {
            //                                    control2.Text = periods[i].Pattern.ToString();
            //                                }
            //                                if (control2.Name == "textbox_10_" + (i + 1).ToString())
            //                                {
            //                                    control2.Text = periods[i].CoupCoeff.ToString();
            //                                }
            //                                if (control2.Name == "textbox_12_" + (i + 1).ToString())
            //                                {
            //                                    control2.Text = periods[i].Contingency;
            //                                }
            //                            }
            //                            if (control2 is DomainUpDown)
            //                            {
            //                                if (control2.Name == "domainUpDown_1_" + (i + 1).ToString())
            //                                {
            //                                    control2.Text = periods[i].Type;
            //                                }
            //                                if (control2.Name == "domainUpDown_7_" + (i + 1).ToString())
            //                                {
            //                                    control2.Text = periods[i].Pattern.ToString();
            //                                }
            //                                if (control2.Name == "domainUpDown_11_" + (i + 1).ToString())
            //                                {
            //                                    control2.Text = periods[i].Contingency;
            //                                }
            //                            }
            //                        }
            //                    }   
            //                }
            //            }
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("XML file is not valid", "XML Validation");
            //    }           
        }



        private string[] GetTypeDependentItems(string type, string selectorName)
        {
            // Entscheiden, welche Einträge basierend auf Typ und eventuell Selector-Namen hinzugefügt werden sollen

            //"No pattern", "Single vertical stripe", "Striped drum (15 stripes)", "T-Patterns", "Four vertical bars", "Diagonals", "Green on pos. blue on neg. torque", "Blue on pos. green on neg. torque", "Constant daylight"
            switch (type)
            {
                case "fs":
                    if (selectorName.Contains("7")) // Spezifische Einträge für "patternSelector" bei "yt"
                    {
                        return new string[] { "Single vertical stripe", "Striped drum (15 stripes)", "T-Patterns", "Four vertical bars", "Diagonals" };
                    }
                    else if (selectorName.Contains("11")) // Angenommen, eine andere Logik für "contingencySelector"
                    {
                        return new string[] { "1_3_Q", "2_4_Q" };
                    }
                    break;
                case "sw":
                    if (selectorName.Contains("7")) // Spezifische Einträge für "patternSelector" bei "yt"
                    {
                        return new string[] { "Green on pos. blue on neg. torque", "Blue on pos. green on neg. torque" };
                    }
                    else if (selectorName.Contains("11")) // Angenommen, eine andere Logik für "contingencySelector"
                    {
                        return new string[] { "left_torque", "right_torque" };
                    }
                    break;
                case "yt":
                    if (selectorName.Contains("7")) // Spezifische Einträge für "patternSelector" bei "yt"
                    {
                        return new string[] { "No pattern", "Constant daylight" };
                    }
                    else if (selectorName.Contains("11")) // Angenommen, eine andere Logik für "contingencySelector"
                    {
                        return new string[] { "left_torque", "right_torque" };
                    }
                    break;
                case "color":
                    if (selectorName.Contains("7")) // Spezifische Einträge für "patternSelector" bei "yt"
                    {
                        return new string[] { "Constant daylight" };
                    }
                    else if (selectorName.Contains("11")) // Angenommen, eine andere Logik für "contingencySelector"
                    {
                        return new string[] { "green", "blue" };
                    }
                    break;
                case "OptomotorR":
                case "OptomotorL":
                    if (selectorName.Contains("7")) // Spezifische Einträge für "patternSelector" bei "yt"
                    {
                        return new string[] { "Constant daylight" };
                    }
                    else if (selectorName.Contains("11")) // Angenommen, eine andere Logik für "contingencySelector"
                    {
                        return new string[] { };
                    }
                    break;
                // Keine Einträge für diese Typen
                default:
                    break;
            }
            return new string[0]; // Leeres Array, falls keine Bedingungen zutreffen
        }


        #region ToolStripClickEvents

        private void tsmNew_Click(object sender, EventArgs e)
        {
            using (new CenterDialog(this))
            { new FrmExperimentConfig().ShowDialog(); }
        }

        private void tsmSave_Click(object sender, EventArgs e)
        {

        }

        private void tsmOpen_Click(object sender, EventArgs e)
        {

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