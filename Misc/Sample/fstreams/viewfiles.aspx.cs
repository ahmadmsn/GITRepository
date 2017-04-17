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
using System.IO;

public partial class viewfiles : System.Web.UI.Page
{
    private string ftpdirectory;
    protected void Page_Load(object sender, EventArgs e)
    {
        //ftpdirectory = Path.Combine(Request.PhysicalApplicationPath, "ftp");
        
        string absolutepath = @"D:\admiral\code";
        //string subpath = @"ftp\samplefile1.txt";
        ftpdirectory = Path.Combine(absolutepath,"ftp");
        if (!IsPostBack)
        {
            createfile();
        }
    }
    private void createfile()
    {
        string[] filelist = Directory.GetFiles(ftpdirectory);
        lstfiles.DataSource = filelist;
        lstfiles.DataBind();
        lblinfo.Text = "";
        Btndel.Enabled = false;
    }

    protected void btnref_Click(object sender, EventArgs e)
    {
        createfile();
    }
    protected void lstfiles_SelectedIndexChanged(object sender, EventArgs e)
    {
        System.Text.StringBuilder displaytext = new System.Text.StringBuilder();
        string filename = lstfiles.SelectedItem.Text;
        displaytext.Append("<b>");
        displaytext.Append(filename);
        displaytext.Append("</b><br /><br />");
        displaytext.Append("Created:");
        displaytext.Append(File.GetCreationTime(filename).ToString());
        displaytext.Append("<br />");
        displaytext.Append("Last Access Time:");
        displaytext.Append(File.GetLastAccessTime(filename).ToString());
        displaytext.Append("<br />");
        FileAttributes attribute=File.GetAttributes(filename);
        if((attribute & FileAttributes.Hidden)==FileAttributes.Hidden)
        {
            displaytext.Append("This Is Hidden File<br />");
        }
        if((attribute & FileAttributes.ReadOnly)==FileAttributes.ReadOnly)
        {
            displaytext.Append("this file is read only");
        }
        else
        {
            Btndel.Enabled=true;
        }
        lblinfo.Text=displaytext.ToString();
     }

    protected void Btndel_Click(object sender, EventArgs e)
    {
        File.Delete(lstfiles.SelectedItem.Text);
        createfile();
    }
}
