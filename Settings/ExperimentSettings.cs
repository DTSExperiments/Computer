using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace UR_MTrack
{
    /// <summary>
    /// Valuecollection of experiment metadata
    /// </summary>
    public class ExperimentSettings
    {
        string _datapath;
        public ExperimentSettings()
        {
            TimeStamp = DateTime.Now;
            PeriodCollection = new List<PeriodValues>();
        }

        [JsonIgnore]            
        public bool IsConfigured { get; set; }


        #region General Meta Data

        public DateTime TimeStamp { get; set; }

        /// <summary>
        /// Path to the folder where measurement files are stored.
        /// </summary>
        public string DataFolderpath
        {
            get
            {
                if (string.IsNullOrEmpty(_datapath))
                {
                    _datapath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                }
                return _datapath;
            }
            set { _datapath = value; }
        }
        /// <summary>
        /// Fully qualified path to the currently used meaurement file
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
        public IEnumerable<PeriodValues> PeriodCollection { get; set; }

        #endregion

    }
}
