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
        ConcurrentBag<IEnumerable<byte>> _dataCollection;
        Thread _dataTh;
        
        ExperimentSettings _expsettings;


        public DataHandler(ref ExperimentSettings settings)
        {
            _expsettings = settings;
            _dataCollection = new ConcurrentBag<IEnumerable<byte>>();
            InitThread();
        }

        #region Properties
        public DateTime StartTime { get; set; }

        #endregion

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
                //Democurves();
                if (_dataCollection.TryTake(out var values))
                {
                    var valtorque = Convert.ToDouble(((values.ElementAt(0) << 8) | values.ElementAt(1)) * 244.14 * Math.Pow(10, -6));
                    var valpix = (values.ElementAt(2) << 8) | values.ElementAt(3);
                    var timestamp = DateTime.Now.Subtract(StartTime).TotalSeconds;
                    var mstring = string.Format("{0}\t{1}\t{2}\t{3}", timestamp, valpix, valtorque, 0);                    
                }
                Thread.Sleep(100);
            }
        }


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
            if (values.Count() > 0)
            { _dataCollection.Add(values); }
        }

       

        #endregion



    }
}
