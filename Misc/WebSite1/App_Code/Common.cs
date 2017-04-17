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
/// Summary description for Common
/// </summary>
public class Common
{
	public Common()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    private int strSalary;
    public int Salary
    {
        get { return strSalary; }
        set { strSalary = value; }
    }
    private string strName;
    public string Name
    {
        get { return strName; }
        set { strName = value; }
    }

}
