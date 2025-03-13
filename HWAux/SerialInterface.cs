using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading;
using Logging;

namespace UR_MTrack
{
    public class SerialInterface : IDisposable
    {
        bool _simulate;
        SerialPort _serialport;
        Thread _simulatorTH;

        public event EventHandler<DataReceivedEventArgs> SerialInterfaceDataReceived;

        public SerialInterface() { }
        public SerialInterface(SerialPortSettings settings)
        {
            Settings = settings;
        }

        #region Properties
        public IEnumerable<string> PortNames { get { return SerialPort.GetPortNames(); } }
        public SerialPortSettings Settings { get; set; }
        public bool Connected { 
            get; 
            set; 
        }


        #endregion

        private void _serialport_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            var buffer = new byte[5];
            _serialport.Read(buffer, 0, 5);
            SerialInterfaceDataReceived?.Invoke(this, new DataReceivedEventArgs(buffer));
        }

        private void InitializeDataSimulator()
        {
            _simulatorTH = new Thread(SimulateData);
            _simulatorTH.IsBackground = true;
            _simulatorTH.Name = "Data Constructor";
            _simulatorTH.Start();
        }

        void SimulateData()
        {

            var buffer = new byte[5];
            var rnd = new Random();
            while (_simulate)
            {
                try
                {
                    rnd.NextBytes(buffer);
                    buffer[4] = 0x0A;
                }
                catch (Exception ex) { Log.Append("Failed to generate random bytes", LogType.Fail, false, ex.Message); }
                finally
                {
                    SerialInterfaceDataReceived?.Invoke(this, new DataReceivedEventArgs(buffer));
                }
            }
        }

        public void StopSimulator()
        {
            _simulate = false;
            _simulatorTH.Abort();
        }

        public void StartSimulator()
        {
            _simulate = true;
            _simulatorTH.Start();
        }

        
        public void CheckPort(SerialPortSettings settings)
        {
            try
            {
                _serialport = new SerialPort()
                {
                    PortName = Settings.Portname,
                    BaudRate = Settings.BaudRate,
                    Parity = Settings.Parity,
                    StopBits = Settings.StopBits,
                    Handshake = Settings.HandShake
                };
                _serialport.Open();
            }
            catch (Exception ex) { Log.Append(ex); }
            finally
            {
                _serialport.Close();
                _serialport.Dispose();
            }
        }

        

        public bool Connect()
        {
            if (!Connected)
            {
                try
                {
                    _serialport = new SerialPort()
                    {
                        PortName = Settings.Portname,
                        BaudRate = Settings.BaudRate,
                        Parity = Settings.Parity,
                        StopBits = Settings.StopBits,
                        Handshake = Settings.HandShake
                    };
                    _serialport.DataReceived += _serialport_DataReceived;
                    _serialport.Open();
                    _serialport.DiscardOutBuffer();
                    _serialport.DiscardInBuffer();
                    Connected = true;
                }
                catch (Exception ex)
                {
                    Connected = false;
                    Log.Append(ex);
                }
            }
            return Connected;
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


        public void Disconnect()
        {
            if (_serialport != null)
            {
                try
                {
                    _serialport.DataReceived -= _serialport_DataReceived;
                    _serialport.Close();
                    _serialport.Dispose();                    
                }
                catch (Exception ex)
                { Log.Append(ex); }
                finally
                { Connected = false; }
            }
        }


        public void Dispose()
        {
            Disconnect();
            _serialport.DataReceived -= _serialport_DataReceived;
            _serialport.DiscardOutBuffer();
            _serialport.DiscardInBuffer();
            _serialport.Dispose();

        }
    }
}
