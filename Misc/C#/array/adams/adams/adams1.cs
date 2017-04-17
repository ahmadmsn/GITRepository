using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace adams
{
    public partial class adams1 : Form
    {
        public adams1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Hello";
        }

        private void toolTip2_Popup(object sender, PopupEventArgs e)
        {

        }

        
    }
}