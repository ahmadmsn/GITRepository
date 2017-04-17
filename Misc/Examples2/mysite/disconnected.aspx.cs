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
using System.Data.SqlClient;
using System.Web.Configuration;

public partial class disconnected : System.Web.UI.Page
{
    string connectionstring = ConfigurationManager.AppSettings["mydb"].ToString();
    
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void cmdinsert_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(connectionstring);
        string select = "select * from mytable";
        SqlCommand cmd = new SqlCommand(select, con);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();       
        da.Fill(ds, "mytable");
        DataRow dr=ds.Tables[0].NewRow();
        dr[0] = txteid.Text;
        dr[1] = txtname.Text;
        ds.Tables[0].Rows.Add(dr);     

        SqlCommandBuilder cb = new SqlCommandBuilder(da);
        try
        {
            da.Update(ds, "mytable");
        }
        catch (Exception err)
        {
            lblerr.Text = err.Message;
        }
        lblerr.Text = "Your Record Is Successfully Inserted";
        
    }
    protected void cmddel_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(connectionstring);
        string select = "select * from mytable";
        SqlCommand cmd=new SqlCommand(select,con);
        
        SqlDataAdapter da=new SqlDataAdapter(cmd);
        DataSet ds=new DataSet();
        da.Fill(ds,"mytable");
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            DataRow dr = ds.Tables[0].Rows[i];
            if (dr[0].ToString() == txteid.Text)
            {
                ds.Tables[0].Rows[i].Delete();
            }
        }
        SqlCommandBuilder cb = new SqlCommandBuilder(da);
        da.Update(ds, "mytable");
        lblerr.Text = "Your Record Is successfully deleted";

    }
    protected void cmdupdate_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(connectionstring);
        string select = "select * from mytable";
        SqlDataAdapter da = new SqlDataAdapter(select, con);
        DataSet ds = new DataSet();
        da.Fill(ds, "mytable");
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            DataRow dr = ds.Tables[0].Rows[i];
            if (dr[0].ToString() == txteid.Text)
            {
                dr[1] = txtname.Text;
            }
        }
        SqlCommandBuilder cb = new SqlCommandBuilder(da);
        da.Update(ds, "mytable");
        lblerr.Text = "Your Record Is Successfully Updated";
    }
    protected void cmdshow_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(connectionstring);
        string select = "select * from mytable";
        SqlDataAdapter da = new SqlDataAdapter(select,con);
        DataSet ds = new DataSet();
        da.Fill(ds, "mytable");
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            DataRow dr = ds.Tables[0].Rows[i];
            if (dr[0].ToString() == txteid.Text)
            {
                txtname.Text = dr[1].ToString();
                break;
            }
            else if (dr[0].ToString() != txteid.Text)
            {
                txteid.Text = "";
                txtname.Text = "";
                lblerr.Text = "There is no record";
            }            
        }
    }
    protected void cmdgrid_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(connectionstring);
        string select = "select * from mytable";
        SqlDataAdapter da = new SqlDataAdapter(select, con);
        DataSet ds = new DataSet();
        da.Fill(ds, "mytable");
        GridView1.DataSource = ds;
        GridView1.DataBind();
        UltraWebGrid1.DataSource = ds;
        UltraWebGrid1.DataBind();
    }
    protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
    {
      
    }
}
