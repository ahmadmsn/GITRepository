using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProcessDemo
{
    public partial class Form1 : Form
    {
        Log oLog;
        public Form1()
        {
            oLog  = new Log();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            oLog.Write();
            ProcessTimer.Start();
        }
        public void CallProcess()
        {
            oLog.Write();
        }

        private void ProcessTimer_Tick(object sender, EventArgs e)
        {
            CallProcess();
            ProcessTimer.Stop();
            ProcessTimer.Start();
        }
    }
}