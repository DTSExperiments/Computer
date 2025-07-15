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
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
namespace UR_MTrack
{
    /// <summary>
    /// Handle Mesurement Data 
    /// </summary>
    public class DataHandler
    {
      
        Thread _dataHandlerTh;
        EventWaitHandle _thControl;
        List<double> _rawtorque;
        List<double> _rawpixel;


        public DataHandler()
        {
            _rawtorque = new List<double>();
            _rawpixel = new List<double>();
            StartTime = DateTime.Now;
            Signals.DataReceived += Signals_DataReceived;
        }

        private void Signals_DataReceived(object sender, DataReceivedEventArgs e)
        {
            //EnqueueRawValues(e.Bytes);
            convertList(e.Bytes);
        }


        private void convertList(IEnumerable<byte> bCollection)
        {
            short nextValueAD = 0;
            ushort nextValuePIX = 0;
            byte[] byteArray = new byte[4];
            var list = bCollection.ToList();

            while (list.Count >= 5)
            {
                try
                {
                    if (Convert.ToByte(list[4]) != 0x0A)
                    {
                        throw new Exception("LF not found");
                    }

                    byteArray = list.GetRange(0, 4).ToArray();
                    list.RemoveRange(0, 5);
                    BitArray nextValueADBit = new BitArray(byteArray);
                    if (nextValueADBit[11] == true)
                    {
                        nextValueADBit = nextValueADBit.Or(new BitArray(BitConverter.GetBytes(0x0000F000)));
                    }
                    nextValueADBit.CopyTo(byteArray, 0);
                    nextValueAD = BitConverter.ToInt16(byteArray, 0);
                    nextValuePIX = BitConverter.ToUInt16(byteArray, 2);



                    //Calculation AD-Values
                    var t = Convert.ToDouble(nextValueAD * 244.14 * Math.Pow(10, -6));
                    var p = Convert.ToDouble(nextValuePIX);

                    new Signals().OnChartValuesPrepared(this, new DataHandlerEventArgs((DateTime.Now - StartTime).TotalSeconds, t, p));

                }
                catch (Exception ex) { }
            }
        }


        #region Properties

        public PeriodValues CurrentPeriod { get; set; }

        public DateTime StartTime { get; set; }

        #endregion

        #region Methods

       
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
        /// Prepare raw values for further processing and clear the buffer.
        /// Averaging torque and location to meet the configured sampling frequency, add the periodnumber and a Timestamp. 
        /// </summary>
        /// <param name="values"></param>
        public bool PreparePeriodValues()
        {
            SuspendWorkerTh();
            var values = new MeasurementValues()
            {
                Timestamp = Math.Round((double)(DateTime.Now - CurrentPeriod.StartTime).Seconds, 2),
                PeriodNumber = CurrentPeriod.Number,

            };
            if (_rawtorque.Count > 0 && _rawpixel.Count > 0)
            {
                values.Torque = _rawtorque.Average();
                values.Location = (int)_rawpixel.Average();

            }

            _rawtorque.Clear();
            _rawpixel.Clear();

            new Signals().OnMValuesPrepared(this, new MeasurementEventArgs(values));
            ResumeWorkerTh();
            return values.Timestamp >= CurrentPeriod.Duration;
        }
        #endregion
    }
}

