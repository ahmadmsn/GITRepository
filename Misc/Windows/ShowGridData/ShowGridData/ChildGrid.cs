using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace ShowGridData
{
    public partial class ChildGrid : Form
    {
        string strConnectionString = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
        DataTable odtChild;
        public ChildGrid(DataTable oDt)
        {
            InitializeComponent();
            odtChild = oDt;

        }

        private void ChildGrid_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = odtChild;
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            object obj=dataGridView1.SelectedCells[0].OwningRow.Cells[1].Value;
            object obj1=dataGridView1.SelectedCells[0].OwningRow.Cells[0].Value;
            string strUpdateMain = "update mytable set Country=@Country where CustomerId=@cid";// +obj.ToString() + "where CustomerId=" + obj1.ToString();

            string strUpdateChild = "update mytable1 set Country=@country where id=@id";// +obj.ToString() + "where id=" + obj1.ToString();

            SqlConnection oCon=new SqlConnection(strConnectionString);
            SqlCommand oCmdMain = new SqlCommand(strUpdateMain, oCon);
            oCmdMain.Parameters.Add("@Country", SqlDbType.VarChar).Value = obj.ToString();
            oCmdMain.Parameters.Add("@cid", SqlDbType.VarChar).Value = obj1.ToString();
            oCon.Open();
            oCmdMain.ExecuteNonQuery();
            oCon.Close();

            SqlCommand oCmdChild = new SqlCommand(strUpdateChild, oCon);
            oCmdChild.Parameters.Add("@Country", SqlDbType.VarChar).Value = obj.ToString();
            oCmdChild.Parameters.Add("@id", SqlDbType.VarChar).Value = obj1.ToString(); 
            oCon.Open();
            oCmdChild.ExecuteNonQuery();
            oCon.Close();
        }
    }
}