//***********************************************************************************************************************************
// Filename:		CurveButton.cs																
// Project:			PlateReaderSoftware 
// Creation Date:	11. 5. 2012	  
// Creation Time:	07:22	
// Original Autor:	(wakl) Kleisch, Walter 
//
//***********************************************************************************************************************************
// 											Copyright (c) 2012 PreSens GmbH
//***********************************************************************************************************************************





using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace UR_MTrack
{
    public class CurveButton : Button
    {
        #region Var        
        Color _borderColor = Color.DarkGray;
        Color _highlightColor = Color.FromArgb(255, Color.SeaShell);
        Color _gradientTop = Color.FromArgb(255, 44, 85, 177);
        Color _gradientBottom = Color.FromArgb(255, 153, 198, 241);


        float[] _relPos = { 0.0f, 0.2f, 0.5f, 1.0f };
        LinearGradientMode _gmode;

        float _outlineWidth;
        int _cornerradius = 1;
        int _highlightsize;
        bool _showExLbl;
        bool _highlight;
        bool _checked;
        bool _usegradient = true;

        #endregion

        public event EventHandler CheckedChanged;

        #region Properties

        [Category("Appearance")]
        [Description("Set the border size.")]
        public float BorderWidth
        {
            get
            {
                return _outlineWidth;
            }
            set
            {
                _outlineWidth = value;
                Invalidate();
            }
        }

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public bool ShowExtLabel
        { get { return _showExLbl; } set { _showExLbl = value; Invalidate(); } }

        [Category("Function")]
        public bool AutoSizeFont { get; set; } = false;

        [Category("Function")]
        public bool Checkable
        { get; set; }

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public bool Checked
        { get { return _checked; } set { _checked = value; Invalidate(); } }


        [Category("Appearance")]
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

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public string ExtMessage
        { get; set; }

       

        [Category("Appearance")]
        [Description("Set the border color to use for the top portion of the gradient fill of the component.")]
        [DefaultValue(typeof(Color), "0x2C55B1")]
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
        [Description("Set the highlight color.")]
        public Color HighlightColor
        {
            get
            {
                return _highlightColor;
            }
            set
            {
                _highlightColor = value;
                Invalidate();
            }
        }


        [DisplayName("Highlight Size")]
        [Category("Appearance")]
        [Description("Set the border thickness when highlighted.")]
        public int HighlightThickness
        {
            get
            {
                return _highlightsize;
            }
            set
            {
                _highlightsize = value;
                Invalidate();
            }
        }

        [Category("Appearance")]
        [Description("The color to use for the top portion of the gradient fill of the component.")]
        [DefaultValue(typeof(Color), "0x2C55B1")]
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


        [Category("Appearance")]
        [Description("The color to use as if button is checked.")]
        public Color CheckedColor
        {
            get; set;
        }

        [Category("Appearance")]
        [Description("The color to use for the bottom portion of the gradient fill of the component.")]
        [DefaultValue(typeof(Color), "0x99C6F1")]
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


        [DisplayName("Gradient Positions")]
        [Description("Set the positions throughout the gradient path.\nValues must be between 0.0 and 1, where the last element must be the greatest one.")]
        [Category("Appearance")]
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
        [Description("")]
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

        #endregion


        #region Override

        protected override void OnPaint(PaintEventArgs pevent)
        {
            
                base.OnPaintBackground(pevent);
                base.OnPaint(pevent);
            
                Graphics g = pevent.Graphics;
                ButtonRenderer.DrawParentBackground(g, ClientRectangle, this);

                // Paint the outer rounded rectangle
                g.SmoothingMode = SmoothingMode.AntiAlias;
                var rect = new RectangleF(ClientRectangle.X, ClientRectangle.Y, ClientRectangle.Width - 2, ClientRectangle.Height - 2);
        
{
                using (GraphicsPath outerPath = RoundedRectangle(rect, CornerRadius, 0))
                {
                    if (_usegradient)
                    {
                        using (LinearGradientBrush fillBrush = new LinearGradientBrush(rect, _gradientTop, _gradientBottom, _gmode))
                        {
                            var blend = new ColorBlend();
                            blend.Positions = _relPos;
                            blend.Colors = new[] { BackColor, BackColor, BackColor, BackColor };

                            if (!Enabled)
                            {
                                blend.Colors = new[] { BackColor, SystemColors.ControlDarkDark, SystemColors.ControlDark, Color.Silver };
                            }
                            else if (_usegradient)
                            {
                                blend.Colors = new[] { BackColor, _gradientTop, _gradientBottom, _gradientBottom };
                            }
                            if (Checked || (Checkable && DesignMode))
                            {
                                blend.Colors = new[] { BackColor, _gradientTop, _gradientBottom, CheckedColor };
                            }
                            fillBrush.InterpolationColors = blend;
                            g.FillPath(fillBrush, outerPath);
                        }
                    }
                    else { g.FillPath(new SolidBrush(BackColor), outerPath);}
                    if (_highlight)
                    {
                        using (Pen outlinePen = new Pen(HighlightColor, BorderWidth + HighlightThickness))
                        {
                            outlinePen.Alignment = PenAlignment.Outset;
                            g.DrawPath(outlinePen, outerPath);
                        }
                    }
                    else if (BorderWidth > 0)
                    {
                        using (Pen outlinePen = new Pen(BorderColor, BorderWidth))
                        {
                            outlinePen.Alignment = PenAlignment.Center;
                            g.DrawPath(outlinePen, outerPath);
                        }
                    }
                    if (_showExLbl)
                    {
                        Rectangle canvas = new Rectangle(Location, new Size(Bounds.Width, 30));
                        var f = new Font(Font.FontFamily, 10, FontStyle.Bold);
                        g.DrawString(ExtMessage, f, new SolidBrush(ForeColor), canvas,
                                                                    new StringFormat(StringFormatFlags.NoClip)
                                                                    {
                                                                        Alignment = StringAlignment.Near,
                                                                        LineAlignment = StringAlignment.Near
                                                                    });

                    }
                }
                if (BackgroundImage != null)
                {
                    g.DrawImage(BackgroundImage, ClientRectangle);
                }
                if (!string.IsNullOrEmpty(Text))
                {
                    g.DrawString(Text, Font, new SolidBrush(ForeColor), rect,
                                                                new StringFormat(StringFormatFlags.NoClip)
                                                                {
                                                                    Alignment = StringAlignment.Center,
                                                                    LineAlignment = StringAlignment.Center
                                                                });
                }
            }
        }


        #region Initialization and Modification

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint |
                            ControlStyles.AllPaintingInWmPaint | ControlStyles.SupportsTransparentBackColor |
                            ControlStyles.ResizeRedraw, true);

            Invalidate();
        }


        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            if (AutoSizeFont)
            {
                AdjustFontsize();
            }
            Invalidate();
        }


        protected override void OnEnabledChanged(EventArgs e)
        {
            Invalidate();
            base.OnEnabledChanged(e);
        }


        protected override void OnClick(EventArgs e)
        {
            if (Checkable)
            {
                //UncheckAllButtons();

            }
            base.OnClick(e);
            Invalidate();
        }
        #endregion


        #region Mouse and Keyboard Interaction

        protected override void OnMouseHover(EventArgs e)
        {
            base.OnMouseHover(e);
        }


        protected override void OnMouseEnter(EventArgs e)
        {
            GradientTop = Color.FromArgb(0, GradientTop);
            _highlight = true;
            base.OnMouseEnter(e);
            Invalidate();
        }


        protected override void OnMouseLeave(EventArgs e)
        {
            GradientTop = Color.FromArgb(150, GradientTop);
            _highlight = false;
            base.OnMouseLeave(e);
            Invalidate();
        }


        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            if (Checkable) { HandleCheckState(); }
            Invalidate();
            base.OnMouseDown(mevent);
        }
        #endregion

        #endregion


        #region Methods        

        void HandleCheckState()
        {
            Checked = !Checked;
            CheckedChanged?.Invoke(this, EventArgs.Empty);
        }

            void AdjustFontsize()
            {
                var size = Font.Size;
                if (Height < Width) { size = size * (Height / (4 * size)); }
                else { size = size * (Width / (4 * size)); }
                Font = new Font(Font.FontFamily, size, Font.Style);
            }


            /// <summary>
            /// Create a graphics path for a rectangle wicth round corners. 
            /// </summary>
            /// <param name="boundingRect"></param>
            /// <param name="cornerRadius"></param>
            /// <param name="margin"></param>
            /// <returns></returns>
            GraphicsPath RoundedRectangle(RectangleF boundingRect, int cornerRadius, int margin)
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

            void UncheckAllButtons()
            {
                if (Parent != null)
                {
                    foreach (var ctrl in Parent.Controls)
                    {
                        if (ctrl.GetType() == this.GetType() && ((CurveButton)ctrl).Checkable)
                        {
                            ((CurveButton)ctrl).Checked = false;
                        }
                    }
                }
            }
            #endregion
        }
    }

