
using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using System.Web.Configuration;

/// <summary>
/// Summary description for DAL
/// </summary>
public class DAL
{
    //Common oCom = null;
    string strConnectionString=ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;    
    //public DAL()
    //{
    //    //oCom = new Common();
    //    //
    //    // TODO: Add constructor logic here
    //    //
    //}
    private DataTable FillDataTable(SqlCommand oCmd)
    {
        SqlConnection oCon = new SqlConnection(strConnectionString);
        oCmd.Connection = oCon;       
        SqlDataAdapter oDa=new SqlDataAdapter(oCmd);
        DataTable oDt =new DataTable();
        try
        {
           oCon.Open();
           oDa.Fill(oDt);
           return oDt;
        }
        catch (Exception oEx)
        {
            return null;
        }
        finally
        {
            if (oCon.State== ConnectionState.Open)
            {
                oCon.Close();
            }
        }

    }
    public DataTable GetRecord(string strSelect)
    {
        SqlCommand oCmd = new SqlCommand(strSelect);
        try
        {
            DataTable oDt = FillDataTable(oCmd);
            return oDt;
        }
        catch (Exception oEx)
        {
            return null;

        }
    }
    public Common [] GetCommonRecords(string strSelect)
    {
        SqlCommand oCmd = new SqlCommand(strSelect);
        
        try
        {
            DataTable oDt = FillDataTable(oCmd);
            Common[] oCom = new Common[oDt.Rows.Count];
          
            //oCom[0].Name = oDt.Rows[0]["name"].ToString();
            //oCom[0].Salary = Convert.ToInt32(oDt.Rows[0]["salary"]);
            for (int nCount = 0; nCount < oDt.Rows.Count; nCount++)
            {
                oCom[nCount] = new Common();
                oCom[nCount].Name = oDt.Rows[nCount]["name"].ToString();
                oCom[nCount].Salary = Convert.ToInt32(oDt.Rows[nCount]["salary"]);
            }
            return oCom;
        }
        catch (Exception oEx)
        {
            return null;

        }
    }
}
