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
        if (!IsPostBack)
        {
            sex.Items.Add("MALE");
            sex.Items.Add("FEMALE");
            acc.Items.Add("Saving");
            acc.Items.Add("Current");
        }

    }
    protected void submit_Click(object sender, EventArgs e)
    {
        Random r = new Random();
        int i;
        HttpCookie cookie = new HttpCookie("MyCookie");
        cookie["fname"] = fname.Text;
        cookie["lanme"] = lname.Text;
        cookie["sex"] = sex.SelectedItem.Text;
        cookie["address"] = add.Text;
        cookie["account"] = acc.SelectedItem.Text;
        cookie["annualincome"] = amt.Text;
        i = r.Next(5000, 10000);
        cookie["Password"] = i.ToString();
        Response.Cookies.Add(cookie);
        //Response.Write(i);
        Response.Redirect("id.aspx?uname=" + fname.Text+"&passwd="+i.ToString());
        
    }
}
