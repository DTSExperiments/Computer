using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UR_MTrack
{
    public class SerialInterface : IDisposable
    {
        bool _simulate;
        int _thSleepTime;
        SerialPort _serialport;
        SerialPortSettings _spSettings;
        Thread _simulatorTH;

        public event EventHandler<DataReceivedEventArgs> DataReceived;

        public SerialInterface() { }
        public SerialInterface(SerialPortSettings settings)
        {
            _spSettings = settings;
        }

        #region Properties
        public IEnumerable<string> PortNames { get { return SerialPort.GetPortNames();} }
        public SerialPortSettings Settings { get; set; }
        public bool Connected { get; set; }


        #endregion

        private void _serialport_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            var buffer = new byte[5];
            _serialport.Read(buffer, 0, 5);
            DataReceived?.Invoke(this, new DataReceivedEventArgs(buffer));
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
            var rnd=new Random();
            while (_simulate)
            {
                try
                {
                    rnd.NextBytes(buffer);
                    buffer[4]=0x0A;
                }
                catch (Exception ex) { Logging.Log("Failed to generate random bytes", LogType.Fail, false, ex.Message); }
                finally 
                {
                    DataReceived?.Invoke(this, new DataReceivedEventArgs(buffer));
                    Thread.Sleep(_thSleepTime);
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

        private string FindComPort(string vid="VID_0403", string pid="PID_6001")
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
            catch(Exception) { throw; }
            finally 
            { 
                _serialport.Close();
                _serialport.Dispose(); 
            }
        }

        public void Connect()
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
                throw new Exception("Connection failed", ex);
            }
        }

        public void SendData(string data)
        {
            if (_serialport != null)
            {
                try
                {
                    _serialport.Write(data);
                }
                catch (Exception)
                { throw; }
            }
        }


        public void Disconnect()
        {
            if (_serialport != null)
            {
                try
                {
                    _serialport.Close();
                }
                catch (Exception ex)
                { throw new Exception("Disconnect failed", ex); }
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
