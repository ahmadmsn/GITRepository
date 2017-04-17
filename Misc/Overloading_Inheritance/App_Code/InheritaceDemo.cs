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
/// Summary description for InheritaceDemo
/// </summary>
public class InheritaceDemo
{
    protected string m_strTest = string.Empty;
    public string m_strTestString = string.Empty;
	public InheritaceDemo()
	{
        m_strTest = "Inside InheritaceDemo";
		
	}
    private int Add()
    {
         int nFirstNum=10;
         int nSecondNum=20;
         int nResult=nFirstNum+nSecondNum;      
         return nResult;
    }
    public virtual int substract()
    {
        int nFirstNum = 20;
        int nSecondNum = 10;
        int nResult = nFirstNum -nSecondNum;
        return nResult;
    }
    protected virtual string substract(string str1stParam)
    {
        return "With Single Parameter";
    }
}
public class D1 : InheritaceDemo
{
    public D1()
    {
        m_strTest = "Inside D1";
    }
    public string D1Func()
    {
        return "This is from D1Func";
    }
}
public class D2 : D1
{
    public D2()
    {
        m_strTest = "Inside D2";
    }
    public string D2Func()
    {
        return m_strTest;
       // return "This is from D2Func";         
        
    }
}

