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
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        SqlConnection m_oConn = new SqlConnection("Data Source=192.168.0.184;Initial Catalog=ffmwsw;uid=wsw;pwd=wsw");
        SqlDataAdapter m_oDa = new SqlDataAdapter("Select * from vs_user_profile where up_loginid='" + TextBox1.Text + "' and up_password='" + TextBox2.Text + "'", m_oConn);
        DataTable dt = new DataTable();
        m_oDa.Fill(dt);

        int globalid = Convert.ToInt32( dt.Rows[0]["up_vsglobalid"]);
        byte[] bytes =(byte[]) dt.Rows[0]["up_accesspermissions"];

    }
}
