using System.Windows.Forms;

namespace plotBrembs
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.config = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Threads = new System.Windows.Forms.Button();
            this.plot = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.trackBarLaser = new System.Windows.Forms.TrackBar();
            this.laser = new System.Windows.Forms.Button();
            this.numericUpDownLaser = new System.Windows.Forms.NumericUpDown();
            this.pictureLaser = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pattern = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.domainUpDown3 = new System.Windows.Forms.DomainUpDown();
            this.domainUpDown2 = new System.Windows.Forms.DomainUpDown();
            this.patternButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.trackBarRotation = new System.Windows.Forms.TrackBar();
            this.rotation = new System.Windows.Forms.Button();
            this.numericUpDownRotation = new System.Windows.Forms.NumericUpDown();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.serialOpen = new System.Windows.Forms.PictureBox();
            this.serialComboBox = new System.Windows.Forms.ComboBox();
            this.simulationData = new System.Windows.Forms.Button();
            this.startSerial = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.config.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.plot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLaser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLaser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLaser)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRotation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRotation)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serialOpen)).BeginInit();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // config
            // 
            this.config.Controls.Add(this.tableLayoutPanel1);
            this.config.Location = new System.Drawing.Point(4, 22);
            this.config.Name = "config";
            this.config.Padding = new System.Windows.Forms.Padding(3);
            this.config.Size = new System.Drawing.Size(869, 587);
            this.config.TabIndex = 1;
            this.config.Text = "Config";
            this.config.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.33333F));
            this.tableLayoutPanel1.Controls.Add(this.Threads, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(869, 587);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // Threads
            // 
            this.Threads.Location = new System.Drawing.Point(147, 143);
            this.Threads.Name = "Threads";
            this.Threads.Size = new System.Drawing.Size(64, 20);
            this.Threads.TabIndex = 3;
            this.Threads.Text = "Thread";
            this.Threads.UseVisualStyleBackColor = true;
            this.Threads.Click += new System.EventHandler(this.button1_Click);
            // 
            // plot
            // 
            this.plot.Controls.Add(this.chart1);
            this.plot.Controls.Add(this.tableLayoutPanel6);
            this.plot.Location = new System.Drawing.Point(4, 22);
            this.plot.Name = "plot";
            this.plot.Padding = new System.Windows.Forms.Padding(3);
            this.plot.Size = new System.Drawing.Size(869, 587);
            this.plot.TabIndex = 0;
            this.plot.Text = "Oscilloscope";
            this.plot.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(863, 441);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.67F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.33F));
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel4, 1, 3);
            this.tableLayoutPanel6.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel6.Controls.Add(this.pattern, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel5, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel3, 1, 2);
            this.tableLayoutPanel6.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 444);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 4;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(863, 140);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22223F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22223F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Controls.Add(this.trackBarLaser, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.laser, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.numericUpDownLaser, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.pictureLaser, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(146, 108);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(714, 29);
            this.tableLayoutPanel4.TabIndex = 15;
            // 
            // trackBarLaser
            // 
            this.trackBarLaser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarLaser.BackColor = System.Drawing.SystemColors.Window;
            this.trackBarLaser.Location = new System.Drawing.Point(161, 3);
            this.trackBarLaser.Maximum = 255;
            this.trackBarLaser.Name = "trackBarLaser";
            this.trackBarLaser.Size = new System.Drawing.Size(152, 23);
            this.trackBarLaser.TabIndex = 9;
            this.trackBarLaser.Scroll += new System.EventHandler(this.trackBarLaser_Scroll);
            // 
            // laser
            // 
            this.laser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.laser.Location = new System.Drawing.Point(477, 3);
            this.laser.Name = "laser";
            this.laser.Size = new System.Drawing.Size(234, 23);
            this.laser.TabIndex = 4;
            this.laser.Text = "Laser On";
            this.laser.UseVisualStyleBackColor = true;
            this.laser.Click += new System.EventHandler(this.laser_Click);
            // 
            // numericUpDownLaser
            // 
            this.numericUpDownLaser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownLaser.Location = new System.Drawing.Point(319, 3);
            this.numericUpDownLaser.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownLaser.Name = "numericUpDownLaser";
            this.numericUpDownLaser.ReadOnly = true;
            this.numericUpDownLaser.Size = new System.Drawing.Size(152, 20);
            this.numericUpDownLaser.TabIndex = 10;
            this.numericUpDownLaser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownLaser.ValueChanged += new System.EventHandler(this.numericUpDownLaser_ValueChanged);
            // 
            // pictureLaser
            // 
            this.pictureLaser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureLaser.Image = global::plotBrembs.Properties.Resources._269210;
            this.pictureLaser.InitialImage = global::plotBrembs.Properties.Resources._269210;
            this.pictureLaser.Location = new System.Drawing.Point(3, 3);
            this.pictureLaser.Name = "pictureLaser";
            this.pictureLaser.Size = new System.Drawing.Size(152, 23);
            this.pictureLaser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureLaser.TabIndex = 11;
            this.pictureLaser.TabStop = false;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.CausesValidation = false;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Laser";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pattern
            // 
            this.pattern.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pattern.AutoSize = true;
            this.pattern.CausesValidation = false;
            this.pattern.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pattern.Location = new System.Drawing.Point(41, 42);
            this.pattern.Name = "pattern";
            this.pattern.Size = new System.Drawing.Size(61, 20);
            this.pattern.TabIndex = 13;
            this.pattern.Text = "Pattern";
            this.pattern.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.ColumnCount = 4;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22223F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22223F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.Controls.Add(this.domainUpDown3, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.domainUpDown2, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.patternButton, 3, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(146, 38);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(714, 29);
            this.tableLayoutPanel5.TabIndex = 12;
            // 
            // domainUpDown3
            // 
            this.domainUpDown3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.domainUpDown3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.domainUpDown3.Items.Add("White");
            this.domainUpDown3.Items.Add("Blue");
            this.domainUpDown3.Items.Add("Green");
            this.domainUpDown3.Items.Add("Cyan");
            this.domainUpDown3.Location = new System.Drawing.Point(161, 3);
            this.domainUpDown3.Name = "domainUpDown3";
            this.domainUpDown3.Size = new System.Drawing.Size(152, 20);
            this.domainUpDown3.TabIndex = 13;
            this.domainUpDown3.Tag = "";
            this.domainUpDown3.Text = "choose Color";
            this.domainUpDown3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.domainUpDown3.SelectedItemChanged += new System.EventHandler(this.domainUpDown3_SelectedItemChanged);
            // 
            // domainUpDown2
            // 
            this.domainUpDown2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.domainUpDown2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.domainUpDown2.Items.Add("No pattern");
            this.domainUpDown2.Items.Add("One touch");
            this.domainUpDown2.Items.Add("Multi touch");
            this.domainUpDown2.Items.Add("T pattern");
            this.domainUpDown2.Location = new System.Drawing.Point(3, 3);
            this.domainUpDown2.Name = "domainUpDown2";
            this.domainUpDown2.Size = new System.Drawing.Size(152, 20);
            this.domainUpDown2.TabIndex = 12;
            this.domainUpDown2.Tag = "";
            this.domainUpDown2.Text = "choose Pattern";
            this.domainUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.domainUpDown2.SelectedItemChanged += new System.EventHandler(this.domainUpDown2_SelectedItemChanged);
            // 
            // patternButton
            // 
            this.patternButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.patternButton.Location = new System.Drawing.Point(477, 3);
            this.patternButton.Name = "patternButton";
            this.patternButton.Size = new System.Drawing.Size(234, 23);
            this.patternButton.TabIndex = 4;
            this.patternButton.Text = "Pattern";
            this.patternButton.UseVisualStyleBackColor = true;
            this.patternButton.Click += new System.EventHandler(this.patternButton_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22223F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22223F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.trackBarRotation, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.rotation, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.numericUpDownRotation, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.domainUpDown1, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(146, 73);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(714, 29);
            this.tableLayoutPanel3.TabIndex = 10;
            // 
            // trackBarRotation
            // 
            this.trackBarRotation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarRotation.BackColor = System.Drawing.SystemColors.Window;
            this.trackBarRotation.Location = new System.Drawing.Point(161, 3);
            this.trackBarRotation.Maximum = 40;
            this.trackBarRotation.Name = "trackBarRotation";
            this.trackBarRotation.Size = new System.Drawing.Size(152, 23);
            this.trackBarRotation.TabIndex = 9;
            this.trackBarRotation.Scroll += new System.EventHandler(this.trackBarRotation_Scroll);
            // 
            // rotation
            // 
            this.rotation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rotation.Location = new System.Drawing.Point(477, 3);
            this.rotation.Name = "rotation";
            this.rotation.Size = new System.Drawing.Size(234, 23);
            this.rotation.TabIndex = 4;
            this.rotation.Text = "Rotate";
            this.rotation.UseVisualStyleBackColor = true;
            this.rotation.Click += new System.EventHandler(this.rotation_Click);
            // 
            // numericUpDownRotation
            // 
            this.numericUpDownRotation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownRotation.Location = new System.Drawing.Point(319, 3);
            this.numericUpDownRotation.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.numericUpDownRotation.Name = "numericUpDownRotation";
            this.numericUpDownRotation.ReadOnly = true;
            this.numericUpDownRotation.Size = new System.Drawing.Size(152, 20);
            this.numericUpDownRotation.TabIndex = 10;
            this.numericUpDownRotation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownRotation.ValueChanged += new System.EventHandler(this.numericUpDownRotation_ValueChanged);
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.domainUpDown1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.domainUpDown1.Items.Add("Sample");
            this.domainUpDown1.Items.Add("Right");
            this.domainUpDown1.Items.Add("Left");
            this.domainUpDown1.Location = new System.Drawing.Point(3, 3);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(152, 20);
            this.domainUpDown1.TabIndex = 11;
            this.domainUpDown1.Tag = "";
            this.domainUpDown1.Text = "choose Rotation";
            this.domainUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.domainUpDown1.SelectedItemChanged += new System.EventHandler(this.domainUpDown1_SelectedItemChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.CausesValidation = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Rotation";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22223F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22223F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.serialOpen, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.serialComboBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.simulationData, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.startSerial, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(146, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(714, 29);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // serialOpen
            // 
            this.serialOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serialOpen.Image = global::plotBrembs.Properties.Resources._269210;
            this.serialOpen.InitialImage = global::plotBrembs.Properties.Resources._269210;
            this.serialOpen.Location = new System.Drawing.Point(161, 3);
            this.serialOpen.Name = "serialOpen";
            this.serialOpen.Size = new System.Drawing.Size(152, 23);
            this.serialOpen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.serialOpen.TabIndex = 12;
            this.serialOpen.TabStop = false;
            // 
            // serialComboBox
            // 
            this.serialComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serialComboBox.FormattingEnabled = true;
            this.serialComboBox.IntegralHeight = false;
            this.serialComboBox.Location = new System.Drawing.Point(3, 3);
            this.serialComboBox.Name = "serialComboBox";
            this.serialComboBox.Size = new System.Drawing.Size(152, 21);
            this.serialComboBox.TabIndex = 0;
            // 
            // simulationData
            // 
            this.simulationData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.simulationData.Location = new System.Drawing.Point(477, 3);
            this.simulationData.Name = "simulationData";
            this.simulationData.Size = new System.Drawing.Size(234, 23);
            this.simulationData.TabIndex = 4;
            this.simulationData.Text = "Simulation";
            this.simulationData.UseVisualStyleBackColor = true;
            this.simulationData.Click += new System.EventHandler(this.simulateData_Click);
            // 
            // startSerial
            // 
            this.startSerial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startSerial.Location = new System.Drawing.Point(319, 3);
            this.startSerial.Name = "startSerial";
            this.startSerial.Size = new System.Drawing.Size(152, 23);
            this.startSerial.TabIndex = 2;
            this.startSerial.Text = "Start";
            this.startSerial.UseVisualStyleBackColor = true;
            this.startSerial.Click += new System.EventHandler(this.startSerial_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.CausesValidation = false;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Serial Interface";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.plot);
            this.tabControl.Controls.Add(this.config);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(877, 613);
            this.tabControl.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 613);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.config.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.plot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLaser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLaser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLaser)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRotation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRotation)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.serialOpen)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabPage config;
        private TableLayoutPanel tableLayoutPanel1;
        private Button Threads;
        private TabPage plot;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel tableLayoutPanel4;
        private TrackBar trackBarLaser;
        private Button laser;
        private NumericUpDown numericUpDownLaser;
        private PictureBox pictureLaser;
        private Label label5;
        private Label pattern;
        private TableLayoutPanel tableLayoutPanel5;
        private DomainUpDown domainUpDown3;
        private DomainUpDown domainUpDown2;
        private Button patternButton;
        private TableLayoutPanel tableLayoutPanel3;
        private TrackBar trackBarRotation;
        private Button rotation;
        private NumericUpDown numericUpDownRotation;
        private DomainUpDown domainUpDown1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel2;
        private PictureBox serialOpen;
        private ComboBox serialComboBox;
        private Button simulationData;
        private Button startSerial;
        private Label label4;
        private TabControl tabControl;
    }
}

