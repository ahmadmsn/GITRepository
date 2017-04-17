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

public partial class self : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("data source=amit; initial catalog=addb;integrated security=sspi");
    SqlCommand cm = new SqlCommand();
    SqlDataReader dr;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            cm.Connection = con;
            cm.CommandText = "select * from stu2";
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                dd1.Items.Add(dr[0].ToString());
            }
            con.Close();
        }
       
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        cm.Connection = con;
        cm.CommandText="Insert into stu2 values('"+txt1.Text+"')";
        con.Open();
        cm.ExecuteNonQuery();
        dd1.Items.Add(txt1.Text);
        con.Close();
    }


 }
