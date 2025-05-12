using Extensions;
using Logging;
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


        public event EventHandler<PatternEventArgs> SetPattern;
        public event EventHandler<RotateEventArgs> SetRotation;
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
            ProcessData();
        }

        void ExperimentControl()
        {
            _timer.Stop();
            _datahandler.CurrentPeriod = _expsettings.PeriodCollection.Next<PeriodValues>(_datahandler.CurrentPeriod);
            if (_datahandler.CurrentPeriod == null) { ExperimentFinished.Invoke(this, EventArgs.Empty); }
            else
            {
                SetPattern?.Invoke(this, new PatternEventArgs(_datahandler.CurrentPeriod.Pattern, ColorPattern.W));
                SetRotation?.Invoke(this,new RotateEventArgs(_expsettings.RotationMode,(byte)(_expsettings.Velocity*(int)_datahandler.CurrentPeriod.CoupCoeff)));
                _datahandler.CurrentPeriod.StartTime = DateTime.Now;
                _timer.Start();
            }
        }

        void ProcessData()
        {
            if (_datahandler.PreparePeriodValues())            
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
            Log.Append("Experiment started.");
            ExperimentControl();
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
