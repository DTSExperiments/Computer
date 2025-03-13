namespace UR_MTrack
{
    partial class FrmExperimentConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExperimentConfig));
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.orientedTextLabel1 = new UR_MTrack.OrientedTextLabel();
            this.tBarSessionConfig = new UR_MTrack.TitleBar();
            this.tblConfig = new System.Windows.Forms.TableLayoutPanel();
            this.tbSamplingRate = new UR_MTrack.WMTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbDataModel = new UR_MTrack.WMTextBox();
            this.tbAnalysis = new UR_MTrack.WMTextBox();
            this.tbRecording = new UR_MTrack.WMTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbFlyBase = new UR_MTrack.WMTextBox();
            this.tbFlyDescription = new UR_MTrack.WMTextBox();
            this.tbFlyName = new UR_MTrack.WMTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbOrcID = new UR_MTrack.WMTextBox();
            this.tbLastName = new UR_MTrack.WMTextBox();
            this.tbFirstName = new UR_MTrack.WMTextBox();
            this.btnChangePath = new UR_MTrack.CurveButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDataPath = new UR_MTrack.WMTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbScope = new System.Windows.Forms.ComboBox();
            this.cmbDMSType = new System.Windows.Forms.ComboBox();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.orientedTextLabel2 = new UR_MTrack.OrientedTextLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnShow = new UR_MTrack.CurveButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tblButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new UR_MTrack.CurveButton();
            this.btnOk = new UR_MTrack.CurveButton();
            this.tblMain.SuspendLayout();
            this.tblConfig.SuspendLayout();
            this.tblButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.AutoSize = true;
            this.tblMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblMain.BackColor = System.Drawing.Color.Transparent;
            this.tblMain.ColumnCount = 2;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblMain.Controls.Add(this.orientedTextLabel1, 0, 1);
            this.tblMain.Controls.Add(this.tBarSessionConfig, 0, 0);
            this.tblMain.Controls.Add(this.tblConfig, 1, 1);
            this.tblMain.Controls.Add(this.tblButtons, 1, 2);
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Margin = new System.Windows.Forms.Padding(0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 3;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.Size = new System.Drawing.Size(828, 1000);
            this.tblMain.TabIndex = 0;
            // 
            // orientedTextLabel1
            // 
            this.orientedTextLabel1.AutoSize = true;
            this.orientedTextLabel1.BackColor = System.Drawing.Color.Transparent;
            this.orientedTextLabel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.orientedTextLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.orientedTextLabel1.ForeColor = System.Drawing.Color.Gainsboro;
            this.orientedTextLabel1.Location = new System.Drawing.Point(0, 60);
            this.orientedTextLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.orientedTextLabel1.MaximumSize = new System.Drawing.Size(60, 0);
            this.orientedTextLabel1.Name = "orientedTextLabel1";
            this.orientedTextLabel1.RotationAngle = 270D;
            this.tblMain.SetRowSpan(this.orientedTextLabel1, 2);
            this.orientedTextLabel1.Size = new System.Drawing.Size(55, 940);
            this.orientedTextLabel1.TabIndex = 3;
            this.orientedTextLabel1.Text = "Experiment Configuration";
            this.orientedTextLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.orientedTextLabel1.TextDirection = UR_MTrack.Direction.Clockwise;
            this.orientedTextLabel1.TextOrientation = UR_MTrack.Orientation.Rotate;
            // 
            // tBarSessionConfig
            // 
            this.tBarSessionConfig.AbtImg = ((System.Drawing.Image)(resources.GetObject("tBarSessionConfig.AbtImg")));
            this.tBarSessionConfig.AbtVisible = false;
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
            this.tBarSessionConfig.FormIcon = global::UR_MTrack.Properties.Resources.ur_logo_wort_bildmarke_weiss;
            this.tBarSessionConfig.GradientAngle = 180F;
            this.tBarSessionConfig.GrColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(195)))));
            this.tBarSessionConfig.IconSize = new System.Drawing.Size(90, 47);
            this.tBarSessionConfig.Location = new System.Drawing.Point(0, 0);
            this.tBarSessionConfig.Margin = new System.Windows.Forms.Padding(0);
            this.tBarSessionConfig.MaxImg = ((System.Drawing.Image)(resources.GetObject("tBarSessionConfig.MaxImg")));
            this.tBarSessionConfig.MiniImg = ((System.Drawing.Image)(resources.GetObject("tBarSessionConfig.MiniImg")));
            this.tBarSessionConfig.Name = "tBarSessionConfig";
            this.tBarSessionConfig.RelPos = new float[] {
        0F,
        0.2F,
        1F};
            this.tBarSessionConfig.ShowIcon = true;
            this.tBarSessionConfig.Size = new System.Drawing.Size(828, 60);
            this.tBarSessionConfig.TabIndex = 1;
            this.tBarSessionConfig.Titel = "";
            this.tBarSessionConfig.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveFrame_MouseDown);
            // 
            // tblConfig
            // 
            this.tblConfig.AutoSize = true;
            this.tblConfig.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblConfig.BackColor = System.Drawing.Color.White;
            this.tblConfig.ColumnCount = 4;
            this.tblConfig.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tblConfig.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblConfig.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblConfig.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblConfig.Controls.Add(this.tbSamplingRate, 0, 4);
            this.tblConfig.Controls.Add(this.label14, 0, 20);
            this.tblConfig.Controls.Add(this.label13, 0, 17);
            this.tblConfig.Controls.Add(this.label12, 0, 14);
            this.tblConfig.Controls.Add(this.label11, 0, 8);
            this.tblConfig.Controls.Add(this.label10, 0, 5);
            this.tblConfig.Controls.Add(this.tbDataModel, 3, 16);
            this.tblConfig.Controls.Add(this.tbAnalysis, 2, 16);
            this.tblConfig.Controls.Add(this.tbRecording, 0, 16);
            this.tblConfig.Controls.Add(this.label8, 0, 15);
            this.tblConfig.Controls.Add(this.label4, 0, 11);
            this.tblConfig.Controls.Add(this.tbFlyBase, 3, 10);
            this.tblConfig.Controls.Add(this.tbFlyDescription, 2, 10);
            this.tblConfig.Controls.Add(this.tbFlyName, 0, 10);
            this.tblConfig.Controls.Add(this.label3, 0, 0);
            this.tblConfig.Controls.Add(this.label2, 0, 9);
            this.tblConfig.Controls.Add(this.tbOrcID, 3, 7);
            this.tblConfig.Controls.Add(this.tbLastName, 2, 7);
            this.tblConfig.Controls.Add(this.tbFirstName, 0, 7);
            this.tblConfig.Controls.Add(this.btnChangePath, 3, 1);
            this.tblConfig.Controls.Add(this.label1, 0, 6);
            this.tblConfig.Controls.Add(this.tbDataPath, 0, 1);
            this.tblConfig.Controls.Add(this.label6, 0, 3);
            this.tblConfig.Controls.Add(this.cmbScope, 0, 12);
            this.tblConfig.Controls.Add(this.cmbDMSType, 2, 12);
            this.tblConfig.Controls.Add(this.rtbDescription, 1, 13);
            this.tblConfig.Controls.Add(this.orientedTextLabel2, 0, 13);
            this.tblConfig.Controls.Add(this.label5, 0, 18);
            this.tblConfig.Controls.Add(this.btnShow, 1, 19);
            this.tblConfig.Controls.Add(this.label9, 0, 2);
            this.tblConfig.Controls.Add(this.label7, 2, 11);
            this.tblConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblConfig.Location = new System.Drawing.Point(55, 60);
            this.tblConfig.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.tblConfig.Name = "tblConfig";
            this.tblConfig.RowCount = 21;
            this.tblConfig.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblConfig.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblConfig.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblConfig.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblConfig.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblConfig.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblConfig.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblConfig.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblConfig.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblConfig.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblConfig.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblConfig.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblConfig.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblConfig.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblConfig.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblConfig.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblConfig.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblConfig.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblConfig.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblConfig.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblConfig.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblConfig.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tblConfig.Size = new System.Drawing.Size(771, 846);
            this.tblConfig.TabIndex = 2;
            // 
            // tbSamplingRate
            // 
            this.tbSamplingRate.AllowDelims = true;
            this.tbSamplingRate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tblConfig.SetColumnSpan(this.tbSamplingRate, 2);
            this.tbSamplingRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSamplingRate.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tbSamplingRate.Location = new System.Drawing.Point(4, 175);
            this.tbSamplingRate.Margin = new System.Windows.Forms.Padding(4, 15, 4, 8);
            this.tbSamplingRate.Name = "tbSamplingRate";
            this.tbSamplingRate.NumbersOnly = true;
            this.tbSamplingRate.ShowToolTip = false;
            this.tbSamplingRate.Size = new System.Drawing.Size(238, 30);
            this.tbSamplingRate.TabIndex = 2;
            this.tbSamplingRate.ToolTipText = "ToolTip";
            this.tbSamplingRate.WatermarkColor = System.Drawing.Color.Silver;
            this.tbSamplingRate.WatermarkText = "Text";
            this.tbSamplingRate.WMFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tblConfig.SetColumnSpan(this.label14, 4);
            this.label14.Location = new System.Drawing.Point(0, 843);
            this.label14.Margin = new System.Windows.Forms.Padding(0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(750, 3);
            this.label14.TabIndex = 31;
            this.label14.Text = "label14";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tblConfig.SetColumnSpan(this.label13, 4);
            this.label13.Location = new System.Drawing.Point(0, 727);
            this.label13.Margin = new System.Windows.Forms.Padding(0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(750, 3);
            this.label13.TabIndex = 30;
            this.label13.Text = "label13";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tblConfig.SetColumnSpan(this.label12, 4);
            this.label12.Location = new System.Drawing.Point(0, 634);
            this.label12.Margin = new System.Windows.Forms.Padding(0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(750, 3);
            this.label12.TabIndex = 29;
            this.label12.Text = "label12";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tblConfig.SetColumnSpan(this.label11, 4);
            this.label11.Location = new System.Drawing.Point(0, 306);
            this.label11.Margin = new System.Windows.Forms.Padding(0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(750, 3);
            this.label11.TabIndex = 28;
            this.label11.Text = "label11";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tblConfig.SetColumnSpan(this.label10, 4);
            this.label10.Location = new System.Drawing.Point(0, 213);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(750, 3);
            this.label10.TabIndex = 27;
            this.label10.Text = "label10";
            // 
            // tbDataModel
            // 
            this.tbDataModel.AllowDelims = true;
            this.tbDataModel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbDataModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDataModel.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tbDataModel.Location = new System.Drawing.Point(512, 689);
            this.tbDataModel.Margin = new System.Windows.Forms.Padding(4, 15, 4, 8);
            this.tbDataModel.Name = "tbDataModel";
            this.tbDataModel.NumbersOnly = false;
            this.tbDataModel.ShowToolTip = false;
            this.tbDataModel.Size = new System.Drawing.Size(238, 30);
            this.tbDataModel.TabIndex = 16;
            this.tbDataModel.ToolTipText = "ToolTip";
            this.tbDataModel.WatermarkColor = System.Drawing.Color.Silver;
            this.tbDataModel.WatermarkText = "Data Model";
            this.tbDataModel.WMFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            // 
            // tbAnalysis
            // 
            this.tbAnalysis.AllowDelims = true;
            this.tbAnalysis.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbAnalysis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAnalysis.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tbAnalysis.Location = new System.Drawing.Point(250, 689);
            this.tbAnalysis.Margin = new System.Windows.Forms.Padding(4, 15, 4, 8);
            this.tbAnalysis.Name = "tbAnalysis";
            this.tbAnalysis.NumbersOnly = false;
            this.tbAnalysis.ShowToolTip = false;
            this.tbAnalysis.Size = new System.Drawing.Size(238, 30);
            this.tbAnalysis.TabIndex = 15;
            this.tbAnalysis.ToolTipText = "ToolTip";
            this.tbAnalysis.WatermarkColor = System.Drawing.Color.Silver;
            this.tbAnalysis.WatermarkText = "Analysis";
            this.tbAnalysis.WMFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            // 
            // tbRecording
            // 
            this.tbRecording.AllowDelims = true;
            this.tbRecording.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tblConfig.SetColumnSpan(this.tbRecording, 2);
            this.tbRecording.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRecording.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tbRecording.Location = new System.Drawing.Point(4, 689);
            this.tbRecording.Margin = new System.Windows.Forms.Padding(4, 15, 4, 8);
            this.tbRecording.Name = "tbRecording";
            this.tbRecording.NumbersOnly = false;
            this.tbRecording.ShowToolTip = false;
            this.tbRecording.Size = new System.Drawing.Size(238, 30);
            this.tbRecording.TabIndex = 14;
            this.tbRecording.ToolTipText = "ToolTip";
            this.tbRecording.WatermarkColor = System.Drawing.Color.Silver;
            this.tbRecording.WatermarkText = "Recording";
            this.tbRecording.WMFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.tblConfig.SetColumnSpan(this.label8, 2);
            this.label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.label8.Location = new System.Drawing.Point(4, 645);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 8, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 29);
            this.label8.TabIndex = 16;
            this.label8.Text = "URI";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.tblConfig.SetColumnSpan(this.label4, 2);
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.label4.Location = new System.Drawing.Point(4, 407);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 8, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Arena";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbFlyBase
            // 
            this.tbFlyBase.AllowDelims = true;
            this.tbFlyBase.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbFlyBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFlyBase.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tbFlyBase.Location = new System.Drawing.Point(512, 361);
            this.tbFlyBase.Margin = new System.Windows.Forms.Padding(4, 15, 4, 8);
            this.tbFlyBase.Name = "tbFlyBase";
            this.tbFlyBase.NumbersOnly = false;
            this.tbFlyBase.ShowToolTip = false;
            this.tbFlyBase.Size = new System.Drawing.Size(238, 30);
            this.tbFlyBase.TabIndex = 10;
            this.tbFlyBase.ToolTipText = "ToolTip";
            this.tbFlyBase.WatermarkColor = System.Drawing.Color.Silver;
            this.tbFlyBase.WatermarkText = "Fly Base";
            this.tbFlyBase.WMFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            // 
            // tbFlyDescription
            // 
            this.tbFlyDescription.AllowDelims = true;
            this.tbFlyDescription.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbFlyDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFlyDescription.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tbFlyDescription.Location = new System.Drawing.Point(250, 361);
            this.tbFlyDescription.Margin = new System.Windows.Forms.Padding(4, 15, 4, 8);
            this.tbFlyDescription.Name = "tbFlyDescription";
            this.tbFlyDescription.NumbersOnly = false;
            this.tbFlyDescription.ShowToolTip = false;
            this.tbFlyDescription.Size = new System.Drawing.Size(238, 30);
            this.tbFlyDescription.TabIndex = 9;
            this.tbFlyDescription.ToolTipText = "ToolTip";
            this.tbFlyDescription.WatermarkColor = System.Drawing.Color.Silver;
            this.tbFlyDescription.WatermarkText = "Fly Description";
            this.tbFlyDescription.WMFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            // 
            // tbFlyName
            // 
            this.tbFlyName.AllowDelims = true;
            this.tbFlyName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tblConfig.SetColumnSpan(this.tbFlyName, 2);
            this.tbFlyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFlyName.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tbFlyName.Location = new System.Drawing.Point(4, 361);
            this.tbFlyName.Margin = new System.Windows.Forms.Padding(4, 15, 4, 8);
            this.tbFlyName.Name = "tbFlyName";
            this.tbFlyName.NumbersOnly = false;
            this.tbFlyName.ShowToolTip = false;
            this.tbFlyName.Size = new System.Drawing.Size(238, 30);
            this.tbFlyName.TabIndex = 8;
            this.tbFlyName.ToolTipText = "ToolTip";
            this.tbFlyName.WatermarkColor = System.Drawing.Color.Silver;
            this.tbFlyName.WatermarkText = "Fly Name";
            this.tbFlyName.WMFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.tblConfig.SetColumnSpan(this.label3, 4);
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.label3.Location = new System.Drawing.Point(4, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 23, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "Data Folder";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.tblConfig.SetColumnSpan(this.label2, 4);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.label2.Location = new System.Drawing.Point(4, 317);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 8, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Fly";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbOrcID
            // 
            this.tbOrcID.AllowDelims = true;
            this.tbOrcID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbOrcID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOrcID.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tbOrcID.Location = new System.Drawing.Point(512, 268);
            this.tbOrcID.Margin = new System.Windows.Forms.Padding(4, 15, 4, 8);
            this.tbOrcID.Name = "tbOrcID";
            this.tbOrcID.NumbersOnly = true;
            this.tbOrcID.ShowToolTip = false;
            this.tbOrcID.Size = new System.Drawing.Size(238, 30);
            this.tbOrcID.TabIndex = 7;
            this.tbOrcID.ToolTipText = "ToolTip";
            this.tbOrcID.WatermarkColor = System.Drawing.Color.Silver;
            this.tbOrcID.WatermarkText = "ORCID";
            this.tbOrcID.WMFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            // 
            // tbLastName
            // 
            this.tbLastName.AllowDelims = true;
            this.tbLastName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLastName.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tbLastName.Location = new System.Drawing.Point(250, 268);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(4, 15, 4, 8);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.NumbersOnly = false;
            this.tbLastName.ShowToolTip = false;
            this.tbLastName.Size = new System.Drawing.Size(238, 30);
            this.tbLastName.TabIndex = 6;
            this.tbLastName.ToolTipText = "ToolTip";
            this.tbLastName.WatermarkColor = System.Drawing.Color.Silver;
            this.tbLastName.WatermarkText = "Last Name";
            this.tbLastName.WMFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            // 
            // tbFirstName
            // 
            this.tbFirstName.AllowDelims = true;
            this.tbFirstName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tblConfig.SetColumnSpan(this.tbFirstName, 2);
            this.tbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFirstName.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tbFirstName.Location = new System.Drawing.Point(4, 268);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(4, 15, 4, 8);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.NumbersOnly = false;
            this.tbFirstName.ShowToolTip = false;
            this.tbFirstName.Size = new System.Drawing.Size(238, 30);
            this.tbFirstName.TabIndex = 5;
            this.tbFirstName.ToolTipText = "ToolTip";
            this.tbFirstName.WatermarkColor = System.Drawing.Color.Silver;
            this.tbFirstName.WatermarkText = "First Name";
            this.tbFirstName.WMFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            // 
            // btnChangePath
            // 
            this.btnChangePath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnChangePath.AutoSizeFont = false;
            this.btnChangePath.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChangePath.BorderWidth = 1F;
            this.btnChangePath.Checkable = false;
            this.btnChangePath.Checked = false;
            this.btnChangePath.CheckedColor = System.Drawing.Color.Empty;
            this.btnChangePath.CornerRadius = 1;
            this.btnChangePath.ExtMessage = null;
            this.btnChangePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePath.GradientColoring = false;
            this.btnChangePath.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnChangePath.HighlightColor = System.Drawing.Color.Coral;
            this.btnChangePath.HighlightThickness = 2;
            this.btnChangePath.Location = new System.Drawing.Point(523, 67);
            this.btnChangePath.Margin = new System.Windows.Forms.Padding(15);
            this.btnChangePath.Name = "btnChangePath";
            this.btnChangePath.RelPos = new float[] {
        0F,
        0.2F,
        0.5F,
        1F};
            this.btnChangePath.ShowExtLabel = false;
            this.btnChangePath.Size = new System.Drawing.Size(128, 38);
            this.btnChangePath.TabIndex = 2;
            this.btnChangePath.Text = "Set";
            this.btnChangePath.UseVisualStyleBackColor = true;
            this.btnChangePath.Click += new System.EventHandler(this.btnChangePath_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.tblConfig.SetColumnSpan(this.label1, 4);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.label1.Location = new System.Drawing.Point(4, 224);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 8, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Experimenter";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbDataPath
            // 
            this.tbDataPath.AllowDelims = true;
            this.tbDataPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tblConfig.SetColumnSpan(this.tbDataPath, 3);
            this.tbDataPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDataPath.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tbDataPath.Location = new System.Drawing.Point(4, 69);
            this.tbDataPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 8);
            this.tbDataPath.MaximumSize = new System.Drawing.Size(500, 0);
            this.tbDataPath.MinimumSize = new System.Drawing.Size(0, 30);
            this.tbDataPath.Name = "tbDataPath";
            this.tbDataPath.NumbersOnly = false;
            this.tbDataPath.ShowToolTip = false;
            this.tbDataPath.Size = new System.Drawing.Size(500, 30);
            this.tbDataPath.TabIndex = 1;
            this.tbDataPath.ToolTipText = "ToolTip";
            this.tbDataPath.WatermarkColor = System.Drawing.Color.Silver;
            this.tbDataPath.WatermarkText = "Text";
            this.tbDataPath.WMFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.tblConfig.SetColumnSpan(this.label6, 2);
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.label6.Location = new System.Drawing.Point(4, 131);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 8, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(237, 29);
            this.label6.TabIndex = 22;
            this.label6.Text = "Sampling Rate [Hz]";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbScope
            // 
            this.tblConfig.SetColumnSpan(this.cmbScope, 2);
            this.cmbScope.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbScope.FormattingEnabled = true;
            this.cmbScope.Location = new System.Drawing.Point(4, 441);
            this.cmbScope.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbScope.Name = "cmbScope";
            this.cmbScope.Size = new System.Drawing.Size(238, 33);
            this.cmbScope.TabIndex = 11;
            // 
            // cmbDMSType
            // 
            this.cmbDMSType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDMSType.FormattingEnabled = true;
            this.cmbDMSType.Location = new System.Drawing.Point(250, 441);
            this.cmbDMSType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbDMSType.Name = "cmbDMSType";
            this.cmbDMSType.Size = new System.Drawing.Size(238, 33);
            this.cmbDMSType.TabIndex = 12;
            // 
            // rtbDescription
            // 
            this.rtbDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbDescription.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rtbDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tblConfig.SetColumnSpan(this.rtbDescription, 3);
            this.rtbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDescription.Location = new System.Drawing.Point(56, 484);
            this.rtbDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtbDescription.Size = new System.Drawing.Size(711, 145);
            this.rtbDescription.TabIndex = 13;
            this.rtbDescription.Text = "";
            this.rtbDescription.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rtbDescription_MouseDown);
            // 
            // orientedTextLabel2
            // 
            this.orientedTextLabel2.AutoSize = true;
            this.orientedTextLabel2.BackColor = System.Drawing.Color.White;
            this.orientedTextLabel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.orientedTextLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orientedTextLabel2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orientedTextLabel2.ForeColor = System.Drawing.Color.DarkGray;
            this.orientedTextLabel2.Location = new System.Drawing.Point(4, 479);
            this.orientedTextLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.orientedTextLabel2.Name = "orientedTextLabel2";
            this.orientedTextLabel2.RotationAngle = 270D;
            this.orientedTextLabel2.Size = new System.Drawing.Size(40, 155);
            this.orientedTextLabel2.TabIndex = 21;
            this.orientedTextLabel2.Text = "Description";
            this.orientedTextLabel2.TextDirection = UR_MTrack.Direction.Clockwise;
            this.orientedTextLabel2.TextOrientation = UR_MTrack.Orientation.Rotate;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.tblConfig.SetColumnSpan(this.label5, 4);
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.label5.Location = new System.Drawing.Point(4, 738);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 8, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 29);
            this.label5.TabIndex = 15;
            this.label5.Text = "Period Setup";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnShow
            // 
            this.btnShow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnShow.AutoSizeFont = false;
            this.btnShow.BackColor = System.Drawing.Color.White;
            this.btnShow.BorderColor = System.Drawing.Color.DarkGray;
            this.btnShow.BorderWidth = 1F;
            this.btnShow.Checkable = false;
            this.btnShow.Checked = false;
            this.btnShow.CheckedColor = System.Drawing.Color.Empty;
            this.btnShow.CornerRadius = 1;
            this.btnShow.ExtMessage = null;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.GradientColoring = false;
            this.btnShow.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnShow.HighlightColor = System.Drawing.Color.Coral;
            this.btnShow.HighlightThickness = 2;
            this.btnShow.Location = new System.Drawing.Point(85, 782);
            this.btnShow.Margin = new System.Windows.Forms.Padding(15);
            this.btnShow.Name = "btnShow";
            this.btnShow.RelPos = new float[] {
        0F,
        0.2F,
        0.5F,
        1F};
            this.btnShow.ShowExtLabel = false;
            this.btnShow.Size = new System.Drawing.Size(128, 46);
            this.btnShow.TabIndex = 17;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShowPeriod_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tblConfig.SetColumnSpan(this.label9, 4);
            this.label9.Location = new System.Drawing.Point(0, 120);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(750, 3);
            this.label9.TabIndex = 26;
            this.label9.Text = "label9";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.label7.Location = new System.Drawing.Point(250, 407);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 8, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 29);
            this.label7.TabIndex = 10;
            this.label7.Text = "Meter Type";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tblButtons
            // 
            this.tblButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblButtons.BackColor = System.Drawing.Color.White;
            this.tblButtons.ColumnCount = 2;
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.95238F));
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.04762F));
            this.tblButtons.Controls.Add(this.btnCancel, 1, 0);
            this.tblButtons.Controls.Add(this.btnOk, 0, 0);
            this.tblButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblButtons.Location = new System.Drawing.Point(55, 906);
            this.tblButtons.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.tblButtons.Name = "tblButtons";
            this.tblButtons.RowCount = 1;
            this.tblButtons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblButtons.Size = new System.Drawing.Size(771, 94);
            this.tblButtons.TabIndex = 4;
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
            this.btnCancel.Location = new System.Drawing.Point(407, 24);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(15);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.RelPos = new float[] {
        0F,
        0.2F,
        0.5F,
        1F};
            this.btnCancel.ShowExtLabel = false;
            this.btnCancel.Size = new System.Drawing.Size(128, 46);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            this.btnOk.ExtMessage = null;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.GradientColoring = false;
            this.btnOk.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnOk.HighlightColor = System.Drawing.Color.Coral;
            this.btnOk.HighlightThickness = 2;
            this.btnOk.Location = new System.Drawing.Point(249, 24);
            this.btnOk.Margin = new System.Windows.Forms.Padding(15);
            this.btnOk.Name = "btnOk";
            this.btnOk.RelPos = new float[] {
        0F,
        0.2F,
        0.5F,
        1F};
            this.btnOk.ShowExtLabel = false;
            this.btnOk.Size = new System.Drawing.Size(128, 46);
            this.btnOk.TabIndex = 19;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // FrmExperimentConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(958, 1059);
            this.Controls.Add(this.tblMain);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmExperimentConfig";
            this.Text = "SessionWizard";
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            this.tblConfig.ResumeLayout(false);
            this.tblConfig.PerformLayout();
            this.tblButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblMain;
        private TitleBar tBarSessionConfig;
        private System.Windows.Forms.TableLayoutPanel tblConfig;
        private OrientedTextLabel orientedTextLabel1;
        private System.Windows.Forms.TableLayoutPanel tblButtons;
        private CurveButton btnOk;
        private CurveButton btnCancel;
        private UR_MTrack.WMTextBox tbDataPath;
        private CurveButton btnChangePath;
        private UR_MTrack.WMTextBox tbOrcID;
        private UR_MTrack.WMTextBox tbLastName;
        private UR_MTrack.WMTextBox tbFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private UR_MTrack.WMTextBox tbFlyBase;
        private UR_MTrack.WMTextBox tbFlyDescription;
        private UR_MTrack.WMTextBox tbFlyName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbScope;
        private System.Windows.Forms.ComboBox cmbDMSType;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private CurveButton btnShow;
        private OrientedTextLabel orientedTextLabel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private UR_MTrack.WMTextBox tbRecording;
        private System.Windows.Forms.Label label8;
        private UR_MTrack.WMTextBox tbDataModel;
        private UR_MTrack.WMTextBox tbAnalysis;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private WMTextBox tbSamplingRate;
    }
}