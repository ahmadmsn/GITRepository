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

public partial class id : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string uname,passwd;
        uname=Request.QueryString["uname"];
        passwd = Request.QueryString["passwd"];
        Label1.Text += uname;
        Label2.Text += passwd;
    }
    protected void ok_Click(object sender, EventArgs e)
    {
        Response.Redirect("mystart.aspx");
    }
}
