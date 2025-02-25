namespace UR_MTrack.Controls
{
    partial class UCtrlChart
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
            this._valueszgc = new ZedGraph.ZedGraphControl();
            this.tblHisto = new System.Windows.Forms.TableLayoutPanel();
            this._histozgc = new ZedGraph.ZedGraphControl();
            this.flowHisto = new System.Windows.Forms.FlowLayoutPanel();
            this.tblMain.SuspendLayout();
            this.tblHisto.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.AutoSize = true;
            this.tblMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblMain.BackColor = System.Drawing.Color.LemonChiffon;
            this.tblMain.ColumnCount = 2;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblMain.Controls.Add(this._valueszgc, 0, 0);
            this.tblMain.Controls.Add(this.tblHisto, 1, 0);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Margin = new System.Windows.Forms.Padding(0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 2;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.Size = new System.Drawing.Size(637, 477);
            this.tblMain.TabIndex = 0;
            // 
            // _valueszgc
            // 
            this._valueszgc.Dock = System.Windows.Forms.DockStyle.Fill;
            this._valueszgc.IsAntiAlias = true;
            this._valueszgc.IsShowCursorValues = true;
            this._valueszgc.Location = new System.Drawing.Point(0, 0);
            this._valueszgc.Margin = new System.Windows.Forms.Padding(0);
            this._valueszgc.Name = "_valueszgc";
            this.tblMain.SetRowSpan(this._valueszgc, 2);
            this._valueszgc.ScrollGrace = 0D;
            this._valueszgc.ScrollMaxX = 0D;
            this._valueszgc.ScrollMaxY = 0D;
            this._valueszgc.ScrollMaxY2 = 0D;
            this._valueszgc.ScrollMinX = 0D;
            this._valueszgc.ScrollMinY = 0D;
            this._valueszgc.ScrollMinY2 = 0D;
            this._valueszgc.Size = new System.Drawing.Size(425, 477);
            this._valueszgc.TabIndex = 0;
            this._valueszgc.UseExtendedPrintDialog = true;
            // 
            // tblHisto
            // 
            this.tblHisto.AutoSize = true;
            this.tblHisto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblHisto.BackColor = System.Drawing.Color.OrangeRed;
            this.tblHisto.ColumnCount = 1;
            this.tblHisto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblHisto.Controls.Add(this._histozgc, 0, 0);
            this.tblHisto.Controls.Add(this.flowHisto, 0, 1);
            this.tblHisto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblHisto.Location = new System.Drawing.Point(428, 0);
            this.tblHisto.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.tblHisto.Name = "tblHisto";
            this.tblHisto.RowCount = 2;
            this.tblMain.SetRowSpan(this.tblHisto, 2);
            this.tblHisto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tblHisto.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblHisto.Size = new System.Drawing.Size(206, 474);
            this.tblHisto.TabIndex = 2;
            // 
            // _histozgc
            // 
            this._histozgc.Dock = System.Windows.Forms.DockStyle.Fill;
            this._histozgc.IsAntiAlias = true;
            this._histozgc.Location = new System.Drawing.Point(0, 0);
            this._histozgc.Margin = new System.Windows.Forms.Padding(0);
            this._histozgc.Name = "_histozgc";
            this._histozgc.ScrollGrace = 0D;
            this._histozgc.ScrollMaxX = 0D;
            this._histozgc.ScrollMaxY = 0D;
            this._histozgc.ScrollMaxY2 = 0D;
            this._histozgc.ScrollMinX = 0D;
            this._histozgc.ScrollMinY = 0D;
            this._histozgc.ScrollMinY2 = 0D;
            this._histozgc.Size = new System.Drawing.Size(206, 200);
            this._histozgc.TabIndex = 1;
            this._histozgc.UseExtendedPrintDialog = true;
            // 
            // flowHisto
            // 
            this.flowHisto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.flowHisto.Location = new System.Drawing.Point(3, 203);
            this.flowHisto.Name = "flowHisto";
            this.flowHisto.Size = new System.Drawing.Size(200, 268);
            this.flowHisto.TabIndex = 2;
            // 
            // UCtrlChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.tblMain);
            this.DoubleBuffered = true;
            this.Name = "UCtrlChart";
            this.Size = new System.Drawing.Size(637, 477);
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            this.tblHisto.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblMain;
        private ZedGraph.ZedGraphControl _valueszgc;
        private ZedGraph.ZedGraphControl _histozgc;
        private System.Windows.Forms.TableLayoutPanel tblHisto;
        private System.Windows.Forms.FlowLayoutPanel flowHisto;
    }
}
