using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UR_MTrack
{
    public class SerialPortSettings
    {
        public string Portname { get; set; } = "COM1";
        public int BaudRate { get; set; } = 115200;
        public StopBits StopBits { get; set; } = StopBits.One;
        public Parity Parity { get; set; } = Parity.None;
        public Handshake HandShake { get; set; } = Handshake.None;
    }
}
