using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UR_MTrack
{
    public partial class GradientPanel : Panel
    {
        #region Var        
        Color _borderColor = Color.DarkGray;
        Color _glowColor = Color.FromArgb(255, Color.LightSalmon);
        Color _gradientTop = Color.FromArgb(255, 79, 184, 0);
        Color _gradientBottom = Color.FromArgb(255, 79, 184, 0);
        LinearGradientMode _gmode = LinearGradientMode.Vertical;
        float[] _relPos = { 0.0f, 0.01f, 0.3f, 1.0f };

        float _bordersize;
        int _cornerradius = 0;
        int _glowsize = 2;
        bool _glow = false;
        bool _canGlow = false;
        bool _usegradient = false;

        #endregion

        public GradientPanel()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.UserPaint |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.SupportsTransparentBackColor |
                     ControlStyles.ResizeRedraw, true);
            UpdateStyles();
            AutoSize = false;
        }


        #region Overrides
        protected override void OnMouseHover(EventArgs e)
        {
            
            base.OnMouseHover(e);
            ///ToDo: Code to show tooltip
        }
        protected override void OnMouseEnter(EventArgs e)
        {
            if (_canGlow) { _glow = true; }
            Invalidate();
        }
        
        protected override void OnMouseLeave(EventArgs e)
        {
            _glow = false;
            Invalidate();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
           // base.OnPaint(e);
            Graphics g = e.Graphics;
            ButtonRenderer.DrawParentBackground(g, ClientRectangle, this);
            
            // Paint the outer rounded rectangle
            g.SmoothingMode = SmoothingMode.AntiAlias;
            var rect =new Rectangle(0, 0, Width, Height);// new Rectangle(ClientRectangle.X, ClientRectangle.Y, ClientRectangle.Width, ClientRectangle.Height);

            using (GraphicsPath outerPath = RoundedRectangle(rect, CornerRadius, 0))
            {
                using (LinearGradientBrush fillBrush = new LinearGradientBrush(rect, _gradientTop, _gradientBottom, _gmode))
                {
                    var blend = new ColorBlend();
                    blend.Positions = _relPos;
                    blend.Colors = new[] { BackColor, BackColor, BackColor, BackColor };

                    if (_usegradient)
                    {
                        blend.Colors = new[] { BackColor, _gradientTop, _gradientBottom, Color.Transparent };
                    }

                    fillBrush.InterpolationColors = blend;
                    g.FillPath(fillBrush, outerPath);
                }
                if (_glow)
                {
                    using (Pen outlinePen = new Pen(GlowColor, BorderSize + Glowsize))
                    {
                        outlinePen.Alignment = PenAlignment.Outset;
                        g.DrawPath(outlinePen, outerPath);
                    }
                }
                else if (BorderSize > 0)
                {
                    using (Pen outlinePen = new Pen(BorderColor, BorderSize))
                    {
                        outlinePen.Alignment = PenAlignment.Center;
                        g.DrawPath(outlinePen, outerPath);
                    }
                }

            }
            if (BackgroundImage != null)
            {
                g.DrawImage(BackgroundImage, ClientRectangle);
            }
        }

        #endregion


        #region Properties


        [Category("Appearance")]
        [Description("Set the border size.")]
        public float BorderSize
        {
            get
            {
                return _bordersize;
            }
            set
            {
                _bordersize = value;
                Invalidate();
            }
        }


        [Category("Appearance")]
        [Description("Set the radius of the rounded button.")]
        public int CornerRadius
        {
            get
            {
                return _cornerradius;
            }
            set
            {
                _cornerradius = value;
                Invalidate();
            }
        }

        [Category("Appearance")]
        [Description("Set the border color to use for the top portion of the gradient fill of the component.")]
        [DefaultValue(typeof(Color), "0x414141")]
        public Color BorderColor
        {
            get
            {
                return _borderColor;
            }
            set
            {
                _borderColor = value;
                Invalidate();
            }
        }

        [Category("Appearance")]
        [Description("Define if this control can drop a glowing border. (HighLight on MouseEnter Event)")]
        public bool UseGlow
        {
            get
            { return _canGlow; }
            set
            {
                _canGlow = value;
                Invalidate();
            }
        }


        [Category("Appearance")]
        [Description("Set the size of the glowing corona.")]
        public int Glowsize
        {
            get
            {
                return _glowsize;
            }
            set
            {
                _glowsize = value;
                Invalidate();
            }
        }



        [Category("Appearance")]
        [Description("Set the highlight color.")]
        public Color GlowColor
        {
            get
            {
                return _glowColor;
            }
            set
            {
                _glowColor = value;
                Invalidate();
            }
        }

        [Category("Gradient")]
        [Description("Select the gradient mode to be used. [vertical, horizontal,...]")]
        public LinearGradientMode GradientDirection
        {
            get
            { return _gmode; }
            set
            {
                _gmode = value;
                Invalidate();
            }
        }

        [Category("Gradient")]
        [DisplayName("Positions")]
        [Description("Set the positions throughout the gradient path.\nValues must be between 0.0 and 1, where the last element must be the greatest one.")]
        public float[] GradientPositions
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

        [Category("Gradient")]
        [Description("Use single solid color, or gradient.")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool GradientColoring
        {
            get
            {

                return _usegradient;
            }
            set
            {
                _usegradient = value;
                Invalidate();
            }
        }

        [Category("Gradient")]
        [Description("The color to use for the top portion of the gradient fill of the component.")]
        public Color GradientTop
        {
            get
            {
                return _gradientTop;
            }
            set
            {
                _gradientTop = value;
                Invalidate();
            }
        }


        [Category("Gradient")]
        [Description("The color to use for the bottom portion of the gradient fill of the component.")]
        [DefaultValue(typeof(Color), "0x4FB800")]
        public Color GradientBottom
        {
            get
            {
                return _gradientBottom;
            }
            set
            {
                _gradientBottom = value;
                Invalidate();
            }
        }


        #endregion


        #region Methods
        /// <summary>
        /// Create a graphics path for a rectangle wicth round corners. 
        /// </summary>
        /// <param name="boundingRect"></param>
        /// <param name="cornerRadius"></param>
        /// <param name="margin"></param>
        /// <returns></returns>
        GraphicsPath RoundedRectangle(Rectangle boundingRect, int cornerRadius, int margin)
        {
            GraphicsPath roundedRect = new GraphicsPath();
            //Top left corner
            roundedRect.AddArc(boundingRect.X + margin, boundingRect.Y + margin, cornerRadius * 2,
      cornerRadius * 2, 180, 90);
            //Top right corner
            roundedRect.AddArc(boundingRect.X + boundingRect.Width - margin - cornerRadius * 2,
      boundingRect.Y + margin, cornerRadius * 2, cornerRadius * 2, 270, 90);
            //Bottom right corner
            roundedRect.AddArc(boundingRect.X + boundingRect.Width - margin - cornerRadius * 2,
      boundingRect.Y + boundingRect.Height - margin - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 0, 90);
            //Bottom left corner
            roundedRect.AddArc(boundingRect.X + margin,
      boundingRect.Y + boundingRect.Height - margin - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 90, 90);
            roundedRect.CloseFigure();
            return roundedRect;
        }
        #endregion

        #region Ausgeblendet

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public new string AccessibleDescription { get; set; } = string.Empty;

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public new string AccessibleRole { get; set; } = string.Empty;

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public new string AccessibleName { get; set; } = string.Empty;

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public new BorderStyle BorderStyle { get; set; } = BorderStyle.None;

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public new bool CausesValidation { get; set; } = false;

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public new ContextMenuStrip ContextMenuStrip { get; set; } = null;

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public new Cursor Cursor { get; set; } = Cursor.Current;

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public new string Font { get; set; }

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public new string ForeColor { get; set; }

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public new bool UseWaitCursor { get; set; } = false;

        #endregion
    }
}
