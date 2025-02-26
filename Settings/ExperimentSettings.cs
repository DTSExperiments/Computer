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
        /// <summary>
        /// Used COM port throughout the experiment.
        /// </summary>
        public string COMPort { get; set; }
        /// <summary>
        /// Path to the folder where measurement files are stored.
        /// </summary>
        public string Datapath { get; set; } 
        /// <summary>
        /// Path to the currently used meaurement file
        /// </summary>
        public string Filepath { get; set; }

        #endregion

        #region Experimenter Data
        public string ORCID { get; set; }
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
        public int SamplingRate { get; set; }
        public int PeriodCount { get { return PeriodCollection.Count(); } }
        
        public int LaserPWMValue { get; set; }
        public IEnumerable<PeriodValues> PeriodCollection { get; set; }

        #endregion
    }
}
