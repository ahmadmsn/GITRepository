using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using ClassLibrary1;

public partial class testpage : System.Web.UI.Page
{
    Class1 c1 = new Class1();
    protected void Page_Load(object sender, EventArgs e)
    {
        //OracleConnection con = new OracleConnection(connectionstring);
        //string select = "select DD_DICTATIONID,DD_TRANSCRIPTID,DD_FILENAME,DD_OWNER,DD_DICTATIONDATE,DD_DOCSTATUS,DD_STAT,DD_TIMEDUEBACK from as_dictationdtls  where rownum<=100";

        //OracleCommand cmd = new OracleCommand(select, con);
        //OracleDataAdapter da = new OracleDataAdapter(select, con);
        //DataSet ds = new DataSet();
        //da.Fill(ds, "mytable");

        //GridView1.DataSource = ds;
        //GridView1.DataBind();


    }
    protected void Button1_Click(object sender, EventArgs e)
    {
       // c1.getuid();
        GridView1.DataSource = c1.getuid();
        GridView1.DataBind();
    }

    //protected void GridView1_PageIndexChanged(object sender, EventArgs e)
    //    {
    //        //OracleConnection con = new OracleConnection(connectionstring);
    //        //string select = "select DD_DICTATIONID,DD_TRANSCRIPTID,DD_FILENAME,DD_OWNER,DD_DICTATIONDATE,DD_DOCSTATUS,DD_STAT,DD_TIMEDUEBACK from as_dictationdtls  where rownum<=100";

    //        //OracleCommand cmd = new OracleCommand(select, con);
    //        //OracleDataAdapter da = new OracleDataAdapter(select, con);
    //        //DataSet ds = new DataSet();
    //        //da.Fill(ds, "mytable");
    //        //GridView1.DataSource = ds;
    //        //GridView1.DataBind();
    //    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
