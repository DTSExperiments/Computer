namespace UR_MTrack
{
    partial class TraceView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.rtbLogBox = new System.Windows.Forms.RichTextBox();
            this.btnClearLog = new UR_MTrack.CurveButton();
            this.tblMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.BackColor = System.Drawing.Color.Transparent;
            this.tblMain.ColumnCount = 2;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblMain.Controls.Add(this.rtbLogBox, 1, 0);
            this.tblMain.Controls.Add(this.btnClearLog, 1, 1);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 2;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.Size = new System.Drawing.Size(800, 415);
            this.tblMain.TabIndex = 0;
            // 
            // rtbLogBox
            // 
            this.rtbLogBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.rtbLogBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbLogBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbLogBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rtbLogBox.Location = new System.Drawing.Point(2, 0);
            this.rtbLogBox.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rtbLogBox.Name = "rtbLogBox";
            this.rtbLogBox.Size = new System.Drawing.Size(796, 362);
            this.rtbLogBox.TabIndex = 2;
            this.rtbLogBox.Text = "";
            // 
            // btnClearLog
            // 
            this.btnClearLog.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClearLog.AutoSizeFont = false;
            this.btnClearLog.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClearLog.BorderWidth = 0F;
            this.btnClearLog.Checkable = false;
            this.btnClearLog.Checked = false;
            this.btnClearLog.CheckedColor = System.Drawing.Color.Empty;
            this.btnClearLog.CornerRadius = 1;
            this.btnClearLog.ExtMessage = null;
            this.btnClearLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearLog.ForeColor = System.Drawing.Color.White;
            this.btnClearLog.GradientBottom = System.Drawing.Color.Transparent;
            this.btnClearLog.GradientColoring = true;
            this.btnClearLog.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnClearLog.GradientTop = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnClearLog.HighlightColor = System.Drawing.Color.Coral;
            this.btnClearLog.HighlightThickness = 2;
            this.btnClearLog.Location = new System.Drawing.Point(290, 362);
            this.btnClearLog.Margin = new System.Windows.Forms.Padding(0);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.RelPos = new float[] {
        0F,
        0.3F,
        0.9F,
        1F};
            this.btnClearLog.ShowExtLabel = false;
            this.btnClearLog.Size = new System.Drawing.Size(220, 53);
            this.btnClearLog.TabIndex = 3;
            this.btnClearLog.Text = "Clear";
            this.btnClearLog.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClearLog.UseVisualStyleBackColor = true;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // TraceView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(800, 415);
            this.Controls.Add(this.tblMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "TraceView";
            this.Opacity = 0.8D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "TraceView";
            this.tblMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblMain;
        private System.Windows.Forms.RichTextBox rtbLogBox;
        private CurveButton btnClearLog;
    }
}