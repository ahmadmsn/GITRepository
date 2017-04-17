using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace Acusis.Poc.FileOperations
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
        //UserName is 'a' and Password is 'a'
        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            //FileOperations.UploadDownload oLoginPage = new FileOperations.UploadDownload();
           
           // string m_strAuthenticate = oProxy.AuthenticateUser(txtUserName.Text, txtPassword.Text);
            string m_strAuthenticate = "WELCOME";
            if (m_strAuthenticate == "WELCOME")
            {
                lblError.Visible = false;                
                Operations oObj = new Operations(txtUserName.Text);
                oObj.oProxy = oProxy;
                oObj.Show();
                this.Hide();
            }
            else
            {
                txtUserName.Text = "";
                txtPassword.Text = "";
                lblError.Visible = true;
            }
            //LoginPage lp = new LoginPage();
            //lp.Visible = false;
            //lp.Enabled = false;
            
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                MessageBox.Show("Hi");
                //btnLogin_Click(object sender, KeyPressEventArgs e);                
            }
        }

        private void LoginPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        
}
}
       

       
          