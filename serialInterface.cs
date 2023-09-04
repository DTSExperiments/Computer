using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace plotBrembs
{
    public enum ColorPattern
    {
        Red,
        Green,
        Blue,
        Cyan,
        White,
        none
    }

    public enum DisplayPattern
    {
        noPattern,
        oneTouch,
        multiTouch,
        tPattern,
        none
    }

    public enum RotationValue
    {
        Sample,
        Right,
        Left
    }

    internal class serialInterface
    {
        public SerialPort _serialPort = null;
        public int laserOnOff = 0;

        public delegate void DataReceivedHandler(byte[] data);
        public event DataReceivedHandler OnDataReceived;

        private Control _uiControl;

        public serialInterface(Control uiControl)
        {
            _serialPort = new SerialPort();
            _serialPort.BaudRate = 115200;
            _serialPort.Parity = Parity.None;
            _uiControl = uiControl;
        }

        public int sendValues(byte laserPWM)
        {
            try
            {
                if (_serialPort.IsOpen)
                {
                    _serialPort.Write("L");
                    _serialPort.Write(Convert.ToChar(laserPWM).ToString());
                    laserOnOff = laserOnOff > 0 ? 0 : 1;
                    return laserOnOff;
                }
                else
                {
                    throw new InvalidOperationException("Serial port is not open.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Serial failed", ex.ToString());
                return -1;
            }
        }

        public void sendValues(RotationValue valueRotation, byte byteRotation)
        {
            try
            {
                if (_serialPort.IsOpen)
                {
                    if (valueRotation == RotationValue.Sample)
                    {
                        _serialPort.Write("s");
                        _serialPort.Write(Convert.ToChar(byteRotation).ToString());
                    }
                    else if (valueRotation == RotationValue.Right)
                    {
                        _serialPort.Write("r");
                        _serialPort.Write(Convert.ToChar(byteRotation).ToString());
                    }
                    else if (valueRotation == RotationValue.Left)
                    {
                        _serialPort.Write("l");
                        _serialPort.Write(Convert.ToChar(byteRotation).ToString());
                    }
                    else
                    {
                        throw new InvalidOperationException("No pattern to show.");
                    }
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

        public void sendValues(DisplayPattern patternDisplay, ColorPattern patternColor)
        {
            try
            {
                if (_serialPort.IsOpen)
                {
                    if (patternDisplay == DisplayPattern.noPattern && patternColor == ColorPattern.Blue)
                    {
                        _serialPort.Write("1");
                        _serialPort.Write("B");
                    }
                    else if (patternDisplay == DisplayPattern.noPattern && patternColor == ColorPattern.Green)
                    {
                        _serialPort.Write("1");
                        _serialPort.Write("G");
                    }
                    else if (patternDisplay == DisplayPattern.noPattern && patternColor == ColorPattern.Cyan)
                    {
                        _serialPort.Write("1");
                        _serialPort.Write("D");
                    }
                    else if (patternDisplay == DisplayPattern.noPattern && patternColor == ColorPattern.White)
                    {
                        _serialPort.Write("1");
                        _serialPort.Write("W");
                    }
                    else if (patternDisplay == DisplayPattern.oneTouch && patternColor == ColorPattern.Blue)
                    {
                        _serialPort.Write("2");
                        _serialPort.Write("B");
                    }
                    else if (patternDisplay == DisplayPattern.oneTouch && patternColor == ColorPattern.Green)
                    {
                        _serialPort.Write("2");
                        _serialPort.Write("G");
                    }
                    else if (patternDisplay == DisplayPattern.oneTouch && patternColor == ColorPattern.Cyan)
                    {
                        _serialPort.Write("2");
                        _serialPort.Write("D");
                    }
                    else if (patternDisplay == DisplayPattern.oneTouch && patternColor == ColorPattern.White)
                    {
                        _serialPort.Write("2");
                        _serialPort.Write("W");
                    }
                    else if (patternDisplay == DisplayPattern.multiTouch && patternColor == ColorPattern.Blue)
                    {
                        _serialPort.Write("3");
                        _serialPort.Write("B");
                    }
                    else if (patternDisplay == DisplayPattern.multiTouch && patternColor == ColorPattern.Green)
                    {
                        _serialPort.Write("3");
                        _serialPort.Write("G");
                    }
                    else if (patternDisplay == DisplayPattern.multiTouch && patternColor == ColorPattern.Cyan)
                    {
                        _serialPort.Write("3");
                        _serialPort.Write("D");
                    }
                    else if (patternDisplay == DisplayPattern.multiTouch && patternColor == ColorPattern.White)
                    {
                        _serialPort.Write("3");
                        _serialPort.Write("W");
                    }
                    else if (patternDisplay == DisplayPattern.tPattern && patternColor == ColorPattern.Blue)
                    {
                        _serialPort.Write("4");
                        _serialPort.Write("B");
                    }
                    else if (patternDisplay == DisplayPattern.tPattern && patternColor == ColorPattern.Green)
                    {
                        _serialPort.Write("4");
                        _serialPort.Write("G");
                    }
                    else if (patternDisplay == DisplayPattern.tPattern && patternColor == ColorPattern.Cyan)
                    {
                        _serialPort.Write("4");
                        _serialPort.Write("D");
                    }
                    else if (patternDisplay == DisplayPattern.tPattern && patternColor == ColorPattern.White)
                    {
                        _serialPort.Write("4");
                        _serialPort.Write("W");
                    }
                    else
                    {
                        throw new InvalidOperationException("No pattern to show.");
                    }
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
                if (_serialPort.IsOpen == false && _serialPort != null)
                {
                    _serialPort.PortName = port;
                    _serialPort.DataReceived += new SerialDataReceivedEventHandler(SerialDataReceivedEventHandler);
                    _serialPort.Open();

                    Thread.Sleep(100);

                    if (_serialPort.BytesToRead == 0)
                    {
                        _serialPort.Write("S");
                        return 0;
                    }
                    else
                    {
                        _serialPort.Write("S");
                        _serialPort.Write("S");
                        return 0;
                    }

                }
                else
                {
                    return -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Serial failed", "Opening SerialPort Event");
                return -1;
            }
        }

        public bool IsSerialPortNull()
        {
            return _serialPort == null;
        }

        public int closePort()
        {

            try
            {
                if (_serialPort.IsOpen && _serialPort != null)
                {
                    _serialPort.Write("S");
                    _serialPort.BaseStream.Flush();
                    _serialPort.DataReceived -= SerialDataReceivedEventHandler;
                    _serialPort.Close();
                    _serialPort.Dispose();
                    _serialPort = null;
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Serial failed {ex.Message}", "Closing SerialPort Event");
                return -1;
            }
        }

        private void SerialDataReceivedEventHandler(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                SerialPort sp = (SerialPort)sender;
                int bytesToRead = sp.BytesToRead;
                byte[] buffer = new byte[bytesToRead];
                sp.Read(buffer, 0, bytesToRead);

                // Raise the OnDataReceived event
                _uiControl.BeginInvoke((Action)(() =>
                {
                    OnDataReceived?.Invoke(buffer);
                }));
            }
            catch (Exception ex)
            {
                // Handle or log the exception as needed
                Debug.WriteLine($"Error in SerialDataReceivedEventHandler: {ex.Message}");
            }
        }
    }
}
