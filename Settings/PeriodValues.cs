using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UR_MTrack
{
    public class PeriodValues
    {
        public PeriodValues() { }   
        public PeriodValues(int nr) { Number = nr; }
        public int Number { get; set; }
        public PeriodType Type { get; set; }
        public int Duration { get; set; }
        public int Outcome { get; set; }
        public PeriodPattern Pattern { get; set; }
        public double CoupCoeff { get; set; } = 11.0;
        public PeriodContingency Contingency { get; set; }
    }
}
