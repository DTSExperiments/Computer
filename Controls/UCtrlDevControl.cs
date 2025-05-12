using Extensions;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace UR_MTrack
{
    public partial class UCtrlDevControl : UserControl
    {
        bool _expanded = true;

        public UCtrlDevControl()
        {
            InitializeComponent();
            BindControls();
            InitializeControls();
        }

        #region Properties
        public bool ConnectBtnState
        {
            get { return btnConnect.Checked; }
            set
            {
                if (value)
                { btnConnect.BackColor = Color.FromArgb(80, Color.GreenYellow); btnConnect.Text = "Connected"; }
                else
                { btnConnect.BackColor = Color.FromArgb(80, Color.LightSalmon); btnConnect.Text = "Disconnected"; }
            }
        }


        #endregion

        #region Methods

        void BindControls()
        {
            cmbSerialPort.Items.Clear();
            cmbSerialPort.DataSource = new SerialInterface().PortNames;
            cmbPattern.DataSource = Extension.BindEnumDescription(typeof(DisplayPattern));
            cmbPattern.DisplayMember = "Description";
            cmbPattern.ValueMember = "value";
            cmbColorPattern.DataSource = Extension.BindEnumDescription(typeof(ColorPattern));
            cmbColorPattern.DisplayMember = "Description";
            cmbColorPattern.ValueMember = "value";
            cmbRotation.DataSource = Extension.BindEnumDescription(typeof(RotationMode));
            cmbRotation.DisplayMember = "Description";
            cmbRotation.ValueMember = "value";
        }

        void InitializeControls()
        {
            if (cmbSerialPort.Items.Contains(Program.Settings.COMPort)){
                cmbSerialPort.SelectedItem = Program.Settings.COMPort;
            }
            if(cmbColorPattern.Items.Contains(Program.Settings.ColorPattern))
            {
                cmbColorPattern.SelectedItem = Program.Settings.ColorPattern;
            }
            if (cmbPattern.Items.Contains(Program.Settings.DisplayPattern))
            {
                cmbPattern.SelectedItem = Program.Settings.DisplayPattern;
            }
            if (cmbRotation.Items.Contains(Program.Settings.RotationMode))
            {
                cmbRotation.SelectedItem = Program.Settings.RotationMode;
            }
            tBarLaser.Value=Program.Settings.LaserPWMValue;
            tBarRotation.Value = Program.Settings.Velocity;
        }

        void ToggleExCoState()
        {
            if (_expanded) { btnExCo.Text = ">"; tblControls.Visible = false; }
            else { btnExCo.Text = "<"; tblControls.Visible = true; }
            _expanded = !_expanded;
        }

        #endregion


        private void nUDLaser_ValueChanged(object sender, EventArgs e)
        {
            tBarLaser.Value = (int)nUDLaser.Value;
        }

        private void tBarLaser_ValueChanged(object sender, EventArgs e)
        {
            nUDLaser.Value = tBarLaser.Value;
        }

        private void tBarRotation_ValueChanged(object sender, EventArgs e)
        {
            nUDRotation.Value = tBarRotation.Value;
        }

        private void numericUpDownRotation_ValueChanged(object sender, EventArgs e)
        {
            tBarRotation.Value = (int)nUDRotation.Value;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            new Signals().OnSerialConnect(this, new SerialPortSettings() 
                                                { Portname = cmbSerialPort.SelectedItem.ToString() });
        }

        private void btnLaser_Click(object sender, EventArgs e)
        {
            if ((sender as CurveButton).Text.Equals("Off"))
            {
                btnLaser.Text = "On";
                btnLaser.BackColor = Color.FromArgb(20, Color.GreenYellow);
                new Signals().OnLaserSwitch(this, (int)nUDLaser.Value);
            }
            else
            {
                btnLaser.Text = "Off";
                btnLaser.BackColor = Color.FromArgb(20, Color.LightSalmon);
                new Signals().OnLaserSwitch(this, 0);
            }
        }


        private void ExCo_Click(object sender, EventArgs e)
        {
            ToggleExCoState();
        }

        private void cmbColorPattern_DropDownClosed(object sender, EventArgs e)
        {
            //cmbColorPattern.BackColor=Color.FromArgb(150, Color.FromName(cmbColorPattern.SelectedText));    
            //cmbColorPattern.=Color.FromName(cmbColorPattern.SelectedText);    
            //cmbColorPattern.Invalidate();
        }

        private void cmbPattern_SelectedIndexChanged(object sender, EventArgs e)
        {
            new Signals().OnSetPattern(this, new PatternEventArgs(cmbPattern.SelectedItem.ToEnum<DisplayPattern>()
                                             , cmbColorPattern.SelectedItem.ToEnum<ColorPattern>()));
        }

        private void cmbColorPattern_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cmbColorPattern.BackColor=Color.FromArgb(150, Color.FromName(cmbColorPattern.SelectedText));    
            new Signals().OnSetPattern(this, new PatternEventArgs(cmbPattern.SelectedItem.ToEnum<DisplayPattern>()
                                 , cmbColorPattern.SelectedItem.ToEnum<ColorPattern>()));
        }

        private void cmbRotation_SelectedIndexChanged(object sender, EventArgs e)
        {
            new Signals().OnRotate(this, new RotateEventArgs(cmbRotation.SelectedItem.ToEnum<RotationMode>(), (int)nUDRotation.Value));
        }
    }
}
