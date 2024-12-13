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
            this.btnRemove = new UR_MTrack.CurveButton();
            this.btnOk = new UR_MTrack.CurveButton();
            this.btnCancel = new UR_MTrack.CurveButton();
            this.tBarSessionConfig = new UR_MTrack.TitleBar();
            this.flpCtrlHost = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tblMain.SuspendLayout();
            this.tblButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.BackColor = System.Drawing.Color.White;
            this.tblMain.ColumnCount = 2;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblMain.Controls.Add(this.orientedTextLabel1, 0, 1);
            this.tblMain.Controls.Add(this.tblButtons, 1, 3);
            this.tblMain.Controls.Add(this.tBarSessionConfig, 0, 0);
            this.tblMain.Controls.Add(this.flpCtrlHost, 1, 1);
            this.tblMain.Controls.Add(this.label1, 1, 2);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 4;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.Size = new System.Drawing.Size(676, 448);
            this.tblMain.TabIndex = 0;
            // 
            // orientedTextLabel1
            // 
            this.orientedTextLabel1.BackColor = System.Drawing.Color.DimGray;
            this.orientedTextLabel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.orientedTextLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.orientedTextLabel1.ForeColor = System.Drawing.Color.Gainsboro;
            this.orientedTextLabel1.Location = new System.Drawing.Point(0, 32);
            this.orientedTextLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.orientedTextLabel1.MaximumSize = new System.Drawing.Size(35, 0);
            this.orientedTextLabel1.Name = "orientedTextLabel1";
            this.orientedTextLabel1.RotationAngle = 270D;
            this.tblMain.SetRowSpan(this.orientedTextLabel1, 3);
            this.orientedTextLabel1.Size = new System.Drawing.Size(35, 416);
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
            this.tblButtons.ColumnCount = 3;
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblButtons.Controls.Add(this.btnRemove, 2, 0);
            this.tblButtons.Controls.Add(this.btnOk, 0, 0);
            this.tblButtons.Controls.Add(this.btnCancel, 1, 0);
            this.tblButtons.Location = new System.Drawing.Point(198, 398);
            this.tblButtons.Margin = new System.Windows.Forms.Padding(0);
            this.tblButtons.Name = "tblButtons";
            this.tblButtons.RowCount = 1;
            this.tblButtons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblButtons.Size = new System.Drawing.Size(315, 50);
            this.tblButtons.TabIndex = 5;
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
            this.btnRemove.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnRemove.ExtMessage = null;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.GradientColoring = false;
            this.btnRemove.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnRemove.HighlightColor = System.Drawing.Color.Coral;
            this.btnRemove.HighlightThickness = 2;
            this.btnRemove.Location = new System.Drawing.Point(220, 10);
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
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.OK;
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
            // tBarSessionConfig
            // 
            this.tBarSessionConfig.AbtImg = ((System.Drawing.Image)(resources.GetObject("tBarSessionConfig.AbtImg")));
            this.tBarSessionConfig.AbtVisible = false;
            this.tBarSessionConfig.AutoSize = true;
            this.tBarSessionConfig.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tBarSessionConfig.BackColor = System.Drawing.Color.DimGray;
            this.tBarSessionConfig.ButtonVisible = false;
            this.tBarSessionConfig.CloseImg = ((System.Drawing.Image)(resources.GetObject("tBarSessionConfig.CloseImg")));
            this.tblMain.SetColumnSpan(this.tBarSessionConfig, 2);
            this.tBarSessionConfig.CtrlBxVisible = false;
            this.tBarSessionConfig.DivColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(184)))), ((int)(((byte)(0)))));
            this.tBarSessionConfig.DivHeight = 3;
            this.tBarSessionConfig.DivVisible = true;
            this.tBarSessionConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.tBarSessionConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBarSessionConfig.FormIcon = null;
            this.tBarSessionConfig.GradientAngle = 180F;
            this.tBarSessionConfig.GrColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(195)))));
            this.tBarSessionConfig.IconSize = new System.Drawing.Size(60, 31);
            this.tBarSessionConfig.Location = new System.Drawing.Point(0, 0);
            this.tBarSessionConfig.Margin = new System.Windows.Forms.Padding(0);
            this.tBarSessionConfig.MaxImg = ((System.Drawing.Image)(resources.GetObject("tBarSessionConfig.MaxImg")));
            this.tBarSessionConfig.MiniImg = ((System.Drawing.Image)(resources.GetObject("tBarSessionConfig.MiniImg")));
            this.tBarSessionConfig.Name = "tBarSessionConfig";
            this.tBarSessionConfig.RelPos = new float[] {
        0F,
        0.2F,
        0.8F};
            this.tBarSessionConfig.ShowIcon = false;
            this.tBarSessionConfig.Size = new System.Drawing.Size(676, 32);
            this.tBarSessionConfig.TabIndex = 2;
            this.tBarSessionConfig.Titel = "";
            this.tBarSessionConfig.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveFrame_MouseDown);
            // 
            // flpCtrlHost
            // 
            this.flpCtrlHost.AutoScroll = true;
            this.flpCtrlHost.AutoScrollMargin = new System.Drawing.Size(10, 0);
            this.flpCtrlHost.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpCtrlHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpCtrlHost.Location = new System.Drawing.Point(35, 32);
            this.flpCtrlHost.Margin = new System.Windows.Forms.Padding(0);
            this.flpCtrlHost.Name = "flpCtrlHost";
            this.flpCtrlHost.Size = new System.Drawing.Size(641, 364);
            this.flpCtrlHost.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(35, 396);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(641, 2);
            this.label1.TabIndex = 7;
            // 
            // FrmPeriodsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(676, 450);
            this.Controls.Add(this.tblMain);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPeriodsView";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.Text = "PeriodDesigner";
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            this.tblButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblMain;
        private TitleBar tBarSessionConfig;
        private System.Windows.Forms.TableLayoutPanel tblButtons;
        private CurveButton btnCancel;
        private CurveButton btnOk;
        private System.Windows.Forms.FlowLayoutPanel flpCtrlHost;
        private OrientedTextLabel orientedTextLabel1;
        private System.Windows.Forms.Label label1;
        private CurveButton btnRemove;
    }
}