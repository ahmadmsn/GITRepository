using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.IO;
using System.Threading;

public partial class _Default : System.Web.UI.Page 
{
    public TextBox txtInformation
    {
        get
        {
            return TextBox1;
        }

    }
    protected void Page_Load(object sender, EventArgs e)
    {
       // HttpCookie oCookie = Request.Cookies["MyCookie"];
        //string b = Request.Cookies["MyCookie"]["a"];//.Value.ToString();

        //int b = Convert.ToInt32(Request.Cookies["MyCookie"]["a"]);

        //Button b1 = new Button();
        //b1.Text = "MyButton";
        //b1.ID = "MyButton";
        //Panel1.Controls.Add(b1);
        //PlaceHolder1.Controls.Add(b1);
        
    }
    protected void test_Click(object sender, EventArgs e)
    {
        string message="<span style=\"color:red\">Welcome" + " Admiral" + " Ahmad" + "</span>";
        Response.Write(message);
        
        Button b1 = new Button();
        b1.Text = "MyButton";
        b1.ID = "MyButton";
        Button foundButton = (Button)Page.FindControl("b1");
         
        
    }
    //public void DisplayControl(ControlCollection control, int depth)
    //{
    //    Response.Write(new String("-", depth * 4) + " >");

    //}




    protected void btnDownLoad_Click(object sender, EventArgs e)
    {
        //string AbsolutePath = @"D:\ad\TestDownLoad.doc";
       // string AbsolutePath = @"D:\ad";
        string path = FileUpload1.FileName;
        string abc = FileUpload1.PostedFile.FileName;
        string a = System.IO.Path.GetDirectoryName(FileUpload1.FileName);
        //string FullPath = Path.Combine(AbsolutePath, path);
        string FullPath = FileUpload1.PostedFile.FileName;
        FileInfo f1 = new FileInfo(FullPath);
        if (f1.Exists)
        {
            Response.AddHeader("Content-Disposition", "attachment; filename=" + f1.Name);
            //Response.AddHeader("Content-Length", f1.Length.ToString());
            //Response.ContentType = "application/octet-stream";
            Response.Flush();
            Response.WriteFile(f1.FullName);
        }
        else
        {            
            Response.Write("<script> alert('files are not exist')</script>");
        }



    }
    protected void btnQuery_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default2.aspx?str=" + TextBox1.Text);
    }
    protected void btnCross_Click(object sender, EventArgs e)
    {
        
    }
    protected void btnWait_Click(object sender, EventArgs e)
    {
        GetValue();
    }
    void GetValue()
    {
        int nResult = 0;
        for (int i = 1; i <= 10; i++)
        {
            int nNum = 2;
            nResult = nNum * i;
            //string strChildName="ChildName "+i;
            

            //System.Threading.Thread.Sleep(500);
            Response.Write(nResult +Environment.NewLine);
            //run(strChildName);
 
            Response.Write("<br/>");

        }
        
    }
    public void run(string strName)
    {
        int nCount=0;
        string strThreadName = strName;
       // Response.Write("Thread Name "+strThreadName);
        do
        {
            Thread.Sleep(500);
            //Response.Write("In "+strThreadName +",count is "+nCount);
            nCount++;
        }
        while(nCount<=10);
    }


}
