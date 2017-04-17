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
    public string FirstName
    {
        get
        {
            return (txt1.Text+ " " + txt2.Text);
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        

    }
    protected void Btn_Click(object sender, EventArgs e)
    {
        //Response.Redirect("Default2.aspx");
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        LinkButton1.PostBackUrl = "Default2.aspx";
    }
}
