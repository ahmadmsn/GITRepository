using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace ShowGridData
{
    public partial class ParrentGrid : Form
    {
        string strConnectionString = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
        public ParrentGrid()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            SqlConnection oCon = new SqlConnection(strConnectionString);
            //string select = "select invoice.sno,invoice.medicine_name,invoice.cost,inv_shipaddress.shipaddress from invoice inner join inv_shipaddress on invoice.sno = inv_shipaddress.sno";
            string select = "select * from mytable";
            SqlCommand oCmd = new SqlCommand(select, oCon);
            SqlDataAdapter oDa = new SqlDataAdapter(oCmd);
            DataTable oDt = new DataTable();
            oDa.Fill(oDt);
            dataGridView1.DataSource = oDt;
            dataGridView1.Columns[0].Visible = false;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int nRowValue = e.RowIndex;
            if (nRowValue >= 0)
            {
                string strColumnName = dataGridView1.SelectedCells[0].OwningColumn.HeaderText;
                //if (strColumnName == "medicine_name")
                if(strColumnName == "City")
                {
                    object obj = dataGridView1.SelectedCells[0].OwningRow.Cells[0].Value;
                    SqlConnection oCon = new SqlConnection(strConnectionString);
                    //string strSelect = "select inv_shipaddress.shipaddress,inv_shipaddress.shipcity,inv_shipaddress.shipcountry from inv_shipaddress where inv_shipaddress.sno = " + obj.ToString();
                    string strSelect = "select * from mytable1 where id=" + obj.ToString();
                    SqlCommand oCmd = new SqlCommand(strSelect, oCon);
                    DataTable oDt = new DataTable();
                    SqlDataAdapter oda = new SqlDataAdapter(oCmd);
                    oda.Fill(oDt);
                    ChildGrid oChild = new ChildGrid(oDt);
                    oChild.Show();
                }
            }
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SqlConnection oCon = new SqlConnection(strConnectionString);
            //string select = "select invoice.sno,invoice.medicine_name,invoice.cost,inv_shipaddress.shipaddress from invoice inner join inv_shipaddress on invoice.sno = inv_shipaddress.sno";
            string select = "select * from mytable";
            SqlCommand oCmd = new SqlCommand(select, oCon);
            SqlDataAdapter oDa = new SqlDataAdapter(oCmd);
            DataTable oDt = new DataTable();
            oDa.Fill(oDt);
            dataGridView1.DataSource = oDt;
            dataGridView1.Columns[0].Visible = false;
        }
    }
}