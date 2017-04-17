using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyLog;


namespace TestLog
{
    public partial class Form1 : Form
    {

        LogWriterEx oLogWriterEx = new LogWriterEx();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            oLogWriterEx.WriteLog("Test","10");
        }
    }
}
