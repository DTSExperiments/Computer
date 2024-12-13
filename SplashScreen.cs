using System;
using System.Drawing;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace PreSens.VisiSensVS
{
    public partial class SplashScreen : Form
    {
        private System.Windows.Forms.Timer myTimer;
        // Fade in by increasing the opacity of the splash to 1.0 
        bool fadeIn = true;
        bool fadeOut = false;
        public bool DBCheckAndCreated { get; set; }
        public SplashScreen()
        {
            InitializeComponent();

            this.SuspendLayout();
            this.labelProductName.Visible = true;
            this.labelProductName.Text = this.AssemblyDescription;
            this.labelVersion.Text = "Product Version : " + this.AssemblyVersion; //2.10"; //AssemblyProduct; String.Format("Version {0}", AssemblyVersion);
            this.labelCopyright.Text = AssemblyCopyright;
            this.labelCompanyName.Text = AssemblyCompany;
            this.Opacity = 0.1;
            DBCheckAndCreated = false;
            this.myTimer = new System.Windows.Forms.Timer { Interval = 10 };
            this.myTimer.Tick += new System.EventHandler(myTimer_Tick);
            this.myTimer.Start();
            this.ResumeLayout();
        }

        void myTimer_Tick(object sender, System.EventArgs e)
        {
            this.lblMsg.SuspendLayout();
            this.lblMsg.Text = String.Empty;
            if (fadeIn)
            {
                if (this.Opacity < 1.0)
                {
                    this.Opacity += 0.02;
                }
                // After fadeIn complete, begin fadeOut 
                else
                {
                    fadeIn = false;
                    fadeOut = true;
                }
            }
            else if (fadeOut) // Fade out by increasing the opacity of the splash to 1.0 
            {
                if (!DBCheckAndCreated)
                {
                    DBCheckAndCreated = true;
                    try
                    {
                        this.myTimer.Stop();
                        try
                        {
                            this.lblMsg.Text = @"Checking admin directory...";
                          //  VSVariableMapping.CheckAndCreateAdminDir();
                            this.lblMsg.Text = @"Checking and cleaning log directory...";
                       
                        }
                        catch (SystemException sysEx)
                        {
                            //MessageBox.Show(@"Other instance is already in use. Please close the other system to start new instance.", @"System already in use!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            //Application.Exit();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.StackTrace, @"Error!");
                            Application.Exit();
                        }
                        this.lblMsg.Text = @"Checking application settings...";
                        this.lblMsg.Refresh();

                        try
                        {
                            //string filenameWithPath = VSVariableMapping.GetAdminDirectory() + VSVariableMapping.VSApplicationSettingsFile;
                            //if (!VSVariableMapping.CheckAndCreateApplicationSettings())
                            //{
                            //    MyAppSettings.SaveDefaultApplicationSettings(filenameWithPath);
                            //}
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        Thread.Sleep(200);
                        DBCheckAndCreated = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        this.myTimer.Start();
                    }
                }
                if (this.Opacity > 0)
                {
                    this.Opacity -= 0.02;
                }
                else
                {
                    fadeOut = false;
                }
            }


            // After fadeIn and fadeOut complete, stop the timer and close this splash. 
            if (!(fadeIn || fadeOut))
            {
                myTimer.Stop();
                this.Close();
            }
            this.lblMsg.ResumeLayout();
        }
        

        #region Assembly Attribute Accessors
        public string AssemblyInformationalVersion
        {
            get
            {
                //object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                object[] attributes = Assembly.GetEntryAssembly().GetCustomAttributes(typeof(AssemblyInformationalVersionAttribute), false) as AssemblyInformationalVersionAttribute[];
                ////if (attributes.Length > 0)
                ////{
                ////    string assyName = attr[0].InformationalVersion;
                ////}
                if (attributes.Length > 0)
                {
                    AssemblyInformationalVersionAttribute InformationVersion = (AssemblyInformationalVersionAttribute)attributes[0];
                    //AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (InformationVersion.InformationalVersion != "")
                    {
                        return InformationVersion.InformationalVersion;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }


        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }

        #endregion Assembly Attribute Accessors

    }
}