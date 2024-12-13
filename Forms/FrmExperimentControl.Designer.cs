namespace UR_MTrack
{
    partial class FrmExperimentControl
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
            this.tblButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnStop = new UR_MTrack.CurveButton();
            this.btnPunish = new UR_MTrack.CurveButton();
            this.btnStartStop = new UR_MTrack.CurveButton();
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.tblButtons.SuspendLayout();
            this.tblMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblButtons
            // 
            this.tblButtons.AutoSize = true;
            this.tblButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.tblButtons.ColumnCount = 3;
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblButtons.Controls.Add(this.btnStop, 1, 0);
            this.tblButtons.Controls.Add(this.btnPunish, 2, 0);
            this.tblButtons.Controls.Add(this.btnStartStop, 0, 0);
            this.tblButtons.Location = new System.Drawing.Point(0, 3);
            this.tblButtons.Margin = new System.Windows.Forms.Padding(0);
            this.tblButtons.Name = "tblButtons";
            this.tblButtons.RowCount = 1;
            this.tblButtons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblButtons.Size = new System.Drawing.Size(210, 56);
            this.tblButtons.TabIndex = 0;
            this.tblButtons.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveFrame_MouseDown);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStop.AutoSizeFont = false;
            this.btnStop.BackColor = System.Drawing.Color.Transparent;
            this.btnStop.BackgroundImage = global::UR_MTrack.Properties.Resources.Stop;
            this.btnStop.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStop.BorderWidth = 0F;
            this.btnStop.Checkable = false;
            this.btnStop.Checked = false;
            this.btnStop.CheckedColor = System.Drawing.Color.Empty;
            this.btnStop.CornerRadius = 20;
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.ExtMessage = null;
            this.btnStop.GradientColoring = false;
            this.btnStop.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.btnStop.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnStop.HighlightThickness = 0;
            this.btnStop.Location = new System.Drawing.Point(80, 3);
            this.btnStop.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnStop.Name = "btnStop";
            this.btnStop.RelPos = new float[] {
        0F,
        0.2F,
        0.5F,
        1F};
            this.btnStop.ShowExtLabel = false;
            this.btnStop.Size = new System.Drawing.Size(50, 50);
            this.btnStop.TabIndex = 1;
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPunish
            // 
            this.btnPunish.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPunish.AutoSizeFont = false;
            this.btnPunish.BackColor = System.Drawing.Color.Transparent;
            this.btnPunish.BackgroundImage = global::UR_MTrack.Properties.Resources.Target;
            this.btnPunish.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPunish.BorderWidth = 0F;
            this.btnPunish.Checkable = false;
            this.btnPunish.Checked = false;
            this.btnPunish.CheckedColor = System.Drawing.Color.Empty;
            this.btnPunish.CornerRadius = 20;
            this.btnPunish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPunish.ExtMessage = null;
            this.btnPunish.GradientColoring = false;
            this.btnPunish.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.btnPunish.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPunish.HighlightThickness = 0;
            this.btnPunish.Location = new System.Drawing.Point(150, 3);
            this.btnPunish.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnPunish.Name = "btnPunish";
            this.btnPunish.RelPos = new float[] {
        0F,
        0.2F,
        0.5F,
        1F};
            this.btnPunish.ShowExtLabel = false;
            this.btnPunish.Size = new System.Drawing.Size(50, 50);
            this.btnPunish.TabIndex = 2;
            this.btnPunish.UseVisualStyleBackColor = false;
            this.btnPunish.Click += new System.EventHandler(this.btnPunish_Click);
            // 
            // btnStartStop
            // 
            this.btnStartStop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStartStop.AutoSizeFont = false;
            this.btnStartStop.BackColor = System.Drawing.Color.Transparent;
            this.btnStartStop.BackgroundImage = global::UR_MTrack.Properties.Resources.Play;
            this.btnStartStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStartStop.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStartStop.BorderWidth = 0F;
            this.btnStartStop.Checkable = false;
            this.btnStartStop.Checked = false;
            this.btnStartStop.CheckedColor = System.Drawing.Color.Empty;
            this.btnStartStop.CornerRadius = 20;
            this.btnStartStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartStop.ExtMessage = null;
            this.btnStartStop.GradientColoring = false;
            this.btnStartStop.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.btnStartStop.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnStartStop.HighlightThickness = 0;
            this.btnStartStop.Location = new System.Drawing.Point(10, 3);
            this.btnStartStop.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.RelPos = new float[] {
        0F,
        0.2F,
        0.5F,
        1F};
            this.btnStartStop.ShowExtLabel = false;
            this.btnStartStop.Size = new System.Drawing.Size(50, 50);
            this.btnStartStop.TabIndex = 0;
            this.btnStartStop.UseVisualStyleBackColor = false;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // tblMain
            // 
            this.tblMain.AutoSize = true;
            this.tblMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblMain.ColumnCount = 1;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblMain.Controls.Add(this.tblButtons, 0, 1);
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 2;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.Size = new System.Drawing.Size(210, 59);
            this.tblMain.TabIndex = 1;
            this.tblMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveFrame_MouseDown);
            // 
            // FrmExperimentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(184)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(220, 67);
            this.Controls.Add(this.tblMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "FrmExperimentControl";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmExperimentControl";
            this.TopMost = true;
            this.tblButtons.ResumeLayout(false);
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblButtons;
        private CurveButton btnStartStop;
        private CurveButton btnStop;
        private CurveButton btnPunish;
        private System.Windows.Forms.TableLayoutPanel tblMain;
    }
}