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
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;

namespace UR_MTrack
{
    /// <summary>
    /// Handle Mesurement Data 
    /// </summary>
    public class DataHandler
    {
        ConcurrentBag<IEnumerable<byte>> _rawValueCollection;
        List<double> _rawtorque;
        List<double> _rawpixel;
        Thread _dataTh;

        public event EventHandler<DataHandlerEventArgs> RawValuesConverted;

        public DataHandler()
        {
            _rawValueCollection = new ConcurrentBag<IEnumerable<byte>>();
            _rawtorque = new List<double>();
            _rawpixel = new List<double>();
            InitThread();
        }





        #region Methods

        void InitThread()
        {
            _dataTh = new Thread(RawDataWorker);
            _dataTh.IsBackground = true;
            _dataTh.Name = "Data Handler Thread";
            _dataTh.Start();
        }


        void RawDataWorker()
        {
            while (_dataTh.IsAlive)
            {
                if (_rawValueCollection.TryTake(out var values))
                {
                    _rawtorque.Add(Convert.ToDouble(((values.ElementAt(0) << 8) | values.ElementAt(1)) * 244.14 * Math.Pow(10, -6)));
                    _rawpixel.Add(PixelToDegree((values.ElementAt(2) << 8) | values.ElementAt(3)));
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
                return (pixel / 400.0) * 180;
            }
            else if (pixel >= 401 && pixel <= 800)
            {
                // Map 401-800 pixels to 0 to -180 degrees
                return -180 + ((pixel - 401) / 400.0) * 180;
            }
#if !DEBUG            
            {
            throw new ArgumentOutOfRangeException("Pixel value is out of range.");
            }  
#endif
            return pixel;
        }

        /// <summary>
        /// 
        /// </summary>
        public void AddMValues(IEnumerable<byte> values)
        {
            if (values.Any())
            { _rawValueCollection.Add(values); }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="values"></param>
        public MeasurementValues GetMValues()
        {
            var values = new MeasurementValues()
            {
                Torque = _rawtorque.Average(),
                Location = (int)_rawpixel.Average()
            };

            _rawtorque.Clear();
            _rawpixel.Clear();
            return values;
        }

        #endregion



    }
}
