using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections;

public partial class _Default : System.Web.UI.Page 
{
    BL oBl=null;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnShow_Click(object sender, EventArgs e)
    {
        oBl = new BL();
        DataTable odt = oBl.BLShow();
        GridView1.DataSource = odt;
        GridView1.DataBind();

    }
    protected void btnShowProduct_Click(object sender, EventArgs e)
    {
        oBl = new BL();
        DataTable odt = oBl.GetProduct();

        GridView1.DataSource = odt;
        GridView1.DataBind();

    }
    protected void btnShowText_Click(object sender, EventArgs e)
    {
         oBl = new BL();
         ArrayList oList = oBl.ShowData();
         IEnumerator oIEnumerator = oList.GetEnumerator();
         int i = 0;
         while (oIEnumerator.MoveNext())
         {
             TextBox1.Text += oList[i]+Environment.NewLine;
             //TextBox1.Text += oList[i];
             i++;
         }
    }
}
