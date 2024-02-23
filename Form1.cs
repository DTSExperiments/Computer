using System.Diagnostics;
using System.IO.Ports;
using System.Text;
using System.Numerics;
using System.Collections;
using ScottPlot;
using System.Windows.Forms;
using System.Threading;
using System.Collections.Generic;
using System.Drawing;
using System;
using Timers = System.Timers;
using System.Reflection;
using System.Windows.Forms.DataVisualization.Charting;
using System.Management;
using System.Configuration;
using Version = System.Version;
using System.IO;
using System.Reflection.Emit;

using Label = System.Windows.Forms.Label;

namespace plotBrembs
{
    
    public partial class Form1 : Form
    {
        readonly ScottPlot.Plottable.DataLogger adLogger;
        readonly ScottPlot.Plottable.DataLogger pixLogger;
        readonly ScottPlot.Plottable.DataLogger laserLogger;

        private static System.Threading.Timer simulationTimer = null;

        private serialInterface serialCom;
        private XmlFileManager fileWriter;

        bool serialComOpen = false;
        bool boLaser = false;

        private double[] liveDataAD = new double[1080];
        private double[] liveDataPIX = new double[1080];

        private List<byte> list = new List<byte>();
        
        public int nextValueIndex = 0;

        public delegate void ShowSerialData();

        Version version = new Version();

        ColorPattern patternColor;

        DisplayPattern patternDisplay;

        RotationValue valueRotation;

        public Form1()
        {
            List<string> portList = new List<string>();
            string[] portNames;

            InitializeComponent();

            resizeWindow();

            version = Assembly.GetExecutingAssembly().GetName().Version;

            portList.AddRange(SerialPort.GetPortNames());
            portList.Sort();

            portNames = portList.ToArray();

            var yAxis3 = formsPlot1.Plot.AddAxis(ScottPlot.Renderable.Edge.Right);
            var yAxis4 = formsPlot1.Plot.AddAxis(ScottPlot.Renderable.Edge.Left);

            adLogger = formsPlot1.Plot.AddDataLogger(Color.Blue, 1, "AD-Value");
            pixLogger = formsPlot1.Plot.AddDataLogger(Color.Red, 1, "Pixel");
            laserLogger = formsPlot1.Plot.AddDataLogger(Color.Green, 1, "Laser");

            adLogger.ViewJump();
            pixLogger.ViewJump();
            laserLogger.ViewJump();

            adLogger.ManageAxisLimits = false;
            pixLogger.ManageAxisLimits = false;
            laserLogger.ManageAxisLimits = false;
            adLogger.YAxisIndex = yAxis3.AxisIndex;
            laserLogger.YAxisIndex = yAxis4.AxisIndex;

            formsPlot1.Plot.SetAxisLimitsX(0, 1080);
            formsPlot1.Plot.SetAxisLimitsY(-180, 180);
            formsPlot1.Plot.SetAxisLimitsY(-0.4, 0.4, yAxis3.AxisIndex);
            formsPlot1.Plot.SetAxisLimitsY(-0.1, 1.1, yAxis4.AxisIndex);

            formsPlot1.Plot.Grid(color: Color.FromArgb(100, Color.Black));
            formsPlot1.Plot.Grid(lineStyle: LineStyle.Dot);

            formsPlot1.Configuration.ScrollWheelZoom = false;
            formsPlot1.Configuration.RightClickDragZoom = false;
            formsPlot1.Configuration.LeftClickDragPan = false;

            formsPlot1.RightClicked -= formsPlot1.DefaultRightClickEvent;

            formsPlot1.Plot.YAxis.Label("arena position");
            yAxis3.Label("torque");
            yAxis4.Label("laser");

            formsPlot1.Plot.YAxis.Color(Color.Red);
            yAxis3.Color(Color.Blue);
            yAxis4.Color(Color.Green);

            double[] yPositions = { -135, -45,  45,  135};
            string[] yLabels = { "-135", "-45", "45", "135" };
            formsPlot1.Plot.YAxis.ManualTickPositions(yPositions, yLabels);

            double[] yAxis3Positions = { -0.2, 0, 0.2 }; // Example positions for yAxis3
            string[] yAxis3Labels = { "-0.2", "0", "0.2" }; // Example labels for yAxis3
            yAxis3.ManualTickPositions(yAxis3Positions, yAxis3Labels);
            yAxis3.MajorGrid(lineWidth: 1, lineStyle: LineStyle.Dash, color: Color.Blue);
            yAxis3.Grid(true);

            double[] yAxis4Positions = { 0, 1 }; // Example positions for yAxis3
            string[] yAxis4Labels = { "off", "on" }; // Example labels for yAxis3
            yAxis4.ManualTickPositions(yAxis4Positions, yAxis4Labels);
            yAxis4.MajorGrid(lineWidth: 1, lineStyle: LineStyle.Dash, color: Color.Green);
            yAxis4.Grid(true);

            formsPlot1.Plot.YAxis.MajorGrid(lineWidth: 1, lineStyle: LineStyle.Dash, color: Color.Red);

            formsPlot1.Refresh(!resolution.Checked);

            if (portNames.Length > 0)
            {
                serialComboBox.Items.AddRange(portNames);
                serialComboBox.SelectedIndex = serialComboBox.FindString(findComPort(ConfigurationManager.AppSettings["VID"], ConfigurationManager.AppSettings["PID"])); ;
            }


            this.Text = version.ToString();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            serialCom = new serialInterface(this);
            serialCom.OnDataReceived += SerialInterface_OnDataReceived;

            //initialize default values
            patternDisplay = DisplayPattern.noPattern;

            domainUpDown3.BackColor = Color.WhiteSmoke;
            domainUpDown3.ForeColor = Color.Black;
            patternColor = ColorPattern.White;

            valueRotation = RotationValue.Sample;

        }


