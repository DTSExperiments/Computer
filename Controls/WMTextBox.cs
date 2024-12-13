using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UR_MTrack
{
    /// <summary>
    /// A Textbox control that offers a Watermark option.
    /// </summary>
    public partial class WMTextBox : TextBox
    {
        ToolTip _tt;  
        string _watermark = "Watermark Text";
        string _ttText = "ToolTip";
        bool _highlight;
        bool _showToolTip;
        public WMTextBox()
        {
            _tt = new ToolTip();
            // | ControlStyles.UserPaint
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                            ControlStyles.UserPaint |
                            ControlStyles.OptimizedDoubleBuffer |
                            ControlStyles.ResizeRedraw, true);            

        }

        protected override void OnPaintBackground(PaintEventArgs pe)
        {
            base.OnPaintBackground(pe);
            if (!Enabled || ReadOnly)
            {
                pe.Graphics.FillRectangle(new SolidBrush(BackColor), pe.ClipRectangle);
            }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            var gr = pe.Graphics;//CreateGraphics())
            
            if (!Focused && string.IsNullOrEmpty(Text) && !string.IsNullOrEmpty(_watermark))
            {
                //gr.DrawString(_watermark, Font, new SolidBrush(WatermarkColor), ClientRectangle);
                TextRenderer.DrawText(gr, _watermark, Font,
                        pe.ClipRectangle, WatermarkColor, BackColor,
                        TextFormatFlags.VerticalCenter | TextFormatFlags.Left);
            }
            else if (!string.IsNullOrEmpty(Text))
            {
                TextRenderer.DrawText(gr, Text, Font,
                        ClientRectangle, ForeColor, BackColor,
                        TextFormatFlags.VerticalCenter | TextFormatFlags.Left);
            }
            if (_highlight)
            {
                gr.DrawRectangle(new Pen(HighlightColor, 1F), GetBorderRectangle());
            }
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            _highlight = false;
            Invalidate();
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            //if (string.IsNullOrEmpty(Text)) { _highlight = true; }
        }       

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if(e.KeyData== Keys.Escape|| e.KeyData == Keys.Back || e.KeyData == Keys.Enter || e.KeyData == Keys.Return)
            {
                if (e.KeyData == Keys.Enter || e.KeyData == Keys.Return) { Refresh(); }
                base.OnKeyDown(e);
            }
            else if (NumbersOnly)
            {
                if (char.IsLetter((char)e.KeyCode)) { e.SuppressKeyPress = true; }
            }            
        }

        protected override void OnMouseHover(EventArgs e)
        {
            base.OnMouseHover(e);
            if(_showToolTip) { _tt.Show(_ttText, TopLevelControl); }
        }

        #region Properties
        public override string Text { get => base.Text; set => base.Text = value; }
        public bool AllowDelims { get; set; } = true;
        public bool NumbersOnly { get; set; } = false;
        public bool ShowToolTip { get { return _showToolTip; } set { _showToolTip = value; } }

        public Color HighlightColor { get; set; } = Color.FromArgb(100, Color.Coral);

        public Color WatermarkColor { get; set; } = Color.Silver;

        public Font WMFont { get; set; } = new Font(new FontFamily("Segoe UI"), 14.0F, FontStyle.Bold);

        public ToolTip ToolTip { get { return _tt; } set { _tt = value; } }
        public string ToolTipText
        {
            get { return _ttText; }
            set
            {
                _ttText = value;
            }
        }
        public string WatermarkText
        {
            get { return _watermark; }
            set
            {
                _watermark = value;
                Invalidate();
            }
        }

        #endregion

        #region Methods

        Rectangle GetBorderRectangle()
        {
            var rect = ClientRectangle;
            rect.Inflate(2, 2);
            return rect;
        }

        public void Highlight()
        {
            _highlight = true;
            Invalidate();
        }

        #endregion
    }
}
