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

namespace plotBrembs
{
    
    public partial class Form1 : Form
    {
        readonly ScottPlot.Plottable.DataLogger adLogger;
        readonly ScottPlot.Plottable.DataLogger pixLogger;

        private static System.Threading.Timer simulationTimer = null;

        private serialInterface serialCom;
        private writeFile fileWriter;

        bool serialComOpen = false;

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

            version = Assembly.GetExecutingAssembly().GetName().Version;

            portList.AddRange(SerialPort.GetPortNames());
            portList.Sort();

            portNames = portList.ToArray();

            var yAxis3 = formsPlot1.Plot.AddAxis(ScottPlot.Renderable.Edge.Left);

            adLogger = formsPlot1.Plot.AddDataLogger(Color.Red, 1, "AD-Value");
            pixLogger = formsPlot1.Plot.AddDataLogger(Color.Blue, 1, "Pixel");

            adLogger.ViewJump();
            pixLogger.ViewJump();

            adLogger.ManageAxisLimits = false;
            pixLogger.ManageAxisLimits = false;
            pixLogger.YAxisIndex = yAxis3.AxisIndex;

            formsPlot1.Plot.SetAxisLimitsX(0, 1080);
            formsPlot1.Plot.SetAxisLimitsY(-1, 1);
            formsPlot1.Plot.SetAxisLimitsY(-180, 180, yAxis3.AxisIndex);

            formsPlot1.Configuration.ScrollWheelZoom = false;
            formsPlot1.Configuration.RightClickDragZoom = false;
            formsPlot1.Configuration.LeftClickDragPan = false;

            formsPlot1.RightClicked -= formsPlot1.DefaultRightClickEvent;


            formsPlot1.Plot.YAxis.Label("Torque");
            yAxis3.Label("Degree");

            formsPlot1.Plot.YAxis.Color(Color.Red);
            yAxis3.Color(Color.Blue);

            formsPlot1.Refresh(!resolution.Checked);

            if (portNames.Length > 0)
            {
                serialComboBox.Items.AddRange(portNames);
                serialComboBox.SelectedIndex = serialComboBox.FindString(findComPort(ConfigurationManager.AppSettings["VID"], ConfigurationManager.AppSettings["PID"])); ;
            }


            this.Text = version.ToString();

            serialCom = new serialInterface(this);
            serialCom.OnDataReceived += SerialInterface_OnDataReceived;

            fileWriter = new writeFile();


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

                Debug.WriteLine(liveDataAD[nextValueIndex].ToString() + " " + liveDataPIX[nextValueIndex].ToString()); //write ad and pix value to debug window
                debug.Text = Math.Round(liveDataAD[nextValueIndex], 4).ToString() + ";" + liveDataPIX[nextValueIndex].ToString();
                TimeSpan timeSpan = DateTime.Now - beginTime;
                Debug.WriteLine(timeSpan.TotalMilliseconds.ToString());

                formsPlot1.Refresh(!resolution.Checked);

                fileWriter.writeValue(liveDataAD[nextValueIndex].ToString() + ";" + liveDataPIX[nextValueIndex].ToString() + ";" + timeSpan.TotalMilliseconds.ToString());
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


        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(updateData));
            }
            else
            {
                fileWriter.closeFile();

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
            returnValue = serialCom.sendValues(Convert.ToByte(numericUpDownLaser.Value));
            switch (returnValue)
            {
                case 0:
                    pictureLaser.Image = Properties.Resources._269210;
                    laser.Text = "Off";
                    break;
                case 1:
                    pictureLaser.Image = Properties.Resources._269251;
                    laser.Text = "On";
                    break;
                case -1:
                    pictureLaser.Image = Properties.Resources._269210;
                    laser.Text = "Off";
                    break;
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
            serialCom.sendValues(patternDisplay, patternColor);
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
            serialCom.sendValues(valueRotation, Convert.ToByte(numericUpDownRotation.Value));
        }

    }
}