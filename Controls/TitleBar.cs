//***********************************************************************************************************************************
// Filename:		TitleBar.cs																
// Project:			PlateReaderSoftware 
// Creation Date:	5. 5. 2022	  
// Creation Time:	12:06	
// Original Autor:	(wakl) Kleisch, Walter 
//
//***********************************************************************************************************************************
// 											Copyright (c) 2022 PreSens GmbH
//***********************************************************************************************************************************



using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Logging;

namespace UR_MTrack
{
    public partial class TitleBar : UserControl
    {
        Color _gColor = Color.FromArgb(180, 40, 40, 41);
        Color _divColor = Color.Green;
        float[] _relPos = { 0.0f, 0.85f, 1.0f };
        LinearGradientBrush _brush;
        float _gAngle = 90F;


        public TitleBar()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.SupportsTransparentBackColor | ControlStyles.ResizeRedraw, true);
            UpdateStyles();
            InitializeComponent();
        }

        #region override

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(GetGradientBrush(), GradientRectangle);
            if (DivVisible)
            {
                e.Graphics.FillRectangle(new SolidBrush(DivColor), DividerRectangle);
            }


            base.OnPaint(e);
        }

        protected override void OnDoubleClick(EventArgs e)
        {
            if (ParentForm.WindowState == FormWindowState.Normal)
            {
                ParentForm.Invoke((MethodInvoker)(() => ParentForm.WindowState = FormWindowState.Maximized));
            }
            else { ParentForm.Invoke((MethodInvoker)(() => ParentForm.WindowState = FormWindowState.Normal)); }
            base.OnDoubleClick(e);
        }

        #endregion


        #region Properties

        #region Icon


        [DisplayName("Show Icon")]
        [Description("")]
        [Category("Form Icon")]
        public bool ShowIcon
        {
            get { return pIcon.Visible; }
            set
            {
                pIcon.Visible = value;
                Invalidate();
            }
        }

        [DisplayName("Icon")]
        [Description("")]
        [Category("Form Icon")]
        public Image FormIcon
        {
            get { return pIcon.BackgroundImage; }
            set
            {
                pIcon.BackgroundImageLayout = ImageLayout.Zoom;
                pIcon.BackgroundImage = value;
                Invalidate();
            }
        }

        [DisplayName("Icon Size")]
        [Description("Define the size of the Form Icon")]
        [Category("Form Icon")]
        public Size IconSize
        {
            get { return pIcon.Size; }
            set
            {
                pIcon.Size = value;
                Invalidate();
            }
        }


        #endregion

        #region Title
        [DisplayName("Titel Text")]
        [Description("")]
        [Category("Title")]
        public string Titel
        {
            get { return lblTitle.Text; }
            set
            {
                lblTitle.Text = value;
                Invalidate();
            }
        }

        //[DisplayName("Fore Color")]
        [Description("")]
        [Category("Title")]
        public override Color ForeColor
        {
            get { return base.ForeColor; }
            set
            {
                lblTitle.ForeColor = base.ForeColor = value;
                Invalidate();
            }
        }

        

        //[DisplayName("Title Font")]
        [Description("")]
        [Category("Title")]
        public override Font Font
        {
            get { return base.Font; }
            set
            {
                lblTitle.Font = base.Font = value;
                Invalidate();
            }
        }

        #endregion

        #region ControlBox


        [DisplayName("Close Image")]
        [Description("")]
        [Category("Control Box")]
        public Image CloseImg
        {
            get { return btnCloseForm.BackgroundImage; }
            set
            {
                btnCloseForm.BackgroundImage = value;
                Invalidate();
            }
        }

        [DisplayName("Show Control Box")]
        [Description("")]
        [Category("Control Box")]
        public bool CtrlBxVisible
        {
            get { return btnMaximize.Visible; }
            set
            {
                btnMaximize.Visible = value;
                btnMinimize.Visible = value;    
                Invalidate();
            }
        }

        [DisplayName("Show About")]
        [Description("")]
        [Category("Control Box")]
        public bool AbtVisible
        {
            get { return  btnAbout.Visible; }
            set
            {
                btnAbout.Visible = value;
                Invalidate();
            }
        }


        [DisplayName("Minimize Image")]
        [Description("")]
        [Category("Control Box")]
        public Image MiniImg
        {
            get { return btnMinimize.BackgroundImage; }
            set
            {
                btnMinimize.BackgroundImage = value;
                Invalidate();
            }
        }

        [DisplayName("Maximize Image")]
        [Description("")]
        [Category("Control Box")]
        public Image MaxImg
        {
            get { return btnMaximize.BackgroundImage; }
            set
            {
                btnMaximize.BackgroundImage = value;
                Invalidate();
            }
        }


        [DisplayName("About Image")]
        [Description("")]
        [Category("Control Box")]
        public Image AbtImg
        {
            get { return btnAbout.BackgroundImage; }
            set
            {
                btnAbout.BackgroundImage = value;
                Invalidate();
            }
        }

        [DisplayName("About Button")]
        [Description("")]
        [Category("Control Box")]
        public bool ButtonVisible
        {
            get { return btnAbout.Visible; }
            set
            {
                btnAbout.Visible = value;
                Invalidate();
            }
        }


        #endregion

        #region Gradient

        [DisplayName("Gradient Angle")]
        [Description("Sets the angle, the gradient is drawn.\nThis value overrides the Gradient Type option if not set to zero.")]
        [Category("Darstellung")]
        public float GradientAngle
        {
            get { return _gAngle; }
            set
            {
                _gAngle = value;
                Invalidate();
            }
        }
               

        [DisplayName("Gradient Color")]
        [Description("Control fades, starting from this color to BackColor.")]
        [Category("Darstellung")]
        public Color GrColor
        {
            get { return _gColor; }
            set
            {
                _gColor = value;
                Invalidate();
            }
        }

        [DisplayName("Gradient Positions")]
        [Description("Set the positions throughout the gradient path.\nValues must be between 0.0 and 1, where the last element must be the greatest one.")]
        [Category("Darstellung")]
        public float[] RelPos
        {
            get
            {
                return _relPos;
            }
            set
            {
                _relPos = value;
                Invalidate();
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Bindable(false)]
        [Browsable(false)]
        public Rectangle GradientRectangle
        {
            get
            {
                return new Rectangle(new Point(Location.X, Location.Y), new Size(this.Size.Width, this.Size.Height - DivHeight));
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Bindable(false)]
        [Browsable(false)]
        public Rectangle DividerRectangle
        {
            get
            {
                return new Rectangle(new Point(Divider.Location.X, Divider.Location.Y), new Size(Divider.Size.Width, Divider.Size.Height));
            }
        }

        #endregion

        #region Divider

        [DisplayName("Divider Visible")]
        [Description("")]
        [Category("Divider")]
        public bool DivVisible
        {
            get
            {
                return Divider.Visible;
            }
            set
            {
                Divider.Visible = value;
                Invalidate();
            }
        }

        [DisplayName("Divider Height")]
        [Description("")]
        [Category("Divider")]
        public int DivHeight
        {
            get
            {
                return Divider.Height;
            }
            set
            {
                Divider.Height = value;
                Invalidate();
            }
        }

        [DisplayName("Divider Color")]
        [Description("")]
        [Category("Divider")]
        public Color DivColor
        {
            get
            {
                return _divColor;
            }
            set
            {
                _divColor = value;
                Invalidate();
            }
        }


        #endregion

        #endregion


        LinearGradientBrush GetGradientBrush()
        {
            var blend = new ColorBlend();
            blend.Positions = RelPos;
            blend.Colors = new[] { _gColor, _gColor, BackColor };
            try
            {
                _brush = new LinearGradientBrush(GradientRectangle, _gColor, BackColor, GradientAngle);
                _brush.InterpolationColors = blend;
            }
            catch (Exception ex)
            {
                Log.Append(ex);
            }
            return _brush;
        }



        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            ParentForm.Invoke((MethodInvoker)(() => ParentForm.Close()));
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            ParentForm.Invoke((MethodInvoker)(() => ParentForm.WindowState = FormWindowState.Minimized));
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (ParentForm.WindowState == FormWindowState.Normal)
            {
                ParentForm.Invoke((MethodInvoker)(() => ParentForm.WindowState = FormWindowState.Maximized));
            }
            else { ParentForm.Invoke((MethodInvoker)(() => ParentForm.WindowState = FormWindowState.Normal)); }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            //using (new CenterDialog(ParentForm)) 
            //{ new AboutBox().ShowDialog(); }
        }

        private void lblTitle_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Clicks == 2)
            {
                OnDoubleClick(null);
            }
            OnMouseDown(e);
        }
    }
}
