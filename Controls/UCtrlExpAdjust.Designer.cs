namespace UR_MTrack
{
    partial class UCtrlExpAdjust
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.btnExCo = new System.Windows.Forms.Button();
            this.tblControls = new System.Windows.Forms.TableLayoutPanel();
            this.tblRotation = new System.Windows.Forms.TableLayoutPanel();
            this.nUDRotation = new System.Windows.Forms.NumericUpDown();
            this.tBarRotation = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbRotation = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tblLaser = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tBarLaser = new System.Windows.Forms.TrackBar();
            this.nUDLaser = new System.Windows.Forms.NumericUpDown();
            this.tblSerialControl = new System.Windows.Forms.TableLayoutPanel();
            this.cmbSerialPort = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tblPattern = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbColorPattern = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbPattern = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAccept = new UR_MTrack.CurveButton();
            this.btnRotate = new UR_MTrack.CurveButton();
            this.btnLaser = new UR_MTrack.CurveButton();
            this.btnConnect = new UR_MTrack.CurveButton();
            this.btnSetPattern = new UR_MTrack.CurveButton();
            this.lblSidebar = new UR_MTrack.OrientedTextLabel();
            this.tblMain.SuspendLayout();
            this.tblControls.SuspendLayout();
            this.tblRotation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDRotation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarRotation)).BeginInit();
            this.tblLaser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBarLaser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDLaser)).BeginInit();
            this.tblSerialControl.SuspendLayout();
            this.tblPattern.SuspendLayout();
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
            this.tblMain.Controls.Add(this.btnExCo, 1, 0);
            this.tblMain.Controls.Add(this.tblControls, 0, 0);
            this.tblMain.Controls.Add(this.lblSidebar, 1, 1);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.tblMain.ForeColor = System.Drawing.Color.Silver;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Margin = new System.Windows.Forms.Padding(0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 2;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMain.Size = new System.Drawing.Size(275, 479);
            this.tblMain.TabIndex = 0;
            // 
            // btnExCo
            // 
            this.btnExCo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnExCo.BackColor = System.Drawing.Color.Gray;
            this.btnExCo.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnExCo.FlatAppearance.BorderSize = 0;
            this.btnExCo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExCo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExCo.Location = new System.Drawing.Point(253, 0);
            this.btnExCo.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.btnExCo.Name = "btnExCo";
            this.btnExCo.Size = new System.Drawing.Size(22, 22);
            this.btnExCo.TabIndex = 1;
            this.btnExCo.Text = "<";
            this.btnExCo.UseVisualStyleBackColor = false;
            this.btnExCo.Click += new System.EventHandler(this.ExCo_Click);
            // 
            // tblControls
            // 
            this.tblControls.AutoSize = true;
            this.tblControls.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblControls.ColumnCount = 1;
            this.tblControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblControls.Controls.Add(this.btnAccept, 0, 4);
            this.tblControls.Controls.Add(this.tblRotation, 0, 3);
            this.tblControls.Controls.Add(this.tblLaser, 0, 1);
            this.tblControls.Controls.Add(this.tblSerialControl, 0, 0);
            this.tblControls.Controls.Add(this.tblPattern, 0, 2);
            this.tblControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblControls.Location = new System.Drawing.Point(3, 0);
            this.tblControls.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.tblControls.Name = "tblControls";
            this.tblControls.RowCount = 5;
            this.tblMain.SetRowSpan(this.tblControls, 2);
            this.tblControls.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblControls.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblControls.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblControls.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblControls.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblControls.Size = new System.Drawing.Size(250, 479);
            this.tblControls.TabIndex = 2;
            // 
            // tblRotation
            // 
            this.tblRotation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblRotation.AutoSize = true;
            this.tblRotation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblRotation.ColumnCount = 2;
            this.tblRotation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblRotation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblRotation.Controls.Add(this.btnRotate, 1, 1);
            this.tblRotation.Controls.Add(this.nUDRotation, 1, 2);
            this.tblRotation.Controls.Add(this.tBarRotation, 0, 2);
            this.tblRotation.Controls.Add(this.label5, 0, 0);
            this.tblRotation.Controls.Add(this.cmbRotation, 0, 1);
            this.tblRotation.Controls.Add(this.label8, 0, 3);
            this.tblRotation.Location = new System.Drawing.Point(0, 299);
            this.tblRotation.Margin = new System.Windows.Forms.Padding(0);
            this.tblRotation.MaximumSize = new System.Drawing.Size(250, 0);
            this.tblRotation.Name = "tblRotation";
            this.tblRotation.RowCount = 4;
            this.tblRotation.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblRotation.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblRotation.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblRotation.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblRotation.Size = new System.Drawing.Size(250, 122);
            this.tblRotation.TabIndex = 40;
            // 
            // nUDRotation
            // 
            this.nUDRotation.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nUDRotation.BackColor = System.Drawing.Color.White;
            this.nUDRotation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUDRotation.Location = new System.Drawing.Point(146, 82);
            this.nUDRotation.Margin = new System.Windows.Forms.Padding(4);
            this.nUDRotation.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.nUDRotation.Name = "nUDRotation";
            this.nUDRotation.ReadOnly = true;
            this.nUDRotation.Size = new System.Drawing.Size(61, 22);
            this.nUDRotation.TabIndex = 11;
            this.nUDRotation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nUDRotation.ValueChanged += new System.EventHandler(this.numericUpDownRotation_ValueChanged);
            // 
            // tBarRotation
            // 
            this.tBarRotation.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tBarRotation.BackColor = System.Drawing.SystemColors.Window;
            this.tBarRotation.Location = new System.Drawing.Point(4, 71);
            this.tBarRotation.Margin = new System.Windows.Forms.Padding(4);
            this.tBarRotation.Maximum = 40;
            this.tBarRotation.MaximumSize = new System.Drawing.Size(151, 35);
            this.tBarRotation.Name = "tBarRotation";
            this.tBarRotation.Size = new System.Drawing.Size(134, 45);
            this.tBarRotation.TabIndex = 10;
            this.tBarRotation.ValueChanged += new System.EventHandler(this.tBarRotation_ValueChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.tblRotation.SetColumnSpan(this.label5, 2);
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.label5.Location = new System.Drawing.Point(3, 5);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "Rotation";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbRotation
            // 
            this.cmbRotation.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbRotation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cmbRotation.FormattingEnabled = true;
            this.cmbRotation.Location = new System.Drawing.Point(3, 32);
            this.cmbRotation.Name = "cmbRotation";
            this.cmbRotation.Size = new System.Drawing.Size(116, 24);
            this.cmbRotation.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.BackColor = System.Drawing.Color.Gray;
            this.tblRotation.SetColumnSpan(this.label8, 2);
            this.label8.Location = new System.Drawing.Point(0, 120);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(250, 2);
            this.label8.TabIndex = 33;
            this.label8.Text = "label8";
            // 
            // tblLaser
            // 
            this.tblLaser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblLaser.AutoSize = true;
            this.tblLaser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblLaser.ColumnCount = 2;
            this.tblLaser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblLaser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblLaser.Controls.Add(this.label9, 0, 3);
            this.tblLaser.Controls.Add(this.label3, 0, 0);
            this.tblLaser.Controls.Add(this.tBarLaser, 0, 1);
            this.tblLaser.Controls.Add(this.btnLaser, 0, 2);
            this.tblLaser.Controls.Add(this.nUDLaser, 1, 1);
            this.tblLaser.Location = new System.Drawing.Point(0, 69);
            this.tblLaser.Margin = new System.Windows.Forms.Padding(0);
            this.tblLaser.MaximumSize = new System.Drawing.Size(250, 0);
            this.tblLaser.Name = "tblLaser";
            this.tblLaser.RowCount = 4;
            this.tblLaser.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLaser.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLaser.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLaser.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLaser.Size = new System.Drawing.Size(250, 122);
            this.tblLaser.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.BackColor = System.Drawing.Color.Gray;
            this.tblLaser.SetColumnSpan(this.label9, 2);
            this.label9.Location = new System.Drawing.Point(0, 120);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(250, 2);
            this.label9.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.label3.Location = new System.Drawing.Point(3, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Laser";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tBarLaser
            // 
            this.tBarLaser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tBarLaser.BackColor = System.Drawing.SystemColors.Window;
            this.tBarLaser.Location = new System.Drawing.Point(4, 25);
            this.tBarLaser.Margin = new System.Windows.Forms.Padding(4);
            this.tBarLaser.Maximum = 100;
            this.tBarLaser.MaximumSize = new System.Drawing.Size(151, 35);
            this.tBarLaser.Name = "tBarLaser";
            this.tBarLaser.Size = new System.Drawing.Size(134, 45);
            this.tBarLaser.TabIndex = 10;
            this.tBarLaser.TickFrequency = 10;
            this.tBarLaser.ValueChanged += new System.EventHandler(this.tBarLaser_ValueChanged);
            // 
            // nUDLaser
            // 
            this.nUDLaser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nUDLaser.BackColor = System.Drawing.Color.White;
            this.nUDLaser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUDLaser.Location = new System.Drawing.Point(145, 36);
            this.nUDLaser.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.nUDLaser.Name = "nUDLaser";
            this.nUDLaser.Size = new System.Drawing.Size(61, 22);
            this.nUDLaser.TabIndex = 38;
            this.nUDLaser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nUDLaser.ValueChanged += new System.EventHandler(this.nUDLaser_ValueChanged);
            // 
            // tblSerialControl
            // 
            this.tblSerialControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblSerialControl.AutoSize = true;
            this.tblSerialControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblSerialControl.ColumnCount = 2;
            this.tblSerialControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblSerialControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblSerialControl.Controls.Add(this.cmbSerialPort, 0, 1);
            this.tblSerialControl.Controls.Add(this.label2, 0, 0);
            this.tblSerialControl.Controls.Add(this.label13, 0, 2);
            this.tblSerialControl.Controls.Add(this.btnConnect, 1, 1);
            this.tblSerialControl.Location = new System.Drawing.Point(0, 0);
            this.tblSerialControl.Margin = new System.Windows.Forms.Padding(0);
            this.tblSerialControl.MaximumSize = new System.Drawing.Size(250, 0);
            this.tblSerialControl.Name = "tblSerialControl";
            this.tblSerialControl.RowCount = 3;
            this.tblSerialControl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblSerialControl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblSerialControl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblSerialControl.Size = new System.Drawing.Size(250, 69);
            this.tblSerialControl.TabIndex = 37;
            // 
            // cmbSerialPort
            // 
            this.cmbSerialPort.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbSerialPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cmbSerialPort.FormattingEnabled = true;
            this.cmbSerialPort.Location = new System.Drawing.Point(3, 32);
            this.cmbSerialPort.Name = "cmbSerialPort";
            this.cmbSerialPort.Size = new System.Drawing.Size(119, 24);
            this.cmbSerialPort.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.tblSerialControl.SetColumnSpan(this.label2, 2);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Serial Interface";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.BackColor = System.Drawing.Color.Gray;
            this.tblSerialControl.SetColumnSpan(this.label13, 2);
            this.label13.Location = new System.Drawing.Point(0, 67);
            this.label13.Margin = new System.Windows.Forms.Padding(0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(250, 2);
            this.label13.TabIndex = 31;
            // 
            // tblPattern
            // 
            this.tblPattern.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblPattern.AutoSize = true;
            this.tblPattern.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblPattern.ColumnCount = 2;
            this.tblPattern.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblPattern.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblPattern.Controls.Add(this.label1, 0, 0);
            this.tblPattern.Controls.Add(this.cmbColorPattern, 1, 2);
            this.tblPattern.Controls.Add(this.label4, 0, 1);
            this.tblPattern.Controls.Add(this.cmbPattern, 0, 2);
            this.tblPattern.Controls.Add(this.label7, 0, 3);
            this.tblPattern.Controls.Add(this.btnSetPattern, 1, 1);
            this.tblPattern.Location = new System.Drawing.Point(0, 191);
            this.tblPattern.Margin = new System.Windows.Forms.Padding(0);
            this.tblPattern.MaximumSize = new System.Drawing.Size(250, 0);
            this.tblPattern.Name = "tblPattern";
            this.tblPattern.RowCount = 4;
            this.tblPattern.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblPattern.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblPattern.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblPattern.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblPattern.Size = new System.Drawing.Size(250, 108);
            this.tblPattern.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.tblPattern.SetColumnSpan(this.label1, 2);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Environment Control";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbColorPattern
            // 
            this.cmbColorPattern.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbColorPattern.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cmbColorPattern.FormattingEnabled = true;
            this.cmbColorPattern.Location = new System.Drawing.Point(125, 79);
            this.cmbColorPattern.Name = "cmbColorPattern";
            this.cmbColorPattern.Size = new System.Drawing.Size(116, 24);
            this.cmbColorPattern.TabIndex = 36;
            this.cmbColorPattern.DropDownClosed += new System.EventHandler(this.cmbColorPattern_DropDownClosed);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.label4.Location = new System.Drawing.Point(3, 47);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Pattern";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbPattern
            // 
            this.cmbPattern.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbPattern.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cmbPattern.FormattingEnabled = true;
            this.cmbPattern.Location = new System.Drawing.Point(3, 79);
            this.cmbPattern.Name = "cmbPattern";
            this.cmbPattern.Size = new System.Drawing.Size(116, 24);
            this.cmbPattern.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.BackColor = System.Drawing.Color.Gray;
            this.tblPattern.SetColumnSpan(this.label7, 2);
            this.label7.Location = new System.Drawing.Point(0, 106);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(250, 2);
            this.label7.TabIndex = 32;
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAccept.AutoSizeFont = false;
            this.btnAccept.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAccept.BorderWidth = 1F;
            this.btnAccept.Checkable = false;
            this.btnAccept.Checked = false;
            this.btnAccept.CheckedColor = System.Drawing.Color.Empty;
            this.btnAccept.CornerRadius = 1;
            this.btnAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAccept.ExtMessage = null;
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.ForeColor = System.Drawing.Color.DimGray;
            this.btnAccept.GradientColoring = false;
            this.btnAccept.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnAccept.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(122)))));
            this.btnAccept.HighlightThickness = 2;
            this.btnAccept.Location = new System.Drawing.Point(82, 431);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(10);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.RelPos = new float[] {
        0F,
        0.2F,
        0.5F,
        1F};
            this.btnAccept.ShowExtLabel = false;
            this.btnAccept.Size = new System.Drawing.Size(85, 26);
            this.btnAccept.TabIndex = 3;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnRotate
            // 
            this.btnRotate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnRotate.AutoSizeFont = false;
            this.btnRotate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRotate.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRotate.BorderWidth = 1F;
            this.btnRotate.Checkable = false;
            this.btnRotate.Checked = false;
            this.btnRotate.CheckedColor = System.Drawing.Color.Empty;
            this.btnRotate.CornerRadius = 1;
            this.btnRotate.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnRotate.ExtMessage = null;
            this.btnRotate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRotate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRotate.ForeColor = System.Drawing.Color.DimGray;
            this.btnRotate.GradientColoring = false;
            this.btnRotate.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnRotate.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(122)))));
            this.btnRotate.HighlightThickness = 2;
            this.btnRotate.Location = new System.Drawing.Point(145, 31);
            this.btnRotate.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.btnRotate.Name = "btnRotate";
            this.btnRotate.RelPos = new float[] {
        0F,
        0.2F,
        0.5F,
        1F};
            this.btnRotate.ShowExtLabel = false;
            this.btnRotate.Size = new System.Drawing.Size(85, 26);
            this.btnRotate.TabIndex = 4;
            this.btnRotate.Text = "Rotate";
            this.btnRotate.UseVisualStyleBackColor = true;
            this.btnRotate.Click += new System.EventHandler(this.btnRotate_Click);
            // 
            // btnLaser
            // 
            this.btnLaser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLaser.AutoSizeFont = false;
            this.btnLaser.BorderColor = System.Drawing.Color.DimGray;
            this.btnLaser.BorderWidth = 1F;
            this.btnLaser.Checkable = false;
            this.btnLaser.Checked = false;
            this.btnLaser.CheckedColor = System.Drawing.Color.Lime;
            this.btnLaser.CornerRadius = 1;
            this.btnLaser.ExtMessage = null;
            this.btnLaser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaser.ForeColor = System.Drawing.Color.DimGray;
            this.btnLaser.GradientColoring = false;
            this.btnLaser.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnLaser.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(122)))));
            this.btnLaser.HighlightThickness = 2;
            this.btnLaser.Location = new System.Drawing.Point(28, 84);
            this.btnLaser.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.btnLaser.Name = "btnLaser";
            this.btnLaser.RelPos = new float[] {
        0F,
        0.2F,
        0.5F,
        1F};
            this.btnLaser.ShowExtLabel = false;
            this.btnLaser.Size = new System.Drawing.Size(85, 26);
            this.btnLaser.TabIndex = 2;
            this.btnLaser.Text = "Off";
            this.btnLaser.UseVisualStyleBackColor = false;
            this.btnLaser.Click += new System.EventHandler(this.btnLaser_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnConnect.AutoSizeFont = false;
            this.btnConnect.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConnect.BorderWidth = 1F;
            this.btnConnect.Checkable = false;
            this.btnConnect.Checked = false;
            this.btnConnect.CheckedColor = System.Drawing.Color.Empty;
            this.btnConnect.CornerRadius = 1;
            this.btnConnect.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnConnect.ExtMessage = null;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.ForeColor = System.Drawing.Color.DimGray;
            this.btnConnect.GradientColoring = false;
            this.btnConnect.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnConnect.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(122)))));
            this.btnConnect.HighlightThickness = 2;
            this.btnConnect.Location = new System.Drawing.Point(135, 31);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(10);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.RelPos = new float[] {
        0F,
        0.2F,
        0.5F,
        1F};
            this.btnConnect.ShowExtLabel = false;
            this.btnConnect.Size = new System.Drawing.Size(85, 26);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnSetPattern
            // 
            this.btnSetPattern.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSetPattern.AutoSizeFont = false;
            this.btnSetPattern.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSetPattern.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSetPattern.BorderWidth = 1F;
            this.btnSetPattern.Checkable = false;
            this.btnSetPattern.Checked = false;
            this.btnSetPattern.CheckedColor = System.Drawing.Color.Empty;
            this.btnSetPattern.CornerRadius = 1;
            this.btnSetPattern.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSetPattern.ExtMessage = null;
            this.btnSetPattern.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetPattern.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetPattern.ForeColor = System.Drawing.Color.DimGray;
            this.btnSetPattern.GradientColoring = false;
            this.btnSetPattern.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnSetPattern.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(122)))));
            this.btnSetPattern.HighlightThickness = 2;
            this.btnSetPattern.Location = new System.Drawing.Point(125, 40);
            this.btnSetPattern.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.btnSetPattern.Name = "btnSetPattern";
            this.btnSetPattern.RelPos = new float[] {
        0F,
        0.2F,
        0.5F,
        1F};
            this.btnSetPattern.ShowExtLabel = false;
            this.btnSetPattern.Size = new System.Drawing.Size(85, 26);
            this.btnSetPattern.TabIndex = 3;
            this.btnSetPattern.Text = "Set";
            this.btnSetPattern.UseVisualStyleBackColor = true;
            this.btnSetPattern.Click += new System.EventHandler(this.btnSetPattern_Click);
            // 
            // lblSidebar
            // 
            this.lblSidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSidebar.BackColor = System.Drawing.Color.Gray;
            this.lblSidebar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSidebar.Location = new System.Drawing.Point(253, 23);
            this.lblSidebar.Margin = new System.Windows.Forms.Padding(0);
            this.lblSidebar.Name = "lblSidebar";
            this.lblSidebar.RotationAngle = 90D;
            this.lblSidebar.Size = new System.Drawing.Size(22, 456);
            this.lblSidebar.TabIndex = 3;
            this.lblSidebar.Text = "Adjustment";
            this.lblSidebar.TextDirection = UR_MTrack.Direction.Clockwise;
            this.lblSidebar.TextOrientation = UR_MTrack.Orientation.Rotate;
            this.lblSidebar.Click += new System.EventHandler(this.ExCo_Click);
            // 
            // UCtrlExpAdjust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tblMain);
            this.Name = "UCtrlExpAdjust";
            this.Size = new System.Drawing.Size(277, 479);
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            this.tblControls.ResumeLayout(false);
            this.tblControls.PerformLayout();
            this.tblRotation.ResumeLayout(false);
            this.tblRotation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDRotation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarRotation)).EndInit();
            this.tblLaser.ResumeLayout(false);
            this.tblLaser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBarLaser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDLaser)).EndInit();
            this.tblSerialControl.ResumeLayout(false);
            this.tblSerialControl.PerformLayout();
            this.tblPattern.ResumeLayout(false);
            this.tblPattern.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblMain;
        private System.Windows.Forms.Button btnExCo;
        private System.Windows.Forms.TableLayoutPanel tblControls;
        private System.Windows.Forms.TableLayoutPanel tblSerialControl;
        private System.Windows.Forms.ComboBox cmbSerialPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private CurveButton btnConnect;
        private System.Windows.Forms.TableLayoutPanel tblLaser;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar tBarLaser;
        private System.Windows.Forms.NumericUpDown nUDLaser;
        private System.Windows.Forms.TableLayoutPanel tblPattern;
        private System.Windows.Forms.ComboBox cmbColorPattern;
        private CurveButton btnSetPattern;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbPattern;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tblRotation;
        private CurveButton btnRotate;
        private System.Windows.Forms.NumericUpDown nUDRotation;
        private System.Windows.Forms.TrackBar tBarRotation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbRotation;
        private System.Windows.Forms.Label label8;
        private CurveButton btnLaser;
        private OrientedTextLabel lblSidebar;
        private CurveButton btnAccept;
    }
}
