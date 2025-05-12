using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UR_MTrack
{
    internal class Signals
    {
        
        public static event EventHandler<PatternEventArgs> SetPattern;
        public void OnSetPattern(object sender, PatternEventArgs e)
        {
            SetPattern?.Invoke(sender, e);
        }

        public static event EventHandler<RotateEventArgs> Rotate;
        public void OnRotate(object sender, RotateEventArgs e)
        {
            Rotate?.Invoke(sender, e);
        }

        public static event EventHandler<int> LaserSwitch;
        public void OnLaserSwitch(object sender, int pwmvalue)
        {
            LaserSwitch?.Invoke(sender, pwmvalue);
        }
        
        public static event EventHandler<SerialPortSettings> SerialConnect;
        public void OnSerialConnect(object sender,SerialPortSettings settings )
        {
            SerialConnect?.Invoke(sender, settings);
        }
    }

    public class PeriodChangedEventArgs : EventArgs
    {
        /// <summary>
        /// Period value collection.
        /// </summary>
        public PeriodValues Values { get; private set; }
        public PeriodChangedEventArgs(PeriodValues values)
        {
            Values = values;
        }
    }

    public class DataHandlerEventArgs : EventArgs
    {
        /// <summary>
        /// Timestamp. Δt from start of period measurement in seconds. 
        /// </summary>
        public double TimeStamp { get; private set; }
        /// <summary>
        /// Single torque value [raw]
        /// </summary>
        public double Torque { get; private set; }
        /// <summary>
        /// Single location value [raw]
        /// </summary>
        public double Location { get; private set; }


        public DataHandlerEventArgs(double timestamp,double torque,double location)
        {
            TimeStamp = timestamp;
            Torque = torque;    
            Location=location;  
        }
    }
    public class ExpControlEventArgs : EventArgs
    {
        /// <summary>
        /// The triggered experiment status. (start, stop ,suspend, resume) 
        /// </summary>
        public ExperimentState ExState { get; private set; }
        public ExpControlEventArgs(ExperimentState exstate)
        {
            ExState = exstate;
        }
    }
    public class MeasurementEventArgs : EventArgs
    {
        /// <summary>
        /// 
        /// </summary>
        public MeasurementValues Values { get; private set; }
        public MeasurementEventArgs(MeasurementValues values)
        {
            Values = values;
        }
    }
   

    public class PatternEventArgs : EventArgs
    {        
        public DisplayPattern Pattern { get; private set; }
        /// <summary>
        /// the code used in FPGA-device. [e.g. "G"->green, "D"->cyan,...]
        /// </summary>
        public ColorPattern Color { get; private set; }


        public PatternEventArgs(DisplayPattern p,ColorPattern color)
        {
            Pattern = p;
            Color = color;
        }
    }

    public class RotateEventArgs : EventArgs
    {
        public RotationMode Rotation { get; private set; }
        public int Velocity { get; private set; }

        public RotateEventArgs(RotationMode r, int velocity)
        {
            Rotation = r;
            Velocity = velocity;
        }
    }

    public class DataReceivedEventArgs : EventArgs
    {
        /// <summary>
        /// Period value collection.
        /// </summary>       
        public IEnumerable<byte> Bytes { get; private set; }
        
        public DataReceivedEventArgs(IEnumerable<byte> data)
        {
            Bytes = data;
        }
    }
}
