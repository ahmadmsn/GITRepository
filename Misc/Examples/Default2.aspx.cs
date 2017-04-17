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
        Literal l = new Literal();
        l.Text=DateTime.Now.ToString();
        PlaceHolder1.Controls.Add(l);
        if (!IsPostBack)
        {
            Calendar1.Visible = false;
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Calendar1.Visible = true;

    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        TextBox1.Text = Calendar1.SelectedDate.Day.ToString() + "/" + Calendar1.SelectedDate.Month .ToString() + "/" + Calendar1.SelectedDate.Year .ToString();
        Calendar1.Visible = false;
    }
    protected void Calendar2_DayRender(object sender, DayRenderEventArgs e)
    {
        if (e.Day.IsToday)
        {
            Literal l = new Literal();
            l.Text = "its to day";
            e.Cell.Controls.Add(l);
            e.Cell.BackColor = System.Drawing.Color.Aqua;
        }
        if (e.Day.DayNumberText == "31")
        {
            Literal l = new Literal();
            l.Text = "its end of month";
            e.Cell.Controls.Add(l);
            e.Cell.BackColor = System.Drawing.Color.Aqua;
        }
    }
    protected void Calendar2_SelectionChanged(object sender, EventArgs e)
    {

    }
}
