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

public partial class Connectedapproach : System.Web.UI.Page
{
    SqlConnection cn = new SqlConnection("data source=stg-1cc267aa387;database=mydatabase;uid=sa;pwd=stg");//"Data Source=stg-1cc267aa387\\SQLEXPRESS;Initial Catalog=mydatabase;Integrated Security=True");
    SqlCommand cm = new SqlCommand();
    SqlDataReader dr;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            cm.Connection = cn;
            cm.CommandText = "select id from person";
            cn.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                DropDownList1.Items.Add(dr[0].ToString());
            }
            cn.Close();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        cm.Connection = cn;
        cm.CommandText="insert into person values('"+TextBox1.Text+"','"+TextBox2.Text +"','"+TextBox3.Text+"')";
        cn.Open();
        cm.ExecuteNonQuery();
        DropDownList1.Items.Add(TextBox1.Text);
        Response.Write("inserted successfully");
        TextBox3.Text = " ";
        TextBox2.Text = " ";
        TextBox1.Text = " ";
        cn.Close();
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        cm.Connection = cn;
        cm.CommandText = "select name,address from person where id='" + DropDownList1.SelectedItem.Text + "'";
        cn.Open();
        dr=cm.ExecuteReader();
        if (dr.Read())
        {
            TextBox5.Text = dr[0].ToString();
            TextBox6.Text = dr[1].ToString();
        }
        cn.Close();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        cm.Connection = cn;
        cm.CommandText = "update person set name='" + TextBox5.Text + "',address='" + TextBox6.Text + "' where id='" + DropDownList1.SelectedItem.Text + "'";
        cn.Open();
        cm.ExecuteNonQuery();
        Response.Write("update successful ");
        TextBox6.Text = " ";
        TextBox5.Text = " ";
        cn.Close();
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        cm.Connection = cn;
        cm.CommandText = "delete from person where id='" + DropDownList1.SelectedItem.Text + "'";
        cn.Open();
        cm.ExecuteNonQuery();
        DropDownList1.Items.Remove(DropDownList1.SelectedItem.Text);
        Response.Write("delete successful ");
        TextBox6.Text = " ";
        TextBox5.Text = " ";
        cn.Close();
    }
}
