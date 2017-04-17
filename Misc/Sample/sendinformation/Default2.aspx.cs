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
        if (PreviousPage != null)
        {

            Label1.Text="You came from " + PreviousPage.Title;

            
        }
        if (PreviousPage != null)
        {
            if (PreviousPage.IsCrossPagePostBack == true)
            {
                Label1.Text = "Cross-page post.";
            }
        }
        else
        {
            Label1.Text = "Not a cross-page post.";
        }
    }
}
