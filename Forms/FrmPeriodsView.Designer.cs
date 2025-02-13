namespace UR_MTrack
{
    partial class FrmPeriodsView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPeriodsView));
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.orientedTextLabel1 = new UR_MTrack.OrientedTextLabel();
            this.tblButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnCreatePeriod = new UR_MTrack.CurveButton();
            this.btnLoadPeriod = new UR_MTrack.CurveButton();
            this.btnOk = new UR_MTrack.CurveButton();
            this.btnCancel = new UR_MTrack.CurveButton();
            this.btnRemove = new UR_MTrack.CurveButton();
            this.tBarPeriodsView = new UR_MTrack.TitleBar();
            this.flpCtrlHost = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tblMain.SuspendLayout();
            this.tblButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.AutoSize = true;
            this.tblMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblMain.BackColor = System.Drawing.Color.White;
            this.tblMain.ColumnCount = 2;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblMain.Controls.Add(this.orientedTextLabel1, 0, 1);
            this.tblMain.Controls.Add(this.tblButtons, 1, 3);
            this.tblMain.Controls.Add(this.tBarPeriodsView, 0, 0);
            this.tblMain.Controls.Add(this.flpCtrlHost, 1, 1);
            this.tblMain.Controls.Add(this.label1, 1, 2);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 4;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.Size = new System.Drawing.Size(769, 549);
            this.tblMain.TabIndex = 0;
            // 
            // orientedTextLabel1
            // 
            this.orientedTextLabel1.BackColor = System.Drawing.Color.DimGray;
            this.orientedTextLabel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.orientedTextLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.orientedTextLabel1.ForeColor = System.Drawing.Color.Gainsboro;
            this.orientedTextLabel1.Location = new System.Drawing.Point(0, 31);
            this.orientedTextLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.orientedTextLabel1.MaximumSize = new System.Drawing.Size(35, 0);
            this.orientedTextLabel1.Name = "orientedTextLabel1";
            this.orientedTextLabel1.RotationAngle = 270D;
            this.tblMain.SetRowSpan(this.orientedTextLabel1, 3);
            this.orientedTextLabel1.Size = new System.Drawing.Size(35, 518);
            this.orientedTextLabel1.TabIndex = 4;
            this.orientedTextLabel1.Text = "Periods";
            this.orientedTextLabel1.TextDirection = UR_MTrack.Direction.Clockwise;
            this.orientedTextLabel1.TextOrientation = UR_MTrack.Orientation.Rotate;
            // 
            // tblButtons
            // 
            this.tblButtons.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tblButtons.AutoSize = true;
            this.tblButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblButtons.ColumnCount = 5;
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblButtons.Controls.Add(this.btnCreatePeriod, 3, 0);
            this.tblButtons.Controls.Add(this.btnLoadPeriod, 2, 0);
            this.tblButtons.Controls.Add(this.btnOk, 0, 0);
            this.tblButtons.Controls.Add(this.btnCancel, 1, 0);
            this.tblButtons.Controls.Add(this.btnRemove, 4, 0);
            this.tblButtons.Location = new System.Drawing.Point(139, 499);
            this.tblButtons.Margin = new System.Windows.Forms.Padding(0);
            this.tblButtons.Name = "tblButtons";
            this.tblButtons.RowCount = 1;
            this.tblButtons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblButtons.Size = new System.Drawing.Size(525, 50);
            this.tblButtons.TabIndex = 5;
            // 
            // btnCreatePeriod
            // 
            this.btnCreatePeriod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreatePeriod.AutoSizeFont = false;
            this.btnCreatePeriod.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCreatePeriod.BorderWidth = 1F;
            this.btnCreatePeriod.Checkable = false;
            this.btnCreatePeriod.Checked = false;
            this.btnCreatePeriod.CheckedColor = System.Drawing.Color.Empty;
            this.btnCreatePeriod.CornerRadius = 1;
            this.btnCreatePeriod.ExtMessage = null;
            this.btnCreatePeriod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreatePeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreatePeriod.GradientColoring = false;
            this.btnCreatePeriod.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnCreatePeriod.HighlightColor = System.Drawing.Color.Coral;
            this.btnCreatePeriod.HighlightThickness = 2;
            this.btnCreatePeriod.Location = new System.Drawing.Point(325, 10);
            this.btnCreatePeriod.Margin = new System.Windows.Forms.Padding(10);
            this.btnCreatePeriod.Name = "btnCreatePeriod";
            this.btnCreatePeriod.RelPos = new float[] {
        0F,
        0.2F,
        0.5F,
        1F};
            this.btnCreatePeriod.ShowExtLabel = false;
            this.btnCreatePeriod.Size = new System.Drawing.Size(85, 30);
            this.btnCreatePeriod.TabIndex = 19;
            this.btnCreatePeriod.Text = "Create New";
            this.btnCreatePeriod.UseVisualStyleBackColor = true;
            this.btnCreatePeriod.Click += new System.EventHandler(this.btnCreatePeriod_Click);
            // 
            // btnLoadPeriod
            // 
            this.btnLoadPeriod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLoadPeriod.AutoSizeFont = false;
            this.btnLoadPeriod.BackColor = System.Drawing.Color.White;
            this.btnLoadPeriod.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLoadPeriod.BorderWidth = 1F;
            this.btnLoadPeriod.Checkable = false;
            this.btnLoadPeriod.Checked = false;
            this.btnLoadPeriod.CheckedColor = System.Drawing.Color.Empty;
            this.btnLoadPeriod.CornerRadius = 1;
            this.btnLoadPeriod.ExtMessage = null;
            this.btnLoadPeriod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadPeriod.GradientColoring = false;
            this.btnLoadPeriod.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnLoadPeriod.HighlightColor = System.Drawing.Color.Coral;
            this.btnLoadPeriod.HighlightThickness = 2;
            this.btnLoadPeriod.Location = new System.Drawing.Point(220, 10);
            this.btnLoadPeriod.Margin = new System.Windows.Forms.Padding(10);
            this.btnLoadPeriod.Name = "btnLoadPeriod";
            this.btnLoadPeriod.RelPos = new float[] {
        0F,
        0.2F,
        0.5F,
        1F};
            this.btnLoadPeriod.ShowExtLabel = false;
            this.btnLoadPeriod.Size = new System.Drawing.Size(85, 30);
            this.btnLoadPeriod.TabIndex = 18;
            this.btnLoadPeriod.Text = "Load";
            this.btnLoadPeriod.UseVisualStyleBackColor = false;
            this.btnLoadPeriod.Click += new System.EventHandler(this.btnLoadPeriod_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnOk.AutoSizeFont = false;
            this.btnOk.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOk.BorderWidth = 1F;
            this.btnOk.Checkable = false;
            this.btnOk.Checked = false;
            this.btnOk.CheckedColor = System.Drawing.Color.Empty;
            this.btnOk.CornerRadius = 1;
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.ExtMessage = null;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.GradientColoring = false;
            this.btnOk.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnOk.HighlightColor = System.Drawing.Color.Coral;
            this.btnOk.HighlightThickness = 2;
            this.btnOk.Location = new System.Drawing.Point(10, 10);
            this.btnOk.Margin = new System.Windows.Forms.Padding(10);
            this.btnOk.Name = "btnOk";
            this.btnOk.RelPos = new float[] {
        0F,
        0.2F,
        0.5F,
        1F};
            this.btnOk.ShowExtLabel = false;
            this.btnOk.Size = new System.Drawing.Size(85, 30);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCancel.AutoSizeFont = false;
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.BorderWidth = 1F;
            this.btnCancel.Checkable = false;
            this.btnCancel.Checked = false;
            this.btnCancel.CheckedColor = System.Drawing.Color.Empty;
            this.btnCancel.CornerRadius = 1;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ExtMessage = null;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.GradientColoring = false;
            this.btnCancel.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnCancel.HighlightColor = System.Drawing.Color.Coral;
            this.btnCancel.HighlightThickness = 2;
            this.btnCancel.Location = new System.Drawing.Point(115, 10);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(10);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.RelPos = new float[] {
        0F,
        0.2F,
        0.5F,
        1F};
            this.btnCancel.ShowExtLabel = false;
            this.btnCancel.Size = new System.Drawing.Size(83, 30);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnRemove.AutoSizeFont = false;
            this.btnRemove.BackColor = System.Drawing.Color.White;
            this.btnRemove.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRemove.BorderWidth = 1F;
            this.btnRemove.Checkable = false;
            this.btnRemove.Checked = false;
            this.btnRemove.CheckedColor = System.Drawing.Color.Empty;
            this.btnRemove.CornerRadius = 1;
            this.btnRemove.ExtMessage = null;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.GradientColoring = false;
            this.btnRemove.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnRemove.HighlightColor = System.Drawing.Color.Coral;
            this.btnRemove.HighlightThickness = 2;
            this.btnRemove.Location = new System.Drawing.Point(430, 10);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(10);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.RelPos = new float[] {
        0F,
        0.2F,
        0.5F,
        1F};
            this.btnRemove.ShowExtLabel = false;
            this.btnRemove.Size = new System.Drawing.Size(83, 30);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Delete";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // tBarPeriodsView
            // 
            this.tBarPeriodsView.AbtImg = ((System.Drawing.Image)(resources.GetObject("tBarPeriodsView.AbtImg")));
            this.tBarPeriodsView.AbtVisible = false;
            this.tBarPeriodsView.AutoSize = true;
            this.tBarPeriodsView.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tBarPeriodsView.BackColor = System.Drawing.Color.DimGray;
            this.tBarPeriodsView.ButtonVisible = false;
            this.tBarPeriodsView.CloseImg = ((System.Drawing.Image)(resources.GetObject("tBarPeriodsView.CloseImg")));
            this.tblMain.SetColumnSpan(this.tBarPeriodsView, 2);
            this.tBarPeriodsView.CtrlBxVisible = false;
            this.tBarPeriodsView.DivColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(184)))), ((int)(((byte)(0)))));
            this.tBarPeriodsView.DivHeight = 2;
            this.tBarPeriodsView.DivVisible = true;
            this.tBarPeriodsView.Dock = System.Windows.Forms.DockStyle.Top;
            this.tBarPeriodsView.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBarPeriodsView.FormIcon = null;
            this.tBarPeriodsView.GradientAngle = 180F;
            this.tBarPeriodsView.GrColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(195)))));
            this.tBarPeriodsView.IconSize = new System.Drawing.Size(60, 31);
            this.tBarPeriodsView.Location = new System.Drawing.Point(0, 0);
            this.tBarPeriodsView.Margin = new System.Windows.Forms.Padding(0);
            this.tBarPeriodsView.MaxImg = ((System.Drawing.Image)(resources.GetObject("tBarPeriodsView.MaxImg")));
            this.tBarPeriodsView.MiniImg = ((System.Drawing.Image)(resources.GetObject("tBarPeriodsView.MiniImg")));
            this.tBarPeriodsView.Name = "tBarPeriodsView";
            this.tBarPeriodsView.RelPos = new float[] {
        0F,
        0.2F,
        1F};
            this.tBarPeriodsView.ShowIcon = false;
            this.tBarPeriodsView.Size = new System.Drawing.Size(769, 31);
            this.tBarPeriodsView.TabIndex = 2;
            this.tBarPeriodsView.Titel = "";
            this.tBarPeriodsView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveFrame_MouseDown);
            // 
            // flpCtrlHost
            // 
            this.flpCtrlHost.AutoScroll = true;
            this.flpCtrlHost.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpCtrlHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpCtrlHost.Location = new System.Drawing.Point(45, 41);
            this.flpCtrlHost.Margin = new System.Windows.Forms.Padding(10);
            this.flpCtrlHost.Name = "flpCtrlHost";
            this.flpCtrlHost.Padding = new System.Windows.Forms.Padding(10, 15, 3, 15);
            this.flpCtrlHost.Size = new System.Drawing.Size(714, 446);
            this.flpCtrlHost.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(35, 497);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(734, 2);
            this.label1.TabIndex = 7;
            // 
            // FrmPeriodsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(769, 551);
            this.Controls.Add(this.tblMain);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPeriodsView";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "PeriodDesigner";
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            this.tblButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblMain;
        private TitleBar tBarPeriodsView;
        private System.Windows.Forms.TableLayoutPanel tblButtons;
        private CurveButton btnCancel;
        private CurveButton btnOk;
        private System.Windows.Forms.FlowLayoutPanel flpCtrlHost;
        private OrientedTextLabel orientedTextLabel1;
        private System.Windows.Forms.Label label1;
        private CurveButton btnRemove;
        private CurveButton btnLoadPeriod;
        private CurveButton btnCreatePeriod;
    }
}