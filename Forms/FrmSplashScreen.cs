﻿using System;
using System.Drawing;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace UR_MTrack

{
    public partial class FrmSplashScreen : Form
    {        
        public FrmSplashScreen()
        {
            InitializeComponent();   
            lblVersion.Text = "Product Version : " + new AboutBox().AssemblyVersion; 
            lblCopyright.Text = new AboutBox().AssemblyCopyright;            
        }
        

    }
}