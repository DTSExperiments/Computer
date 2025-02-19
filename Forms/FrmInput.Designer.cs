namespace UR_MTrack
{
    partial class FrmInput
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInput));
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.tblPrjType = new System.Windows.Forms.TableLayoutPanel();
            this.curveButton2 = new UR_MTrack.CurveButton();
            this.btnNew = new UR_MTrack.CurveButton();
            this.label3 = new System.Windows.Forms.Label();
            this.tblPeriodCnt = new System.Windows.Forms.TableLayoutPanel();
            this.lblHint = new System.Windows.Forms.Label();
            this.tbPeriodCnt = new UR_MTrack.WMTextBox();
            this.tblButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tBar = new UR_MTrack.TitleBar();
            this.tblMain.SuspendLayout();
            this.tblPrjType.SuspendLayout();
            this.tblPeriodCnt.SuspendLayout();
            this.tblButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.AutoSize = true;
            this.tblMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblMain.BackColor = System.Drawing.Color.White;
            this.tblMain.ColumnCount = 1;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblMain.Controls.Add(this.tblPrjType, 0, 2);
            this.tblMain.Controls.Add(this.tblPeriodCnt, 0, 1);
            this.tblMain.Controls.Add(this.tblButton, 0, 4);
            this.tblMain.Controls.Add(this.tBar, 0, 0);
            this.tblMain.Location = new System.Drawing.Point(1, 1);
            this.tblMain.Margin = new System.Windows.Forms.Padding(0, 0, 2, 1);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 5;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMain.Size = new System.Drawing.Size(344, 271);
            this.tblMain.TabIndex = 4;
            this.tblMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveFrame_MouseDown);
            // 
            // tblPrjType
            // 
            this.tblPrjType.AutoSize = true;
            this.tblPrjType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblPrjType.BackColor = System.Drawing.Color.White;
            this.tblPrjType.ColumnCount = 2;
            this.tblPrjType.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblPrjType.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblPrjType.Controls.Add(this.curveButton2, 1, 2);
            this.tblPrjType.Controls.Add(this.btnNew, 1, 1);
            this.tblPrjType.Controls.Add(this.label3, 1, 0);
            this.tblPrjType.Location = new System.Drawing.Point(3, 92);
            this.tblPrjType.Name = "tblPrjType";
            this.tblPrjType.RowCount = 3;
            this.tblPrjType.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblPrjType.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblPrjType.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblPrjType.Size = new System.Drawing.Size(338, 125);
            this.tblPrjType.TabIndex = 11;
            this.tblPrjType.Visible = false;
            // 
            // curveButton2
            // 
            this.curveButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.curveButton2.AutoSizeFont = false;
            this.curveButton2.BorderColor = System.Drawing.Color.DarkGray;
            this.curveButton2.BorderWidth = 1F;
            this.curveButton2.Checkable = false;
            this.curveButton2.Checked = false;
            this.curveButton2.CheckedColor = System.Drawing.Color.Empty;
            this.curveButton2.CornerRadius = 1;
            this.curveButton2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.curveButton2.ExtMessage = null;
            this.curveButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.curveButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curveButton2.GradientColoring = false;
            this.curveButton2.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.curveButton2.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(122)))));
            this.curveButton2.HighlightThickness = 2;
            this.curveButton2.Location = new System.Drawing.Point(126, 85);
            this.curveButton2.Margin = new System.Windows.Forms.Padding(10);
            this.curveButton2.Name = "curveButton2";
            this.curveButton2.RelPos = new float[] {
        0F,
        0.2F,
        0.5F,
        1F};
            this.curveButton2.ShowExtLabel = false;
            this.curveButton2.Size = new System.Drawing.Size(85, 30);
            this.curveButton2.TabIndex = 5;
            this.curveButton2.Text = "Open";
            this.curveButton2.UseVisualStyleBackColor = true;
            this.curveButton2.Click += new System.EventHandler(this.curveButton2_Click);
            // 
            // btnNew
            // 
            this.btnNew.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNew.AutoSizeFont = false;
            this.btnNew.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNew.BorderWidth = 1F;
            this.btnNew.Checkable = false;
            this.btnNew.Checked = false;
            this.btnNew.CheckedColor = System.Drawing.Color.Empty;
            this.btnNew.CornerRadius = 1;
            this.btnNew.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnNew.ExtMessage = null;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.GradientColoring = false;
            this.btnNew.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnNew.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(122)))));
            this.btnNew.HighlightThickness = 2;
            this.btnNew.Location = new System.Drawing.Point(126, 35);
            this.btnNew.Margin = new System.Windows.Forms.Padding(10);
            this.btnNew.Name = "btnNew";
            this.btnNew.RelPos = new float[] {
        0F,
        0.2F,
        0.5F,
        1F};
            this.btnNew.ShowExtLabel = false;
            this.btnNew.Size = new System.Drawing.Size(85, 30);
            this.btnNew.TabIndex = 5;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(332, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Please enter how many periods should be generated.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Visible = false;
            // 
            // tblPeriodCnt
            // 
            this.tblPeriodCnt.AutoSize = true;
            this.tblPeriodCnt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblPeriodCnt.BackColor = System.Drawing.Color.White;
            this.tblPeriodCnt.ColumnCount = 2;
            this.tblPeriodCnt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblPeriodCnt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblPeriodCnt.Controls.Add(this.lblHint, 1, 0);
            this.tblPeriodCnt.Controls.Add(this.tbPeriodCnt, 1, 1);
            this.tblPeriodCnt.Location = new System.Drawing.Point(3, 33);
            this.tblPeriodCnt.Name = "tblPeriodCnt";
            this.tblPeriodCnt.RowCount = 2;
            this.tblPeriodCnt.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblPeriodCnt.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblPeriodCnt.Size = new System.Drawing.Size(338, 53);
            this.tblPeriodCnt.TabIndex = 10;
            this.tblPeriodCnt.Visible = false;
            // 
            // lblHint
            // 
            this.lblHint.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHint.AutoSize = true;
            this.lblHint.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHint.Location = new System.Drawing.Point(3, 5);
            this.lblHint.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(332, 17);
            this.lblHint.TabIndex = 7;
            this.lblHint.Text = "Please enter how many periods should be generated.";
            this.lblHint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbPeriodCnt
            // 
            this.tbPeriodCnt.AcceptsReturn = true;
            this.tbPeriodCnt.AllowDelims = true;
            this.tbPeriodCnt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbPeriodCnt.HighlightColor = System.Drawing.Color.Coral;
            this.tbPeriodCnt.Location = new System.Drawing.Point(3, 28);
            this.tbPeriodCnt.Name = "tbPeriodCnt";
            this.tbPeriodCnt.NumbersOnly = true;
            this.tbPeriodCnt.ShowToolTip = false;
            this.tbPeriodCnt.Size = new System.Drawing.Size(100, 22);
            this.tbPeriodCnt.TabIndex = 12;
            this.tbPeriodCnt.ToolTipText = "ToolTip";
            this.tbPeriodCnt.WatermarkColor = System.Drawing.Color.Silver;
            this.tbPeriodCnt.WatermarkText = "1...100";
            this.tbPeriodCnt.WMFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.tbPeriodCnt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_KeyDown);
            // 
            // tblButton
            // 
            this.tblButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tblButton.AutoSize = true;
            this.tblButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblButton.ColumnCount = 3;
            this.tblButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblButton.Controls.Add(this.btnOk, 1, 0);
            this.tblButton.Controls.Add(this.btnCancel, 2, 0);
            this.tblButton.Location = new System.Drawing.Point(58, 223);
            this.tblButton.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.tblButton.Name = "tblButton";
            this.tblButton.RowCount = 1;
            this.tblButton.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblButton.Size = new System.Drawing.Size(210, 45);
            this.tblButton.TabIndex = 4;
            // 
            // btnOk
            // 
            this.btnOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOk.Location = new System.Drawing.Point(10, 5);
            this.btnOk.Margin = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(85, 30);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancel.Location = new System.Drawing.Point(115, 5);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 30);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tBar
            // 
            this.tBar.AbtImg = ((System.Drawing.Image)(resources.GetObject("tBar.AbtImg")));
            this.tBar.AbtVisible = false;
            this.tBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tBar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(195)))));
            this.tBar.ButtonVisible = false;
            this.tBar.CloseImg = ((System.Drawing.Image)(resources.GetObject("tBar.CloseImg")));
            this.tBar.CtrlBxVisible = false;
            this.tBar.DivColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(184)))), ((int)(((byte)(0)))));
            this.tBar.DivHeight = 2;
            this.tBar.DivVisible = false;
            this.tBar.FormIcon = ((System.Drawing.Image)(resources.GetObject("tBar.FormIcon")));
            this.tBar.GradientAngle = 0F;
            this.tBar.GrColor = System.Drawing.Color.DimGray;
            this.tBar.IconSize = new System.Drawing.Size(34, 18);
            this.tBar.Location = new System.Drawing.Point(0, 0);
            this.tBar.Margin = new System.Windows.Forms.Padding(0);
            this.tBar.MaxImg = ((System.Drawing.Image)(resources.GetObject("tBar.MaxImg")));
            this.tBar.MaximumSize = new System.Drawing.Size(400, 32);
            this.tBar.MiniImg = ((System.Drawing.Image)(resources.GetObject("tBar.MiniImg")));
            this.tBar.Name = "tBar";
            this.tBar.RelPos = new float[] {
        0F,
        0.2F,
        1F};
            this.tBar.ShowIcon = false;
            this.tBar.Size = new System.Drawing.Size(344, 30);
            this.tBar.TabIndex = 13;
            this.tBar.TabStop = false;
            this.tBar.Titel = "";
            this.tBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveFrame_MouseDown);
            // 
            // FrmInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DimGray;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(363, 280);
            this.Controls.Add(this.tblMain);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmInput";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Enter comment for current session     ";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            this.tblPrjType.ResumeLayout(false);
            this.tblPrjType.PerformLayout();
            this.tblPeriodCnt.ResumeLayout(false);
            this.tblPeriodCnt.PerformLayout();
            this.tblButton.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TableLayoutPanel tblMain;
        private System.Windows.Forms.TableLayoutPanel tblButton;
        private System.Windows.Forms.TableLayoutPanel tblPeriodCnt;
        private System.Windows.Forms.Label lblHint;
        private WMTextBox tbPeriodCnt;
        private System.Windows.Forms.TableLayoutPanel tblPrjType;
        private System.Windows.Forms.Label label3;
        private CurveButton curveButton2;
        private CurveButton btnNew;
        private TitleBar tBar;
    }
}