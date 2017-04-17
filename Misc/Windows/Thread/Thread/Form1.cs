using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Web;
using System.Threading;
using System.Diagnostics;

namespace ThreadExample
{
    public partial class Form1 : Form
    {
        public Thread DownloadThread = null;

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            //DownloadThread = new Thread(DownloadThreadFunction);
            //DownloadThread.Start();
            this.progressBar1.Maximum = 100;
            WebClient myClient = new WebClient();
            Uri url = new Uri("http://thenexusgroup.co.uk/videos/funny.mpeg");
            //
            string file = "c:\\January.mpeg";

            myClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressCallback);

            myClient.DownloadFileCompleted += new AsyncCompletedEventHandler(DownloadFileCallBack2);

            myClient.DownloadFileAsync(url, file);
        }
        
        void DownloadProgressCallback(object sender, DownloadProgressChangedEventArgs e)
        {
            this.progressBar1.Value = e.ProgressPercentage;
            this.label1.Text = "File Size: " + e.TotalBytesToReceive / 1024 + " KB";
            this.label2.Text = "Received: " + e.BytesReceived / 1024 + " KB";
            this.label3.Text = e.ProgressPercentage.ToString()+ " %";
        }

        void DownloadFileCallBack2(object sender, AsyncCompletedEventArgs c)
        {
            this.label3.Text = "Download Completed";
        }

        public void DownloadThreadFunction()
        {
            //System.Net.WebClient client = new WebClient();
            //client.DownloadFile("http://thenexusgroup.co.uk/videos/funny.mpeg", "c:\\abc.mpeg");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Process oprocess = new Process();
            string strpath = "C:\\Inetpub\\wwwroot\\uploadLog\\uploadLog\\bin\\Debug" + "\\uploadLog.exe";
            oprocess.StartInfo.FileName = strpath;
            //string LogFilePath = "'"+Environment.ExpandEnvironmentVariables("%USERPROFILE%").ToString() + "\\My Documents\\Acusis\\Wordscript\\Log\\"+"'";
            oprocess.StartInfo.Arguments = "sunil.kumar "+ "\"" + Environment.ExpandEnvironmentVariables("%USERPROFILE%").ToString() + "\\My Documents\\Acusis\\Wordscript\\Log\\"+"\"";
            oprocess.Start();
        }
    }
}