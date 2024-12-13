using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UR_MTrack
{
    /// <summary>
    /// Valuecollection of experiment metadata
    /// </summary>
    public class ExperimentSettings
    {
        public IEnumerable<PeriodValues> PeriodCollection { get; set; }
        public DateTime Timestamp { get; set; }
        public string Datapath { get; set; } = Properties.Settings.Default.DefaultPeriodPath;
        public string COMPort { get; set; }
        public ulong ORCID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FlyName { get; set; }
        public string FlyDescription { get; set; }
        public Scope Scope { get; set; }
        public DMSType DMSType { get; set; }
        public string ExperimentDescription { get; set; }
        public int PeriodCount { get; set; }
        public string Recording { get; set; }
        public string Analysis { get; set; }
        public string DataModel { get; set; }

    }
}
