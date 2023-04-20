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

        public void sendValues()
        {
            try
            {
                if (_serialPort.IsOpen)
                {
                    _serialPort.Write("2");
                    _serialPort.Write("r");
                    _serialPort.Write(BitConverter.GetBytes(1), 0, 1);
                }
                else
                {
                    throw new InvalidOperationException("Serial port is not open.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Serial failed", ex.ToString());
            }
            
        }

        public int openPort(string port)
        {
            try
            {
                if (!_serialPort.IsOpen)
                {
                    _serialPort.PortName = port;
                    _serialPort.DataReceived += new SerialDataReceivedEventHandler(SerialDataReceivedEventHandler);
                    _serialPort.Open();
                    Thread.Sleep(100);
                    if (_serialPort.BytesToRead == 0)
                    {
                        _serialPort.Write("S");
                        return 1;
                    }
                    else
                    {
                        _serialPort.Write("S");
                        _serialPort.Write("S");
                        return 2;
                    }

                }
                else
                {
                    _serialPort.Write("S");
                    _serialPort.DataReceived -= SerialDataReceivedEventHandler;
                    _serialPort.Dispose();
                    return 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Serial failed", "Opening SerialPort Event");
                return -1;
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
                        _serialPort.WriteLine("S");
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
