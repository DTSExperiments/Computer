using System.Windows.Forms;
using Label = System.Windows.Forms.Label;


namespace UR_MTrack
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.periodsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.tblLogBox = new System.Windows.Forms.TableLayoutPanel();
            this.rtbLogBox = new System.Windows.Forms.RichTextBox();
            this.tblControlHost = new System.Windows.Forms.TableLayoutPanel();
            this.flpHistoCollection = new System.Windows.Forms.FlowLayoutPanel();
            this.tBarMain = new UR_MTrack.TitleBar();
            this.btnAbout = new UR_MTrack.CurveButton();
            this.btnCollapseLog = new UR_MTrack.CurveButton();
            this.tblHisto = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.tblMain.SuspendLayout();
            this.tblLogBox.SuspendLayout();
            this.tblControlHost.SuspendLayout();
            this.tblHisto.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmFiles,
            this.settingsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 35);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(997, 46);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmFiles
            // 
            this.tsmFiles.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmNew,
            this.tsmSave,
            this.tsmOpen,
            this.exitToolStripMenuItem});
            this.tsmFiles.Name = "tsmFiles";
            this.tsmFiles.Size = new System.Drawing.Size(45, 42);
            this.tsmFiles.Text = "Files";
            // 
            // tsmNew
            // 
            this.tsmNew.Name = "tsmNew";
            this.tsmNew.Size = new System.Drawing.Size(177, 22);
            this.tsmNew.Text = "New";
            this.tsmNew.Click += new System.EventHandler(this.tsmNew_Click);
            // 
            // tsmSave
            // 
            this.tsmSave.Name = "tsmSave";
            this.tsmSave.Size = new System.Drawing.Size(177, 22);
            this.tsmSave.Text = "Save";
            this.tsmSave.Click += new System.EventHandler(this.tsmSave_Click);
            // 
            // tsmOpen
            // 
            this.tsmOpen.Name = "tsmOpen";
            this.tsmOpen.Size = new System.Drawing.Size(177, 22);
            this.tsmOpen.Text = "Open Experiment";
            this.tsmOpen.Click += new System.EventHandler(this.tsmOpen_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.periodsToolStripMenuItem,
            this.configurationToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(66, 42);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // periodsToolStripMenuItem
            // 
            this.periodsToolStripMenuItem.Name = "periodsToolStripMenuItem";
            this.periodsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.periodsToolStripMenuItem.Text = "Periods";
            this.periodsToolStripMenuItem.Click += new System.EventHandler(this.periodsToolStripMenuItem_Click);
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.configurationToolStripMenuItem.Text = "Configuration";
            this.configurationToolStripMenuItem.Click += new System.EventHandler(this.configurationToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.AutoToolTip = true;
            this.aboutToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(47, 42);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tblMain
            // 
            this.tblMain.AutoSize = true;
            this.tblMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblMain.BackColor = System.Drawing.Color.White;
            this.tblMain.ColumnCount = 2;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblMain.Controls.Add(this.menuStrip1, 0, 1);
            this.tblMain.Controls.Add(this.tBarMain, 0, 0);
            this.tblMain.Controls.Add(this.btnAbout, 1, 1);
            this.tblMain.Controls.Add(this.tblLogBox, 0, 3);
            this.tblMain.Controls.Add(this.tblControlHost, 0, 2);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 5;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.Size = new System.Drawing.Size(1070, 744);
            this.tblMain.TabIndex = 3;
            // 
            // tblLogBox
            // 
            this.tblLogBox.AutoSize = true;
            this.tblLogBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblLogBox.ColumnCount = 1;
            this.tblMain.SetColumnSpan(this.tblLogBox, 2);
            this.tblLogBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLogBox.Controls.Add(this.btnCollapseLog, 0, 0);
            this.tblLogBox.Controls.Add(this.rtbLogBox, 0, 1);
            this.tblLogBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLogBox.Location = new System.Drawing.Point(0, 634);
            this.tblLogBox.Margin = new System.Windows.Forms.Padding(0);
            this.tblLogBox.Name = "tblLogBox";
            this.tblLogBox.RowCount = 2;
            this.tblLogBox.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLogBox.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLogBox.Size = new System.Drawing.Size(1070, 110);
            this.tblLogBox.TabIndex = 8;
            // 
            // rtbLogBox
            // 
            this.rtbLogBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rtbLogBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbLogBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbLogBox.ForeColor = System.Drawing.Color.Silver;
            this.rtbLogBox.Location = new System.Drawing.Point(2, 14);
            this.rtbLogBox.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rtbLogBox.Name = "rtbLogBox";
            this.rtbLogBox.Size = new System.Drawing.Size(1066, 96);
            this.rtbLogBox.TabIndex = 1;
            this.rtbLogBox.Text = "";
            // 
            // tblControlHost
            // 
            this.tblControlHost.AutoSize = true;
            this.tblControlHost.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblControlHost.ColumnCount = 3;
            this.tblMain.SetColumnSpan(this.tblControlHost, 2);
            this.tblControlHost.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblControlHost.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblControlHost.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblControlHost.Controls.Add(this.tblHisto, 2, 0);
            this.tblControlHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblControlHost.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tblControlHost.Location = new System.Drawing.Point(3, 81);
            this.tblControlHost.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.tblControlHost.Name = "tblControlHost";
            this.tblControlHost.RowCount = 1;
            this.tblControlHost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblControlHost.Size = new System.Drawing.Size(1064, 550);
            this.tblControlHost.TabIndex = 9;
            // 
            // flpHistoCollection
            // 
            this.flpHistoCollection.AutoScroll = true;
            this.flpHistoCollection.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpHistoCollection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.flpHistoCollection.Location = new System.Drawing.Point(3, 203);
            this.flpHistoCollection.MaximumSize = new System.Drawing.Size(200, 0);
            this.flpHistoCollection.Name = "flpHistoCollection";
            this.flpHistoCollection.Size = new System.Drawing.Size(194, 338);
            this.flpHistoCollection.TabIndex = 0;
            // 
            // tBarMain
            // 
            this.tBarMain.AbtImg = null;
            this.tBarMain.AbtVisible = false;
            this.tBarMain.AutoSize = true;
            this.tBarMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tBarMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(195)))));
            this.tBarMain.ButtonVisible = false;
            this.tBarMain.CloseImg = ((System.Drawing.Image)(resources.GetObject("tBarMain.CloseImg")));
            this.tblMain.SetColumnSpan(this.tBarMain, 2);
            this.tBarMain.CtrlBxVisible = true;
            this.tBarMain.DivColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(184)))), ((int)(((byte)(0)))));
            this.tBarMain.DivHeight = 4;
            this.tBarMain.DivVisible = true;
            this.tBarMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tBarMain.ForeColor = System.Drawing.Color.Gainsboro;
            this.tBarMain.FormIcon = ((System.Drawing.Image)(resources.GetObject("tBarMain.FormIcon")));
            this.tBarMain.GradientAngle = 0F;
            this.tBarMain.GrColor = System.Drawing.Color.DimGray;
            this.tBarMain.IconSize = new System.Drawing.Size(60, 25);
            this.tBarMain.Location = new System.Drawing.Point(0, 0);
            this.tBarMain.Margin = new System.Windows.Forms.Padding(0);
            this.tBarMain.MaxImg = ((System.Drawing.Image)(resources.GetObject("tBarMain.MaxImg")));
            this.tBarMain.MiniImg = ((System.Drawing.Image)(resources.GetObject("tBarMain.MiniImg")));
            this.tBarMain.Name = "tBarMain";
            this.tBarMain.RelPos = new float[] {
        0F,
        0.2F,
        0.8F};
            this.tBarMain.ShowIcon = true;
            this.tBarMain.Size = new System.Drawing.Size(1070, 35);
            this.tBarMain.TabIndex = 5;
            this.tBarMain.Titel = "Title Text";
            this.tBarMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveFrame_MouseDown);
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAbout.AutoSizeFont = false;
            this.btnAbout.BackColor = System.Drawing.Color.Transparent;
            this.btnAbout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAbout.BackgroundImage")));
            this.btnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAbout.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAbout.BorderWidth = 0F;
            this.btnAbout.Checkable = false;
            this.btnAbout.Checked = false;
            this.btnAbout.CheckedColor = System.Drawing.Color.Empty;
            this.btnAbout.CornerRadius = 10;
            this.btnAbout.ExtMessage = null;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.ForeColor = System.Drawing.Color.DimGray;
            this.btnAbout.GradientBottom = System.Drawing.Color.Transparent;
            this.btnAbout.GradientColoring = true;
            this.btnAbout.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnAbout.GradientTop = System.Drawing.Color.Transparent;
            this.btnAbout.HighlightColor = System.Drawing.Color.SeaShell;
            this.btnAbout.HighlightThickness = 0;
            this.btnAbout.Location = new System.Drawing.Point(1000, 38);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.RelPos = new float[] {
        0F,
        0.1F,
        0.8F,
        1F};
            this.btnAbout.ShowExtLabel = false;
            this.btnAbout.Size = new System.Drawing.Size(40, 40);
            this.btnAbout.TabIndex = 6;
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Visible = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnCollapseLog
            // 
            this.btnCollapseLog.AutoSizeFont = false;
            this.btnCollapseLog.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCollapseLog.BorderWidth = 0F;
            this.btnCollapseLog.Checkable = false;
            this.btnCollapseLog.Checked = false;
            this.btnCollapseLog.CheckedColor = System.Drawing.Color.Empty;
            this.btnCollapseLog.CornerRadius = 1;
            this.btnCollapseLog.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCollapseLog.ExtMessage = null;
            this.btnCollapseLog.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCollapseLog.GradientBottom = System.Drawing.Color.DimGray;
            this.btnCollapseLog.GradientColoring = true;
            this.btnCollapseLog.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnCollapseLog.GradientTop = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCollapseLog.HighlightColor = System.Drawing.Color.Coral;
            this.btnCollapseLog.HighlightThickness = 2;
            this.btnCollapseLog.Location = new System.Drawing.Point(0, 0);
            this.btnCollapseLog.Margin = new System.Windows.Forms.Padding(0);
            this.btnCollapseLog.Name = "btnCollapseLog";
            this.btnCollapseLog.RelPos = new float[] {
        0F,
        0.1F,
        0.5F,
        1F};
            this.btnCollapseLog.ShowExtLabel = false;
            this.btnCollapseLog.Size = new System.Drawing.Size(1070, 14);
            this.btnCollapseLog.TabIndex = 0;
            this.btnCollapseLog.Text = "Trace Log";
            this.btnCollapseLog.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCollapseLog.UseVisualStyleBackColor = true;
            this.btnCollapseLog.Click += new System.EventHandler(this.btnCollapseLog_Click);
            // 
            // tblHisto
            // 
            this.tblHisto.ColumnCount = 1;
            this.tblHisto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblHisto.Controls.Add(this.flpHistoCollection, 0, 1);
            this.tblHisto.Dock = System.Windows.Forms.DockStyle.Right;
            this.tblHisto.Location = new System.Drawing.Point(861, 3);
            this.tblHisto.Name = "tblHisto";
            this.tblHisto.RowCount = 2;
            this.tblHisto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tblHisto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblHisto.Size = new System.Drawing.Size(200, 544);
            this.tblHisto.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(1070, 744);
            this.ControlBox = false;
            this.Controls.Add(this.tblMain);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "Main";            
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            this.tblLogBox.ResumeLayout(false);
            this.tblControlHost.ResumeLayout(false);
            this.tblHisto.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private SaveFileDialog saveFileDialog1;
        private ToolTip toolTip1;
        private OpenFileDialog openFileDialog1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsmFiles;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private TableLayoutPanel tblMain;
        private TitleBar tBarMain;
        private CurveButton btnAbout;
        private ToolStripMenuItem tsmNew;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem tsmSave;
        private ToolStripMenuItem tsmOpen;
        private ToolStripMenuItem periodsToolStripMenuItem;
        private ToolStripMenuItem configurationToolStripMenuItem;
        private TableLayoutPanel tblLogBox;
        private CurveButton btnCollapseLog;
        private RichTextBox rtbLogBox;
        private TableLayoutPanel tblControlHost;
        private FlowLayoutPanel flpHistoCollection;
        private TableLayoutPanel tblHisto;
    }
}

