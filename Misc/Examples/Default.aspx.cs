using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class _Default : System.Web.UI.Page 
{
    string s = " ";
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Write(HiddenField1.Value);
        Table t = new Table();
        for (int i = 0; i < 3; i++)
        {
            TableRow tr = new TableRow();
            for (int j = 0; j < 3; j++)
            {
                TableCell tc = new TableCell();
                tc.Text = j.ToString();
                tr.Cells.Add(tc);

            }
            t.Rows.Add(tr);
        }
      
        t.BackColor = System.Drawing.Color.Aqua;
        t.BorderColor = System.Drawing.Color.Blue ;
        t.BorderStyle = BorderStyle.Solid;
        t.GridLines = GridLines.Both;
        this.Controls.Add(t);
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        
        if (CheckBox1.Checked)
        {
            s += CheckBox1.Text;
        }
        if (CheckBox2.Checked)
        {
            s += ","+CheckBox2.Text;
        }
        if (CheckBox3.Checked)
        {
            s += ","+CheckBox3.Text;
        
        }
        Response.Write(s);
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        for(int i=0;i<CheckBoxList1.Items.Count;i++)
        {
       if(CheckBoxList1.Items[i].Selected)
       {
       s+=CheckBoxList1.Items[i].Text+",";
       }
        }
        Response.Write(s);
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Write(RadioButtonList1.SelectedItem.Text);
    }
    protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {

    }
    protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
