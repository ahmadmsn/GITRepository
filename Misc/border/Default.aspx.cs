using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Drawing;
using System.Drawing.Text;
using System.ComponentModel;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string[] colorarry = Enum.GetNames(typeof(KnownColor));
            dropdowncolor.DataSource = colorarry;
            dropdowncolor.DataBind();

            string[] borderarray = Enum.GetNames(typeof(BorderStyle));
            Rdbtnborder.DataSource = borderarray;
            Rdbtnborder.DataBind();
        }

    }
    protected void update_Click(object sender, EventArgs e)
    {
        Panel1.BackColor = Color.FromName(dropdowncolor.SelectedItem.Text);

        TypeConverter c = TypeDescriptor.GetConverter(typeof(BorderStyle));
        Panel1.BorderStyle=(BorderStyle) c.ConvertFromString(Rdbtnborder.SelectedItem.Text);

        //Panel1.BorderStyle = (BorderStyle)c.ConvertFromString("Solid");

        if (chkboxdefault.Checked)
        {
            //Img1.ImageUrl=Server.MapPath("image" \\
        }

    }
}
