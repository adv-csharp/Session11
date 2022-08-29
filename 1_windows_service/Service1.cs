using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace _1_windows_service
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            Timer timer = new Timer(); //using System.Timers;
            timer.Interval = 10 * 1000; // 10 * (1000 ms)
            timer.Elapsed += Timer_Elapsed; // Add Event
            timer.Start(); //<-- START ⭐

            /*
             * Command Prompt For VS 2022
             *  installutil <FILE>
             *  
             */
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            File.WriteAllText("d:\\1.txt", $"{DateTime.Now} -- Salam");
        }
        

        protected override void OnStop()
        {
        }
    }
}
