using Extensions;
using Logging;
using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace UR_MTrack
{
    public class MeasurementDirector
    {
        MeasurementTimer _timer;
        EventWaitHandle _wait;
        ExperimentSettings _expsettings;
        PeriodValues _currentperiod;

        public MeasurementDirector(ExperimentSettings settings)
        {
            _expsettings = settings;
            _wait = new EventWaitHandle(true, EventResetMode.ManualReset); //true --> signaled >>thread can continue<<
            InitializeTimer();
        }


        private void _timer_Elapsed(object sender, EventArgs e)
        {
            var dT = (DateTime.Now - _currentperiod.StartTime).TotalSeconds;
            Debug.WriteLine("current dT: " + dT.ToString() + "/" + _currentperiod.Duration);
            if (dT >= _currentperiod.Duration)
            {
                _timer.Stop();
                ProcessData();
                NextPeriod();
            }
        }


        void NextPeriod()
        {   
            if (_expsettings.PeriodCollection.Last().Equals(_currentperiod))
            {
                MessageBox.Show("Experiment finished");
                new Signals().OnExperimentFinished(this, EventArgs.Empty);
            }
            else
            {
                _currentperiod = _expsettings.PeriodCollection.Next<PeriodValues>(_currentperiod);
                MessageBox.Show("selected next period: " + _currentperiod.Number);
                new Signals().OnSetPattern(this, new PatternEventArgs(_currentperiod.Pattern,_currentperiod.ColorPattern));
                MessageBox.Show(string.Format("Setting Pattern: {0}\nColor: {1}" + _currentperiod.Pattern.ToDescriptionString<DisplayPattern>(),
                                                                                    _currentperiod.ColorPattern.ToDescriptionString<ColorPattern>()));
                new Signals().OnRotate(this, new RotateEventArgs(_currentperiod.RotationMode, (byte)(_currentperiod.Velocity/** (int)pv.CoupCoeff*/)));
                MessageBox.Show(string.Format("Setting Rotation: {0}\nVelocity: {1}" + _currentperiod.RotationMode.ToDescriptionString<RotationMode>(),
                                                                    _currentperiod.Velocity));
                _currentperiod.StartTime = DateTime.Now;
                _timer.Start();
            }
        }

        

        /// <summary>
        /// Block the worker thread from execution.
        /// </summary>
        void SuspendExCtrl()
        {
            _wait.Reset();
        }

        /// <summary>
        /// Resume from a previously set block signal.
        /// </summary>
        void ResumeExCtrl()
        {
            _wait.Set();
        }

        void ProcessData()
        {
            
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
            ResumeExCtrl();
        }

    }
}
