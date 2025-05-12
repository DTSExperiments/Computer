using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UR_MTrack
{
    /// <summary>
    /// Valuecollection of experiment metadata
    /// </summary>
    public class AppSettings
    {
        public AppSettings()        {}


        /// <summary>
        /// Used COM port throughout the experiment.
        /// </summary>
        public string COMPort { get; set; } = "COM1";
        public SerialPortSettings COMPortSettings { get; set; }=new SerialPortSettings();

        public bool AutoConnect { get; set; }=true;

        /// <summary>
        /// 
        /// </summary>
        public int LaserPWMValue { get; set; } = 0;

        /// <summary>
        /// 
        /// </summary>
        public int Velocity { get; set; } = 0;

        /// <summary>
        /// 
        /// </summary>
        public RotationMode RotationMode { get; set; } = RotationMode.s;
        /// <summary>
        /// 
        /// </summary>
        public ColorPattern ColorPattern { get; set; } = ColorPattern.W;
        /// <summary>
        /// 
        /// </summary>
        public DisplayPattern DisplayPattern { get; set; } = DisplayPattern.stripeddrum;


    }
}
