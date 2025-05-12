//**********************************************************************************************************************************
// Filename:	DataHandler.cs																
// Project:	    MelaTrack
// Creation Date:	26. 11. 2024	  
// Creation Time:	09:33	
// Original Autor:	Walter Sebastian Kleisch 
// 
//***********************************************************************************************************************************
// 			                        Copyright (c) 2024 Universität Regensburg							
//***********************************************************************************************************************************
using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZedGraph;
using System.Threading;
namespace UR_MTrack
{
    /// <summary>
    /// Handle Mesurement Data 
    /// </summary>
    public class DataHandler
    {
        EventWaitHandle _thControl;
        ConcurrentBag<IEnumerable<byte>> _rawValueCollection;
        List<double> _rawtorque;
        List<double> _rawpixel;
        Thread _dataHandlerTh;
        

        public event EventHandler<MeasurementEventArgs> MValuesPrepared;
        public event EventHandler<DataHandlerEventArgs> ChartValuesPrepared;
        public DataHandler()
        {
            _rawValueCollection = new ConcurrentBag<IEnumerable<byte>>();
            _rawtorque = new List<double>();
            _rawpixel = new List<double>();
            InitThread();
        }


        #region Properties

        public PeriodValues CurrentPeriod { get; set; }

        #endregion


        #region Methods

        void InitThread()
        {
            _thControl = new EventWaitHandle(true, EventResetMode.ManualReset); //true --> signaled >>thread can continue<<
            _dataHandlerTh = new Thread(RawDataWorker);
            _dataHandlerTh.IsBackground = true;
            _dataHandlerTh.Name = "ThDataHandler";
            _dataHandlerTh.Start();

        }


        void RawDataWorker()
        {
            while (_dataHandlerTh.IsAlive)
            {
                _thControl.WaitOne(); //waiting for signalling [EWH.Set()] if a reset was called previously.
                if (_rawValueCollection.TryTake(out var values))
                {
                    var t = Convert.ToDouble(((values.ElementAt(0) << 8) | values.ElementAt(1)) * 244.14 * Math.Pow(10, -6));
                    var p = PixelToDegree((values.ElementAt(2) << 8) | values.ElementAt(3));
                    _rawtorque.Add(t);
                    _rawpixel.Add(p);
                    ChartValuesPrepared?.Invoke(this,new DataHandlerEventArgs((DateTime.Now- CurrentPeriod.StartTime).TotalSeconds,t,p));
                }
                Thread.Sleep(1);
            }
        }


        /// <summary>
        /// convert the transmitted pixel to degree of torsion 
        /// </summary>
        /// <param name="pixel"></param>
        /// <returns></returns>
        double PixelToDegree(double pixel)
        {
            if (pixel >= 0 && pixel <= 400)
            {
                // Map 0-400 pixels to 0-180 degrees
                return Math.Round((pixel / 400.0) * 180, 0);
            }
            else if (pixel >= 401 && pixel <= 800)
            {
                // Map 401-800 pixels to 0 to -180 degrees
                return Math.Round(-180 + ((pixel - 401) / 400.0) * 180, 0);
            }
#if !DEBUG            
            {
            throw new ArgumentOutOfRangeException("Pixel value is out of range.");
            }  
#endif
            return pixel;
        }

        /// <summary>
        /// Block the worker thread from execution.
        /// </summary>
        public void SuspendWorkerTh()
        {
            _thControl.Reset();
        }

        /// <summary>
        /// Resume from a previously block signal.
        /// </summary>
        public void ResumeWorkerTh()
        {
            _thControl.Set();
        }

        /// <summary>
        /// Add raw values to a temporary collection.
        /// </summary>
        public void EnqueueRawValues(IEnumerable<byte> values)
        {
            if (values.Any())
            { _rawValueCollection.Add(values); }
        }

        /// <summary>
        /// Prepare raw values for further processing and clear the buffer.
        /// Averaging torque and location to meet the configured sampling frequency, add the periodnumber and a Timestamp. 
        /// </summary>
        /// <param name="values"></param>
        public bool PreparePeriodValues()
        {
            SuspendWorkerTh();
            var values = new MeasurementValues()
            {
                Timestamp = Math.Round((DateTime.Now - CurrentPeriod.StartTime).TotalSeconds, 0),
                PeriodNumber = CurrentPeriod.Number,
                Torque = _rawtorque.Average(),
                Location = (int)_rawpixel.Average()
            };
            MValuesPrepared?.Invoke(this, new MeasurementEventArgs(values));
            _rawtorque.Clear();
            _rawpixel.Clear();
            ResumeWorkerTh();
            return values.Timestamp >= CurrentPeriod.Duration;
        }
        #endregion
    }
}

