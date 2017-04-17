using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.ServiceProcess;
using System.Text;
using System.IO;

namespace MyService2
{
    public partial class MyService2 : ServiceBase
    {
        System.Timers.Timer t1 = null;
        public MyService2()
        {
            InitializeComponent();
            t1 = new System.Timers.Timer();
            t1.Elapsed += new System.Timers.ElapsedEventHandler(t1_Elapsed);
        }

      
        protected override void OnStart(string[] args)
        {
            // TODO: Add code here to start your service.
            //FileStream fs = new FileStream(@"c:\temp\service2.txt", FileAccess.ReadWrite);
                //File.Create(@"c:\temp\service2.txt");
                //new FileStream(@"c:\temp\test.txt");
            //StreamWriter sw = File.AppendText(@"c:\temp\service2.txt");
            //sw.WriteLine("Service is started");
            //sw.Close();
            //System.Timers.Timer t1 = new System.Timers.Timer(1000);
            //t1.Elapsed += new System.Timers.ElapsedEventHandler(t1_Elapsed);
           
            //fs.Close();
            t1.Start();
        }

        void t1_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            StreamWriter sw = File.AppendText(@"c:\temp\service2.txt");
            sw.WriteLine("Service is started");
            sw.Close();
            //throw new Exception("The method or operation is not implemented.");
        }

        protected override void OnStop()
        {
            // TODO: Add code here to perform any tear-down necessary to stop your service.
            //FileStream fs = File.Create(@"c:\temp\service2.txt");//, null, FileOptions.None, FileAccess.ReadWrite);
            //System.Timers.Timer t2 = new System.Timers.Timer(1000);
            //StreamWriter sw = File.AppendText(@"c:\temp\service2.txt");
            //sw.WriteLine("Service is closed");
            //sw.Close();
           //t2.Elapsed += new System.Timers.ElapsedEventHandler(t2_Elapsed);
           //fs.Close();
            t1.Stop();
        }

        //void t2_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        //{
        //    StreamWriter sw = File.AppendText(@"c:\temp\service2.txt");
        //    sw.WriteLine("Service is closed");
        //    sw.Close();
        //    //throw new Exception("The method or operation is not implemented.");
        //}
    }
} 
