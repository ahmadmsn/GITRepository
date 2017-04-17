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
    protected void Button1_Click(object sender, EventArgs e)
    {
        Label2.Text = "Your Name Is"+" "+TextBox1.Text;
        
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Label2.Text = "This Is By Image button"+TextBox1.Text;
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Label3.Text = DropDownList1.SelectedItem.Text;
    }
    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Label4.Text = "You have selected"+" "+ListBox1.SelectedItem.Text;
    }
}
