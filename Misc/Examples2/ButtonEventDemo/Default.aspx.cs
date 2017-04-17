using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //TextBox1.Attributes.Add("OnKeyPress", "javascript:if(event.keyCode==13)__doPostBack('" + btnNormal.UniqueID + "','')");
        TextBox1.Attributes.Add("onKeyDown", "javascript:checkevent();");

    }
    protected void btnDefault_Click(object sender, EventArgs e)
    {
        Response.Write("YouClicked Default Button");
    }
    protected void btnNormal_Click(object sender, EventArgs e)
    {
        Response.Write("You Clicked Normal Button");
    }
}
