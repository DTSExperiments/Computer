using System.IO.Ports;

namespace UR_MTrack
{
    public class SerialPortSettings
    {
        public string Portname { get; set; } = "COM1";
        public int BaudRate { get; set; } = 115200;
        public StopBits StopBits { get; set; } = StopBits.One;
        public Parity Parity { get; set; } = Parity.None;
        public Handshake HandShake { get; set; } = Handshake.None;
        public new string ToString()
        {
            return string.Format("PortName: {0}\nBaudRate: {1}\nStopBits: {2}\nParity: {3}\nHandShake: {4}",
                                    Portname, BaudRate, StopBits, Parity, HandShake);
        }
    }
}
