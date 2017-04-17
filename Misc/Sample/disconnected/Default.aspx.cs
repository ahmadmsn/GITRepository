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

    int i;
    string connectionstring = WebConfigurationManager.ConnectionStrings["addb"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string selectsql = "select au_id,au_lname,au_fname,phone,address,city,state,zip from authors";
            SqlConnection con = new SqlConnection(connectionstring);
            SqlCommand cmd = new SqlCommand(selectsql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();


            da.Fill(ds, "authors");
            for (int i = 0; i < ds.Tables["authors"].Rows.Count; i++)
            {
                DataRow dr = ds.Tables["authors"].Rows[i];
                ListItem newitem = new ListItem();
                newitem.Text = dr["au_lname"] + "," + dr["au_fname"];
                newitem.Value = dr["au_id"].ToString();
                ddl.Items.Add(newitem);

            }
        }
       

        
    }
    protected void ddl_SelectedIndexChanged(object sender, EventArgs e)
    {
        string show = "select * from authors where au_id='"+ddl.SelectedValue+"'";
        SqlConnection con = new SqlConnection(connectionstring);
        SqlCommand cmd = new SqlCommand(show, con);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        

        da.Fill(ds, "authors");
        for(int i=0;i<ds.Tables[0].Rows.Count;i++)
        {
            
            DataRow dr=ds.Tables["authors"].Rows[i];
            //Response.Write(dr[1].ToString());
            //txtid.Text = ddl.SelectedValue.ToString();
            txtid.Text = dr["au_id"].ToString();
            txtfname.Text = dr["au_lname"].ToString();
            txtlname.Text = dr["au_fname"].ToString();
            txtphone.Text = dr["phone"].ToString();
            txtaddress.Text = dr["address"].ToString();
            txtcity.Text = dr["city"].ToString();
            txtstate.Text = dr["state"].ToString();
            txtzip.Text = dr["zip"].ToString();

            
          }

    }
    protected void btnupdate_Click(object sender, EventArgs e)
    {
        string update = "select * from authors";
        SqlConnection con = new SqlConnection(connectionstring);
        SqlCommand cmd = new SqlCommand(update, con);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds, "authors");
        for (int i = 0; i < ds.Tables["authors"].Rows.Count; i++)
        {
            DataRow dr = ds.Tables["authors"].Rows[i];
            if (dr[0].ToString() == ddl.SelectedItem.Text)
            {
                dr[0] = txtid.Text;
                dr[1] = txtfname.Text;
                dr[2] = txtlname.Text;
                dr[3] = txtphone.Text;
                dr[4] = txtaddress.Text;
                dr[5] = txtcity.Text;
                dr[6] = txtstate.Text;
                dr[7] = txtzip.Text;
            }

        }
        SqlCommandBuilder b = new SqlCommandBuilder(da);
        da.Update(ds.Tables["authors"]);
        ddl.Items.Add(txtlname.Text  + "," + txtfname.Text);
        lblinfo.Text = "Updated Successfully........";

    }
    protected void btnfirst_Click(object sender, EventArgs e)
    {
        string next="select * from authors";
        SqlConnection con = new SqlConnection(connectionstring);
        SqlCommand cmd = new SqlCommand(next, con);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds, "authors");
        DataRow dr = ds.Tables[0].Rows[0];
        txtid.Text = dr[0].ToString();
        txtid.Text = dr[0].ToString();
        txtfname.Text = dr[1].ToString();
        txtlname.Text = dr[2].ToString();
        txtphone.Text = dr[3].ToString();
        txtaddress.Text = dr["phone"].ToString();
        txtcity.Text = dr["city"].ToString();
        txtstate.Text = dr["state"].ToString();
        txtzip.Text = dr["zip"].ToString();
        ViewState.Add("status", 0);
    }
    protected void btnnxt_Click(object sender, EventArgs e)
    {
        i = Convert.ToInt32(ViewState["status"]);
        i++;
        string next="select * from authors";
        SqlConnection con = new SqlConnection(connectionstring);
        SqlCommand cmd = new SqlCommand(next, con);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds, "authors");
        if (i == ds.Tables[0].Rows.Count)
            i = 0;
        DataRow dr = ds.Tables[0].Rows[i];
        txtid.Text = dr[0].ToString();
        txtid.Text = dr[0].ToString();
        txtfname.Text = dr[1].ToString();
        txtlname.Text = dr[2].ToString();
        txtphone.Text = dr[3].ToString();
        txtaddress.Text = dr["phone"].ToString();
        txtcity.Text = dr["city"].ToString();
        txtstate.Text = dr["state"].ToString();
        txtzip.Text = dr["zip"].ToString();
        ViewState.Add("status", i);
    }
    protected void btncreate_Click(object sender, EventArgs e)
    {
        txtid.Text = " ";
        txtid.Text = " ";
        txtfname.Text = " ";
        txtlname.Text = " ";
        txtphone.Text = " ";
        txtaddress.Text = " ";
        txtcity.Text = " ";
        txtstate.Text = " ";
        txtzip.Text = " ";
    }
    protected void btninsert_Click(object sender, EventArgs e)
    {
        string insert = "select * from authors";
        SqlConnection con = new SqlConnection(connectionstring);
        SqlCommand cmd = new SqlCommand(insert, con);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds, "authors");
        ds.Tables["authors"].Rows.Add(txtid.Text, txtfname.Text, txtlname.Text, txtphone.Text, txtaddress.Text, txtcity.Text, txtstate.Text, txtzip.Text);
        SqlCommandBuilder b = new SqlCommandBuilder(da);
        da.Update(ds.Tables["authors"]);
        ddl.Items.Add(txtlname.Text + " , " + txtfname.Text);
        lblinfo.Text="Inserted Succefully..........";
    }
    protected void btndelete_Click(object sender, EventArgs e)
    {
        string delete = "Select * from authors";
        SqlConnection con = new SqlConnection(connectionstring);
        SqlCommand cmd = new SqlCommand(delete, con);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds, "authors");
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            DataRow dr = ds.Tables[0].Rows[i];
            if (dr[0].ToString() == ddl.SelectedItem.Text)
            {
                ds.Tables["authors"].Rows[i].Delete();
            }
        }
        SqlCommandBuilder b = new SqlCommandBuilder(da);
        da.Update(ds.Tables["authors"]);
        ddl.Items.Remove(ddl.Text);
        txtid.Text = " ";
        txtid.Text = " ";
        txtfname.Text = " ";
        txtlname.Text = " ";
        txtphone.Text = " ";
        txtaddress.Text = " ";
        txtcity.Text = " ";
        txtstate.Text = " ";
        txtzip.Text = " ";
        lblinfo.Text = "Deleted Successfully............";

    }
}