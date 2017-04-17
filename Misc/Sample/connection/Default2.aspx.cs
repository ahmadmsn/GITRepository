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

public partial class Default2 : System.Web.UI.Page
{
    static string myconnection = "server=716E6FB4741D44F;database=pubs;integrated security=sspi";
    SqlConnection con = new SqlConnection(myconnection);
        
    protected void Page_Load(object sender, EventArgs e)
    {
        string select = "select * from ad";
        SqlCommand cmd = new SqlCommand(select, con);
        SqlDataReader dr;
        con.Open();
        dr = cmd.ExecuteReader();
        while (dr.Read())
        {
            DropDownList1.Items.Add(dr[0].ToString());
        }
        con.Close();
    
    }
}
