using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;

namespace UR_MTrack
{
    /// <summary>
    /// Valuecollection of experiment metadata
    /// </summary>
    public class ExperimentSettings
    {
        public ExperimentSettings() 
        { 
            TimeStamp = DateTime.Now; 
            PeriodCollection=new List<PeriodValues>();  
        }

        #region General Meta Data

        public DateTime TimeStamp { get; set; }
        public string COMPort { get; set; }
        public string Datapath { get; set; } = Properties.Settings.Default.DataPath;

        #endregion

        #region Experimenter Data
        public ulong ORCID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        #endregion

        #region Fly Data

        public string FlyName { get; set; }
        public string FlyDescription { get; set; }
        public string FlyBase { get; set; }

        #endregion

        #region Experiment Data

        public DMSType DMSType { get; set; }
        public ArenaType Arena { get; set; }        
        public string ExperimentDescription { get; set; }
        
        public string Recording { get; set; }
        public string Analysis { get; set; }
        public string DataModel { get; set; }
        public int Duration { get; set; }
        public int SamplingRate { get; set; } = 60;
        public int PeriodCount { get { return PeriodCollection.Count(); } }
        
        
        //[JsonIgnore]        
        public IEnumerable<PeriodValues> PeriodCollection { get; set; }

        #endregion
    }
}
