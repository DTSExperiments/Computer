using System;
using System.Drawing;
using System.Windows.Forms;
using ZedGraph;

namespace UR_MTrack
{
    public partial class UCtrlChart : UserControl
    {
        RollingPointPairList _pvalLive;
        RollingPointPairList _tvalLive;
        PointPairList _posvalues;
        PointPairList _torquevalues;
        PointPair _punisher;
        ChartDataMode _currentMode;

        public UCtrlChart()
        {
            InitializeComponent();            
            InitializeViews();
            HookUpEvents();
            HideHistogram();
            SwitchDisplayMode(ChartDataMode.Live);
        }


        #region Properties

        public ZedGraphControl ADValuesZGC { get { return _valueszgc; } }
        public ZedGraphControl Histogram { get { return _histozgc; } }

        #endregion


        #region Methods
        void CalculateHistogram(PointPairList histList)
        {
            for (int i = 0; i < histList.Count - 1; i++)
            {
                BoxObj box = new BoxObj(histList[i].X, histList[i].Y, histList[i + 1].X - histList[i].X, histList[i].Y,
                                        Color.Aquamarine, Color.LightCyan, Color.Magenta);
                box.IsClippedToChartRect = true;
                _histozgc.GraphPane.GraphObjList.Add(box);
            }
        }


        void InitializeViews()
        {
            _valueszgc.Dock = DockStyle.Fill;
            _valueszgc.BorderStyle = BorderStyle.None;
            _histozgc.Dock = DockStyle.Fill;
            _histozgc.BorderStyle = BorderStyle.None;
            SetupValuesZGC();
            SetupHistoZGC();
        }

        void HookUpEvents()
        {
            Signals.MValuesPrepared += signal_MValuesReceived;
            Signals.LaserSwitch += Signals_LaserSwitch;
        }

        private void Signals_LaserSwitch(object sender, int e)
        {
            if (e != 0)
            {
                _valueszgc.GraphPane.Chart.Fill.Color = Color.FromArgb(100, Color.Red);
            }
            else { _valueszgc.GraphPane.Chart.Fill.Color = Color.White; }
        }

        private void signal_MValuesReceived(object sender, MeasurementEventArgs e)
        {
            AddValues(e.Values);
        }