        private void resizeWindow()
        {
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;

            if (screenHeight > 1080)
            {
                // Assuming you want to scale the form to 80% of its original size as an example
                float scalePercentage = 1.5f;

                this.Width = (int)(this.Width * scalePercentage);
                this.Height = (int)(this.Height * scalePercentage);

            }
        }

        private string findComPort(string vid, string pid)
        {
            string comPort = "";

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", $"SELECT * FROM Win32_PnPEntity WHERE DeviceID LIKE '%VID_{vid}%' AND DeviceID LIKE '%PID_{pid}%' AND Name LIKE '%(COM%'");

            foreach (ManagementObject queryObj in searcher.Get())
            {
                string name = queryObj["Name"].ToString();
                int startIndex = name.IndexOf("(COM");
                int endIndex = name.IndexOf(")", startIndex);
                if (startIndex != -1 && endIndex != -1)
                {
                    comPort = name.Substring(startIndex + 1, endIndex - startIndex - 1);
                    Console.WriteLine($"Device with VID_0403 and PID_6001 is connected to {comPort}");
                }
            }

            return comPort;
        }

        private void startSerial_Click(object sender, EventArgs e)
        {
            int returnValue = 0;

            try
            {
                if (serialComOpen == false)
                {
                    if (serialCom != null && serialCom.IsSerialPortNull() == false)
                    {
                        returnValue = serialCom.openPort(serialComboBox.Text);
                        if (returnValue == 0)
                        {
                            serialOpen.Image = Properties.Resources._269251;
                            startSerial.Text = "Stop";
                            serialComOpen = true;
                            laser.Enabled = true;
                            patternButton.Enabled = true;
                            rotation.Enabled = true;
                        }
                        else
                        {
                            serialOpen.Image = Properties.Resources._269210;
                            startSerial.Text = "Failed";
                        }

                    }
                    else
                    {
                        if (serialCom == null)
                        {
                            serialCom = new serialInterface(this);
                            serialCom.OnDataReceived += SerialInterface_OnDataReceived;

                            returnValue = serialCom.openPort(serialComboBox.Text);
                            if (returnValue == 0)
                            {
                                serialOpen.Image = Properties.Resources._269251;
                                startSerial.Text = "Stop";
                                serialComOpen = true;
                                laser.Enabled = true;
                                patternButton.Enabled = true;
                                rotation.Enabled = true;
                            }
                            else
                            {
                                serialOpen.Image = Properties.Resources._269210;
                                startSerial.Text = "Failed";
                                throw new Exception("Serial port failed");
                            }
                        }

                        else
                        {

                        }
                    }
                }
                else
                {
                    serialOpen.Image = Properties.Resources._269210;
                    startSerial.Text = "Start";
                    serialCom.OnDataReceived -= SerialInterface_OnDataReceived;
                    if (serialCom.closePort() != 0)
                    {
                        throw new Exception("Serial port failed");
                    };
                    serialCom = null;
                    serialComOpen = false;
                    laser.Enabled = false;
                    patternButton.Enabled = false;
                    rotation.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 


           
        }

        private void simulateData_Click(object sender, EventArgs e)
        {
            TimerCallback timerCallback = new TimerCallback(sendSimulationData);
            simulationTimer = new System.Threading.Timer(timerCallback, null, 0, 500);


            Debug.WriteLine("Press the Enter key to exit the program at any time... ");
        }

        private void sendSimulationData(Object source)
        {
            list.Add(Convert.ToByte(0xC9));
            list.Add(Convert.ToByte(0x00));
            list.Add(Convert.ToByte(0xC8));
            list.Add(Convert.ToByte(0x00));
            list.Add(Convert.ToByte(0x0A));

            this.BeginInvoke(new ShowSerialData(convertList));

        }

        private void SerialInterface_OnDataReceived(byte[] data)
        {
            foreach (Byte value in data)
            {
                list.Add(Convert.ToByte(value));
            }

            convertList();

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
                        adLogger.Clear();
                        pixLogger.Clear();
                        laserLogger.Clear();
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


        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process procces = System.Diagnostics.Process.GetCurrentProcess();
            System.Diagnostics.ProcessThreadCollection threadCollection = procces.Threads;

            string threads = string.Empty;

            foreach (System.Diagnostics.ProcessThread proccessThread in threadCollection)
            {
                threads += string.Format("Thread Id: {0}, ThreadState: {1}\r\n", proccessThread.Id, proccessThread.ThreadState);
            }

            Debug.WriteLine(Thread.CurrentThread.ManagedThreadId);


            MessageBox.Show(threads);
        }


        private void updateData()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(updateData));
            }
            else
            {

                DateTime beginTime = DateTime.Now;
                
                adLogger.Add(nextValueIndex, liveDataAD[nextValueIndex]);
                pixLogger.Add(nextValueIndex, PixelToDegree(liveDataPIX[nextValueIndex]));

                //convert bool to double
                if (boLaser == true)
                {
                    laserLogger.Add(nextValueIndex, 1);
                    formsPlot1.Plot.Style(figureBackground: Color.Red);
                }
                else
                {
                    laserLogger.Add(nextValueIndex, 0);
                    formsPlot1.Plot.Style(figureBackground: Color.White);
                }



                Debug.WriteLine(liveDataAD[nextValueIndex].ToString() + " " + liveDataPIX[nextValueIndex].ToString()); //write ad and pix value to debug window
                debug.Text = Math.Round(liveDataAD[nextValueIndex], 4).ToString() + ";" + liveDataPIX[nextValueIndex].ToString();
                TimeSpan timeSpan = DateTime.Now - beginTime;
                Debug.WriteLine(timeSpan.TotalMilliseconds.ToString());

                formsPlot1.Refresh(!resolution.Checked);

                //fileWriter.writeValue(liveDataAD[nextValueIndex].ToString() + ";" + liveDataPIX[nextValueIndex].ToString() + ";" + timeSpan.TotalMilliseconds.ToString());
            }

        }

