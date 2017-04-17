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

    }
    protected void btn1_Click(object sender, EventArgs e)
    {
        string errmessage = "<b> Mistakes Found: </b><br />";
        
        foreach (BaseValidator ctrl in Validators)
        {
            
            if (!ctrl.IsValid)
            {
                //Response.Write("Hello");
               
                errmessage += ctrl.ErrorMessage + " <br />";
                TextBox ctrlInput = (TextBox)this.FindControl(ctrl.ControlToValidate);

                errmessage += " * Problem is with this input: ";
                errmessage += ctrlInput.Text + "<br />";
            }
        }
        Label3.Text = errmessage;
        
    }
}
