using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Practice_15._04._11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            MyClass ob1 = new MyClass(4, 5);
            MyClass ob2 = new MyClass(6, 7);
            MessageBox.Show("ob1 " + ob1.show().ToString());
            MessageBox.Show("ob2 " + ob2.show().ToString());

            if (ob1.sameAs(ob2))
            {
                MessageBox.Show("ob1 and ob2 has same value");
            }
            else
            {
                MessageBox.Show("ob1 and ob2 has diffrent value");
            }
            ob1.copy(ob2);
            MessageBox.Show("After Copy" +ob1.show().ToString());

            if(ob1.sameAs(ob2))
                MessageBox.Show("ob1 and ob2 is same");
            else
                MessageBox.Show("ob1 and ob2 is diffrent");
            
        }

    }
    
}
