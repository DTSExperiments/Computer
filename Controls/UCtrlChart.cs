using System.Drawing;
using System.Windows.Forms;
using ZedGraph;

namespace UR_MTrack
{
    public partial class UCtrlChart : UserControl
    {
        PointPairList _posvalues;
        PointPairList _torquevalues;
        PointPair _punisher;

        public UCtrlChart()
        {
            InitializeComponent();
            _posvalues = new PointPairList();
            _torquevalues = new PointPairList();
            _punisher = new PointPair();
            InitializeViews();
            HideHistogram();
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



        #region chart
        void SetupValuesZGC()
        {
            _valueszgc.IsEnableWheelZoom = false;

            var _graphPane = _valueszgc.GraphPane;

            _graphPane.Title.Text = " MelaTrack Data Visualizer";
            _graphPane.Title.FontSpec = _graphPane.XAxis.Title.FontSpec = new FontSpec("Segoe UI", 20, Color.FromArgb(180, 75, 75, 75), true, false, false);
            _graphPane.Title.FontSpec.Border.IsVisible = false;
            _graphPane.TitleGap = 1;
            _graphPane.Legend.IsVisible = false;
            _graphPane.Border.Color = Color.White;



            _graphPane.XAxis.Type = AxisType.Linear;
            _graphPane.XAxis.Title.Text = "Time [s]";
            _graphPane.XAxis.Scale.FontSpec = new FontSpec("Segoe UI Semilight", 10, Color.FromArgb(75, 75, 75), false, false, false);
            _graphPane.XAxis.Scale.FontSpec.Border.IsVisible = false;
            _graphPane.XAxis.Title.FontSpec = new FontSpec("Segoe UI Semilight", 12, Color.FromArgb(75, 75, 75), false, false, false);
            _graphPane.XAxis.Title.FontSpec.Border.IsVisible = false;
            _graphPane.XAxis.Scale.Min = 0;
            _graphPane.XAxis.Scale.Max = 100;

            _graphPane.YAxis.IsVisible = true;
            _graphPane.YAxis.Type = AxisType.Linear;
            _graphPane.YAxis.Title.Text = "arena position";
            _graphPane.YAxis.Scale.FontSpec = new FontSpec("Segoe UI Semilight", 10, Color.Red, false, false, false);
            _graphPane.YAxis.Scale.FontSpec.Border.IsVisible = false;
            _graphPane.YAxis.Title.FontSpec = new FontSpec("Segoe UI Semilight", 12, Color.Red, false, false, false);
            _graphPane.YAxis.Title.FontSpec.Border.IsVisible = false;
            _graphPane.YAxis.Scale.FontSpec.Angle = 90;
            _graphPane.YAxis.Title.FontSpec.Angle = 180;
            _graphPane.YAxis.Scale.Min = -1800;
            _graphPane.YAxis.Scale.Max = 1800;
            _graphPane.YAxis.Scale.MagAuto = false;


            _graphPane.YAxis.MinorGrid.IsVisible = false;   
            _graphPane.YAxis.MinorTic.IsAllTics = false;
            _graphPane.YAxis.MajorTic.Size = 1.0f;
            _graphPane.YAxis.MajorGrid.IsVisible = true;
            _graphPane.YAxis.MajorGrid.Color = Color.FromArgb(150, Color.Red);
            _graphPane.AddCurve("Positon", _posvalues, Color.Red, SymbolType.None);
            
            _graphPane.Y2Axis.IsVisible = true;
            _graphPane.Y2Axis.Type = AxisType.Linear;
            _graphPane.Y2Axis.Title.Text = "torque";
            _graphPane.Y2Axis.Scale.FontSpec = new FontSpec("Segoe UI Semilight", 10, Color.Blue, false, false, false);
            _graphPane.Y2Axis.Scale.FontSpec.Border.IsVisible = false;
            _graphPane.Y2Axis.Title.FontSpec = new FontSpec("Segoe UI Semilight", 12, Color.Blue, false, false, false);
            _graphPane.Y2Axis.Title.FontSpec.Border.IsVisible = false;
            _graphPane.Y2Axis.Scale.FontSpec.Angle = 270;
            _graphPane.Y2Axis.Title.FontSpec.Angle = 180;
            _graphPane.Y2Axis.Scale.Min = -0.4d;
            _graphPane.Y2Axis.Scale.Max = 0.4d;
            _graphPane.Y2Axis.Scale.MagAuto = false;


            _graphPane.Y2Axis.MinorGrid.IsVisible = false; 
            _graphPane.Y2Axis.MinorTic.IsAllTics = false;
            _graphPane.Y2Axis.MajorTic.Size = 1.0f;
            _graphPane.Y2Axis.MajorGrid.IsVisible = true;
            _graphPane.Y2Axis.MajorGrid.Color = Color.FromArgb(150, Color.Blue);
            _graphPane.AddCurve("Torque", _torquevalues, Color.Blue, SymbolType.None).IsY2Axis = true;

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

        void UpdateViews()
        {
            _valueszgc.AxisChange();
            _valueszgc.Invalidate();
            _histozgc.AxisChange();
            _histozgc.Invalidate();
        }

        /// <summary>
        /// Show the raw not yet averaged values
        /// </summary>
        /// <param name="timestamp"></param>
        /// <param name="torque"></param>
        /// <param name="position"></param>
        public void AddValues(double timestamp, double torque, double position)
        {
            _torquevalues.Add(timestamp, torque);
            _posvalues.Add(timestamp, position);
            UpdateViews();
        }

        public void AddValues(MeasurementValues mVal)
        {
            _torquevalues.Add(mVal.Timestamp, mVal.Torque);
            _posvalues.Add(mVal.Timestamp, mVal.Location);
        }

        public void ResetChart()
        {
            _torquevalues.Clear();
            _posvalues.Clear();
            //_valueszgc.GraphPane.CurveList.Clear();
            _valueszgc.Refresh();
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

    }
}
#endregion