using System;
using System.Windows.Forms;
using Extensions;

namespace UR_MTrack
{
    public partial class UCtrlPeriod : UserControl
    {
        PeriodValues _periodValues;

        public event EventHandler<PeriodChangedEventArgs> PeriodChanged;

        public UCtrlPeriod()
        {
            InitializeComponent();
        }

        public UCtrlPeriod(int number)
        {
            InitializeComponent();
            _periodValues = new PeriodValues(number);  
            BindControls();

        }

        public UCtrlPeriod(PeriodValues _pvalues)
        {
            InitializeComponent();
            _periodValues = _pvalues;   
            BindControls();
            UpdateControls(_periodValues);
        }

        #region Properties
        public PeriodValues Period { get { return _periodValues; } }
        #endregion


        #region Methods
        void BindControls()
        {
            SuspendLayout();
            lblHeaderCounter.Text = _periodValues.Number.ToString();
            cmbType.DataSource = Extension.BindEnumDescription(typeof(PeriodType));
            cmbType.DisplayMember = "Description";
            cmbType.ValueMember = "value";
            cmbPattern.DataSource = Extension.BindEnumDescription(typeof(PeriodPattern));
            cmbPattern.DisplayMember = "Description";
            cmbPattern.ValueMember = "value";
            cmbContingency.DataSource = Extension.BindEnumDescription(typeof(PeriodContingency));
            cmbContingency.DisplayMember = "Description";
            cmbContingency.ValueMember = "value";
            ResumeLayout();

        }

        void CollectValues()
        {
            _periodValues.Pattern = cmbPattern.SelectedItem.ToEnum<PeriodPattern>();
            _periodValues.Type = cmbType.SelectedItem.ToEnum<PeriodType>();
            _periodValues.Contingency = cmbPattern.SelectedItem.ToEnum<PeriodContingency>();
            _periodValues.Duration=tbDuration.GetIntValue(); 
            _periodValues.Outcome=tbOutcome.GetIntValue();
            _periodValues.CoupCoeff=tbCouplingCoeff.GetDoubleValue();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_values"></param>
        public void UpdateControls(PeriodValues _values)
        {
            cmbType.SelectedValue = _values.Type;
            cmbPattern.SelectedValue=_values.Pattern;
            cmbContingency.SelectedValue=_values.Contingency;
            tbDuration.Text=_values.Duration.ToString();
            tbOutcome.Text=_values.Outcome.ToString();
            tbCouplingCoeff.Text=_values.CoupCoeff.ToString();      
        }


        #endregion

        private void cmb_DropDownClosed(object sender, EventArgs e)
        {
            CollectValues();
            PeriodChanged?.Invoke(this, new PeriodChangedEventArgs(_periodValues));
        }

        private void tb_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter||e.KeyCode == Keys.Return) 
            {
                CollectValues();
                PeriodChanged?.Invoke(this, new PeriodChangedEventArgs(_periodValues));
            }
        }
    }
}
