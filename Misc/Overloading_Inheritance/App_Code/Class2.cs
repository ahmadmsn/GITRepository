using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

/// <summary>
/// Summary description for Class2
/// </summary>
public class Class2:D2
{
	public Class2()
	{
        string str = "aaa";
	}
    protected override string substract(string str1stParam)
    {
        return str1stParam;
        //return base.substract(str1stParam);
    }
    public override int substract()
    {
        int i = 100 + 200;
        return i;
        //return base.substract();
    }  
    public string CallInheritanceDemo()
    {      
        string strReturn = substract().ToString();
        //string strReturn = D2Func();
       //string strReturn = d.D2Func();
       return strReturn;
    }
}
