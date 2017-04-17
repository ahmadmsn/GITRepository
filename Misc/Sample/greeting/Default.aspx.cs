using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.ComponentModel;


public partial class _Default : System.Web.UI.Page 
{
    string file;
    protected void Page_Load(object sender, EventArgs e)
    {
       



        Image1.ImageUrl = "kar64a.jpg";
        
        ListItem item = new ListItem();
        item.Text = BorderStyle.None.ToString();
        item.Value = ((int)BorderStyle.None).ToString();

        InstalledFontCollection fname = new InstalledFontCollection();

        foreach (FontFamily i in fname.Families)
        {
            fontname.Items.Add(i.Name);
        }
        
            filelst.Items.Clear();
            try
            {
                DirectoryInfo dir = new DirectoryInfo(Server.MapPath("image"));
                foreach (FileInfo myfile in dir.GetFiles())
                {
                    filelst.Items.Add(myfile.Name);
                }
            }
            catch 
            {
                //finish;
            }
           // filelst.SelectedIndex = -1;

            string[] colorarray = Enum.GetNames(typeof(KnownColor));
            backcolor.DataSource = colorarray;
            backcolor.DataBind();

            string[] borderstylearray = Enum.GetNames(typeof(BorderStyle));
            borderlistbtn.DataSource = borderstylearray;
            borderlistbtn.DataBind();

            mylabl.Text = "This Is My WebSite";


            

    }
    protected void cmdupdate_Click(object sender, EventArgs e)
    {
        pnl.BackColor = Color.FromName(backcolor.SelectedItem.Text);



        TypeConverter c = TypeDescriptor.GetConverter(typeof(BorderStyle));
        pnl.BorderStyle = (BorderStyle)c.ConvertFromString("Solid");        
        
        
        if (Chkbox.Checked)
        {
            Image1.Visible = true;

        }
        else
        {
            Image1.Visible = false;
        }

        Image1.ImageUrl = "~\\"+"image"+"\\" + filelst.SelectedItem.Text;

       /* if (backcolor.SelectedItem.Text == "White" ) 
        {
            pnl.BackColor = Color.White;
        }
        if (backcolor.SelectedItem.Text == "Red")
        {
            pnl.BackColor = Color.Red;
        }
        if (backcolor.SelectedItem.Text == "Pink")
        {
            pnl.BackColor = Color.Pink;
        }*/

        if (txtfontsize.Text.Trim().Length==0)
        {
            lblgreeting.Font.Size = 10;

        }
        else
        {
            lblgreeting.Font.Size = Convert.ToInt32(txtfontsize.Text);
        }

        lblgreeting.Text = msg.Text;

       /* if (rbbdrnone.Checked == true)
        {
            pnl.BorderStyle = BorderStyle.None;
        }
        if (rbdouble.Checked == true)
        {
            pnl.BorderStyle = BorderStyle.Double;
        }
        if (rbbdrsolid.Checked == true)
        {
            pnl.BorderStyle = BorderStyle.Solid;
        }*/
        lblgreeting.Font.Name = fontname.SelectedItem.Text;
        
        


       

    }
    protected void cmddownload_Click(object sender, EventArgs e)
    {
        
        FileUpload1.SaveAs(Server.MapPath("image") + "\\"  + FileUpload1.FileName);
        file = Server.MapPath("image") + "\\" + FileUpload1.FileName;
        Image1.ImageUrl = file;
    }
    protected void filelst_SelectedIndexChanged(object sender, EventArgs e)
    {
        
       
    }
}
