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
     int a,b;
    int result;
     
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            a = Convert.ToInt32(TextBox1.Text);
            b = Convert.ToInt32(TextBox2.Text);
            result = a + b;
            Label1.Text = "After Adding  " + result.ToString();
        }
        catch
        {
            Label1.Text = "Both TextField Shoul Be Filled";
            //Label1.Text = err.Message;
        }

    }
    protected void btn2_Click(object sender, EventArgs e)
    {
        try
        {
            if(a<b)
            {
                Label1.Text="Enter Greater number For Subtraction";
            }
            else
            {
            a = Convert.ToInt32(TextBox1.Text);
            b = Convert.ToInt32(TextBox2.Text);
            result = a - b;
            Label1.Text = "After Subtraction   " + result;
            }
        }
        catch
        {
            Label1.Text="Both Text Filled Should Be filled";
        }

    }
    protected void btn3_Click(object sender, EventArgs e)
    {
        try
        {
            a = Convert.ToInt32(TextBox1.Text);
            b = Convert.ToInt32(TextBox2.Text);
            result = a * b;
            Label1.Text = "After Multiplication  " + result.ToString();
        }
        catch
        {
            Label1.Text="Both field should be filled";
        }
    }
    protected void btn4_Click(object sender, EventArgs e)
    {
        try
        {
            a = Convert.ToInt32(TextBox1.Text);
            b = Convert.ToInt32(TextBox2.Text);
            result = a / b;
            Label1.Text = "After Division   " + result;
        }
        //catch (DivideByZeroException err)
        //{
        //   //Label1.Text= Trace.Warn("btn4_Click", "Caught Error", err.ToString());
        //   // Label1.Text = "Number Can't be devided by zero";
        //    //Label1.Text = err.Message;
        //}
        catch(Exception err)
        {
            Trace.Warn("btn4_Click", "Caught Error", err);
            //Label1.Text = "Both field should be fill";
        }
    }
}
