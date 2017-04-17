using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ProcessDemo
{
    class Log
    {
        public void Write()
        {
            //FileStream fs = new FileStream(@"C:\Temp\ProcessLog" +System.DateTime.Now.Ticks +".txt", FileMode.Create);
            StreamWriter sw = File.AppendText(@"C:\Temp\ProcessTemp\ProcessLog" + System.DateTime.Now.Ticks + ".txt");
            sw.WriteLine("Process Time is " + DateTime.Now);
            sw.Close();
        }
    }
}
