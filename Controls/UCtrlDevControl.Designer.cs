namespace UR_MTrack
{
    partial class UCtrlDevControl
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
            this.tblControls = new System.Windows.Forms.TableLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tblSerialControl = new System.Windows.Forms.TableLayoutPanel();
            this.cmbSerialPort = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tblPattern = new System.Windows.Forms.TableLayoutPanel();
            this.cmbPattern = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbColorPattern = new System.Windows.Forms.ComboBox();
            this.tblLaser = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.tBarLaser = new System.Windows.Forms.TrackBar();
            this.nUDLaser = new System.Windows.Forms.NumericUpDown();
            this.tblRotation = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbRotation = new System.Windows.Forms.ComboBox();
            this.tBarRotation = new System.Windows.Forms.TrackBar();
            this.nUDRotation = new System.Windows.Forms.NumericUpDown();
            this.gradientPanel3 = new UR_MTrack.GradientPanel();
            this.gradientPanel1 = new UR_MTrack.GradientPanel();
            this.btnExCo = new UR_MTrack.CurveButton();
            this.lblSidebar = new UR_MTrack.OrientedTextLabel();
            this.gradientPanel2 = new UR_MTrack.GradientPanel();
            this.btnConnect = new UR_MTrack.CurveButton();
            this.gradientPanel4 = new UR_MTrack.GradientPanel();
            this.gradientPanel5 = new UR_MTrack.GradientPanel();
            this.btnLaser = new UR_MTrack.CurveButton();
            this.btnRotation = new UR_MTrack.CurveButton();
            this.tblMain.SuspendLayout();
            this.tblControls.SuspendLayout();
            this.tblSerialControl.SuspendLayout();
            this.tblPattern.SuspendLayout();
            this.tblLaser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBarLaser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDLaser)).BeginInit();
            this.tblRotation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBarRotation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDRotation)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.AutoSize = true;
            this.tblMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblMain.BackColor = System.Drawing.Color.White;
            this.tblMain.ColumnCount = 2;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Controls.Add(this.gradientPanel3, 1, 1);
            this.tblMain.Controls.Add(this.gradientPanel1, 1, 0);
            this.tblMain.Controls.Add(this.tblControls, 0, 0);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.tblMain.ForeColor = System.Drawing.Color.Silver;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Margin = new System.Windows.Forms.Padding(0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 3;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.Size = new System.Drawing.Size(418, 1549);
            this.tblMain.TabIndex = 0;
            // 
            // tblControls
            // 
            this.tblControls.AutoSize = true;
            this.tblControls.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblControls.ColumnCount = 1;
            this.tblControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblControls.Controls.Add(this.label11, 0, 6);
            this.tblControls.Controls.Add(this.label1, 0, 3);
            this.tblControls.Controls.Add(this.label10, 0, 1);
            this.tblControls.Controls.Add(this.lblSidebar, 0, 0);
            this.tblControls.Controls.Add(this.tblSerialControl, 0, 2);
            this.tblControls.Controls.Add(this.tblPattern, 0, 4);
            this.tblControls.Controls.Add(this.tblLaser, 0, 7);
            this.tblControls.Controls.Add(this.tblRotation, 0, 5);
            this.tblControls.Location = new System.Drawing.Point(0, 0);
            this.tblControls.Margin = new System.Windows.Forms.Padding(0);
            this.tblControls.Name = "tblControls";
            this.tblControls.RowCount = 9;
            this.tblMain.SetRowSpan(this.tblControls, 2);
            this.tblControls.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblControls.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblControls.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblControls.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblControls.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblControls.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblControls.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblControls.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblControls.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblControls.Size = new System.Drawing.Size(378, 1043);
            this.tblControls.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.label11.Location = new System.Drawing.Point(4, 796);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(153, 32);
            this.label11.TabIndex = 42;
            this.label11.Text = "Accessory";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.label1.Location = new System.Drawing.Point(4, 240);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 32);
            this.label1.TabIndex = 37;
            this.label1.Text = "Arena Control";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.label10.Location = new System.Drawing.Point(4, 65);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 25, 4, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(225, 32);
            this.label10.TabIndex = 38;
            this.label10.Text = "Communication";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.tblSerialControl.Controls.Add(this.cmbSerialPort, 0, 2);
            this.tblSerialControl.Controls.Add(this.label2, 0, 1);
            this.tblSerialControl.Controls.Add(this.gradientPanel2, 0, 0);
            this.tblSerialControl.Controls.Add(this.btnConnect, 1, 2);
            this.tblSerialControl.Location = new System.Drawing.Point(0, 105);
            this.tblSerialControl.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.tblSerialControl.MaximumSize = new System.Drawing.Size(375, 0);
            this.tblSerialControl.Name = "tblSerialControl";
            this.tblSerialControl.RowCount = 3;
            this.tblSerialControl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblSerialControl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblSerialControl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblSerialControl.Size = new System.Drawing.Size(375, 117);
            this.tblSerialControl.TabIndex = 37;
            // 
            // cmbSerialPort
            // 
            this.cmbSerialPort.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbSerialPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSerialPort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbSerialPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cmbSerialPort.FormattingEnabled = true;
            this.cmbSerialPort.Location = new System.Drawing.Point(4, 66);
            this.cmbSerialPort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbSerialPort.Name = "cmbSerialPort";
            this.cmbSerialPort.Size = new System.Drawing.Size(225, 33);
            this.cmbSerialPort.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.tblSerialControl.SetColumnSpan(this.label2, 2);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.label2.Location = new System.Drawing.Point(4, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 15, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 29);
            this.label2.TabIndex = 25;
            this.label2.Text = "Serial Interface";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.tblPattern.Controls.Add(this.gradientPanel4, 0, 0);
            this.tblPattern.Controls.Add(this.cmbPattern, 0, 2);
            this.tblPattern.Controls.Add(this.label4, 0, 1);
            this.tblPattern.Controls.Add(this.label7, 0, 3);
            this.tblPattern.Controls.Add(this.cmbColorPattern, 0, 4);
            this.tblPattern.Location = new System.Drawing.Point(0, 280);
            this.tblPattern.Margin = new System.Windows.Forms.Padding(0);
            this.tblPattern.MaximumSize = new System.Drawing.Size(375, 0);
            this.tblPattern.Name = "tblPattern";
            this.tblPattern.RowCount = 5;
            this.tblPattern.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblPattern.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblPattern.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblPattern.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblPattern.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblPattern.Size = new System.Drawing.Size(375, 198);
            this.tblPattern.TabIndex = 39;
            // 
            // cmbPattern
            // 
            this.cmbPattern.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tblPattern.SetColumnSpan(this.cmbPattern, 2);
            this.cmbPattern.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPattern.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbPattern.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cmbPattern.FormattingEnabled = true;
            this.cmbPattern.Location = new System.Drawing.Point(4, 58);
            this.cmbPattern.Margin = new System.Windows.Forms.Padding(4, 10, 10, 10);
            this.cmbPattern.Name = "cmbPattern";
            this.cmbPattern.Size = new System.Drawing.Size(225, 33);
            this.cmbPattern.TabIndex = 34;
            this.cmbPattern.SelectedIndexChanged += new System.EventHandler(this.cmbPattern_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.label4.Location = new System.Drawing.Point(4, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 15, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 29);
            this.label4.TabIndex = 27;
            this.label4.Text = "Display Pattern";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.label7.Location = new System.Drawing.Point(4, 116);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 15, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 29);
            this.label7.TabIndex = 42;
            this.label7.Text = "Color Pattern";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbColorPattern
            // 
            this.cmbColorPattern.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tblPattern.SetColumnSpan(this.cmbColorPattern, 2);
            this.cmbColorPattern.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColorPattern.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbColorPattern.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cmbColorPattern.FormattingEnabled = true;
            this.cmbColorPattern.Location = new System.Drawing.Point(4, 155);
            this.cmbColorPattern.Margin = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.cmbColorPattern.Name = "cmbColorPattern";
            this.cmbColorPattern.Size = new System.Drawing.Size(225, 33);
            this.cmbColorPattern.TabIndex = 36;
            this.cmbColorPattern.SelectedIndexChanged += new System.EventHandler(this.cmbColorPattern_SelectedIndexChanged);
            this.cmbColorPattern.DropDownClosed += new System.EventHandler(this.cmbColorPattern_DropDownClosed);
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
            this.tblLaser.Controls.Add(this.gradientPanel5, 0, 0);
            this.tblLaser.Controls.Add(this.label3, 0, 1);
            this.tblLaser.Controls.Add(this.tBarLaser, 0, 2);
            this.tblLaser.Controls.Add(this.btnLaser, 0, 3);
            this.tblLaser.Controls.Add(this.nUDLaser, 1, 2);
            this.tblLaser.Location = new System.Drawing.Point(0, 836);
            this.tblLaser.Margin = new System.Windows.Forms.Padding(0);
            this.tblLaser.MaximumSize = new System.Drawing.Size(375, 0);
            this.tblLaser.Name = "tblLaser";
            this.tblLaser.RowCount = 4;
            this.tblLaser.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLaser.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLaser.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLaser.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLaser.Size = new System.Drawing.Size(375, 207);
            this.tblLaser.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.tblLaser.SetColumnSpan(this.label3, 2);
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.label3.Location = new System.Drawing.Point(4, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 15, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 29);
            this.label3.TabIndex = 26;
            this.label3.Text = "Laser Intensity [PWM]";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tBarLaser
            // 
            this.tBarLaser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tBarLaser.BackColor = System.Drawing.SystemColors.Window;
            this.tBarLaser.Location = new System.Drawing.Point(4, 58);
            this.tBarLaser.Margin = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.tBarLaser.Maximum = 100;
            this.tBarLaser.MaximumSize = new System.Drawing.Size(226, 54);
            this.tBarLaser.Name = "tBarLaser";
            this.tBarLaser.Size = new System.Drawing.Size(226, 69);
            this.tBarLaser.TabIndex = 10;
            this.tBarLaser.TickFrequency = 10;
            this.tBarLaser.ValueChanged += new System.EventHandler(this.tBarLaser_ValueChanged);
            // 
            // nUDLaser
            // 
            this.nUDLaser.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.nUDLaser.BackColor = System.Drawing.Color.White;
            this.nUDLaser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUDLaser.Location = new System.Drawing.Point(263, 77);
            this.nUDLaser.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.nUDLaser.Name = "nUDLaser";
            this.nUDLaser.Size = new System.Drawing.Size(92, 30);
            this.nUDLaser.TabIndex = 38;
            this.nUDLaser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nUDLaser.ValueChanged += new System.EventHandler(this.nUDLaser_ValueChanged);
            // 
            // tblRotation
            // 
            this.tblRotation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblRotation.AutoSize = true;
            this.tblRotation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblRotation.ColumnCount = 2;
            this.tblRotation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblRotation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblRotation.Controls.Add(this.btnRotation, 0, 4);
            this.tblRotation.Controls.Add(this.label8, 0, 2);
            this.tblRotation.Controls.Add(this.label5, 0, 0);
            this.tblRotation.Controls.Add(this.cmbRotation, 0, 1);
            this.tblRotation.Controls.Add(this.tBarRotation, 0, 3);
            this.tblRotation.Controls.Add(this.nUDRotation, 1, 3);
            this.tblRotation.Location = new System.Drawing.Point(0, 478);
            this.tblRotation.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.tblRotation.MaximumSize = new System.Drawing.Size(375, 0);
            this.tblRotation.Name = "tblRotation";
            this.tblRotation.RowCount = 5;
            this.tblRotation.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblRotation.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblRotation.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblRotation.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblRotation.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblRotation.Size = new System.Drawing.Size(375, 300);
            this.tblRotation.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.label8.Location = new System.Drawing.Point(4, 112);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 15, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 29);
            this.label8.TabIndex = 42;
            this.label8.Text = "Velocity";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.tblRotation.SetColumnSpan(this.label5, 2);
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.label5.Location = new System.Drawing.Point(4, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 15, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 29);
            this.label5.TabIndex = 28;
            this.label5.Text = "Rotation Mode";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbRotation
            // 
            this.cmbRotation.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tblRotation.SetColumnSpan(this.cmbRotation, 2);
            this.cmbRotation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRotation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbRotation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cmbRotation.FormattingEnabled = true;
            this.cmbRotation.Location = new System.Drawing.Point(4, 54);
            this.cmbRotation.Margin = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.cmbRotation.Name = "cmbRotation";
            this.cmbRotation.Size = new System.Drawing.Size(225, 33);
            this.cmbRotation.TabIndex = 35;
            this.cmbRotation.SelectedIndexChanged += new System.EventHandler(this.cmbRotation_SelectedIndexChanged);
            // 
            // tBarRotation
            // 
            this.tBarRotation.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tBarRotation.BackColor = System.Drawing.SystemColors.Window;
            this.tBarRotation.Location = new System.Drawing.Point(4, 151);
            this.tBarRotation.Margin = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.tBarRotation.Maximum = 40;
            this.tBarRotation.MaximumSize = new System.Drawing.Size(226, 54);
            this.tBarRotation.Name = "tBarRotation";
            this.tBarRotation.Size = new System.Drawing.Size(226, 69);
            this.tBarRotation.TabIndex = 10;
            this.tBarRotation.ValueChanged += new System.EventHandler(this.tBarRotation_ValueChanged);
            // 
            // nUDRotation
            // 
            this.nUDRotation.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.nUDRotation.BackColor = System.Drawing.Color.White;
            this.nUDRotation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUDRotation.Location = new System.Drawing.Point(263, 170);
            this.nUDRotation.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.nUDRotation.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.nUDRotation.Name = "nUDRotation";
            this.nUDRotation.ReadOnly = true;
            this.nUDRotation.Size = new System.Drawing.Size(92, 30);
            this.nUDRotation.TabIndex = 11;
            this.nUDRotation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nUDRotation.ValueChanged += new System.EventHandler(this.numericUpDownRotation_ValueChanged);
            // 
            // gradientPanel3
            // 
            this.gradientPanel3.AccessibleDescription = "";
            this.gradientPanel3.AccessibleName = "";
            this.gradientPanel3.AccessibleRole = "";
            this.gradientPanel3.BackColor = System.Drawing.Color.DimGray;
            this.gradientPanel3.BorderColor = System.Drawing.Color.DarkGray;
            this.gradientPanel3.BorderSize = 0F;
            this.gradientPanel3.CausesValidation = false;
            this.gradientPanel3.CornerRadius = 1;
            this.gradientPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.gradientPanel3.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(122)))));
            this.gradientPanel3.Glowsize = 1;
            this.gradientPanel3.GradientBottom = System.Drawing.Color.White;
            this.gradientPanel3.GradientColoring = true;
            this.gradientPanel3.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gradientPanel3.GradientPositions = new float[] {
        0F,
        0.95F,
        1F};
            this.gradientPanel3.GradientTop = System.Drawing.Color.DimGray;
            this.gradientPanel3.Location = new System.Drawing.Point(378, 40);
            this.gradientPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.gradientPanel3.Name = "gradientPanel3";
            this.tblMain.SetRowSpan(this.gradientPanel3, 2);
            this.gradientPanel3.Size = new System.Drawing.Size(8, 1509);
            this.gradientPanel3.TabIndex = 2;
            this.gradientPanel3.UseGlow = false;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.AccessibleDescription = "";
            this.gradientPanel1.AccessibleName = "";
            this.gradientPanel1.AccessibleRole = "";
            this.gradientPanel1.AutoSize = true;
            this.gradientPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gradientPanel1.BackColor = System.Drawing.Color.DimGray;
            this.gradientPanel1.BorderColor = System.Drawing.Color.DimGray;
            this.gradientPanel1.BorderSize = 0F;
            this.gradientPanel1.CausesValidation = false;
            this.gradientPanel1.Controls.Add(this.btnExCo);
            this.gradientPanel1.CornerRadius = 1;
            this.gradientPanel1.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(122)))));
            this.gradientPanel1.Glowsize = 2;
            this.gradientPanel1.GradientBottom = System.Drawing.Color.Transparent;
            this.gradientPanel1.GradientColoring = true;
            this.gradientPanel1.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gradientPanel1.GradientPositions = new float[] {
        0F,
        0.01F,
        1F};
            this.gradientPanel1.GradientTop = System.Drawing.Color.DimGray;
            this.gradientPanel1.Location = new System.Drawing.Point(378, 0);
            this.gradientPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(40, 40);
            this.gradientPanel1.TabIndex = 3;
            this.gradientPanel1.UseGlow = false;
            // 
            // btnExCo
            // 
            this.btnExCo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnExCo.AutoSizeFont = false;
            this.btnExCo.BackColor = System.Drawing.Color.DimGray;
            this.btnExCo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExCo.BorderWidth = 0F;
            this.btnExCo.Checkable = false;
            this.btnExCo.Checked = false;
            this.btnExCo.CheckedColor = System.Drawing.Color.Lime;
            this.btnExCo.CornerRadius = 10;
            this.btnExCo.ExtMessage = null;
            this.btnExCo.FlatAppearance.BorderSize = 0;
            this.btnExCo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExCo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExCo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExCo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnExCo.ForeColor = System.Drawing.Color.White;
            this.btnExCo.GradientBottom = System.Drawing.Color.LimeGreen;
            this.btnExCo.GradientColoring = true;
            this.btnExCo.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.btnExCo.GradientTop = System.Drawing.Color.DimGray;
            this.btnExCo.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnExCo.HighlightThickness = 0;
            this.btnExCo.Location = new System.Drawing.Point(0, 0);
            this.btnExCo.Margin = new System.Windows.Forms.Padding(0);
            this.btnExCo.Name = "btnExCo";
            this.btnExCo.RelPos = new float[] {
        0F,
        0.8F,
        1F};
            this.btnExCo.ShowExtLabel = false;
            this.btnExCo.Size = new System.Drawing.Size(40, 40);
            this.btnExCo.TabIndex = 1;
            this.btnExCo.Text = "<";
            this.btnExCo.UseVisualStyleBackColor = false;
            this.btnExCo.Click += new System.EventHandler(this.ExCo_Click);
            // 
            // lblSidebar
            // 
            this.lblSidebar.BackColor = System.Drawing.Color.DimGray;
            this.lblSidebar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblSidebar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSidebar.ForeColor = System.Drawing.Color.White;
            this.lblSidebar.Location = new System.Drawing.Point(0, 0);
            this.lblSidebar.Margin = new System.Windows.Forms.Padding(0);
            this.lblSidebar.Name = "lblSidebar";
            this.lblSidebar.RotationAngle = 0D;
            this.lblSidebar.Size = new System.Drawing.Size(378, 40);
            this.lblSidebar.TabIndex = 3;
            this.lblSidebar.Text = "Device Control";
            this.lblSidebar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSidebar.TextDirection = UR_MTrack.Direction.Clockwise;
            this.lblSidebar.TextOrientation = UR_MTrack.Orientation.Rotate;
            this.lblSidebar.Click += new System.EventHandler(this.ExCo_Click);
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.AccessibleDescription = "";
            this.gradientPanel2.AccessibleName = "";
            this.gradientPanel2.AccessibleRole = "";
            this.gradientPanel2.BackColor = System.Drawing.Color.DimGray;
            this.gradientPanel2.BorderColor = System.Drawing.Color.DarkGray;
            this.gradientPanel2.BorderSize = 1F;
            this.gradientPanel2.CausesValidation = false;
            this.tblSerialControl.SetColumnSpan(this.gradientPanel2, 2);
            this.gradientPanel2.CornerRadius = 1;
            this.gradientPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gradientPanel2.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(122)))));
            this.gradientPanel2.Glowsize = 1;
            this.gradientPanel2.GradientBottom = System.Drawing.Color.White;
            this.gradientPanel2.GradientColoring = true;
            this.gradientPanel2.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gradientPanel2.GradientPositions = new float[] {
        0F,
        0.6F,
        1F};
            this.gradientPanel2.GradientTop = System.Drawing.Color.DimGray;
            this.gradientPanel2.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(391, 4);
            this.gradientPanel2.TabIndex = 38;
            this.gradientPanel2.UseGlow = true;
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
            this.btnConnect.Location = new System.Drawing.Point(248, 63);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(15);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.RelPos = new float[] {
        0F,
        0.2F,
        0.5F,
        1F};
            this.btnConnect.ShowExtLabel = false;
            this.btnConnect.Size = new System.Drawing.Size(128, 39);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // gradientPanel4
            // 
            this.gradientPanel4.AccessibleDescription = "";
            this.gradientPanel4.AccessibleName = "";
            this.gradientPanel4.AccessibleRole = "";
            this.gradientPanel4.BackColor = System.Drawing.Color.DimGray;
            this.gradientPanel4.BorderColor = System.Drawing.Color.DarkGray;
            this.gradientPanel4.BorderSize = 1F;
            this.gradientPanel4.CausesValidation = false;
            this.tblPattern.SetColumnSpan(this.gradientPanel4, 2);
            this.gradientPanel4.CornerRadius = 1;
            this.gradientPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gradientPanel4.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(122)))));
            this.gradientPanel4.Glowsize = 1;
            this.gradientPanel4.GradientBottom = System.Drawing.Color.White;
            this.gradientPanel4.GradientColoring = true;
            this.gradientPanel4.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gradientPanel4.GradientPositions = new float[] {
        0F,
        0.6F,
        1F};
            this.gradientPanel4.GradientTop = System.Drawing.Color.DimGray;
            this.gradientPanel4.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.gradientPanel4.Name = "gradientPanel4";
            this.gradientPanel4.Size = new System.Drawing.Size(375, 4);
            this.gradientPanel4.TabIndex = 39;
            this.gradientPanel4.UseGlow = true;
            // 
            // gradientPanel5
            // 
            this.gradientPanel5.AccessibleDescription = "";
            this.gradientPanel5.AccessibleName = "";
            this.gradientPanel5.AccessibleRole = "";
            this.gradientPanel5.BackColor = System.Drawing.Color.DimGray;
            this.gradientPanel5.BorderColor = System.Drawing.Color.DarkGray;
            this.gradientPanel5.BorderSize = 1F;
            this.gradientPanel5.CausesValidation = false;
            this.tblLaser.SetColumnSpan(this.gradientPanel5, 2);
            this.gradientPanel5.CornerRadius = 1;
            this.gradientPanel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gradientPanel5.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(122)))));
            this.gradientPanel5.Glowsize = 1;
            this.gradientPanel5.GradientBottom = System.Drawing.Color.White;
            this.gradientPanel5.GradientColoring = true;
            this.gradientPanel5.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gradientPanel5.GradientPositions = new float[] {
        0F,
        0.6F,
        1F};
            this.gradientPanel5.GradientTop = System.Drawing.Color.DimGray;
            this.gradientPanel5.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.gradientPanel5.Name = "gradientPanel5";
            this.gradientPanel5.Size = new System.Drawing.Size(375, 4);
            this.gradientPanel5.TabIndex = 41;
            this.gradientPanel5.UseGlow = true;
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
            this.tblLaser.SetColumnSpan(this.btnLaser, 2);
            this.btnLaser.CornerRadius = 1;
            this.btnLaser.ExtMessage = null;
            this.btnLaser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaser.ForeColor = System.Drawing.Color.DimGray;
            this.btnLaser.GradientColoring = false;
            this.btnLaser.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnLaser.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(122)))));
            this.btnLaser.HighlightThickness = 2;
            this.btnLaser.Location = new System.Drawing.Point(123, 152);
            this.btnLaser.Margin = new System.Windows.Forms.Padding(4, 15, 4, 15);
            this.btnLaser.Name = "btnLaser";
            this.btnLaser.RelPos = new float[] {
        0F,
        0.2F,
        0.5F,
        1F};
            this.btnLaser.ShowExtLabel = false;
            this.btnLaser.Size = new System.Drawing.Size(128, 40);
            this.btnLaser.TabIndex = 2;
            this.btnLaser.Text = "Off";
            this.btnLaser.UseVisualStyleBackColor = false;
            this.btnLaser.Click += new System.EventHandler(this.btnLaser_Click);
            // 
            // btnRotation
            // 
            this.btnRotation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRotation.AutoSizeFont = false;
            this.btnRotation.BorderColor = System.Drawing.Color.DimGray;
            this.btnRotation.BorderWidth = 1F;
            this.btnRotation.Checkable = false;
            this.btnRotation.Checked = false;
            this.btnRotation.CheckedColor = System.Drawing.Color.Lime;
            this.tblRotation.SetColumnSpan(this.btnRotation, 2);
            this.btnRotation.CornerRadius = 1;
            this.btnRotation.ExtMessage = null;
            this.btnRotation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRotation.ForeColor = System.Drawing.Color.DimGray;
            this.btnRotation.GradientColoring = false;
            this.btnRotation.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnRotation.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(122)))));
            this.btnRotation.HighlightThickness = 2;
            this.btnRotation.Location = new System.Drawing.Point(123, 245);
            this.btnRotation.Margin = new System.Windows.Forms.Padding(4, 15, 4, 15);
            this.btnRotation.Name = "btnRotation";
            this.btnRotation.RelPos = new float[] {
        0F,
        0.2F,
        0.5F,
        1F};
            this.btnRotation.ShowExtLabel = false;
            this.btnRotation.Size = new System.Drawing.Size(128, 40);
            this.btnRotation.TabIndex = 3;
            this.btnRotation.Text = "Set";
            this.btnRotation.UseVisualStyleBackColor = false;
            this.btnRotation.Click += new System.EventHandler(this.btnRotation_Click);
            // 
            // UCtrlDevControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tblMain);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UCtrlDevControl";
            this.Size = new System.Drawing.Size(419, 1549);
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            this.tblControls.ResumeLayout(false);
            this.tblControls.PerformLayout();
            this.tblSerialControl.ResumeLayout(false);
            this.tblSerialControl.PerformLayout();
            this.tblPattern.ResumeLayout(false);
            this.tblPattern.PerformLayout();
            this.tblLaser.ResumeLayout(false);
            this.tblLaser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBarLaser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDLaser)).EndInit();
            this.tblRotation.ResumeLayout(false);
            this.tblRotation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBarRotation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDRotation)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblMain;
        private System.Windows.Forms.TableLayoutPanel tblControls;
        private System.Windows.Forms.TableLayoutPanel tblSerialControl;
        private System.Windows.Forms.ComboBox cmbSerialPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tblLaser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar tBarLaser;
        private System.Windows.Forms.NumericUpDown nUDLaser;
        private System.Windows.Forms.TableLayoutPanel tblPattern;
        private System.Windows.Forms.ComboBox cmbColorPattern;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbPattern;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tblRotation;
        private System.Windows.Forms.NumericUpDown nUDRotation;
        private System.Windows.Forms.TrackBar tBarRotation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbRotation;
        private CurveButton btnLaser;
        private OrientedTextLabel lblSidebar;
        private CurveButton btnExCo;
        private System.Windows.Forms.Label label10;
        private CurveButton btnConnect;
        private GradientPanel gradientPanel2;
        private GradientPanel gradientPanel4;
        private GradientPanel gradientPanel5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private GradientPanel gradientPanel3;
        private GradientPanel gradientPanel1;
        private CurveButton btnRotation;
    }
}
