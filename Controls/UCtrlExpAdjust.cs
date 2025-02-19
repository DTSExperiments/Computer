using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Extensions;

namespace UR_MTrack
{
    public partial class UCtrlExpAdjust : UserControl
    {
        bool _expanded = true;

        public event EventHandler<int> LaserSwitch;
        public event EventHandler<PatternEventArgs> SetPattern;
        public event EventHandler<RotateEventArgs> Rotate;
        public event EventHandler<string> SerialConnect;
        public event EventHandler AdjustmentFinished;

        public UCtrlExpAdjust()
        {
            InitializeComponent();
            BindControls();
            AutoSize = true;
            Dock = DockStyle.Left;
            btnLaser.BackColor = Color.FromArgb(80, Color.LightSalmon); 
            //ToggleExCoState();
        }

        
        public bool ConnectBtnState
        {
            get { return btnConnect.Checked; }
            set
            {
                if (value)
                { btnConnect.BackColor = Color.FromArgb(80, Color.GreenYellow); btnConnect.Text = "Connected"; }
                else 
                { btnConnect.BackColor = Color.FromArgb(80, Color.LightSalmon); btnConnect.Text = "Disconnected";}
            }
        }

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
            SerialConnect?.Invoke(this, cmbSerialPort.SelectedItem.ToString());
        }

        private void btnSetPattern_Click(object sender, EventArgs e)
        {
            SetPattern?.Invoke(this, new PatternEventArgs(cmbPattern.SelectedItem.ToEnum<DisplayPattern>()
                                                         , cmbColorPattern.SelectedItem.ToEnum<ColorPattern>()));
        }

        private void btnRotate_Click(object sender, EventArgs e)
        {
            Rotate?.Invoke(this, new RotateEventArgs(cmbRotation.SelectedItem.ToEnum<RotationMode>(), (int)nUDRotation.Value));
        }

        private void btnLaser_Click(object sender, EventArgs e)
        {
            if ((sender as CurveButton).Text.Equals("Off"))
            {
                btnLaser.Text = "On";
                btnLaser.BackColor = Color.FromArgb(20, Color.GreenYellow);
                LaserSwitch?.Invoke(this, (int)nUDLaser.Value);
            }
            else
            {
                btnLaser.Text = "Off";
                btnLaser.BackColor = Color.FromArgb(20, Color.LightSalmon);
                LaserSwitch?.Invoke(this, 0);
            }
        }


        private void btnAccept_Click(object sender, EventArgs e)
        {
            AdjustmentFinished?.Invoke(this, EventArgs.Empty);
            ToggleExCoState();
        }

        private void ExCo_Click(object sender, EventArgs e)
        {
            ToggleExCoState();
        }


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

        void ToggleExCoState()
        {
            if (_expanded) { btnExCo.Text = ">"; tblControls.Visible = false; }
            else { btnExCo.Text = "<"; tblControls.Visible = true; }
            _expanded = !_expanded;
        }

        private void cmbColorPattern_DropDownClosed(object sender, EventArgs e)
        {
            //cmbColorPattern.ForeColor=Color.FromArgb(150, Color.FromName(cmbColorPattern.SelectedText));    
        }

        
    }
}
