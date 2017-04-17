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
/// Summary description for OperatorOverloading
/// </summary>
public struct OperatorOverloading
{
    private int nReal;
    private int nImaginary;
	public OperatorOverloading(int i,int j)
	{
        nReal = i;
        nImaginary = j;
	}
    public static OperatorOverloading operator +(OperatorOverloading op1, OperatorOverloading op2)
    {
        OperatorOverloading op = new OperatorOverloading();
        op.nReal = op1.nReal + op2.nImaginary;
        op.nImaginary = op2.nImaginary + op2.nReal;
        return op;
    }
    public static OperatorOverloading operator ++(OperatorOverloading op3)
    {
        op3.nReal++;
        op3.nImaginary++;
        return op3;
    }
}
