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
using System.Data.OracleClient;
using System.Web.Configuration;
using ClassLibrary1;

public partial class Home : System.Web.UI.Page
{
    Class1 c1=new Class1();
    string connectionstring = WebConfigurationManager.ConnectionStrings["mydb"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
        //OracleConnection con = new OracleConnection(connectionstring);
        //string select = "select el_slno,el_dictationid,el_transcriptid,el_actiondate,el_eventid,el_actorid,el_source,el_destination from as_eventlog,as_dictationdtls where as_eventlog.el_dictationid=as_dictationdtls.dd_dictationid and as_eventlog.el_transcriptid=as_dictationdtls.dd_transcriptid and rownum<=5";
        //OracleDataAdapter da = new OracleDataAdapter(select, con);
        //DataSet ds = new DataSet();
        //da.Fill(ds, "mytable");
        //GridView2.DataSource = ds;
        //GridView2.DataBind();


        //GridView1.
        //Label1.Text = GridView1.SelectedDataKey.ToString();

        
    }
    protected void cmdshow_Click(object sender, EventArgs e)
    {        
        GridView1.DataSource = c1.getuid();
        GridView1.DataBind();
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        GridView1.DataSource = c1.getuid();
        GridView1.DataBind();
        
    }

    
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {      
        //if (e.Row.DataItem != null)
        //{
        //    Label1.Text = e.Row.Cells[2].Text;
        //}
    }
    protected void GridView1_RowCommand(object sender, EventArgs e)
    {
        //Label1.Text = GridView1.Rows(e.CommandArgument.ToString).Cells(4).Text.ToString;
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        //GridView1.Visible = false;
        
        string s=GridView1.SelectedValue.ToString();
        //Label1.Text = s.ToString();

        OracleConnection con = new OracleConnection(connectionstring);
        string select = "select el_slno,el_dictationid,el_transcriptid,el_actiondate,el_eventid,el_actorid,el_source,el_destination from as_eventlog,as_dictationdtls where as_eventlog.el_dictationid=as_dictationdtls.dd_dictationid and as_eventlog.el_transcriptid=as_dictationdtls.dd_transcriptid and dd_filename='"+s.ToString()+"'";
        OracleCommand cmd = new OracleCommand(select, con);
        //cmd.Parameters.AddWithValue("@filename", s.ToString());
        OracleDataAdapter da = new OracleDataAdapter(cmd);
        DataSet ds = new DataSet();
        try
        {
            da.Fill(ds, "mytable");
            GridView2.DataSource = ds;
            GridView2.DataBind();
        }
        catch (Exception err)
        {
            Label1.Text = err.Message;
        }

    }
}
