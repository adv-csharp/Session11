using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.ServiceProcess;
using System.Threading.Tasks;

namespace _1_windows_service
{
    [RunInstaller(true)]
    public partial class ProjectInstaller : System.Configuration.Install.Installer
    {
        public ProjectInstaller()
        {
            InitializeComponent();
        }

        private void serviceProcessInstaller1_AfterInstall(object sender, InstallEventArgs e)
        {
            //Service Start
            //ServiceInstaller serviceInstaller = (ServiceInstaller) sender;


            //using (ServiceController sc = new ServiceController("fadUpdateService"))
            //{
            //    sc.Start();
            //}
        }
    }
}
