using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace ThreadExample
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fFMWSWDataSet1.MF_HTSAF_Info' table. You can move, or remove it, as needed.
            this.mF_HTSAF_InfoTableAdapter.Fill(this.fFMWSWDataSet1.MF_HTSAF_Info);
            // add checkbox header
            Rectangle rect = dataGridView1.GetCellDisplayRectangle(0, -1, true);
            // set checkbox header to center of header cell. +1 pixel to position correctly.
            rect.X = rect.Location.X + (rect.Width / 4);


            CheckBox checkboxHeader = new CheckBox();
            checkboxHeader.Name = "checkboxHeader";
            checkboxHeader.Size = new Size(18, 18);
            checkboxHeader.Location = rect.Location;
            checkboxHeader.CheckedChanged += new EventHandler(checkboxHeader_CheckedChanged);

            dataGridView1.Controls.Add(checkboxHeader);

            //this.mF_Transcriber_Work_AllocationTableAdapter.Fill(this.fFMWSWDataSet.MF_Transcriber_Work_Allocation);
        }

        void checkboxHeader_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)dataGridView1.Controls.Find("checkboxHeader", true)[0]).Checked == true)
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    dataGridView1[0, i].Value = ((CheckBox)dataGridView1.Controls.Find("checkboxHeader", true)[0]).Checked;
                }
                dataGridView1.EndEdit();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("Column: " + e.ColumnIndex + " , Row: " + e.RowIndex);

            //MessageBox.Show(((CheckBox)dataGridView1.Controls.Find("chkSelect", true)[e.RowIndex]).Checked.ToString());
            
            
            //if (dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() != null)
            //{
            //    if (Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()) != false)
            //    {
            //        //dataGridView1[0, -1].Value = false;
            //        //(DataGridViewCheckBoxColumn)chkSelect = (DataGridViewCheckBoxColumn)(dataGridView1.Controls.Find("checkboxHeader", true)[0]);
            //    }
            //}
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && this.dataGridView1.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn)
            {
                dataGridView1.EndEdit();
                try
                {
                    if (Convert.ToBoolean(dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString()) == true)
                    {
                        string mySelection = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    }
                    else if (Convert.ToBoolean(dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString()) == false)
                    {
                        string myUnSelected = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                        ((CheckBox)dataGridView1.Controls.Find("checkboxHeader", true)[0]).Checked = false;
                    }
                }
                catch
                { }
            }
        }
    }
}