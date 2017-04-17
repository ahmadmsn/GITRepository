using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.OleDb;
using System.Data.SqlClient;


public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
 

 }
 
    //protected void Button2_Click(object sender, EventArgs e)
    //{
    //    string sqltable;
    //    sqltable="Registration";
    //    SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ToString());
    //    Conn.Open();
    //    Response.Write("Database Connected");
    //    string path1;
    //    path1 = File1.Value;
    //    string strConnection = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " + path1 + ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=1'";
    //    OleDbConnection con = new OleDbConnection(strConnection);
    //    Response.Write("Connected");
    //    //OleDbDataAdapter ad = new OleDbDataAdapter("select * from [Sheet1$]", con);
    //    //DataTable dt = new DataTable();
    //    //ad.Fill(dt);
    //    OleDbCommand cmd = new OleDbCommand("select * from [Sheet1$]", con);
    //    OleDbDataReader dr;
    //    con.Open();
    //    dr = cmd.ExecuteReader();
    //    SqlBulkCopy bulk = new SqlBulkCopy(Conn);
    //    bulk.DestinationTableName = sqltable;
    //    bulk.WriteToServer(dr);
    //    Response.Write("Datas IMPORTED");

        
    //}
    protected void Button1_Click(object sender, EventArgs e)
    {
        string path, path2 = string.Empty;
        path = File1.Value;
  
        string strConnection = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " + path + ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=1'";
        OleDbConnection con = new OleDbConnection(strConnection);
       //Show the Excel datas in grid view
        OleDbDataAdapter ad = new OleDbDataAdapter("select * from [Sheet1$]", con);
        DataTable dt = new DataTable();
        ad.Fill(dt);
        GridView1.DataSource = dt;
        GridView1.DataBind();

   
        SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ToString());
        Conn.Open();
       
       // OleDbCommand cmd = new OleDbCommand("select * from [Sheet1$]", con);
       // OleDbDataReader dr;
        //con.Open();
       // dr = cmd.ExecuteReader();
        SqlBulkCopy bulk = new SqlBulkCopy(Conn);
        bulk.DestinationTableName = "mytable";
        bulk.WriteToServer(dt);
        Response.Write("DATA IMPORTED");
      //  dr.Close();
        Conn.Close();
        con.Close();

    }
}
