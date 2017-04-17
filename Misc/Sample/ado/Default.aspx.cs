using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page 
{
    SqlConnection con = new SqlConnection();
    SqlCommand cm = new SqlCommand();
    SqlDataReader dr;
    
       
    protected void Page_Load(object sender, EventArgs e)
    {
        

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        con.ConnectionString = "Data Source=7df9bbcb924748b; database=addb;uid= ;pwd= ; Integrated Security= sspi";
        cm.CommandText = "insert into student values('" + txtroll.Text + "','" + txtname.Text + "','" + txtaddress.Text  + "')";
        cm.Connection = con;
        con.Open();
        cm.ExecuteNonQuery();
        Response.Write("Your Data Is Inserted");
        con.Close();
    }
}