        private double PixelToDegree(double pixel)
        {
            if (pixel >= 0 && pixel <= 400)
            {
                // Map 0-400 pixels to 0-180 degrees
                return (pixel / 400.0) * 180;
            }
            else if (pixel >= 401 && pixel <= 800)
            {
                // Map 401-800 pixels to 0 to -180 degrees
                return -180 + ((pixel - 401) / 400.0) * 180;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Pixel value is out of range.");
            }
        }

        private void clearTableLayoutPanel()
        {
            tableLayoutPanel12.Controls.Clear();
        }

        private void CreateAndAddTableLayoutPanel(int periodCounter)
        {
            // Create a new string array for the labels

            string[] LabelNames = { @"Type", @"Duration", @"Outcome", @"Pattern", @"Coup_Coeff", @"Contingency" };

            TableLayoutPanel newTableLayoutPanel = new TableLayoutPanel();
            newTableLayoutPanel.Dock = DockStyle.Fill;
            newTableLayoutPanel.ColumnCount = 1;
            newTableLayoutPanel.RowCount = 12; // Adjust according to your needs
            newTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));

            Label periodLabel = new Label();
            periodLabel.Text = @"Period " + periodCounter.ToString();
            //set the font to bold
            periodLabel.Font = new Font(periodLabel.Font, FontStyle.Bold);
            periodLabel.Margin = new Padding(0, 10, 0, 10);
            periodLabel.Anchor = AnchorStyles.None;
            periodLabel.AutoSize = true;
            newTableLayoutPanel.Controls.Add(periodLabel,0,0);

            // Dynamically add rows (controls) to the newTableLayoutPanel
            for (int i = 0; i < newTableLayoutPanel.RowCount; i++)
            {
                if (i % 2 == 0) // Label row
                {
                    Label label = new Label();
                    label.Name = "label_" + i.ToString() + "_" + periodCounter.ToString();
                    label.Text = LabelNames[(i / 2)];
                    label.Anchor = AnchorStyles.None;
                    label.AutoSize = true;
                    newTableLayoutPanel.Controls.Add(label, 0, i+1);
                }
                else // TextBox row
                {
                    TextBox textBox = new TextBox();
                    textBox.Dock = DockStyle.Fill;
                    textBox.Name = "textbox_" + i.ToString() + "_" + periodCounter.ToString();
                    newTableLayoutPanel.Controls.Add(textBox, 0, i+1);
                }
            }

            // Assuming you want to add the newTableLayoutPanel to an existing container (e.g., tableLayoutPanel12)
            // Make sure tableLayoutPanel12 is the correct container where you want to add newTableLayoutPanel
            // This could be a direct addition to the tabPage1 or another panel/container in your form
            int row = tableLayoutPanel12.RowCount;
            int column = tableLayoutPanel12.ColumnCount; // Assuming you want to add it in a new column for demonstration
            tableLayoutPanel12.Controls.Add(newTableLayoutPanel, 0, 0);

            // If you specifically want to add it to tableLayoutPanel12, make sure tableLayoutPanel12 is prepared to accept it
            // For example, if tableLayoutPanel12 should contain multiple instances of newTableLayoutPanel, you may need to adjust its RowCount and possibly add new rows dynamically.

            // Refresh the form or the container to display the newly added TableLayoutPanel
            tableLayoutPanel12.Refresh(); // Refresh tabPage1 or the specific container where you added the new layout
        }



        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(updateData));
            }
            else
            {
                //fileWriter.closeFile();

                if (serialComOpen == true)
                {
                    serialOpen.Image = Properties.Resources._269210;
                    startSerial.Text = "Start";
                    serialCom.OnDataReceived -= SerialInterface_OnDataReceived;
                    serialCom.closePort();
                    serialCom = null;
                    serialComOpen = false;
                }
                else
                {

                }
            }
        }

        private void trackBarRotation_Scroll(object sender, EventArgs e)
        {
            TrackBar trackBar = sender as TrackBar;

            numericUpDownRotation.Value = trackBar.Value;
        }

        private void numericUpDownRotation_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown rotationUpDown = sender as NumericUpDown;
            int number = 0;
            try
            {
                number = Convert.ToInt32(rotationUpDown.Value);
                if (number > 255)
                {
                    throw new ArgumentException();
                }
                trackBarRotation.Value = number;
            }
            catch(Exception ex)
            {
                rotationUpDown.Text = "0";
            }
            
        }

        private void trackBarLaser_Scroll(object sender, EventArgs e)
        {
            TrackBar trackBar = sender as TrackBar;

            numericUpDownLaser.Value = trackBar.Value;
        }

        private void numericUpDownLaser_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown rotationUpDown = sender as NumericUpDown;
            int number = 0;
            try
            {
                number = Convert.ToInt32(rotationUpDown.Value);
                if (number > 255)
                {
                    throw new ArgumentException();
                }
                trackBarLaser.Value = number;
            }
            catch (Exception ex)
            {
                rotationUpDown.Text = "0";
            }

        }


        private void laser_Click(object sender, EventArgs e)
        {
            int returnValue = 0;
            if (serialComOpen == true)
            {
                try
                {
                    returnValue = serialCom.sendValues(Convert.ToByte(Math.Round((double)numericUpDownLaser.Value * 2.55, 0)));

                    switch (returnValue)
                    {
                        case 0:
                            pictureLaser.Image = Properties.Resources._269210;
                            boLaser = false;
                            laser.Text = "Off";
                            break;
                        case 1:
                            pictureLaser.Image = Properties.Resources._269251;
                            boLaser = true;
                            laser.Text = "On";
                            break;
                        case -1:
                            pictureLaser.Image = Properties.Resources._269210;
                            boLaser = false;
                            laser.Text = "Off";
                            break;
                    }
                }
                catch (Exception ex)
                {
                    laser.Enabled = false;
                    MessageBox.Show(ex.ToString(), "Laser Event");
                }
            }
            else
            {
                   laser.Enabled = false;
            }


        }

        private void domainUpDown3_SelectedItemChanged(object sender, EventArgs e)
        {
            DomainUpDown color = sender as DomainUpDown;
            switch (color.Text)
            {
                case "Red":
                    color.BackColor = Color.Red;
                    color.ForeColor = Color.WhiteSmoke;
                    patternColor = ColorPattern.Red;
                    break;
                case "Green":
                    color.BackColor = Color.Green;
                    color.ForeColor = Color.WhiteSmoke;
                    patternColor = ColorPattern.Green;
                    break;
                case "Blue":
                    color.BackColor = Color.Blue;
                    color.ForeColor = Color.WhiteSmoke;
                    patternColor = ColorPattern.Blue;
                    break;
                case "Cyan":
                    color.BackColor = Color.Cyan;
                    color.ForeColor = Color.Black;
                    patternColor = ColorPattern.Cyan;
                    break;
                case "White":
                    color.BackColor = Color.WhiteSmoke;
                    color.ForeColor = Color.Black;
                    patternColor = ColorPattern.White;
                    break;
                default:
                    color.BackColor = Color.Empty;
                    color.ForeColor = Color.Black;
                    patternColor = ColorPattern.none;
                    break;
            }
        }

        private void domainUpDown2_SelectedItemChanged(object sender, EventArgs e)
        {
            DomainUpDown pattern = sender as DomainUpDown;
            switch (pattern.Text)
            {
                case "No pattern":
                    patternDisplay = DisplayPattern.noPattern;
                    break;
                case "One touch":
                    patternDisplay = DisplayPattern.oneTouch;
                    break;
                case "Multi touch":
                    patternDisplay = DisplayPattern.multiTouch;
                    break;
                case "T pattern":
                    patternDisplay = DisplayPattern.tPattern;
                    break;
                default:
                    patternDisplay = DisplayPattern.noPattern;
                    break;
            }
        }

        private void patternButton_Click(object sender, EventArgs e)
        {
            if (serialComOpen == true)
            {
                try
                {
                    serialCom.sendValues(patternDisplay, patternColor);
                }
                catch (Exception ex)
                {
                    patternButton.Enabled = false;
                    MessageBox.Show(ex.ToString(), "Laser Event");
                }
            }
            else
            {
                patternButton.Enabled = false;
            }
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            DomainUpDown rotation = sender as DomainUpDown;
            switch (rotation.Text)
            {
                case "Sample":
                    valueRotation = RotationValue.Sample;
                    break;
                case "Right":
                    valueRotation = RotationValue.Right;
                    break;
                case "Left":
                    valueRotation = RotationValue.Left;
                    break;
                default:
                    break;
            }
        }

        private void rotation_Click(object sender, EventArgs e)
        {
            if (serialComOpen == true)
            {
                try
                {
                    serialCom.sendValues(valueRotation, Convert.ToByte(numericUpDownRotation.Value));
                }
                catch (Exception ex)
                {
                    rotation.Enabled = false;
                    MessageBox.Show(ex.ToString(), "Laser Event");
                }
            }
            else
            {
                rotation.Enabled = false;
            }
        }


        private void fileDialog_Click(object sender, EventArgs e)
        {
            string directory = null;
            string fileName = null;

            DateTimeOffset dto = new DateTimeOffset(DateTime.UtcNow);

            saveFileDialog1.Filter = "XML files(.xml) | *.xml";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.FileName = dto.ToString("yyyyMMdd_HHmmss");
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                label3.Text = saveFileDialog1.FileName;
                directory = Path.GetDirectoryName(saveFileDialog1.FileName);
                fileName = Path.GetFileName(saveFileDialog1.FileName);
                fileWriter = new XmlFileManager(directory, fileName);
            }
            else
            {
                label3.Text = "No file selected";
            }
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == "LastName")
            {
                textBox5.Text = "";
            }
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "FirstName")
            {
                textBox4.Text = "";
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            //xmlFileManager.UpdateFirstName("firstname", textBox4.Text);
        }



        private void textBox2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "ORCID")
            {
                textBox2.Text = "";
            }
        }

        private void saveXML_Click(object sender, EventArgs e)
        {
            string directory = null;
            string fileName = null;

            DateTimeOffset dto = new DateTimeOffset(DateTime.UtcNow);

            saveFileDialog1.Filter = "XML files(.xml) | *.xml";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.FileName = @"Periods-" + dto.ToString("yyyyMMdd_HHmmss");
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                directory = Path.GetDirectoryName(saveFileDialog1.FileName);
                fileName = Path.GetFileName(saveFileDialog1.FileName);
                fileWriter = new XmlFileManager(directory, fileName, this);
            }
            else
            {
                
            }
        }

        private void loadXML_Click(object sender, EventArgs e)
        {
            string directory = null;
            string fileName = null;

            DateTimeOffset dto = new DateTimeOffset(DateTime.UtcNow);

            openFileDialog1.Filter = "XML files(.xml) | *.xml";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                directory = Path.GetDirectoryName(openFileDialog1.FileName);
                fileName = Path.GetFileName(openFileDialog1.FileName);
                Boolean validationSchema = XmlFileManager.validateXML(directory, fileName);
            }
            else
            {
                
            }
        }

        private void textBox4_MouseHover(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb != null && tb.Tag != null)
            {
                toolTip1.SetToolTip(tb, tb.Tag.ToString());
            }
        }



        private void textBox5_MouseHover(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb != null && tb.Tag != null)
            {
                toolTip1.SetToolTip(tb, tb.Tag.ToString());
            }
        }

        private void textBox2_MouseHover(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb != null && tb.Tag != null)
            {
                toolTip1.SetToolTip(tb, tb.Tag.ToString());
            }
        }

        private void NumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is not a digit or a control character
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Handle the event, effectively ignoring the input
            }
        }

        private void NumberTextBox_TextChanged(object sender, EventArgs e)
        {
            if (numberTextBox.Text != "")
            {
                int value = int.Parse(numberTextBox.Text);
                // Check if the value is outside the range 1 to 32
                if (value < 1 || value > 32)
                {
                    numberTextBox.Text = @""; // Clearing the text or set it to a default valid value
                    toolTip1.Show("Number must be between 1 and 32.", numberTextBox, 0, -20, 5000);
                }
                else
                {
                    clearTableLayoutPanel();
                    for (int i = 0; i < value; i++)
                    {
                        CreateAndAddTableLayoutPanel(i+1);
                    }
                }
            }
        }

        public string getNumberTextBox
        {
            get { return this.numberTextBox.Text; }
        }

    }
}