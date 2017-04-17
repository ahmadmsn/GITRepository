using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.IO;
using System.Collections.Generic;

public class bookentry
{
    private string author;
    public string Author
    {
        get
        {
            return author;
        }
        set
        {
            author = value;
        }
    }
    private DateTime submitted;
    public DateTime Submitted
    {
        get
        {
            return submitted;
        }
        set
        {
            submitted = value;
        }
    }
    private string message;
    public string Message
    {
        get
        {
            return message;
        }
        set
        {
            message = value;
        }
    }
}
public partial class _Default : System.Web.UI.Page 
{
    private string guestbookname;
            
    protected void Page_Load(object sender, EventArgs e)
    {
        guestbookname = Server.MapPath("default.aspx");
        if(!IsPostBack)
        {
            guestbooklist.DataSource = getallentries();
            guestbooklist.DataBind();
        }        
    }

    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        bookentry newentry = new bookentry();
        newentry.Author = txtname.Text;
        newentry.Submitted = DateTime.Now;
        newentry.Message = txtmessage.Text;

        try
        {
            saveentry(newentry);
        }
        catch(Exception err)
        {
            lblerr.Text = err.Message + " File Not saved";
            return;
        }
        guestbooklist.DataSource = getallentries();
        guestbooklist.DataBind();
        txtname.Text="";
        txtmessage.Text="";
    }
    private List <bookentry> getallentries()
    {
        List<bookentry> entries=new List<bookentry>();
        try
        {
            DirectoryInfo guestbookdir=new DirectoryInfo(guestbookname);
            foreach(FileInfo fileitem in guestbookdir.GetFiles())
            {
                try
                {
                    entries.Add(getentryfromfile(fileitem));
                }
                catch(Exception err)
                {
                    lblerr.Text = err.Message;
                }
            }
        }
        catch(Exception err)
        {
            lblerr.Text = err.Message;
        }
        return entries;
    }
    private bookentry getentryfromfile(FileInfo entryfile)
    {
        bookentry newentry = new bookentry();
        StreamReader sr = entryfile.OpenText();
        newentry.Author = sr.ReadLine();
        newentry.Submitted = DateTime.Parse(sr.ReadLine());
        newentry.Message = sr.ReadLine();
        sr.Close();
        return newentry;
    }
    private void saveentry(bookentry entry)
    {
        Random random = new Random();
        string filename = guestbookname + @"\";
        filename += DateTime.Now.Ticks.ToString() + random.Next(100).ToString();
        FileInfo newfile = new FileInfo(filename);
        StreamWriter sw = newfile.CreateText();
        sw.WriteLine(entry.Author);
        sw.WriteLine(entry.Submitted);
        sw.WriteLine(entry.Message);
        sw.Flush();
        sw.Close();
    }
}

