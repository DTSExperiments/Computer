using System;

namespace UR_MTrack
{
    public class PeriodValues
    {
        public PeriodValues() { }
        public PeriodValues(int nr) { Number = nr; }
        public int Number { get; set; }
        public DateTime StartTime { get; set; }
        public ExperimentType Type { get; set; }
        public int Duration { get; set; }
        public int Outcome { get; set; }
        public DisplayPattern Pattern { get; set; }
        public ColorPattern ColorPattern { get; set; }

        public int Velocity { get; set; } = 1;
        
        public RotationMode RotationMode { get; set; } = RotationMode.s;
        public double CoupCoeff { get; set; } = 11.0;
        public PeriodContingency Contingency { get; set; }
    }
}
