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

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //TextBox1.Attributes.Add("OnKeyDown","javascript:checkevent();");
        TextBox1.Attributes.Add("OnKeyPress", "javascript:if(event.keyCode==13)__doPostBack('" + btnDefaulr.UniqueID + "','')");
    }
    protected void btnNormal_Click(object sender, EventArgs e)
    {
        Response.Write("NormalButton Clicked");
    }
    protected void btnDefaulr_Click(object sender, EventArgs e)
    {
        Response.Write("Default Button Clicked");
    }
}
