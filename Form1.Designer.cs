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
            this.components = new System.ComponentModel.Container();
            this.config = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.domainUpDown5 = new System.Windows.Forms.DomainUpDown();
            this.domainUpDown4 = new System.Windows.Forms.DomainUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.fileDialog = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.resolution = new System.Windows.Forms.CheckBox();
            this.plot = new System.Windows.Forms.TabPage();
            this.formsPlot1 = new ScottPlot.FormsPlot();
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
            this.debug = new System.Windows.Forms.TextBox();
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
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.config.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.plot.SuspendLayout();
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
            this.config.Location = new System.Drawing.Point(4, 25);
            this.config.Margin = new System.Windows.Forms.Padding(4);
            this.config.Name = "config";
            this.config.Padding = new System.Windows.Forms.Padding(4);
            this.config.Size = new System.Drawing.Size(1161, 725);
            this.config.TabIndex = 1;
            this.config.Text = "Config";
            this.config.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.33333F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel8, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel10, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel9, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel7, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.resolution, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1159, 722);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 3;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel8.Controls.Add(this.textBox7, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.textBox6, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.textBox3, 2, 0);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(197, 133);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(958, 35);
            this.tableLayoutPanel8.TabIndex = 19;
            // 
            // textBox7
            // 
            this.textBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox7.Location = new System.Drawing.Point(323, 4);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(311, 22);
            this.textBox7.TabIndex = 17;
            // 
            // textBox6
            // 
            this.textBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox6.Location = new System.Drawing.Point(4, 4);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(311, 22);
            this.textBox6.TabIndex = 16;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(642, 4);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(312, 22);
            this.textBox3.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.CausesValidation = false;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(74, 138);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 25);
            this.label8.TabIndex = 18;
            this.label8.Text = "URI";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 3;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel10.Controls.Add(this.textBox5, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.textBox4, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.textBox2, 2, 0);
            this.tableLayoutPanel10.Location = new System.Drawing.Point(197, 90);
            this.tableLayoutPanel10.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 1;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(958, 35);
            this.tableLayoutPanel10.TabIndex = 17;
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox5.Location = new System.Drawing.Point(323, 4);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(311, 22);
            this.textBox5.TabIndex = 17;
            this.textBox5.Tag = "LastName";
            this.textBox5.Text = "LastName";
            this.textBox5.Click += new System.EventHandler(this.textBox5_Click);
            this.textBox5.MouseHover += new System.EventHandler(this.textBox5_MouseHover);
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.Location = new System.Drawing.Point(4, 4);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(311, 22);
            this.textBox4.TabIndex = 16;
            this.textBox4.Tag = "FirstName";
            this.textBox4.Text = "FirstName";
            this.textBox4.Click += new System.EventHandler(this.textBox4_Click);
            this.textBox4.MouseHover += new System.EventHandler(this.textBox4_MouseHover);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(642, 4);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(312, 22);
            this.textBox2.TabIndex = 15;
            this.textBox2.Tag = "ORCID";
            this.textBox2.Text = "ORCID";
            this.textBox2.Click += new System.EventHandler(this.textBox2_Click);
            this.textBox2.MouseHover += new System.EventHandler(this.textBox4_MouseHover);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.CausesValidation = false;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 95);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Experimenter";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 3;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel9.Controls.Add(this.domainUpDown5, 1, 0);
            this.tableLayoutPanel9.Controls.Add(this.domainUpDown4, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.textBox1, 2, 0);
            this.tableLayoutPanel9.Location = new System.Drawing.Point(197, 47);
            this.tableLayoutPanel9.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(958, 35);
            this.tableLayoutPanel9.TabIndex = 15;
            // 
            // domainUpDown5
            // 
            this.domainUpDown5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.domainUpDown5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.domainUpDown5.Items.Add("No pattern");
            this.domainUpDown5.Items.Add("One touch");
            this.domainUpDown5.Items.Add("Multi touch");
            this.domainUpDown5.Items.Add("T pattern");
            this.domainUpDown5.Location = new System.Drawing.Point(323, 4);
            this.domainUpDown5.Margin = new System.Windows.Forms.Padding(4);
            this.domainUpDown5.Name = "domainUpDown5";
            this.domainUpDown5.Size = new System.Drawing.Size(311, 22);
            this.domainUpDown5.TabIndex = 14;
            this.domainUpDown5.Tag = "";
            this.domainUpDown5.Text = "choose Pattern";
            this.domainUpDown5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // domainUpDown4
            // 
            this.domainUpDown4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.domainUpDown4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.domainUpDown4.Items.Add("No pattern");
            this.domainUpDown4.Items.Add("One touch");
            this.domainUpDown4.Items.Add("Multi touch");
            this.domainUpDown4.Items.Add("T pattern");
            this.domainUpDown4.Location = new System.Drawing.Point(4, 4);
            this.domainUpDown4.Margin = new System.Windows.Forms.Padding(4);
            this.domainUpDown4.Name = "domainUpDown4";
            this.domainUpDown4.Size = new System.Drawing.Size(311, 22);
            this.domainUpDown4.TabIndex = 13;
            this.domainUpDown4.Tag = "";
            this.domainUpDown4.Text = "choose Pattern";
            this.domainUpDown4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(642, 4);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(312, 22);
            this.textBox1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.CausesValidation = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Save";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel7.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.fileDialog, 0, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(197, 4);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(958, 35);
            this.tableLayoutPanel7.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.CausesValidation = false;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(546, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "none";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fileDialog
            // 
            this.fileDialog.Location = new System.Drawing.Point(4, 4);
            this.fileDialog.Margin = new System.Windows.Forms.Padding(4);
            this.fileDialog.Name = "fileDialog";
            this.fileDialog.Size = new System.Drawing.Size(183, 27);
            this.fileDialog.TabIndex = 4;
            this.fileDialog.Text = "fileDialog";
            this.fileDialog.UseVisualStyleBackColor = true;
            this.fileDialog.Click += new System.EventHandler(this.fileDialog_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.CausesValidation = false;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(49, 52);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Metadata";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resolution
            // 
            this.resolution.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resolution.AutoSize = true;
            this.resolution.Location = new System.Drawing.Point(4, 176);
            this.resolution.Margin = new System.Windows.Forms.Padding(4);
            this.resolution.Name = "resolution";
            this.resolution.Size = new System.Drawing.Size(185, 35);
            this.resolution.TabIndex = 5;
            this.resolution.Text = "High resolution";
            this.resolution.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.resolution.UseVisualStyleBackColor = true;
            // 
            // plot
            // 
            this.plot.Controls.Add(this.formsPlot1);
            this.plot.Controls.Add(this.tableLayoutPanel6);
            this.plot.Location = new System.Drawing.Point(4, 25);
            this.plot.Margin = new System.Windows.Forms.Padding(4);
            this.plot.Name = "plot";
            this.plot.Padding = new System.Windows.Forms.Padding(4);
            this.plot.Size = new System.Drawing.Size(1161, 725);
            this.plot.TabIndex = 0;
            this.plot.Text = "Oscilloscope";
            this.plot.UseVisualStyleBackColor = true;
            // 
            // formsPlot1
            // 
            this.formsPlot1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formsPlot1.Location = new System.Drawing.Point(4, 4);
            this.formsPlot1.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.formsPlot1.Name = "formsPlot1";
            this.formsPlot1.Size = new System.Drawing.Size(1153, 545);
            this.formsPlot1.TabIndex = 1;
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
            this.tableLayoutPanel6.Location = new System.Drawing.Point(4, 549);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 4;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(1153, 172);
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
            this.tableLayoutPanel4.Location = new System.Drawing.Point(196, 133);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(953, 35);
            this.tableLayoutPanel4.TabIndex = 15;
            // 
            // trackBarLaser
            // 
            this.trackBarLaser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarLaser.BackColor = System.Drawing.SystemColors.Window;
            this.trackBarLaser.Location = new System.Drawing.Point(215, 4);
            this.trackBarLaser.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarLaser.Maximum = 100;
            this.trackBarLaser.Name = "trackBarLaser";
            this.trackBarLaser.Size = new System.Drawing.Size(203, 27);
            this.trackBarLaser.TabIndex = 9;
            this.trackBarLaser.Scroll += new System.EventHandler(this.trackBarLaser_Scroll);
            // 
            // laser
            // 
            this.laser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.laser.Enabled = false;
            this.laser.Location = new System.Drawing.Point(637, 4);
            this.laser.Margin = new System.Windows.Forms.Padding(4);
            this.laser.Name = "laser";
            this.laser.Size = new System.Drawing.Size(312, 27);
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
            this.numericUpDownLaser.Location = new System.Drawing.Point(426, 4);
            this.numericUpDownLaser.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownLaser.Name = "numericUpDownLaser";
            this.numericUpDownLaser.ReadOnly = true;
            this.numericUpDownLaser.Size = new System.Drawing.Size(203, 22);
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
            this.pictureLaser.Location = new System.Drawing.Point(4, 4);
            this.pictureLaser.Margin = new System.Windows.Forms.Padding(4);
            this.pictureLaser.Name = "pictureLaser";
            this.pictureLaser.Size = new System.Drawing.Size(203, 27);
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
            this.label5.Location = new System.Drawing.Point(65, 138);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 25);
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
            this.pattern.Location = new System.Drawing.Point(59, 52);
            this.pattern.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pattern.Name = "pattern";
            this.pattern.Size = new System.Drawing.Size(74, 25);
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
            this.tableLayoutPanel5.Controls.Add(this.debug, 2, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(196, 47);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(953, 35);
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
            this.domainUpDown3.Location = new System.Drawing.Point(215, 4);
            this.domainUpDown3.Margin = new System.Windows.Forms.Padding(4);
            this.domainUpDown3.Name = "domainUpDown3";
            this.domainUpDown3.Size = new System.Drawing.Size(203, 22);
            this.domainUpDown3.TabIndex = 13;
            this.domainUpDown3.Tag = "";
            this.domainUpDown3.Text = "White";
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
            this.domainUpDown2.Location = new System.Drawing.Point(4, 4);
            this.domainUpDown2.Margin = new System.Windows.Forms.Padding(4);
            this.domainUpDown2.Name = "domainUpDown2";
            this.domainUpDown2.Size = new System.Drawing.Size(203, 22);
            this.domainUpDown2.TabIndex = 12;
            this.domainUpDown2.Tag = "";
            this.domainUpDown2.Text = "No pattern";
            this.domainUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.domainUpDown2.SelectedItemChanged += new System.EventHandler(this.domainUpDown2_SelectedItemChanged);
            // 
            // patternButton
            // 
            this.patternButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.patternButton.Enabled = false;
            this.patternButton.Location = new System.Drawing.Point(637, 4);
            this.patternButton.Margin = new System.Windows.Forms.Padding(4);
            this.patternButton.Name = "patternButton";
            this.patternButton.Size = new System.Drawing.Size(312, 27);
            this.patternButton.TabIndex = 4;
            this.patternButton.Text = "Pattern";
            this.patternButton.UseVisualStyleBackColor = true;
            this.patternButton.Click += new System.EventHandler(this.patternButton_Click);
            // 
            // debug
            // 
            this.debug.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.debug.Location = new System.Drawing.Point(426, 4);
            this.debug.Margin = new System.Windows.Forms.Padding(4);
            this.debug.Name = "debug";
            this.debug.Size = new System.Drawing.Size(203, 22);
            this.debug.TabIndex = 14;
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
            this.tableLayoutPanel3.Location = new System.Drawing.Point(196, 90);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(953, 35);
            this.tableLayoutPanel3.TabIndex = 10;
            // 
            // trackBarRotation
            // 
            this.trackBarRotation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarRotation.BackColor = System.Drawing.SystemColors.Window;
            this.trackBarRotation.Location = new System.Drawing.Point(215, 4);
            this.trackBarRotation.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarRotation.Maximum = 40;
            this.trackBarRotation.Name = "trackBarRotation";
            this.trackBarRotation.Size = new System.Drawing.Size(203, 27);
            this.trackBarRotation.TabIndex = 9;
            this.trackBarRotation.Scroll += new System.EventHandler(this.trackBarRotation_Scroll);
            // 
            // rotation
            // 
            this.rotation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rotation.Enabled = false;
            this.rotation.Location = new System.Drawing.Point(637, 4);
            this.rotation.Margin = new System.Windows.Forms.Padding(4);
            this.rotation.Name = "rotation";
            this.rotation.Size = new System.Drawing.Size(312, 27);
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
            this.numericUpDownRotation.Location = new System.Drawing.Point(426, 4);
            this.numericUpDownRotation.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownRotation.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.numericUpDownRotation.Name = "numericUpDownRotation";
            this.numericUpDownRotation.ReadOnly = true;
            this.numericUpDownRotation.Size = new System.Drawing.Size(203, 22);
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
            this.domainUpDown1.Location = new System.Drawing.Point(4, 4);
            this.domainUpDown1.Margin = new System.Windows.Forms.Padding(4);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(203, 22);
            this.domainUpDown1.TabIndex = 11;
            this.domainUpDown1.Tag = "";
            this.domainUpDown1.Text = "Sample";
            this.domainUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.domainUpDown1.SelectedItemChanged += new System.EventHandler(this.domainUpDown1_SelectedItemChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.CausesValidation = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(196, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(953, 35);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // serialOpen
            // 
            this.serialOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serialOpen.Image = global::plotBrembs.Properties.Resources._269210;
            this.serialOpen.InitialImage = global::plotBrembs.Properties.Resources._269210;
            this.serialOpen.Location = new System.Drawing.Point(215, 4);
            this.serialOpen.Margin = new System.Windows.Forms.Padding(4);
            this.serialOpen.Name = "serialOpen";
            this.serialOpen.Size = new System.Drawing.Size(203, 27);
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
            this.serialComboBox.Location = new System.Drawing.Point(4, 4);
            this.serialComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.serialComboBox.Name = "serialComboBox";
            this.serialComboBox.Size = new System.Drawing.Size(203, 24);
            this.serialComboBox.TabIndex = 0;
            // 
            // simulationData
            // 
            this.simulationData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.simulationData.Location = new System.Drawing.Point(637, 4);
            this.simulationData.Margin = new System.Windows.Forms.Padding(4);
            this.simulationData.Name = "simulationData";
            this.simulationData.Size = new System.Drawing.Size(312, 27);
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
            this.startSerial.Location = new System.Drawing.Point(426, 4);
            this.startSerial.Margin = new System.Windows.Forms.Padding(4);
            this.startSerial.Name = "startSerial";
            this.startSerial.Size = new System.Drawing.Size(203, 27);
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
            this.label4.Location = new System.Drawing.Point(25, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 25);
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
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1169, 754);
            this.tabControl.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 754);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.config.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.plot.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLaser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLaser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLaser)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
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
        private TabPage plot;
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
        private TextBox debug;
        private Button fileDialog;
        private ScottPlot.FormsPlot formsPlot1;
        private CheckBox resolution;
        private TableLayoutPanel tableLayoutPanel7;
        private Label label1;
        private Label label3;
        private SaveFileDialog saveFileDialog1;
        private Label label6;
        private TableLayoutPanel tableLayoutPanel9;
        private DomainUpDown domainUpDown4;
        private TableLayoutPanel tableLayoutPanel8;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox3;
        private Label label8;
        private TableLayoutPanel tableLayoutPanel10;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox2;
        private Label label7;
        private DomainUpDown domainUpDown5;
        private TextBox textBox1;
        private ToolTip toolTip1;
    }
}

