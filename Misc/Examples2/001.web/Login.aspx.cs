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

public partial class _Default : System.Web.UI.Page
{
    string connectionstring = WebConfigurationManager.ConnectionStrings["mydb"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
        //connection();

    }
    protected void cmdlbtn_Click(object sender, EventArgs e)
    {

        OracleConnection con = new OracleConnection(connectionstring);
        string select = "select ud_id,ud_accountid,ud_loginid from as_userdtls";// where ud_loginid=@lname";
        OracleCommand cmd = new OracleCommand(select, con);
        //cmd.Parameters.AddWithValue("@lname", txtlname.Text);
        //OracleDataReader dr;
        OracleDataAdapter da = new OracleDataAdapter(select, con);
        DataSet ds = new DataSet();
        da.Fill(ds,"mytable");

        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            DataRow dr = ds.Tables[0].Rows[i];
            if (dr["ud_loginid"].ToString() == txtlname.Text && dr["ud_id"].ToString() == txtpwd.Text)
            {
                Response.Redirect("home.aspx");
            }
            else
            {
                lblerr.Text = "Invalid UserName Or Password";
            }
        }

       //GridView1.DataSource = ds;
        //GridView1.DataBind();


    }
    protected void connection()
    {
        //OracleConnection con = new OracleConnection(connectionstring);
        //string select = "select ud_id,ud_accountid,ud_loginid from as_userdtls where ud_loginid==@lname"; 
        //OracleCommand cmd = new OracleCommand(select, con);
        //cmd.Parameters.AddWithValue("@lname", txtlname.Text);
        //OracleDataReader dr;
        ////OracleDataAdapter da = new OracleDataAdapter(select, con);
        ////DataSet ds = new DataSet();
        ////da.Fill(ds);
        //try
        //{
        //    con.Open();

        //    dr = cmd.ExecuteReader();
        //    //Response.Write(select);
        //    GridView1.DataSource = dr;
        //    GridView1.DataBind();
        //}
        //catch (Exception err)
        //{
        //    lblerr.Text = err.Message;
        //}
        //finally
        //{
        //    con.Close();
        //}
    }
}
