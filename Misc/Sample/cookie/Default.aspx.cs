using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Net;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        HttpCookie cookie = Request.Cookies["Prefrences"];

        //cookie["Name"] = "Mathew";
        //Response.Cookies.Add(cookie);
        
        if (cookie == null)
        {
            cookie = new HttpCookie("Prefrences");
            lbl1.Text = "<b> Unknown Customer</b>";
        }
        else
        {
            lbl1.Text = "<b>Cookie Found</b><br /><br />";
            lbl1.Text = "Welcome" + cookie["Name"];
        }

    }
    protected void btn1_Click(object sender, EventArgs e)
    {
        HttpCookie cookie = Request.Cookies["Prefrences"];
        if (cookie == null)
        {
            cookie = new HttpCookie("Preferences");
        }
        cookie["Name"] = txt1.Text;
        cookie.Expires.AddYears(1);
        Response.Cookies.Add(cookie);

        lbl1.Text = "<b>Cookie Created</b><br /><br />";
        lbl1.Text = "New Customer" + cookie["Name"];
    
    }
}
