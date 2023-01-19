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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.plot = new System.Windows.Forms.TabPage();
            this.config = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.simulationData = new System.Windows.Forms.Button();
            this.startSerial = new System.Windows.Forms.Button();
            this.serialComboBox = new System.Windows.Forms.ComboBox();
            this.Threads = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.plot.SuspendLayout();
            this.config.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // plot
            // 
            this.plot.Controls.Add(this.chart1);
            this.plot.Location = new System.Drawing.Point(4, 22);
            this.plot.Name = "plot";
            this.plot.Padding = new System.Windows.Forms.Padding(3);
            this.plot.Size = new System.Drawing.Size(869, 587);
            this.plot.TabIndex = 0;
            this.plot.Text = "Plot";
            this.plot.UseVisualStyleBackColor = true;
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.simulationData, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.startSerial, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.serialComboBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Threads, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 450F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(849, 503);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // simulationData
            // 
            this.simulationData.Location = new System.Drawing.Point(427, 30);
            this.simulationData.Name = "simulationData";
            this.simulationData.Size = new System.Drawing.Size(64, 20);
            this.simulationData.TabIndex = 4;
            this.simulationData.Text = "Simulation";
            this.simulationData.UseVisualStyleBackColor = true;
            this.simulationData.Click += new System.EventHandler(this.simulateData_Click);
            // 
            // startSerial
            // 
            this.startSerial.Location = new System.Drawing.Point(3, 30);
            this.startSerial.Name = "startSerial";
            this.startSerial.Size = new System.Drawing.Size(64, 20);
            this.startSerial.TabIndex = 2;
            this.startSerial.Text = "Start";
            this.startSerial.UseVisualStyleBackColor = true;
            this.startSerial.Click += new System.EventHandler(this.startSerial_Click);
            // 
            // serialComboBox
            // 
            this.serialComboBox.FormattingEnabled = true;
            this.serialComboBox.Location = new System.Drawing.Point(3, 3);
            this.serialComboBox.Name = "serialComboBox";
            this.serialComboBox.Size = new System.Drawing.Size(418, 21);
            this.serialComboBox.TabIndex = 0;
            // 
            // Threads
            // 
            this.Threads.Location = new System.Drawing.Point(3, 56);
            this.Threads.Name = "Threads";
            this.Threads.Size = new System.Drawing.Size(64, 20);
            this.Threads.TabIndex = 3;
            this.Threads.Text = "Thread";
            this.Threads.UseVisualStyleBackColor = true;
            this.Threads.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.plot);
            this.tabControl.Controls.Add(this.config);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(877, 613);
            this.tabControl.TabIndex = 1;
            // 
            // chart1
            // 
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(863, 581);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
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
            this.plot.ResumeLayout(false);
            this.config.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabPage plot;
        private TabPage config;
        private TabControl tabControl;
        private TableLayoutPanel tableLayoutPanel1;
        private ComboBox serialComboBox;
        private Button startSerial;
        private Button Threads;
        private Button simulationData;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

