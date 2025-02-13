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
        ZedGraphControl _adValueszgc;
        ZedGraphControl _histogramzgc;
        PointPairList _posvalues;
        PointPairList _torquevalues;
        PointPair _punisher;
        ExperimentSettings _expsettings;
                

        public DataHandler(ref ExperimentSettings settings)
        {
            _expsettings = settings;
            _dataCollection = new ConcurrentBag<IEnumerable<byte>>();    
            _histogramzgc = new ZedGraphControl(); 
            _adValueszgc = new ZedGraphControl();
            _posvalues= new PointPairList(); 
            _torquevalues= new PointPairList();
            InitializeViews();
            InitThread();
        }

        #region Properties
        public ZedGraphControl ADValuesZGC { get { return _adValueszgc; } }
        public ZedGraphControl Histogram { get { return _histogramzgc; } }
        public DateTime StartTime { get; set; }

        #endregion
        
        #region Methods
        void InitializeViews()
        {
            _adValueszgc.Dock = DockStyle.Fill;
            _adValueszgc.BorderStyle = BorderStyle.None;
            _histogramzgc.Dock = DockStyle.Fill;
            _histogramzgc.BorderStyle = BorderStyle.None;
            SetupValuesZGC();
            SetupHistoZGC();
#if DEBUG
Democurves();
#endif
        }

        void SetupValuesZGC()
        {
            _adValueszgc.IsEnableWheelZoom = false;
            
            var _graphPane = _adValueszgc.GraphPane;
            #region chart
            _graphPane.Title.Text = " MelaTrack Data Visualizer";
            _graphPane.Title.FontSpec=_graphPane.XAxis.Title.FontSpec = new FontSpec("Segoe UI", 20, Color.FromArgb(180,75,75,75), true, false, false);
            _graphPane.Title.FontSpec.Border.IsVisible = false;
            _graphPane.TitleGap = 1;
            _graphPane.Legend.IsVisible = false;
            _graphPane.Border.Color = Color.White;
            
        

            _graphPane.XAxis.Type = AxisType.Linear;
            _graphPane.XAxis.Title.Text = "Time [ms]";
            _graphPane.XAxis.Scale.FontSpec = new FontSpec("Segoe UI Semilight", 10, Color.FromArgb(75,75,75), false, false, false) ;
            _graphPane.XAxis.Scale.FontSpec.Border.IsVisible = false;
            _graphPane.XAxis.Title.FontSpec = new FontSpec("Segoe UI Semilight", 12, Color.FromArgb(75,75,75), false, false, false);
            _graphPane.XAxis.Title.FontSpec.Border.IsVisible = false;
            _graphPane.XAxis.Scale.Min = 0;
            _graphPane.XAxis.Scale.Max = 1010;

            _graphPane.YAxis.IsVisible = true;
            _graphPane.YAxis.Type = AxisType.Linear;
            _graphPane.YAxis.Title.Text = "arena position";
            _graphPane.YAxis.Scale.FontSpec = new FontSpec("Segoe UI Semilight", 10, Color.Red, false, false, false);
            _graphPane.YAxis.Scale.FontSpec.Border.IsVisible = false;
            _graphPane.YAxis.Title.FontSpec = new FontSpec("Segoe UI Semilight", 12, Color.Red, false, false, false);
            _graphPane.YAxis.Title.FontSpec.Border.IsVisible = false;
            _graphPane.YAxis.Scale.FontSpec.Angle = 90;
            _graphPane.YAxis.Title.FontSpec.Angle = 180;
            _graphPane.YAxis.Scale.Min = -180;
            _graphPane.YAxis.Scale.Max = 180;
            _graphPane.YAxis.MajorTic.Size = 1.0f;
            _graphPane.YAxis.MajorGrid.IsVisible = true;
            _graphPane.YAxis.MajorGrid.Color = Color.FromArgb(150,Color.Red);

            _graphPane.Y2Axis.IsVisible = true;
            _graphPane.Y2Axis.Type = AxisType.Linear;
            _graphPane.Y2Axis.Title.Text = "torque";
            _graphPane.Y2Axis.Scale.FontSpec = new FontSpec("Segoe UI Semilight", 10, Color.Blue, false, false, false);
            _graphPane.Y2Axis.Scale.FontSpec.Border.IsVisible = false;
            _graphPane.Y2Axis.Title.FontSpec = new FontSpec("Segoe UI Semilight", 12, Color.Blue, false, false, false);
            _graphPane.Y2Axis.Title.FontSpec.Border.IsVisible = false;
            _graphPane.Y2Axis.Scale.FontSpec.Angle =270;
            _graphPane.Y2Axis.Title.FontSpec.Angle = 180;
            _graphPane.Y2Axis.Scale.Min = -0.4d;//-0.4d;
            _graphPane.Y2Axis.Scale.Max = 0.4d;// 0.4d;
            _graphPane.Y2Axis.MajorTic.Size = 1.0f;
            _graphPane.YAxis.MajorGrid.IsVisible = true;
            _graphPane.YAxis.MajorGrid.Color = Color.FromArgb(150, Color.Blue);
            #endregion

#endregion
            UpdateViews();
        }
        void SetupHistoZGC()
        {
            var _graphPane = _histogramzgc.GraphPane;
            #region chart
            _graphPane.Title.Text = "Live Histogram";
            _graphPane.Title.FontSpec = _graphPane.XAxis.Title.FontSpec = new FontSpec("Segoe UI", 15, Color.FromArgb(180, 75, 75, 75), true, false, false);
            _graphPane.Title.FontSpec.Border.IsVisible = false;
            //_graphPane.TitleGap = 1;
            _graphPane.Legend.IsVisible = false;
            _graphPane.Border.Color = Color.White;
            _graphPane.Fill = new Fill(Color.White);
            _graphPane.Chart.Fill = new Fill(Color.White);
            
            _graphPane.YAxis.Scale.Max=0.5d;
            _graphPane.YAxis.Scale.Min = 0;
            _graphPane.XAxis.Scale.Min = 0;
            _graphPane.XAxis.Scale.Max = 1.5;
            //_graphPane.YAxis.Scale.Max = 0.2;
        }

        void UpdateViews()
        {
            _adValueszgc.AxisChange();
            _adValueszgc.Invalidate();
            _histogramzgc.AxisChange();
            _histogramzgc.Invalidate();
        }

        void Democurves()
        {
            _posvalues = FillPPList_DemoValues(-12000, 12000);
            // 
            var _adcurve =_adValueszgc.GraphPane.AddCurve("Fly Position", _posvalues, Color.IndianRed, SymbolType.None);
            _adcurve.Line.IsAntiAlias = true;
            _adcurve.Line.IsOptimizedDraw = true;
            


            _torquevalues = FillPPList_DemoValues(100, 150);
            var _torqueCurve = _adValueszgc.GraphPane.AddCurve("Torque", _torquevalues, Color.Blue, SymbolType.None);
            _torqueCurve.Line.IsAntiAlias = true;
            _torqueCurve.Line.IsOptimizedDraw = true;
            _torqueCurve.IsY2Axis = true;

            CalculateHistogram(_torquevalues);
            UpdateViews();
        }

        PointPairList FillPPList_DemoValues(int min,int max)
        {
            var list=new PointPairList();
            var seed = (int)(DateTime.Now.Ticks / 13);
            var rand = new Random(seed);
            for(int i=0;i<100;i++)
            {
                //list.Add((double)i, ((double)rand.Next(min, max))/1000);
                list.Add((double)i, Math.Round((Math.Sin(i)),2));
            }
            return list;
        }


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
                if(_dataCollection.TryTake(out var values))
                {
                    var valtorque = Convert.ToDouble(((values.ElementAt(0) << 8) | values.ElementAt(1)) * 244.14 * Math.Pow(10, -6));
                    var valpix = (values.ElementAt(2) << 8) | values.ElementAt(3);
                    var timestamp=DateTime.Now.Subtract(StartTime).TotalSeconds;
                    var mstring = string.Format("{0}\t{1}\t{2}\t{3}", timestamp, valpix, valtorque,0);
                   // new FileFactory().ChangeXMLValue(_expsettings.Filepath, "csv_data", mstring);
                    _torquevalues.Add(timestamp,valtorque); 
                    _posvalues.Add(timestamp,PixelToDegree((double)valpix));
                    UpdateViews();
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
            else
            {

            throw new ArgumentOutOfRangeException("Pixel value is out of range.");
            }
#endif
            return pixel;
        }

        void CalculateHistogram(PointPairList histList)
        {
            for (int i = 0; i < histList.Count - 1; i++)
            {
                BoxObj box = new BoxObj(histList[i].X, histList[i].Y, histList[i + 1].X - histList[i].X, histList[i].Y,
                                        Color.Aquamarine,Color.LightCyan,Color.Magenta);
                box.IsClippedToChartRect = true;
                _histogramzgc.GraphPane.GraphObjList.Add(box);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void AddMValues(IEnumerable<byte> values)
        {
            if(values.Count()>0) 
            { _dataCollection.Add(values); }
        }

        public void ResetChart()
        {
            _torquevalues.Clear();
            _posvalues.Clear();
            _adValueszgc.GraphPane.CurveList.Clear();
            _adValueszgc.Refresh();
            
        }

#endregion



    }
}
