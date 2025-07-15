using Logging;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;

namespace UR_MTrack
{
    public class ComInterface : IDisposable
    {
        SerialPort _serialport;

        public ComInterface() { }

        #region Properties
        public IEnumerable<string> SerialPortNames { get { return SerialPort.GetPortNames(); } }
        public bool Connected { get; set; }

        #endregion

        private void _serialport_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            var b2read = _serialport.BytesToRead;   
            var buffer = new byte[b2read];
            _serialport.Read(buffer, 0, b2read);
            new Signals().OnDataReceived(this, new DataReceivedEventArgs(buffer));
            _serialport.DiscardInBuffer();
        }

        void PrintBuffer(IEnumerable<byte> buffer)
        {
            System.Diagnostics.Debug.Write("Byte values: ");
            for(int i=0;i<buffer.Count();i++  )
            {
                System.Diagnostics.Debug.Write(buffer.ElementAt(i).ToString()+"-");
            }
        }

        public void SwitchAqMode(DataMode mode)
        {
            if (_serialport != null)
            {
                if (mode.Equals(DataMode.Auto)) { _serialport.DataReceived += _serialport_DataReceived; }
                else if (mode.Equals(DataMode.DataPoll))
                { _serialport.DataReceived -= _serialport_DataReceived; }
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

                _serialport.DataReceived += _serialport_DataReceived;
                _serialport.Open();
                _serialport.DiscardInBuffer();
                new Signals().OnConnectionStatusChanged(this, DeviceStatus.connected);
                Connected = true;
                SendData(FPGACom.GetStartCommand());
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
                    _serialport.Write(data,0,1);
                    Log.Append(string.Format("Writing \"{0}\" to serial port", data), LogType.Info);
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
                    _serialport.DataReceived -= _serialport_DataReceived;
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
