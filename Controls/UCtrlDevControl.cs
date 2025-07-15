using Extensions;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace UR_MTrack
{
    public partial class UCtrlDevControl : UserControl
    {
        bool _expanded = true;
        bool initialized;
        public UCtrlDevControl()
        {
            InitializeComponent();
            if (!LicenseManager.UsageMode.Equals(LicenseUsageMode.Designtime))
            {
                BindControls();
                Initialize();

            }

        }

        #region SignalHandler
        private void Signals_DeviceStatusChanged(object sender, DeviceStatus e)
        {
            if (e.Equals(DeviceStatus.on))
            {
                btnLaser.Text = "On";
                btnLaser.BackColor = Color.FromArgb(200, Color.GreenYellow);
            }
            else if (e.Equals(DeviceStatus.off))
            {
                btnLaser.Text = "Off";
                btnLaser.BackColor = Color.FromArgb(200, Color.LightSalmon);
            }
        }

        private void Signals_ConnectionStatusChanged(object sender, DeviceStatus e)
        {
            if (e.Equals(DeviceStatus.connected))
            {
                btnConnect.BackColor = Color.FromArgb(80, Color.GreenYellow); btnConnect.Text = "Connected";
            }
            else if (e.Equals(DeviceStatus.disconnected))
            {
                btnConnect.BackColor = Color.FromArgb(80, Color.LightSalmon); btnConnect.Text = "Disconnected";
            }
        }


        #endregion


        #region Methods

        void BindControls()
        {
            cmbSerialPort.Items.Clear();
            cmbSerialPort.DataSource = new ComInterface().SerialPortNames;
            cmbPattern.DataSource = Extension.BindEnumDescription(typeof(DisplayPattern));
            cmbPattern.DisplayMember = "Description";
            cmbPattern.ValueMember = "value";
            cmbColorPattern.DataSource = Extension.BindEnumDescription(typeof(ColorPattern));
            cmbColorPattern.DisplayMember = "Description";
            cmbColorPattern.ValueMember = "value";
            cmbRotation.DataSource = Extension.BindEnumDescription(typeof(RotationMode));
            cmbRotation.DisplayMember = "Description";
            cmbRotation.ValueMember = "value";

            Signals.ConnectionStatusChanged += Signals_ConnectionStatusChanged;
            Signals.DeviceStatusChanged += Signals_DeviceStatusChanged;
        }

        void Initialize()
        {
            cmbSerialPort.SelectedItem = Program.Settings.COMPortSettings.Portname;
            cmbColorPattern.SelectedValue = ColorPattern.W;  // Program.Settings.ColorPattern;
            cmbPattern.SelectedValue = DisplayPattern.noPattern; // Program.Settings.DisplayPattern;
            cmbRotation.SelectedValue = RotationMode.s;  // Program.Settings.RotationMode;
            tBarLaser.Value = 0; //Program.Settings.LaserPWMValue;
            tBarRotation.Value = 0; // Program.Settings.Velocity;
            btnLaser.Text = "Off";
            btnLaser.BackColor = Color.FromArgb(200, Color.LightSalmon);
            initialized = true;
        }

        void SaveData()
        {
            if (initialized)
            {
                var sps = new SerialPortSettings() { Portname = cmbSerialPort.SelectedItem.ToString() };
                new FileFactory().SaveAppSettings(
                new AppSettings()
                {
                    RotationMode = cmbRotation.SelectedItem.ToEnum<RotationMode>(),
                    DisplayPattern = cmbPattern.SelectedItem.ToEnum<DisplayPattern>(),
                    ColorPattern = cmbColorPattern.SelectedItem.ToEnum<ColorPattern>(),
                    COMPortSettings = sps,
                    LaserPWMValue = tBarLaser.Value,
                    Velocity = tBarRotation.Value
                });
            }
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
           
            SaveData();
        }

        private void numericUpDownRotation_ValueChanged(object sender, EventArgs e)
        {
            tBarRotation.Value = (int)nUDRotation.Value;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            new Signals().OnConnectRequest(this, new SerialPortSettings() { Portname = cmbSerialPort.SelectedItem.ToString() });
            SaveData();
        }

        private void btnLaser_Click(object sender, EventArgs e)
        {
            new Signals().OnLaserSwitch(this, (int)nUDLaser.Value);
            SaveData();
            new Signals().OnLaserSwitch(this, (int)nUDLaser.Value);
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
            SaveData();
        }

        private void cmbColorPattern_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cmbColorPattern.BackColor=Color.FromName(cmbColorPattern.SelectedText);    
            new Signals().OnSetPattern(this, new PatternEventArgs(cmbPattern.SelectedItem.ToEnum<DisplayPattern>()
                                 , cmbColorPattern.SelectedItem.ToEnum<ColorPattern>()));
            SaveData();
        }

        private void cmbRotation_SelectedIndexChanged(object sender, EventArgs e)
        {
            new Signals().OnRotate(this, new RotateEventArgs(cmbRotation.SelectedItem.ToEnum<RotationMode>(), (int)nUDRotation.Value));
            SaveData();
        }

        private void btnRotation_Click(object sender, EventArgs e)
        {
             new Signals().OnRotate(this, new RotateEventArgs(cmbRotation.SelectedItem.ToEnum<RotationMode>(), tBarRotation.Value));
        }
    }
}
