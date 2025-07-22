using Logging;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Threading;
using Timer =System.Windows.Forms.Timer;

namespace UR_MTrack
{
    public class ComInterface : IDisposable
    {
        SerialPort _serialport;
        Timer _t;

        public ComInterface()
        {
            _t = new Timer();
            _t.Interval = (int)(1000d / 60);
            _t.Tick += _t_Tick;
            _t.Start();
        }

        private void _t_Tick(object sender, EventArgs e)
        {
            PollSerialData();
        }

        #region Properties
        public IEnumerable<string> SerialPortNames { get { return SerialPort.GetPortNames(); } }
        public bool Connected { get; set; }
        public int AcquisitionInterval { get { return _t.Interval; } set { _t.Interval = value; } }

        #endregion

        private void PollSerialData()
        {
            if (_serialport != null)
            {
                try
                {
                    if (_serialport.IsOpen)
                    {
                        _serialport.DiscardInBuffer();
                        while(_serialport.BytesToRead < 5)
                        {
                            Thread.Sleep(1);                           
                        }
                        var buffer = new byte[_serialport.BytesToRead];
                        System.Diagnostics.Debug.Write("BytesToRead: " + _serialport.BytesToRead.ToString() + "\n");
                        _serialport.Read(buffer, 0, buffer.Length);
                        new Signals().OnDataReceived(this, new DataReceivedEventArgs(buffer));
                    }
                    //PrintBuffer(buffer);
                }
                catch (Exception ex)
                {
                    Log.Append(ex);
                }
            }
        }

        void PrintBuffer(IEnumerable<byte> buffer)
        {
            System.Diagnostics.Debug.Write("buffer content:\n");
            for (int i = 0; i < buffer.Count(); i++)
            {
                System.Diagnostics.Debug.Write("|:" + i + ":|" + buffer.ElementAt(i).ToString() + "\n");
            }
        }


        public void Connect(SerialPortSettings settings)
        {
            Log.Append("Opening serial port " + settings.Portname, LogType.Info);
            try
            {
                _serialport = new SerialPort()
                {
                    PortName = settings.Portname,
                    BaudRate = settings.BaudRate,
                    Parity = settings.Parity,
                    StopBits = settings.StopBits,
                    Handshake = settings.HandShake
                };
                _serialport.Open();
                _serialport.DiscardInBuffer();
                new Signals().OnConnectionStatusChanged(this, DeviceStatus.connected);
                SendData(FPGACom.GetStartCommand());
                Connected = true;
            }
            catch (Exception ex)
            {
                new Signals().OnConnectionStatusChanged(this, DeviceStatus.disconnected);
                Log.Append(ex);
            }
        }

        public void SendData(string data)
        {
            if (_serialport != null)
            {
                try
                {
                    _serialport.Write(data);
                    Log.Append(string.Format("Writing \"{0}\" to serial port", data), LogType.Info);
                }
                catch (Exception ex)
                { Log.Append(ex); }
            }
        }

        public void SendData(byte[] data)
        {
            if (_serialport != null)
            {
                try
                {
                    _serialport.Write(data, 0, 1);
                }
                catch (Exception ex)
                { Log.Append(ex); }
            }
        }

        public void Disconnect()
        {
            if (_serialport != null)
            {
                try
                {
                    new Signals().OnConnectionStatusChanged(this, DeviceStatus.disconnected);
                    _serialport.Close();
                    _serialport.Dispose();
                    Connected = false;
                }
                catch (Exception ex)
                { Log.Append(ex); }
            }
        }


        public void Dispose()
        {
            Disconnect();
            _serialport.DiscardOutBuffer();
            _serialport.DiscardInBuffer();
            _serialport.Dispose();

        }
    }
}
