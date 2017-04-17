using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;

public partial class DisconnectedApproach : System.Web.UI.Page
{
    SqlConnection cn = new SqlConnection("data source=stg-1cc267aa387;database=mydatabase;uid=sa;pwd=stg");//"Data Source=stg-1cc267aa387\\SQLEXPRESS;Initial Catalog=mydatabase;Integrated Security=True");
    SqlCommand cm = new SqlCommand();
    SqlDataAdapter da = new SqlDataAdapter();
    DataSet ds = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {
        cm.CommandText = "select * from person";
        cm.Connection = cn;
        da = new SqlDataAdapter(cm);
        da.Fill(ds, "table1");
        for (int i = 0; i < ds.Tables["table1"].Rows.Count; i++)
        {
            DataRow dr = ds.Tables[0].Rows[i];
            DropDownList1.Items.Add(dr[0].ToString());
        }
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
