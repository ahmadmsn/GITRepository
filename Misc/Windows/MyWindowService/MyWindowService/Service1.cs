using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.ServiceProcess;
using System.Text;
using System.Windows;
using System.Timers;
using System.IO;


namespace MyWindowService
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            // TODO: Add code here to start your service.
            FileStream fs = new FileStream(@"c:\temp\mcWindowsService.txt",
            FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter m_streamWriter = new StreamWriter(fs);
            m_streamWriter.BaseStream.Seek(0, SeekOrigin.End);
            m_streamWriter.WriteLine(" mcWindowsService: Service Started \n");
            m_streamWriter.Flush();
            m_streamWriter.Close(); 
            
        }

        protected override void OnStop()
        {
            // TODO: Add code here to perform any tear-down necessary to stop your service.
            FileStream fs = new FileStream(@"c:\temp\mcWindowsService.txt",
            FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter m_streamWriter = new StreamWriter(fs);
            m_streamWriter.BaseStream.Seek(0, SeekOrigin.End);
            m_streamWriter.WriteLine(" mcWindowsService: Service Stopped \n"); m_streamWriter.Flush();
            m_streamWriter.Close(); 
        }
    }
}
