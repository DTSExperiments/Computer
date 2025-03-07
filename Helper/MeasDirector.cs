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
        PeriodValues _currentPeriod;


        public event EventHandler<MDirectorEventArgs> MValuesReceived;
        public event EventHandler Abort;

        public MeasDirector(ref ExperimentSettings settings, DataHandler dHandler)
        {
            _expsettings = settings;
            _datahandler = dHandler;
            InitializeTimer();
        }


        private void _timer_Elapsed(object sender, EventArgs e)
        {
            GrabMeasurement();
        }


        #region Properties

        public DateTime PeriodStartTime { get; private set; }

        #endregion

        void SetupPeriod()
        {

        }

        void GrabMeasurement()
        {
            var values = _datahandler.GetMValues();
            values.Timestamp = Math.Round((DateTime.Now - PeriodStartTime).TotalSeconds, 0);
            values.PeriodNumber=_currentPeriod.Number;
            MValuesReceived?.Invoke(this, new MDirectorEventArgs(values));
            if (values.Timestamp >= _currentPeriod.Duration)
            {
                
            }
        }

        void InitializeTimer()
        {
            _timer = new MeasurementTimer();
            _timer.Interval = (1d / _expsettings.SamplingRate) * 1000;
            _timer.Elapsed += _timer_Elapsed;
        }

        public void StartExperiment()
        {
            foreach (PeriodValues pv in _expsettings.PeriodCollection)
            {
                _currentPeriod = pv;
                PeriodStartTime = DateTime.Now;
            }
        }

        public void AbortMeasurement()
        {
            _datahandler.SuspendWorkerTh();
            Abort?.Invoke(this, EventArgs.Empty);
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
