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

/// <summary>
/// Summary description for BL
/// </summary>
public class BL
{
    #region Member Varibales
    DAL oDal=null;
    //Common oCom = null;
    #endregion

    public BL()
	{
       oDal=new DAL();
      // oCom = new Common();
	}
    public DataTable BLShow()
    {
        try
        {
            string strSelect = "select * from emp";
            DataTable oDt = oDal.GetRecord(strSelect);
            return oDt;
        }
        catch (Exception oEx)
        {
            return null;
        }

    }
    /// <summary>
    /// Getting record from Product table.
    /// </summary>
    /// <returns></returns>
    public DataTable GetProduct()
    {     
        try
        {
            string strSelectProduct = "Select * from product";
            DataTable oDt = oDal.GetRecord(strSelectProduct);
            return oDt;
        }
        catch
        {
            return null;
        }
    }
    public ArrayList ShowData()
    {
        //Common [] oCom=new Common[2];
        string strSelect = "select * from emp";
        Common[] oCom = oDal.GetCommonRecords(strSelect);
        ArrayList oList = new ArrayList();
        IEnumerator oIEnumerator = oCom.GetEnumerator();
        int i = 0;
        while (oIEnumerator.MoveNext())
        {
            oList.Add("Name is: "+oCom[i].Name + "," + "Salary is: "+oCom[i].Salary);
            //oList.Add(oCom[i].Salary);
            i = i+1;
        }
        return oList;
    }
}
