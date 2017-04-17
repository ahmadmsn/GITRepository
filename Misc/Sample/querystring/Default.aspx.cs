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
        if (!IsPostBack)
        {

            lst1.Items.Add("Econa Sofa");
        }
        
    }
    protected void btn1_Click(object sender, EventArgs e)
    {
        if (lst1.SelectedIndex == -1)
        {
            lbl1.Text = "You Must Select An Item";
        }
        else
        {
            string str = "Default2.aspx?";
            str += "Item=" + lst1.SelectedItem.Text;
            str += "Mode=" + chk.Checked.ToString();

            Response.Redirect(str);
        }

    }
}
