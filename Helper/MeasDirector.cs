using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UR_MTrack
{
    public class MeasDirector
    {
        ExperimentSettings _expsettings;
        DataHandler _datahandler;
        public MeasDirector(ref ExperimentSettings settings,DataHandler dHandler)
        {
            _expsettings = settings;
            _datahandler = dHandler;
            

        }

        #region Properties
        public DateTime StartTime { get; set; }

        #endregion


        public void StartPeriodMeasurement()
        {
            StartTime = DateTime.Now;


        }
    }
}
