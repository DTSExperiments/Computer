using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace UR_MTrack
{
    public class MeasurementTimer: IDisposable
    {
        Timer _basetimer;
        System.Threading.SemaphoreSlim _semaphore;
        double _interval;
        double _monitorinterval=1000;
        double _ticktime=1;
        DateTime _endtime;
        DateTime _cntdwn;

        public MeasurementTimer()
        {
            InitializeTimer();
        }

        public event EventHandler TimerElapsed;
    
        public bool IsDisposed
        { get; set; }
        public bool IsActive
        { get; set; }
        
        /// <summary>
        /// Give a new Interval for the timer [MilliSeconds].
        /// </summary>
        public double Interval
        {
            get { return _interval; }
            set
            {
                if (value <= 0) { _interval = 3000; }
                else { _interval = value; }
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
                if (value <= 0) { _monitorinterval = 1000; } else { _monitorinterval = value; }
            }
        }

        void MeasurementTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            var cntvalue = _cntdwn.Subtract(DateTime.Now).TotalMilliseconds;
            _semaphore.Wait();
            if (cntvalue <= 0)
            {
                var value = _endtime.Subtract(DateTime.Now).TotalMilliseconds;// calculate the remaining time till next measurement[ms]
                
                _cntdwn = DateTime.Now.AddMilliseconds(1000); // set the new target for the monitor event
            }
            if (_endtime.Subtract(DateTime.Now).TotalMilliseconds <= 0)
            {
                _endtime = DateTime.Now.AddMilliseconds(_interval);                        
                TimerElapsed?.Invoke(this, EventArgs.Empty);
            }
            _semaphore.Release();
        }

        private void InitializeTimer()
        {
            _basetimer = new System.Timers.Timer();
            _basetimer.AutoReset = true;
            _basetimer.Interval = _ticktime;
            _basetimer.Elapsed += MeasurementTimer_Elapsed;
            _basetimer.Enabled = false;
            _semaphore = new System.Threading.SemaphoreSlim(1);
        }

      
        public void Start()
        {
            _endtime = DateTime.Now.AddMilliseconds(_interval);
            _cntdwn = DateTime.Now.AddMilliseconds(_monitorinterval);
            if (!IsDisposed)
            {
                _basetimer.Start();
                IsActive = true;
            }
        }

        public void Stop()
        {
            if (!IsDisposed)
            {
                _basetimer.Stop();
                IsActive = false;
            }
        }

        public void Dispose()
        {
            if (IsActive) { Stop(); }
            _basetimer.Elapsed -= MeasurementTimer_Elapsed;
            IsDisposed = true;
            _basetimer?.Dispose();
        }          
    }
}
