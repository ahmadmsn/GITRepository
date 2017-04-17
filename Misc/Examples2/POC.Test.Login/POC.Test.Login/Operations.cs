using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;


namespace POC.Test.Login
{
    public partial class Operations : Form
    {
        public FileOperations.UploadDownload oProxy;
        public Operations()
        {
            InitializeComponent();
        }

        //public Operations(string strTextBox)
        //{
        //    InitializeComponent();
        //    lblWelcome.Text = "Welcome  " + strTextBox;
        //}        
        private void btnShowFiles_Click(object sender, EventArgs e)
        {
            String[] m_strFileNames = oProxy.GetFile();           
            lstShowFiles.DataSource = m_strFileNames;            
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Open File";
            openFileDialog1.Filter = "All Files|*.*";
            openFileDialog1.FileName = "";
            try
            {
                openFileDialog1.InitialDirectory = "D:\\";
            }
            catch
            {

            }
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName == "")
                return;
            else
                txtFileName.Text = openFileDialog1.FileName;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (txtFileName.Text != string.Empty)
                UploadFile(txtFileName.Text);
            else
                MessageBox.Show("You must select a file first.", "No File Selected");
        }
        private void UploadFile(string strFileName)
        {
            try
            {
                String m_strFile = Path.GetFileName(strFileName);
               // FileOperations.UploadDownload oSrv = new FileOperations.UploadDownload();
               
                FileInfo oFinfo = new FileInfo(strFileName);
                long m_lBytes = oFinfo.Length;
                double m_dLen = Convert.ToDouble(oFinfo.Length / 1000000);
                if (m_dLen < 4)
                {
                    FileStream oFileStream = new FileStream(strFileName, FileMode.Open, FileAccess.Read);
                    BinaryReader oBr = new BinaryReader(oFileStream);
                    byte[] m_byData = oBr.ReadBytes((int)m_lBytes);
                    oBr.Close();
                    string m_strTmp = oProxy.UploadFile(m_byData, m_strFile);
                    oFileStream.Close();
                    oFileStream.Dispose();
                    MessageBox.Show("File Upload Status: " + m_strTmp, "File Upload");
                }
                else
                {
                    MessageBox.Show("The file selected exceeds the size limit for uploads.", "File Size");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Upload Error");
            }

        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            string m_strFileName = lstShowFiles.SelectedItem.ToString();
            string m_strFilePath = @"D:\ad\User\" + m_strFileName;
            saveFileDialog1.FileName = m_strFileName;
            saveFileDialog1.Filter = "RichText Files (*.rtf)|*.RTF|Text Files (*.txt)|*.TXT" +
                      "|All files (*.*)|*.*";
            //saveFileDialog1.ShowDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream oFileStream = null;
               
               // FileOperations.UploadDownload oDownload = new FileOperations.UploadDownload();
                
                byte[] m_byBytes = null;
                m_byBytes = oProxy.DownloadFile(m_strFilePath);
                //Response.AddHeader("Content-Disposition", "attachment; filename=" + filename);
                oFileStream = new FileStream(saveFileDialog1.FileName, FileMode.Create);
                oFileStream.Write(m_byBytes, 0, m_byBytes.Length);
                oFileStream.Close();
                oFileStream = null;
            }
            lblShow.Text = "File Downloaded SuccessFully.............";
        }

        private void Operations_Load(object sender, EventArgs e)
        {
            //Operations op1 = new Operations();
            //op1.Close();
            //LoginPage oL1 = new LoginPage(this);
            //oL1.ShowDialog();
            //string str = oL1.
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();

           
            
            //oClose.close
            LoginPage oLogOut = new LoginPage();
            oLogOut.Show();
            
        }

        private void Operations_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }
    }
}