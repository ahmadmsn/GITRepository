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

public partial class mypage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string str;
        str=Request.QueryString["Name"];
        Response.Write(str);
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Label1.Text = HiddenField1.Value;

    }
    protected void HiddenField1_ValueChanged(object sender, EventArgs e)
    {
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        /*for(int i=0; i<Table1.Rows.Count;i++)
            for(int j=0;*/
    }
}
