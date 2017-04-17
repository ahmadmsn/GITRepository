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
    public class Furniture
    {
        public string Name;
        public string Description;
        public decimal Cost;
        public Furniture(string name, string description, decimal cost)
        {
            Name = name;
            Description = description;
            Cost = cost;
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Furniture piece1 = new Furniture("Econo Sofa", "Acme Inc", 74.99M);
            Furniture piece2 = new Furniture("Pioneer Table", "Heritage", 866.74M);
            Furniture piece3 = new Furniture("Retro Cabinet", "SixtiesLtd", 300.1M);

            Session["Furniture1"] = piece1;
            Session["Furniture2"] = piece2;
            Session["Furniture3"] = piece3;

            ListBox1.Items.Add(piece1.Name);
            ListBox1.Items.Add(piece2.Name);
            ListBox1.Items.Add(piece3.Name);
        }

            Label1.Text = "Session Id :" + Session.SessionID;
            Label1.Text += "</br> Number Of Objects" + Session.Count.ToString();
            Label1.Text += "</br> Mode" + Session.Mode.ToString();
            Label1.Text += "</br> Is Cookieless" + Session.IsCookieless.ToString();
            Label1.Text += "</br> Is New" + Session.IsNewSession.ToString();
            Label1.Text += "</br> Timeout" + Session.Timeout.ToString();
    }
    protected void btn1_Click(object sender, EventArgs e)
    {
        if (ListBox1.SelectedIndex == -1)
        {
            Label2.Text = "No Item Selected";
        }
        else
        {
            int v = ListBox1.SelectedIndex + 1;
            string key = "Furniture" + v.ToString();
            Furniture piece = (Furniture)Session[key];
            Label2.Text = "Name" + piece.Name;
            Label2.Text += "</br>Description" + piece.Description;
            Label2.Text += "</br>Cost" + piece.Cost.ToString();
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default2.aspx");
    }
}
