using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PassValue
{
    public partial class Form2 : Form
    {
        public Form2(string strTextBox)
        {
            
            InitializeComponent();
            lblGetInformation.Text = strTextBox;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}