        #region chart
        void SetupValuesZGC()
        {
            _valueszgc.IsEnableWheelZoom = true;

            var _graphPane = _valueszgc.GraphPane;

            _graphPane.Border.Width = 0;
            _graphPane.Chart.Border.Width = 0;

            _graphPane.Title.Text = "MelaTrack Data Visualizer";
            _graphPane.Title.FontSpec = _graphPane.XAxis.Title.FontSpec = new FontSpec("Segoe UI", 20, Color.FromArgb(180, 75, 75, 75), true, false, false);
            _graphPane.Title.FontSpec.Border.IsVisible = false;
            
            _graphPane.TitleGap = 1;
            _graphPane.Legend.IsVisible = false;
            _graphPane.Border.Width = 0;

            _graphPane.XAxis.Type = AxisType.Linear;
            _graphPane.XAxis.Title.Text = "Time [s]";
            _graphPane.XAxis.Scale.FontSpec = new FontSpec("Segoe UI Semilight", 8, Color.FromArgb(75, 75, 75), false, false, false);
            _graphPane.XAxis.Scale.FontSpec.Border.IsVisible = false;
            _graphPane.XAxis.Title.FontSpec = new FontSpec("Segoe UI Semilight", 12, Color.FromArgb(75, 75, 75), false, false, false);
            _graphPane.XAxis.Title.FontSpec.Border.IsVisible = false;
            _graphPane.XAxis.Scale.BaseTic = 0.5;

            _graphPane.XAxis.Scale.MaxAuto = true;
            _graphPane.XAxis.Scale.MinAuto = true;
            //_graphPane.XAxis.Scale.Max = 10;
            _graphPane.XAxis.Scale.MajorStep = 10;
            _graphPane.XAxis.Scale.MinorStep = 0.1;
            _graphPane.XAxis.MinorTic.IsAllTics = true;
            _graphPane.XAxis.MajorTic.IsOpposite = false;
            _graphPane.XAxis.MinorTic.IsOpposite = false;
            _graphPane.XAxis.MajorGrid.Color = Color.DarkGray; 
            _graphPane.XAxis.MajorGrid.PenWidth = 1f;
            _graphPane.XAxis.MajorGrid.DashOff = 1.5f;
            _graphPane.XAxis.MajorGrid.IsVisible = true;


            _graphPane.YAxis.IsVisible = true;
            _graphPane.YAxis.Type = AxisType.Linear;
            _graphPane.YAxis.Title.Text = "arena position";
            
            _graphPane.YAxis.Scale.FontSpec = new FontSpec("Segoe UI Semilight", 8, Color.Red, false, false, false);
            _graphPane.YAxis.Scale.FontSpec.Border.IsVisible = false;
            _graphPane.YAxis.Title.FontSpec = new FontSpec("Segoe UI Semilight", 12, Color.Red, false, false, false);
            _graphPane.YAxis.Title.FontSpec.Border.IsVisible = false;
            _graphPane.YAxis.Scale.FontSpec.Angle = 90;
            _graphPane.YAxis.Title.FontSpec.Angle = 180;
            _graphPane.YAxis.Scale.Min = -190;
            _graphPane.YAxis.Scale.Max = 190;
            _graphPane.YAxis.Scale.MajorStep = 90;
            _graphPane.YAxis.Scale.MinorStep = 45;
            _graphPane.YAxis.Scale.MagAuto = false;
            _graphPane.YAxis.MinorGrid.IsVisible = false;            
            _graphPane.YAxis.MajorGrid.IsVisible = true;
            _graphPane.YAxis.MajorGrid.Color = Color.Red; //Color.FromArgb(150, Color.Red);
            _graphPane.YAxis.MajorGrid.PenWidth = 0.5f;
            _graphPane.YAxis.MajorGrid.DashOff = 0.5f;
            _graphPane.YAxis.MajorTic.Size = 5.0f;
            _graphPane.YAxis.MajorTic.IsOpposite = false;
            _graphPane.YAxis.MinorTic.IsOpposite = false;
            _graphPane.YAxis.MinorTic.IsAllTics = false;


            _graphPane.Y2Axis.IsVisible = true;
            _graphPane.Y2Axis.Type = AxisType.Linear;
            _graphPane.Y2Axis.Title.Text = "torque";
            _graphPane.Y2Axis.Scale.FontSpec = new FontSpec("Segoe UI Semilight", 8, Color.Blue, false, false, false);
            _graphPane.Y2Axis.Scale.FontSpec.Border.IsVisible = false;
            _graphPane.Y2Axis.Title.FontSpec = new FontSpec("Segoe UI Semilight", 12, Color.Blue, false, false, false);
            _graphPane.Y2Axis.Title.FontSpec.Border.IsVisible = false;
            _graphPane.Y2Axis.Scale.FontSpec.Angle = 270;
            _graphPane.Y2Axis.Title.FontSpec.Angle = 180;
            _graphPane.Y2Axis.Scale.Min = -0.5d;
            _graphPane.Y2Axis.Scale.Max = 0.5d;
            _graphPane.Y2Axis.Scale.MajorStep = 0.25;
            _graphPane.Y2Axis.Scale.MinorStep = 0.1;
            _graphPane.Y2Axis.Scale.MagAuto = false;
            _graphPane.Y2Axis.MinorGrid.IsVisible = false;           
            _graphPane.Y2Axis.MajorGrid.IsVisible = true;
            _graphPane.Y2Axis.MajorGrid.DashOff = 1f;
            _graphPane.Y2Axis.MajorGrid.Color = Color.Blue; //Color.FromArgb(150, Color.Blue);
            _graphPane.Y2Axis.MajorGrid.PenWidth = 0.5f;
            _graphPane.Y2Axis.MajorTic.Size = 5.0f;
            _graphPane.Y2Axis.MajorTic.IsOpposite = false;
            _graphPane.Y2Axis.MinorTic.IsOpposite = false;
            _graphPane.Y2Axis.MinorTic.IsAllTics = false;            

            UpdateViews();
        }

