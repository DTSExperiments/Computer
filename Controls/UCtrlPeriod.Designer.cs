namespace UR_MTrack
{
    partial class UCtrlPeriod
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
            this.components = new System.ComponentModel.Container();
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.cmbContingency = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblHeaderDelim = new System.Windows.Forms.Label();
            this.lblHeaderCounter = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.cmbPattern = new System.Windows.Forms.ComboBox();
            this.tbOutcome = new UR_MTrack.WMTextBox();
            this.tbCouplingCoeff = new UR_MTrack.WMTextBox();
            this.tbDuration = new UR_MTrack.WMTextBox();
            this.tblMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.AutoSize = true;
            this.tblMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblMain.BackColor = System.Drawing.Color.White;
            this.tblMain.ColumnCount = 3;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblMain.Controls.Add(this.cmbContingency, 1, 4);
            this.tblMain.Controls.Add(this.tbOutcome, 1, 7);
            this.tblMain.Controls.Add(this.tbCouplingCoeff, 1, 6);
            this.tblMain.Controls.Add(this.label1, 0, 2);
            this.tblMain.Controls.Add(this.lblHeader, 0, 0);
            this.tblMain.Controls.Add(this.label5, 0, 6);
            this.tblMain.Controls.Add(this.label4, 0, 3);
            this.tblMain.Controls.Add(this.label6, 0, 4);
            this.tblMain.Controls.Add(this.label3, 0, 7);
            this.tblMain.Controls.Add(this.label2, 0, 5);
            this.tblMain.Controls.Add(this.label7, 2, 5);
            this.tblMain.Controls.Add(this.lblHeaderDelim, 0, 1);
            this.tblMain.Controls.Add(this.lblHeaderCounter, 1, 0);
            this.tblMain.Controls.Add(this.tbDuration, 1, 5);
            this.tblMain.Controls.Add(this.cmbType, 1, 2);
            this.tblMain.Controls.Add(this.cmbPattern, 1, 3);
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Margin = new System.Windows.Forms.Padding(0);
            this.tblMain.Name = "tblMain";
            this.tblMain.Padding = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.tblMain.RowCount = 8;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.Size = new System.Drawing.Size(264, 196);
            this.tblMain.TabIndex = 0;
            this.tblMain.DoubleClick += new System.EventHandler(this.SelectCtrl_Click);
            // 
            // cmbContingency
            // 
            this.cmbContingency.FormattingEnabled = true;
            this.cmbContingency.Location = new System.Drawing.Point(106, 87);
            this.cmbContingency.Name = "cmbContingency";
            this.cmbContingency.Size = new System.Drawing.Size(98, 21);
            this.cmbContingency.TabIndex = 19;
            this.cmbContingency.DropDownClosed += new System.EventHandler(this.cmb_DropDownClosed);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type";
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHeader.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(37, 5);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(63, 23);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Period ";
            this.lblHeader.DoubleClick += new System.EventHandler(this.SelectCtrl_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(3, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Coup Coefficient";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(3, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Pattern";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(3, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Contingency";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(3, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Outcome";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(3, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Duration";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(210, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "ms";
            // 
            // lblHeaderDelim
            // 
            this.lblHeaderDelim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeaderDelim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(184)))), ((int)(((byte)(0)))));
            this.tblMain.SetColumnSpan(this.lblHeaderDelim, 3);
            this.lblHeaderDelim.Location = new System.Drawing.Point(0, 28);
            this.lblHeaderDelim.Margin = new System.Windows.Forms.Padding(0);
            this.lblHeaderDelim.Name = "lblHeaderDelim";
            this.lblHeaderDelim.Size = new System.Drawing.Size(263, 2);
            this.lblHeaderDelim.TabIndex = 13;
            // 
            // lblHeaderCounter
            // 
            this.lblHeaderCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeaderCounter.AutoSize = true;
            this.lblHeaderCounter.BackColor = System.Drawing.Color.Transparent;
            this.lblHeaderCounter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHeaderCounter.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderCounter.Location = new System.Drawing.Point(106, 5);
            this.lblHeaderCounter.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblHeaderCounter.Name = "lblHeaderCounter";
            this.lblHeaderCounter.Size = new System.Drawing.Size(98, 23);
            this.lblHeaderCounter.TabIndex = 1;
            this.lblHeaderCounter.Text = "1";
            this.lblHeaderCounter.DoubleClick += new System.EventHandler(this.SelectCtrl_Click);
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(106, 33);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(98, 21);
            this.cmbType.TabIndex = 17;
            this.cmbType.DropDownClosed += new System.EventHandler(this.cmb_DropDownClosed);
            // 
            // cmbPattern
            // 
            this.cmbPattern.FormattingEnabled = true;
            this.cmbPattern.Location = new System.Drawing.Point(106, 60);
            this.cmbPattern.Name = "cmbPattern";
            this.cmbPattern.Size = new System.Drawing.Size(98, 21);
            this.cmbPattern.TabIndex = 18;
            this.cmbPattern.DropDownClosed += new System.EventHandler(this.cmb_DropDownClosed);
            // 
            // tbOutcome
            // 
            this.tbOutcome.AllowDelims = true;
            this.tbOutcome.BackColor = System.Drawing.Color.White;
            this.tbOutcome.Font = new System.Drawing.Font("Arial", 9.75F);
            this.tbOutcome.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.tbOutcome.Location = new System.Drawing.Point(106, 170);
            this.tbOutcome.Name = "tbOutcome";
            this.tbOutcome.NumbersOnly = true;
            this.tbOutcome.ShowToolTip = false;
            this.tbOutcome.Size = new System.Drawing.Size(98, 22);
            this.tbOutcome.TabIndex = 16;
            this.tbOutcome.ToolTipText = "ToolTip";
            this.tbOutcome.WatermarkColor = System.Drawing.Color.Silver;
            this.tbOutcome.WatermarkText = "";
            this.tbOutcome.WMFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.tbOutcome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_KeyDown);
            // 
            // tbCouplingCoeff
            // 
            this.tbCouplingCoeff.AllowDelims = true;
            this.tbCouplingCoeff.Font = new System.Drawing.Font("Arial", 9.75F);
            this.tbCouplingCoeff.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.tbCouplingCoeff.Location = new System.Drawing.Point(106, 142);
            this.tbCouplingCoeff.Name = "tbCouplingCoeff";
            this.tbCouplingCoeff.NumbersOnly = true;
            this.tbCouplingCoeff.ShowToolTip = false;
            this.tbCouplingCoeff.Size = new System.Drawing.Size(98, 22);
            this.tbCouplingCoeff.TabIndex = 15;
            this.tbCouplingCoeff.Text = "0";
            this.tbCouplingCoeff.ToolTipText = "ToolTip";
            this.tbCouplingCoeff.WatermarkColor = System.Drawing.Color.Silver;
            this.tbCouplingCoeff.WatermarkText = "0,5";
            this.tbCouplingCoeff.WMFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.tbCouplingCoeff.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_KeyDown);
            // 
            // tbDuration
            // 
            this.tbDuration.AllowDelims = true;
            this.tbDuration.Font = new System.Drawing.Font("Arial", 9.75F);
            this.tbDuration.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.tbDuration.Location = new System.Drawing.Point(106, 114);
            this.tbDuration.Name = "tbDuration";
            this.tbDuration.NumbersOnly = true;
            this.tbDuration.ShowToolTip = false;
            this.tbDuration.Size = new System.Drawing.Size(98, 22);
            this.tbDuration.TabIndex = 14;
            this.tbDuration.Text = "0";
            this.tbDuration.ToolTipText = "ToolTip";
            this.tbDuration.WatermarkColor = System.Drawing.Color.Silver;
            this.tbDuration.WatermarkText = "Time in ms";
            this.tbDuration.WMFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.tbDuration.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_KeyDown);
            // 
            // UCtrlPeriod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tblMain);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UCtrlPeriod";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 2, 2);
            this.Size = new System.Drawing.Size(266, 198);
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblMain;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblHeaderDelim;
        private System.Windows.Forms.Label lblHeaderCounter;
        private WMTextBox tbCouplingCoeff;
        private WMTextBox tbDuration;
        private WMTextBox tbOutcome;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.ComboBox cmbPattern;
        private System.Windows.Forms.ComboBox cmbContingency;
    }
}
