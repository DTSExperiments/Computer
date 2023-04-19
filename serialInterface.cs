using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace plotBrembs
{
    internal class serialInterface
    {
        public SerialPort _serialPort = null;

        public delegate void DataReceivedHandler(byte[] data);
        public event DataReceivedHandler OnDataReceived;

        public serialInterface()
        {
            _serialPort = new SerialPort();
            _serialPort.BaudRate = 115200;
            _serialPort.Parity = Parity.None;
        }

        public void openPort(string port)
        {
            try
            {
                if (!_serialPort.IsOpen)
                {
                    _serialPort.PortName = port;
                    _serialPort.DataReceived += new SerialDataReceivedEventHandler(SerialDataReceivedEventHandler);
                    _serialPort.Open();
                    if (_serialPort.BytesToRead == 0)
                    {
                        _serialPort.WriteLine("S");
                        _serialPort.WriteLine("S");
                    }
                    else
                    {
                        _serialPort.WriteLine("S");
                    }

                }
                else
                {
                    _serialPort.WriteLine("S");
                    _serialPort.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Serial failed", "Opening SerialPort Event");
            }
        }

        public void closePort()
        {
            try
            {
                if (_serialPort.IsOpen)
                {
                    Thread.Sleep(100);
                    if (_serialPort.BytesToRead > 0)
                    {
                        _serialPort.WriteLine("Stop");
                        _serialPort.Close();
                    }
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "SerialInterface Event");
            }
        }

        private void SerialDataReceivedEventHandler(object sender, SerialDataReceivedEventArgs e)
        {
            {
                SerialPort sp = (SerialPort)sender;
                int bytesToRead = sp.BytesToRead;
                byte[] buffer = new byte[bytesToRead];
                sp.Read(buffer, 0, bytesToRead);

                // Raise the OnDataReceived event
                OnDataReceived?.Invoke(buffer);
            }
        }
    }
}
