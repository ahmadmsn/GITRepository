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
        int v = 1;
        string key = "Furniture" + v.ToString();
        Furniture piece = (Furniture)Session[key];
        Label1.Text = "Name" + piece.Name;
        Label1.Text += "</br>Description" + piece.Description;
        Label1.Text += "</br>Cost" + piece.Cost.ToString();
        //Label1.Text = "Session Id :" + Session.SessionID;
        //Label1.Text += "</br> Number Of Objects" + Session.Count.ToString();
        //Label1.Text += "</br> Mode" + Session.Mode.ToString();
        //Label1.Text += "</br> Is Cookieless" + Session.IsCookieless.ToString();
        //Label1.Text += "</br> Is New" + Session.IsNewSession.ToString();
        //Label1.Text += "</br> Timeout" + Session.Timeout.ToString();
    }
}

