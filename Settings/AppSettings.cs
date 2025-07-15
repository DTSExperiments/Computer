namespace UR_MTrack
{
    /// <summary>
    /// Valuecollection of experiment metadata
    /// </summary>
    public class AppSettings
    {
        public AppSettings() { }

        public SerialPortSettings COMPortSettings { get; set; } = new SerialPortSettings();

        public bool AutoConnect { get; set; } = true;

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
