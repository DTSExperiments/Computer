using System;
using System.Drawing;
using System.Reflection;
//using System.Threading;
using System.Windows.Forms;

namespace UR_MTrack
{
    public partial class FrmSplashScreen : Form
    {
        Timer _shutdown = new Timer();  
        public FrmSplashScreen()
        {
            _shutdown.Interval = 3000;
            _shutdown.Tick += _shutdown_Tick;
            _shutdown.Start();
            InitializeComponent();   
            lblVersion.Text = "Product Version : " + new AboutBox().AssemblyVersion; 
            lblCopyright.Text = new AboutBox().AssemblyCopyright;            
        }

        private void _shutdown_Tick(object sender, EventArgs e)
        {
            _shutdown.Stop();
            Dispose();
        }

        public string Message { get { return lblMsg.Text; } set { lblMsg.Text = value; } }

        public new void Dispose()
        {
            _shutdown.Tick -= _shutdown_Tick;
            _shutdown.Dispose();
            base.Dispose(true);
        }
    }
}