        void SetupHistoZGC()
        {
            var _graphPane = _histozgc.GraphPane;
            _graphPane.Title.Text = "Live Histogram";
            _graphPane.Title.FontSpec = _graphPane.XAxis.Title.FontSpec = new FontSpec("Segoe UI", 15, Color.FromArgb(180, 75, 75, 75), true, false, false);
            _graphPane.Title.FontSpec.Border.IsVisible = false;

            _graphPane.Legend.IsVisible = false;
            _graphPane.Border.Color = Color.White;
            _graphPane.Fill = new Fill(Color.White);
            _graphPane.Chart.Fill = new Fill(Color.White);

            _graphPane.XAxis.Title.IsVisible = false;
            _graphPane.XAxis.IsVisible = false;
            _graphPane.XAxis.Scale.Min = 0;
            _graphPane.XAxis.Scale.Max = 1.5;

            _graphPane.YAxis.Title.IsVisible = false;
            _graphPane.YAxis.IsVisible = false;
            _graphPane.YAxis.Scale.Max = 0.5d;
            _graphPane.YAxis.Scale.Min = 0;

            _graphPane.Y2Axis.IsVisible = false;
            _graphPane.X2Axis.IsVisible = false;
        }

        void SwitchDisplayMode(ChartDataMode mode)
        {
            var _graphPane = _valueszgc.GraphPane;
            if (mode.Equals(ChartDataMode.Live))
            {                
                //_graphPane.Border.Color = Color.Gray;
                //_graphPane.Fill = new Fill(Color.DimGray);
                //_graphPane.Chart.Fill = new Fill(Color.FromArgb(255,50,50,50));
                _graphPane.Title.Text = "Oszilloscope Mode";

                _pvalLive = new RollingPointPairList(1000);
                _tvalLive = new RollingPointPairList(1000);
                var poscurve=_valueszgc.GraphPane.AddCurve("Positon", _pvalLive, Color.FromArgb(250,Color.Red),SymbolType.None);
                poscurve.Line.IsSmooth = true;
                poscurve.Line.IsAntiAlias = true;
                poscurve.Line.SmoothTension = 1;
                poscurve.Line.Width = 1.5f;
                
                
                poscurve=_valueszgc.GraphPane.AddCurve("Torque", _tvalLive, Color.FromArgb(250,Color.Blue), SymbolType.None);
                poscurve.IsY2Axis = true;
                poscurve.Line.IsSmooth = true;
                poscurve.Line.IsAntiAlias = true;
                poscurve.Line.SmoothTension = 1;
                poscurve.Line.Width = 1.5f;

            }
            else if (mode.Equals(ChartDataMode.Experiment))
            {
                _posvalues = new PointPairList();
                _torquevalues = new PointPairList();
                _punisher = new PointPair();
                _valueszgc.GraphPane.AddCurve("Positon", _posvalues, Color.Red, SymbolType.None);
                _valueszgc.GraphPane.AddCurve("Torque", _torquevalues, Color.Blue, SymbolType.None).IsY2Axis = true;
            }
            UpdateViews();
        }


        void UpdateViews()
        {
            _valueszgc.AxisChange();
            _valueszgc.Invalidate();
            _histozgc.AxisChange();
            _histozgc.Invalidate();
        }

        
        public void AddValues(MeasurementValues mVal)
        {
            if (_currentMode.Equals(ChartDataMode.Live))
            {
                _tvalLive.Add(mVal.Timestamp, mVal.Torque);
                _pvalLive.Add(mVal.Timestamp, mVal.Location);
            }
            else
            {
                _torquevalues.Add(mVal.Timestamp, mVal.Torque);
                _posvalues.Add(mVal.Timestamp, mVal.Location);
            }
            UpdateViews();
        }


        public void ResetChart()
        {
            _torquevalues.Clear();
            _posvalues.Clear();
            UpdateViews(); 
        }


        public void ShowHistogram()
        {
            tblHisto.Visible = true;
            flowHisto.Visible = true;
        }


        public void HideHistogram()
        {
            tblHisto.Visible = false;
            flowHisto.Visible = false;
        }
        #endregion

        private void _valueszgc_Load(object sender, EventArgs e)
        {

        }
    }
}
#endregion