using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UR_MTrack
{
    public class MeasDirector
    {
        MeasurementTimer _timer;

        ExperimentSettings _expsettings;
        DataHandler _datahandler;


        public event EventHandler<MDirectorEventArgs> MValuesReceived;
        public event EventHandler Abort;

        public MeasDirector(ref ExperimentSettings settings,DataHandler dHandler)
        {
            _expsettings = settings;
            _datahandler = dHandler;
            Initialize();
        }


        private void _timer_Elapsed(object sender, EventArgs e)
        {
            var values = _datahandler.GetMValues();
            values.Timestamp=(DateTime.Now-StartTime).TotalSeconds;
            MValuesReceived?.Invoke(this,new MDirectorEventArgs(values));
        }


        #region Properties
        public DateTime StartTime { get; private set; }

        #endregion


        void Initialize()
        {
            _timer = new MeasurementTimer();
            _timer.Interval = (1d / _expsettings.SamplingRate) * 1000; 
            _timer.Elapsed += _timer_Elapsed;
        }
        public void StartMeasurement()
        {
            StartTime = DateTime.Now;
        }
        public void AbortMeasurement()
        {
            _datahandler.SuspendWorkerTh();
            Abort?.Invoke(this,EventArgs.Empty);
        }
        public void Suspend()
        {
            _datahandler.SuspendWorkerTh();
            _timer.Stop(); 
        }

        public void Resume()
        {
            _datahandler.ResumeWorkerTh();
            _timer.Start();
        }
               

    }
}
