using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowPosition
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            m_oWelcomeForm = new Form();
            m_oWelcomeForm.ShowInTaskbar = false;
            m_oWelcomeForm.Visible = true;
            m_oWelcomeForm.FormBorderStyle = FormBorderStyle.None;

            //Int32 StartPosX = Screen.PrimaryScreen. - m_oWelcomeForm.Width;
            //Int32 StartPosY = Screen.PrimaryScreen.WorkingArea.Height;
            //SetWindowPos(m_oWelcomeForm.Handle, HWND_TOPMOST, StartPosX, StartPosY, m_oWelcomeForm.Width, m_oWelcomeForm.Height, SWP_NOACTIVATE);
            //SetWindowPos(m_oWelcomeForm.Handle, HWND_TOPMOST, 250, 200, 458, 316, SWP_NOACTIVATE);            


        }
    }
}