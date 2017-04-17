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
    static string mc = "server=716E6FB4741D44F\amit;database=addb;uid=sa;pwd=mssql2005";
    SqlConnection con = new SqlConnection(mc);
    SqlDataReader dr;
    protected void Page_Load(object sender, EventArgs e)
    {
        string select = "Select * from authors";
        SqlCommand cmd = new SqlCommand(select, con);
        con.Open();
        dr = cmd.ExecuteReader();
        while (dr.Read())
        {
            DropDownList1.Items.Add(dr[0].ToString());
        }
        con.Close();

    }
}
