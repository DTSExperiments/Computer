namespace UR_MTrack
{
    partial class AboutBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutBox));
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.labelCompanyName = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.tBar = new UR_MTrack.TitleBar();
            this.tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.AutoSize = true;
            this.tblMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblMain.BackColor = System.Drawing.Color.White;
            this.tblMain.ColumnCount = 2;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblMain.Controls.Add(this.label1, 1, 5);
            this.tblMain.Controls.Add(this.logoPictureBox, 0, 1);
            this.tblMain.Controls.Add(this.labelProductName, 1, 1);
            this.tblMain.Controls.Add(this.labelVersion, 1, 2);
            this.tblMain.Controls.Add(this.labelCopyright, 1, 3);
            this.tblMain.Controls.Add(this.labelCompanyName, 1, 4);
            this.tblMain.Controls.Add(this.okButton, 1, 7);
            this.tblMain.Controls.Add(this.textBoxDescription, 1, 6);
            this.tblMain.Controls.Add(this.tBar, 1, 0);
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Margin = new System.Windows.Forms.Padding(0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 8;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.Size = new System.Drawing.Size(387, 329);
            this.tblMain.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label1.Location = new System.Drawing.Point(147, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 15, 3, 0);
            this.label1.MaximumSize = new System.Drawing.Size(0, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "Desription";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.logoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoPictureBox.Image = global::UR_MTrack.Properties.Resources.ur_logo_wort_bildmarke_weiss;
            this.logoPictureBox.Location = new System.Drawing.Point(0, 30);
            this.logoPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.logoPictureBox.Name = "logoPictureBox";
            this.tblMain.SetRowSpan(this.logoPictureBox, 7);
            this.logoPictureBox.Size = new System.Drawing.Size(141, 299);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 12;
            this.logoPictureBox.TabStop = false;
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.labelProductName.Location = new System.Drawing.Point(147, 45);
            this.labelProductName.Margin = new System.Windows.Forms.Padding(6, 15, 3, 0);
            this.labelProductName.MaximumSize = new System.Drawing.Size(0, 17);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(84, 15);
            this.labelProductName.TabIndex = 19;
            this.labelProductName.Text = "Product Name";
            this.labelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.labelVersion.Location = new System.Drawing.Point(147, 65);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(6, 5, 3, 0);
            this.labelVersion.MaximumSize = new System.Drawing.Size(0, 17);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(45, 13);
            this.labelVersion.TabIndex = 0;
            this.labelVersion.Text = "Version";
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCopyright
            // 
            this.labelCopyright.AutoSize = true;
            this.labelCopyright.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.labelCopyright.Location = new System.Drawing.Point(147, 83);
            this.labelCopyright.Margin = new System.Windows.Forms.Padding(6, 5, 3, 0);
            this.labelCopyright.MaximumSize = new System.Drawing.Size(0, 17);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(58, 13);
            this.labelCopyright.TabIndex = 21;
            this.labelCopyright.Text = "Copyright";
            this.labelCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.AutoSize = true;
            this.labelCompanyName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.labelCompanyName.Location = new System.Drawing.Point(147, 101);
            this.labelCompanyName.Margin = new System.Windows.Forms.Padding(6, 5, 3, 0);
            this.labelCompanyName.MaximumSize = new System.Drawing.Size(0, 17);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(87, 13);
            this.labelCompanyName.TabIndex = 22;
            this.labelCompanyName.Text = "Company Name";
            this.labelCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDescription.BackColor = System.Drawing.Color.White;
            this.textBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDescription.Location = new System.Drawing.Point(147, 153);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.Size = new System.Drawing.Size(237, 137);
            this.textBoxDescription.TabIndex = 23;
            this.textBoxDescription.TabStop = false;
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.BackColor = System.Drawing.Color.White;
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.okButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.okButton.FlatAppearance.BorderSize = 0;
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.okButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.okButton.Location = new System.Drawing.Point(277, 296);
            this.okButton.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(100, 30);
            this.okButton.TabIndex = 24;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
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
            this.tblMain.SetColumnSpan(this.tBar, 2);
            this.tBar.CtrlBxVisible = false;
            this.tBar.DivColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(184)))), ((int)(((byte)(0)))));
            this.tBar.DivHeight = 2;
            this.tBar.DivVisible = false;
            this.tBar.FormIcon = ((System.Drawing.Image)(resources.GetObject("tBar.FormIcon")));
            this.tBar.GradientAngle = 0F;
            this.tBar.GrColor = System.Drawing.Color.DimGray;
            this.tBar.IconSize = new System.Drawing.Size(34, 24);
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
            this.tBar.Size = new System.Drawing.Size(387, 30);
            this.tBar.TabIndex = 25;
            this.tBar.TabStop = false;
            this.tBar.Titel = "";
            // 
            // AboutBox
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(538, 370);
            this.Controls.Add(this.tblMain);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutBox";
            this.Padding = new System.Windows.Forms.Padding(1, 0, 2, 1);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "VisiSensVSAboutBox";
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblMain;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label label1;
        private TitleBar tBar;
    }
}
