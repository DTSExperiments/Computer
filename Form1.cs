using System.Diagnostics;
using System.IO.Ports;
using System.Text;
using System.Numerics;
using System.Collections;
using ScottPlot;

namespace plot
{
    public partial class Form1 : Form
    {
        public SerialPort _serialPort = null;
        public Thread ReadSerialDataThread;

        private double[] liveDataAD = new double[4000];
        private double[] liveDataPIX = new double[4000];

        private List<byte> list = new List<byte>();
        private int nextValueIndex = -1;

        public delegate void ShowSerialData(List<byte> _readSerialValue);

        public Form1()
        {
            InitializeComponent();

            List<string> portList = new List<string>();

            portList.AddRange(SerialPort.GetPortNames());
            portList.Sort();

            string[] portNames = portList.ToArray();
            serialComboBox.Items.AddRange(portNames);

            serialComboBox.SelectedIndex = 0;

            this.Text = "Fligh Simulation";

            _serialPort = new SerialPort();
            _serialPort.BaudRate = 115200;
            _serialPort.Parity = Parity.None;

            var pltAD = formsPlot1.Plot.AddSignal(liveDataAD);
            var pltPX = formsPlot1.Plot.AddSignal(liveDataPIX);
            formsPlot1.Plot.AxisAutoX(margin: 0);
            formsPlot1.Plot.SetAxisLimits(yMin: -2048 , yMax: 2047);

            formsPlot1.Plot.Title("flySimulation");
            formsPlot1.Plot.Grid(true);

            pltAD.Color = Color.Magenta;
            pltPX.Color = Color.Green;
            pltAD.LineWidth = 2;
            pltPX.LineWidth = 2;
            pltAD.YAxisIndex = 0;
            pltPX.YAxisIndex = 1;

            formsPlot1.Plot.YAxis.Color(Color.Magenta);
            formsPlot1.Plot.YAxis.Label("AD-Value");
            formsPlot1.Plot.YAxis2.Color(Color.Green);
            formsPlot1.Plot.YAxis2.Label("PIXEL-Value");
            formsPlot1.Plot.XAxis.Label("Time");

            formsPlot1.Refresh();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //double[] dataX = new double[] { 1, 2, 3, 4, 5 };
            //double[] dataY = new double[] { 1, 4, 9, 16, 25 };
            //formsPlot1.Plot.AddScatter(dataX, dataY);
            //formsPlot1.Refresh();
        }

        private void startSerial_Click(object sender, EventArgs e)
        {
            try
            {
                if (!_serialPort.IsOpen)
                {
                    _serialPort.PortName = serialComboBox.Text;
                    _serialPort.DataReceived += new SerialDataReceivedEventHandler(SerialDataReceivedEventHandler);
                    _serialPort.Open();
                    _serialPort.WriteLine("Start");
                }
                else
                {
                    _serialPort.WriteLine("Stop");
                    _serialPort.Close();
                }
            }
            catch (Exception ex)
            {

            }
            


        }

        private void SerialDataReceivedEventHandler(object sender, SerialDataReceivedEventArgs e)
        {
            {
                try
                {
                    SerialPort sp = (SerialPort)sender;
                    while(sp.BytesToRead > 0)
                    {
                        list.Add(Convert.ToByte(sp.ReadByte()));
                        //Debug.WriteLine(sp.ReadByte());
                    }
                }
                catch
                {

                }
                this.BeginInvoke(new ShowSerialData(LineReceived), list);
            }
        }

        private void LineReceived(List<byte> _serialValue)
        {
            ushort nextValueUint = 0;
            short nextValueAD = 0;
            ushort nextValuePIX = 0;
            byte[] byteArray = new byte[4];            

            while (_serialValue.Count >= 5 && _serialValue.IndexOf(0x0A) == 4)
            {
                byteArray = _serialValue.GetRange(0, 4).ToArray();
                nextValueUint = BitConverter.ToUInt16(byteArray, 0);
                BitArray nextValueADBit = new BitArray(byteArray);
                if (nextValueADBit[11] == true)
                {
                    nextValueADBit = nextValueADBit.Or(new BitArray(System.BitConverter.GetBytes(0xF000)));
                }
                nextValueADBit.CopyTo(byteArray, 0);
                nextValueAD = BitConverter.ToInt16(byteArray, 0);
                nextValuePIX = BitConverter.ToUInt16(byteArray, 2);

                Debug.WriteLine(nextValueAD);
                Debug.WriteLine(nextValuePIX);

                debugTextbox.Text = DateTime.UtcNow.ToString() + "/ " + nextValueAD.ToString() + "/ " + nextValuePIX.ToString();

                _serialValue.RemoveRange(0,  5);

                nextValueIndex = (nextValueIndex < liveDataAD.Length - 1) ? nextValueIndex + 1 : 0;
                liveDataAD[nextValueIndex] = Convert.ToDouble(nextValueAD);
                liveDataPIX[nextValueIndex] = Convert.ToDouble(nextValuePIX);
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

        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {

            //System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();
            //messageBoxCS.AppendFormat("{0} = {1}", "CloseReason", e.CloseReason);
            //messageBoxCS.AppendLine();
            //messageBoxCS.AppendFormat("{0} = {1}", "Cancel", e.Cancel);
            //messageBoxCS.AppendLine();
            //MessageBox.Show(messageBoxCS.ToString(), "FormClosing Event");

            _serialPort.WriteLine("Stop");
            _serialPort.Close();
        }


        private void updateData()
        {
            formsPlot1.Refresh();
        }
    }
}