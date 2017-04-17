using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Web.Mail;


public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnsendemail_Click(object sender, EventArgs e)
    {
        try
        {
            MailMessage mail = new MailMessage();
            mail.To = txtto.Text;
            mail.From = new MailMessage "kekde@neerajkekde.com";//txtfrom.Text;
            mail.Subject = txtsub.Text;
            mail.Body = txtwrite.Text;
            SmtpMail.SmtpServer = "smtp.acusis.com";
            SmtpMail.Send(mail);
            Page.RegisterStartupScript("aa", "<script>alert('mail1 sent successfully')</script>");

        }
        catch (Exception ex)
        {
            string m_strError = ex.Message;
            Page.RegisterStartupScript("aa", "<script>alert('+ m_strError + ')</script>");
        }


    }
    protected void btnattachfile_Click(object sender, EventArgs e)
    {
        
        MailMessage mail=new MailMessage();
        string attachedFile = File1.PostedFile.FileName;
        if (attachedFile != "")
        {
            FileList.Items.Add(attachedFile);
        }
        MailAttachment attachment = null;
        try
        {
            if (FileList.Items.Count > 0)
            {
                foreach (ListItem l in FileList.Items)
                {
                    Response.Write(l.Text);
                    attachment = new MailAttachment(l.Text);
                    mail.Attachments.Add(attachment);
                }
            }
            Response.Write("Number Of Attachments are" + mail.Attachments.Count);
            SmtpMail.SmtpServer= "smtp.acusis.com";
            SmtpMail.Send(mail);
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }

    }
   
}

