using Extensions;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UR_MTrack
{
    public class ExperimentDirector
    {
        MeasurementTimer _timer;
        ExperimentSettings _expsettings;
        DataHandler _datahandler;
        PeriodValues _currentPeriod;


        public event EventHandler<MDirectorEventArgs> MValuesReceived;
        public event EventHandler<PatternEventArgs> SetPattern;
        public event EventHandler ExperimentFinished;
        public event EventHandler Abort;

        public ExperimentDirector(ref ExperimentSettings settings, DataHandler dHandler)
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

        void ExperimentControl()
        {
            _timer.Stop();
            _currentPeriod = _expsettings.PeriodCollection.Next<PeriodValues>(_currentPeriod);
            if (_currentPeriod == null) { ExperimentFinished.Invoke(this, EventArgs.Empty); }
            else
            {
                SetPattern?.Invoke(this, new PatternEventArgs(_currentPeriod.Pattern, ColorPattern.W));
                PeriodStartTime = DateTime.Now;
                _timer.Start();
            }
        }

        void GrabMeasurement()
        {
            var values = _datahandler.GetMValues();
            values.Timestamp = Math.Round((DateTime.Now - PeriodStartTime).TotalSeconds, 0);
            values.PeriodNumber = _currentPeriod.Number;
            MValuesReceived?.Invoke(this, new MDirectorEventArgs(values));
            if (values.Timestamp >= _currentPeriod.Duration)
            {
                ExperimentControl();
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
