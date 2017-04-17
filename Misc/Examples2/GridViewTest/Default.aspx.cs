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
    //string ConnectionString = "Data Source=onam;Initial Catalog=master;uid=sa;pwd=";
    string ConnectionString = "Data Source=192.168.0.176;Initial Catalog=pubs;uid=wsw;pwd=wsw";
    protected void Page_Load(object sender, EventArgs e)
    {      
        SqlConnection oConn = new SqlConnection(ConnectionString);
        string strSelect = "select * from test";
        SqlCommand oCmd = new SqlCommand(strSelect, oConn);
        SqlDataAdapter da = new SqlDataAdapter(oCmd);
        DataTable oDt = new DataTable();
        da.Fill(oDt);
        GridView1.DataSource = oDt;
        GridView1.DataBind();
        oConn.Close();

        
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        SqlConnection oConn = new SqlConnection(ConnectionString);
        string strSelect = "select * from test";
        SqlCommand oCmd = new SqlCommand(strSelect, oConn);
        SqlDataAdapter da = new SqlDataAdapter(oCmd);
        DataTable oDt = new DataTable();
        da.Fill(oDt);
        GridView1.DataSource = oDt;
        GridView1.DataBind();
        oConn.Close();
    }
    protected void btnClick_Click(object sender, EventArgs e)
    {
        //string Text = Request.Form["MyRadioButton"];
        //Response.Write(Text);

        string Text = Request.Form["RowSelector"];
        Response.Write(Text);
        
        
    }
}
