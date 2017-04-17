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
    protected void btnInHeritence_Click(object sender, EventArgs e)
    {
        //D2 d = new D2();
        //string strTest = d.D2Func();
        Class2 c2 = new Class2();
        //string strTest = c2.CallInheritanceDemo();
        int i = c2.substract();
        //string strPrtectedTest=c2.substract(string str1stParam)--not Accessible becouse of protected;
    }
    protected void btnOperatorOverloading_Click(object sender, EventArgs e)
    {
        OperatorOverloading o1 = new OperatorOverloading(10, 20);
        OperatorOverloading o2 = new OperatorOverloading(30, 40);
        OperatorOverloading o5 = new OperatorOverloading(100, 200);
        OperatorOverloading o3 = o1 + o2;
        OperatorOverloading o10 = new OperatorOverloading(10, 20);
        OperatorOverloading o4 = ++o1;
    }
}
