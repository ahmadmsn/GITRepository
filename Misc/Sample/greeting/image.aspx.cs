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

public partial class image : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Image1.ImageUrl = "kar64a.jpg";
    }

    protected void updatebtn_Click(object sender, EventArgs e)
    {
        if (chkbox.Checked)
        {
            Image1.Visible = true;
        }
        else
        {
            Image1.Visible = false;
        }
    }
}
