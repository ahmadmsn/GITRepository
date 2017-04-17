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

public partial class Forms : System.Web.UI.Page
{
    string myconnection = WebConfigurationManager.ConnectionStrings["addb"].ConnectionString;
    string eval;
    protected void CustomValidator2_ServerValidate(object source, ServerValidateEventArgs args)
    {
        try
        {
            int val = Int32.Parse(args.Value.Substring(0, 3));
            //Response.Write(val.ToString());
            if (val % 7 == 0)
            {
                args.IsValid = true;
            }
            else
            {
                args.IsValid = false;
            }
        }
        catch
        {
            args.IsValid = false;
        }
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
    protected void btnnew_Click(object sender, EventArgs e)
    {
        txtname.Text = "";
        txtpwd.Text = "";
        txtpwd2.Text = "";
        txtmail.Text = "";
        txtage.Text = "";
        txtreffered.Text = "";
    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {

        string insert = "select * from form";
        SqlConnection con = new SqlConnection(myconnection);
        SqlCommand cmd = new SqlCommand(insert, con);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds, "form");



        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            DataRow dr = ds.Tables[0].Rows[i];
            //eval = dr[2].ToString();
            if (dr[2].ToString() == txtmail.Text)
            {
                da.Dispose();
                Label1.Text = "This Mail Id is Alredy exist";
            }
            else
            {
                ds.Tables["form"].Rows.Add(txtname.Text, txtpwd.Text, txtmail.Text, txtage.Text, txtreffered.Text);
                SqlCommandBuilder sb = new SqlCommandBuilder(da);
                da.Update(ds.Tables["form"]);
                Response.Write("Inserted Succefully");
            }
        }
        //ds.Tables["form"].Rows.Add(txtname.Text, txtpwd.Text, txtmail.Text, txtage.Text, txtreffered.Text);
        //SqlCommandBuilder sb = new SqlCommandBuilder(da);
        //da.Update(ds.Tables["form"]);
        //Response.Write("Inserted Succefully");


        //if (eval == txtmail.Text)
        //{
        //    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        //    {
        //        DataRow dr1 = ds.Tables[0].Rows[i];
        //        eval = dr1.ToString();
        //    }

        //    SqlCommandBuilder sb1 = new SqlCommandBuilder(da);
        //   da.Dispose();
        //   Label1.Text="This Mail Id is Alredy exist";
        //}
        //else
        //{

        //    ds.Tables["form"].Rows.Add(txtname.Text, txtpwd.Text, txtmail.Text, txtage.Text, txtreffered.Text);
        //    SqlCommandBuilder sb = new SqlCommandBuilder(da);
        //    da.Update(ds.Tables["form"]);
        //    Response.Write("Inserted Succefully");
        //}


    }
   }
    
