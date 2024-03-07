using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plotBrembs
{
    public class Period
    {
        public int Number { get; set; }
        public string Type { get; set; }
        public int Duration { get; set; }
        public int Outcome { get; set; }
        public int Pattern { get; set; }
        public int CoupCoeff { get; set; }
        public string Contingency { get; set; }
    }
}
