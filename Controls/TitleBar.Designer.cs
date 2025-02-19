using UR_MTrack.Properties;

namespace UR_MTrack
{
    partial class TitleBar
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
            this.tblControlHost = new System.Windows.Forms.TableLayoutPanel();
            this.Divider = new System.Windows.Forms.Label();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAbout = new UR_MTrack.CurveButton();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.pIcon = new System.Windows.Forms.Panel();
            this.tblControlHost.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblControlHost
            // 
            this.tblControlHost.AutoSize = true;
            this.tblControlHost.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblControlHost.BackColor = System.Drawing.Color.Transparent;
            this.tblControlHost.ColumnCount = 6;
            this.tblControlHost.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblControlHost.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblControlHost.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblControlHost.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblControlHost.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblControlHost.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblControlHost.Controls.Add(this.Divider, 0, 1);
            this.tblControlHost.Controls.Add(this.btnCloseForm, 5, 0);
            this.tblControlHost.Controls.Add(this.lblTitle, 1, 0);
            this.tblControlHost.Controls.Add(this.btnAbout, 2, 0);
            this.tblControlHost.Controls.Add(this.btnMinimize, 3, 0);
            this.tblControlHost.Controls.Add(this.btnMaximize, 4, 0);
            this.tblControlHost.Controls.Add(this.pIcon, 0, 0);
            this.tblControlHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblControlHost.Location = new System.Drawing.Point(0, 0);
            this.tblControlHost.Margin = new System.Windows.Forms.Padding(0);
            this.tblControlHost.Name = "tblControlHost";
            this.tblControlHost.RowCount = 2;
            this.tblControlHost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblControlHost.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblControlHost.Size = new System.Drawing.Size(298, 42);
            this.tblControlHost.TabIndex = 0;
            this.tblControlHost.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTitle_MouseDown);
            // 
            // Divider
            // 
            this.Divider.BackColor = System.Drawing.Color.Transparent;
            this.tblControlHost.SetColumnSpan(this.Divider, 6);
            this.Divider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Divider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Divider.Location = new System.Drawing.Point(0, 40);
            this.Divider.Margin = new System.Windows.Forms.Padding(0);
            this.Divider.Name = "Divider";
            this.Divider.Size = new System.Drawing.Size(298, 2);
            this.Divider.TabIndex = 0;
            this.Divider.Text = "Divider";
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCloseForm.BackgroundImage = global::UR_MTrack.Properties.Resources.GradientClose;
            this.btnCloseForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCloseForm.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnCloseForm.FlatAppearance.BorderSize = 0;
            this.btnCloseForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.btnCloseForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseForm.Location = new System.Drawing.Point(263, 7);
            this.btnCloseForm.Margin = new System.Windows.Forms.Padding(2, 2, 10, 2);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(25, 25);
            this.btnCloseForm.TabIndex = 7;
            this.btnCloseForm.UseVisualStyleBackColor = true;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitle.Location = new System.Drawing.Point(95, 8);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(45, 24);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTitle_MouseDown);
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAbout.AutoSizeFont = false;
            this.btnAbout.BackgroundImage = global::UR_MTrack.Properties.Resources.Info;
            this.btnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAbout.BorderColor = System.Drawing.Color.IndianRed;
            this.btnAbout.BorderWidth = 0F;
            this.btnAbout.Checkable = false;
            this.btnAbout.Checked = false;
            this.btnAbout.CheckedColor = System.Drawing.Color.Empty;
            this.btnAbout.CornerRadius = 16;
            this.btnAbout.Enabled = false;
            this.btnAbout.ExtMessage = null;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.GradientBottom = System.Drawing.Color.White;
            this.btnAbout.GradientColoring = true;
            this.btnAbout.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnAbout.GradientTop = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(198)))), ((int)(((byte)(241)))));
            this.btnAbout.HighlightColor = System.Drawing.Color.SeaShell;
            this.btnAbout.HighlightThickness = 0;
            this.btnAbout.Location = new System.Drawing.Point(151, 4);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.RelPos = new float[] {
        0F,
        0.2F,
        0.5F,
        1F};
            this.btnAbout.ShowExtLabel = false;
            this.btnAbout.Size = new System.Drawing.Size(32, 32);
            this.btnAbout.TabIndex = 10;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Visible = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMinimize.BackgroundImage = global::UR_MTrack.Properties.Resources.GradientMinimize;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Location = new System.Drawing.Point(205, 7);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(25, 25);
            this.btnMinimize.TabIndex = 5;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMaximize.BackgroundImage = global::UR_MTrack.Properties.Resources.GradientMaximize;
            this.btnMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMaximize.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.btnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Location = new System.Drawing.Point(234, 7);
            this.btnMaximize.Margin = new System.Windows.Forms.Padding(2);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(25, 25);
            this.btnMaximize.TabIndex = 6;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // pIcon
            // 
            this.pIcon.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pIcon.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pIcon.BackColor = System.Drawing.Color.Transparent;
            this.pIcon.BackgroundImage = global::UR_MTrack.Properties.Resources.ur_logo_wort_bildmarke_weiss;
            this.pIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pIcon.Location = new System.Drawing.Point(3, 4);
            this.pIcon.Name = "pIcon";
            this.pIcon.Size = new System.Drawing.Size(81, 32);
            this.pIcon.TabIndex = 9;
            // 
            // TitleBar
            // 
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(190)))));
            this.Controls.Add(this.tblControlHost);
            this.DoubleBuffered = true;
            this.Name = "TitleBar";
            this.Size = new System.Drawing.Size(298, 42);
            this.tblControlHost.ResumeLayout(false);
            this.tblControlHost.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        System.Windows.Forms.Label Divider;
        System.Windows.Forms.TableLayoutPanel tblControlHost;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pIcon;
        private CurveButton btnAbout;
    }
}
