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

public partial class Detailed : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        HttpCookie detailed = Request.Cookies["mycookie"];
        det.Text = "Yr name is : " + detailed["fname"] + " " + detailed["lname"];
        det.Text += "<br/> sex : "+detailed["sex"];
        det.Text += "<br/> Address : " +detailed["address"];
        det.Text += "<br/> Account type " +detailed["account"];
        det.Text += "<br/> Annual Income " + detailed["annualincome"];


    }
}
