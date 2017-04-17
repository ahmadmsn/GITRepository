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

public partial class _Default : System.Web.UI.Page 
{
    SqlConnection con = new SqlConnection("server=716E6FB4741D44F;database=pubs;integrated security=sspi");
    SqlCommand cm = new SqlCommand();
    SqlDataReader dr;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //Label1.Text = DateTimeKind.Local.ToString();

            cm.Connection = con;
            cm.CommandText = "select * from ad";
            
            
            con.Open();

            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                ddlroll.Items.Add(dr[0].ToString());
            }
            con.Close();
        }
        

    }
    protected void btninsert_Click(object sender, EventArgs e)
    {
        try
        {
            if ((txtroll.Text) == null)
            {
                Response.Write ("Enter Valid Charactor");
            }
            else
            {
                cm.Connection = con;
                cm.CommandText = "insert into student values('" + txtroll.Text + "','" + txtname.Text + "','" + txtaddress.Text + "')";
                cm.Connection = con;
                con.Open();
                cm.ExecuteNonQuery();
                if (txtroll.Text == null)
                {
                    Response.Write("Enter Atleast One number");
                }
                ddlroll.Items.Add(txtroll.Text);
                Response.Write("Your Data Is Inserted");
                txtroll.Text = " ";
                txtname.Text = " ";
                txtaddress.Text = " ";
                con.Close();
            }
        }
        catch (Exception  ex)
        {
            //Response.Write("Enter Valid Roll Number and Name and Address ");
            lblinfo.Text = "Enter Valid Roll Number and Name and Address";
            lblinfo.Text+=ex.Message ;
        }
    }
protected void  TextBox2_TextChanged(object sender, EventArgs e)
{

}
    protected void ddlroll_SelectedIndexChanged(object sender, EventArgs e)
    {
        cm.Connection=con;
        cm.CommandText="select name,address from student where rollnumber='"+ddlroll.SelectedItem.Text+"'";
        con.Open();
        dr = cm.ExecuteReader();
        while (dr.Read())
        {
            txtroll.Text = ddlroll.SelectedItem.Text;
            txtdispname.Text = dr[0].ToString();
            txtdispadd.Text = dr[1].ToString();
        }
        con.Close();
    }
    protected void btnupdate_Click(object sender, EventArgs e)
    {
        cm.Connection = con;
        cm.CommandText="update student set name='"+txtdispname.Text+"',address='"+txtdispadd.Text+"' where rollnumber='"+ddlroll.SelectedItem.Text+"'";
        con.Open();
        cm.ExecuteNonQuery();
        Response.Write("Updated Succesfully");
        lbl1.Text = "Updated Name Is: "+txtdispname.Text;
        lbl2.Text = "Update Address Is: "+txtdispadd.Text;
        
        txtdispname.Text=" ";
        txtdispadd.Text=" ";
        con.Close();

    }
    protected void btndel_Click(object sender, EventArgs e)
    {
        cm.Connection = con;
        cm.CommandText = "delete from student where rollnumber='" + ddlroll.SelectedItem.Text + "'";
        con.Open();
        cm.ExecuteNonQuery();
        ddlroll.Items.Remove(ddlroll.SelectedItem.Text);
        
        Response.Write("Deleted Successfully");
        txtdispname.Text = " ";
        txtdispadd.Text = " ";
        con.Close();
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void btnshow_Click(object sender, EventArgs e)
    {
        
        cm.Connection = con;
        cm.CommandText = "select * from student";
        
        con.Open();
        dr = cm.ExecuteReader();
        GridView1.DataSource  = dr;
        GridView1.DataBind();
        con.Close();

    }
}
