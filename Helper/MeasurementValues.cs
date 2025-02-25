using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UR_MTrack
{
    public class MeasurementValues
    {
        /// <summary>
        /// 
        /// </summary>
        public int PeriodNumber { get; set; }

        /// <summary>
        /// measured torquevalue (average to fulfill the sampling rate)
        /// </summary>
        public double Torque { get; set; }

        /// <summary>
        /// pixelvalue recalculated to degree (average to fulfill the sampling rate requirement) 
        /// </summary>
        public int Location { get;  set; }
       
        /// <summary>
        /// total seconds since period measurement started  
        /// </summary>
        public double Timestamp {  get; set; }

        public override string ToString()
        {
            return string.Format("{0}\t{1}\t{2}\t{3}", Timestamp, Location, Torque, 0);
        }
    }
}
