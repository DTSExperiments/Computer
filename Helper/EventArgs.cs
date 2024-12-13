using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UR_MTrack
{
    public class LogEventArgs : EventArgs
    {
        /// <summary>
        /// Show a message box 
        /// </summary>
        public bool IsShowMsgBox { get; private set; }

        /// <summary>
        /// A title to the message for e.g. showing in messagebox
        /// </summary>
        public string Title { get; private set; }

        /// <summary>
        /// The message to be logged
        /// </summary>
        public string Message { get; private set; }
        public System.Windows.Forms.MessageBoxIcon Icon { get; set; }


        public LogEventArgs(string message, LogType messagetype, bool showmsgbox)
        {
            IsShowMsgBox = showmsgbox;
            Message = message;
            Title = messagetype.ToString();

            if (messagetype == LogType.Error) { Icon = System.Windows.Forms.MessageBoxIcon.Error; }
            else if (messagetype == LogType.Warning) { Icon = System.Windows.Forms.MessageBoxIcon.Warning; }
            else
            {
                Icon = System.Windows.Forms.MessageBoxIcon.Information;
            }
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

    public class PatternEventArgs : EventArgs
    {        
        public DisplayPattern Pattern { get; private set; }
        public string ColorName { get; private set; }

        public PatternEventArgs(DisplayPattern p,string color)
        {
            Pattern = p;
            ColorName = color;
        }
    }

    public class RotateEventArgs : EventArgs
    {
        public RotationValue Rotation { get; private set; }
        public int Angle { get; private set; }

        public RotateEventArgs(RotationValue r, int angle)
        {
            Rotation = r;
            Angle = angle;
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
