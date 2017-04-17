using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace POC.Test.Login
{
    public partial class LoginPage : Form
    {    
        FileOperations.UploadDownload oProxy;
        public LoginPage()
        {
            InitializeComponent();
            
            oProxy = new FileOperations.UploadDownload();
            CookieContainer oContainer = new CookieContainer();
            oProxy.CookieContainer = oContainer;
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            string str = webBrowser1.Url.ToString();
           
            if (str.Contains("default.aspx"))
            {
                Operations oObj = new Operations();
                oObj.Show();

                Visible = false; 
                oObj.oProxy = oProxy;
            }
           
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }        
    }
}

  
