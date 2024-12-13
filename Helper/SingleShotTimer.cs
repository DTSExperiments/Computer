//***********************************************************************************************************************************
// Filename:		SingleShotTimer.cs																
// Project:			VisiSensVS 
// Creation Date:	24. 6. 2013	  
// Creation Time:	09:59	
// Original Autor:	(wakl) Kleisch, Walter 
//
//***********************************************************************************************************************************
// 											Copyright (c) 2013 PreSens GmbH
//***********************************************************************************************************************************



using System;
using System.Timers;

namespace UR_MTrack
{
    public class SingleShotTimer : IDisposable
    {
        Timer _timer;

        public SingleShotTimer(double timeoutperiod = 2000)
        {
            _timer = new Timer();
            _timer.Interval = timeoutperiod;
            _timer.AutoReset = false;
            _timer.Enabled = false;
            _timer.Elapsed += timer_Elapsed;
        }

        #region Properties

       
        public bool IsActive { get; private set; }
        #endregion

        #region Events
        /// <summary>
        /// Event is raised if the timer period elapsed
        /// </summary>
        public event EventHandler TimerElapsed;

        #endregion

        #region EventHandler

        void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            _timer.Stop();
            TimerElapsed?.Invoke(this, EventArgs.Empty);
        }
        #endregion

        #region Methods

        public void Start()
        {
            try
            {
                if (_timer != null)
                {
                    _timer.Enabled = true;
                    _timer.Start();
                    IsActive = true;
                }
            }
            catch (Exception) { }
        }
        public void Restart()
        {            
            try
            {
                if (_timer != null)
                {
                    _timer.Stop();
                    _timer.Start();
                }
            }
            catch (Exception) { }
        }
        public void Stop()
        {
            try
            {
                if (_timer != null)
                {
                    _timer.Stop();
                    _timer.Enabled = false;
                    IsActive = false;
                }
            }
            catch (Exception) { }

        }
        public void Dispose()
        {
            if (_timer != null)
            {
                _timer.Enabled = false;
                _timer.Elapsed -= timer_Elapsed;
            }
            if (TimerElapsed != null)
            { TimerElapsed = null; }
        }

        #endregion

    }

}
