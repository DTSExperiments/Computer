using Logging;
using System;
using System.Timers;

namespace UR_MTrack
{
    public sealed class MeasurementTimer : IDisposable
    {
        Timer _basetimer;
        double _monitorinterval;

        public MeasurementTimer(bool singleshot = false)
        {
            InitializeTimer(singleshot);
        }

        public event EventHandler Elapsed;

        public bool IsDisposed
        { get; set; }

        /// <summary>
        /// Give a new Interval for the timer [MilliSeconds].
        /// </summary>
        public double Interval
        {
            get { return _basetimer.Interval; }
            set
            {
                if (value > 0) { _basetimer.Interval = value; }
            }
        }
        /// <summary>
        /// Give a new interval to monitor the current timer status [MilliSeconds].
        /// </summary>
        public double MonitorInterval
        {
            get { return _monitorinterval; }
            set
            {
                if (value > 0)
                { _monitorinterval = value; }
            }
        }

        void MeasurementTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Elapsed?.Invoke(this, EventArgs.Empty);
        }

        private void InitializeTimer(bool singleshot)
        {
            _basetimer = new Timer();
            _basetimer.AutoReset = !singleshot;
            _basetimer.Elapsed += MeasurementTimer_Elapsed;
            _basetimer.Enabled = false;
        }


        public void Start()
        {
            if (!IsDisposed)
            {
                _basetimer.Interval = Interval;
                Log.Append("Starting Timer with interval " + Interval.ToString() + "ms");
                _basetimer.Start();
            }
        }

        public void Stop()
        {
            if (!IsDisposed)
            {
                _basetimer.Stop();
            }
        }

        public void Dispose()
        {
            _basetimer.Elapsed -= MeasurementTimer_Elapsed;
            IsDisposed = true;
            _basetimer?.Dispose();
        }
    }
}
