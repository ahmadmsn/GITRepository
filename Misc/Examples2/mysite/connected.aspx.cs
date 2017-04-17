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

public partial class _Default : System.Web.UI.Page 
{
    string connectionstring = ConfigurationManager.AppSettings["mydb"].ToString();
    //string connectionstring = WebConfigurationManager.ConnectionStrings["mydb"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void cmdinsert_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(connectionstring);
        string insert = "insert into mytable values(@eid,@ename)";
        SqlCommand cmd = new SqlCommand(insert, con);
        cmd.Parameters.AddWithValue("@eid", txteid.Text);
        cmd.Parameters.AddWithValue("@ename", txtname.Text);
        try
        {
            con.Open();
            cmd.ExecuteNonQuery();
        }
        catch (Exception err)
        {
            lblerr.Text = err.Message;
        }
        finally
        {
            con.Close();
        }

    }
    protected void cmddel_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(connectionstring);
        string delete = "delete from mytable where eid=@eid";
        SqlCommand cmd = new SqlCommand(delete, con);
        cmd.Parameters.AddWithValue("@eid", txteid.Text);
        try
        {
            con.Open();
            cmd.ExecuteNonQuery();
        }
        catch (Exception err)
        {
            lblerr.Text = err.Message;
        }
        finally
        {
            con.Close();
            lblerr.Text = "Deleted Successfully";
        }
    }
    protected void cmdupdate_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(connectionstring);
        string update = "update mytable set name=@name where eid=@eid";
        SqlCommand cmd = new SqlCommand(update, con);
        cmd.Parameters.AddWithValue("@eid", txteid.Text);
        cmd.Parameters.AddWithValue("@name", txtname.Text);
        try
        {
            con.Open();
            cmd.ExecuteNonQuery();
        }
        catch (Exception err)
        {
            lblerr.Text = err.Message;
        }
        finally
        {
            con.Close();
            lblerr.Text=("Updated Successfully");
        }
    }
    protected void cmdshow_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(connectionstring);
        string select = "select * from mytable where eid=@eid";
        SqlCommand cmd = new SqlCommand(select, con);
        cmd.Parameters.AddWithValue("@eid", txteid.Text);
        SqlDataReader dr;
        try
        {
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtname.Text = dr["name"].ToString();
            }
        }
        catch (Exception err)
        {
            lblerr.Text = err.Message;
        }
        finally
        {
            con.Close();
        }
    }
    protected void cmdgrid_Click(object sender, EventArgs e)
    {
        SqlConnection con=new SqlConnection(connectionstring);
        string select="select * from mytable";
        SqlCommand cmd=new SqlCommand(select,con);
        SqlDataReader dr;
        try
        {
            con.Open();
            dr=cmd.ExecuteReader();
            
            GridView1.DataSource=dr;
            GridView1.DataBind();
            
        }
        catch(Exception err)
        {
            lblerr.Text=err.Message;
        }
        finally
        {
            con.Close();
        }

    }
}
