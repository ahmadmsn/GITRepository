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
using System.ComponentModel;

public partial class WebUserControl : System.Web.UI.UserControl
{
    private string SaveToPath = "";
    private string VirtualPath = "";

    # region File Upload Control Properties
    [Browsable(true), Category("Properties"), Description("Save Location Of File")]
    public string File_Save_Path
    {
        get
        {
            return SaveToPath;
        }
        set
        {
            SaveToPath = value;
        }
    }
    [Browsable(true), Category("Properties"), Description("Virtual Path Od Document")]
    public string Virtual_Path
    {
        get
        {
            return VirtualPath;
        }
        set
        {
            VirtualPath = value;
        }
    }
    #endregion
    protected void Page_Load(object sender, EventArgs e)
    {
        //string lblError="";
        lblError.Text = "";
        if (!Page.IsPostBack)
        {
            if (VirtualPath.Length == 0)
            {
                lblError.Text = "Virtual Path Property Is Not been set";
                Panel_Control.Enabled = false;
                return;
            }
            else if (SaveToPath.Length == 0)
            {
                lblError.Text = "Save To Path roperty is not set";
                Panel_Control.Enabled = false;
                return;
            }
            else
            {
                if (ValidatePath() == true)
                {
                    if (ShowAllFiles() == false)
                    {
                        Panel_Control.Enabled = false;
                        return;
                    }
                }
                else
                {
                    Panel_Control.Enabled = true;
                    return;
                }
            }
        }
    }
    public bool ValidatePath()
    {
        try
        {
            if (System.IO.Directory.Exists(SaveToPath) == false)
            {
                System.IO.Directory.CreateDirectory(SaveToPath);
                return true;
            }
            else
            {
                return true;
            }
        }
        catch (Exception ex)
        {
            lblError.Text = "Error " + ex.Message;
            return false;
        }
    }
    private bool ShowAllFiles()
    {
        try
        {
            lstDocs.Items.Clear();
            string[] SubFiles = Directory.GetFiles(SaveToPath);
            foreach (string file_obj in SubFiles)
            {
                string doc_name = System.IO.Path.GetFileName(file_obj);
                ListItem tempitem = new ListItem(doc_name, file_obj);
                lstDocs.Items.Add(tempitem);
            }
            return true;
        }
        catch (Exception ex)
        {
            lblError.Text = "Error " + ex.Message;
            return false;
        }
    }
    protected void btnUpload_Click(object sender, EventArgs e)
    {
        try
        {

            if (filePSE.PostedFile.FileName == "" || filePSE.PostedFile.ContentLength == 0)
            {

                return;

            }



            string path = filePSE.PostedFile.FileName;

            string doc_name = System.IO.Path.GetFileName(path);

            string err = "";



            bool isSafeFile = CheckExtensions(doc_name);

            if (isSafeFile == false)
            {

                return;

            }



            if (System.IO.File.Exists(SaveToPath + doc_name))
            {

                this.lblError.Text = "A file with this name already exists.";

                return;

            }



            filePSE.PostedFile.SaveAs(SaveToPath + doc_name);



            //Create list item with text as document name

            //and value as full path

            ListItem item = new ListItem(doc_name, SaveToPath + doc_name);



            //add to list box

            lstDocs.Items.Add(item);



            this.lblError.Text = "File uploaded successfully.";



        }

        catch (Exception ex)
        {

            Response.Write("Error Uploading File: " + ex.Message.ToString());

            Response.End();

        }

    }



    /// <summary>

    /// Delete File

    /// </summary>

    protected void btnDelete_Click(object sender, EventArgs e)
    {

        try
        {

            if (this.lstDocs.Items.Count == 0)
            {

                lblError.Text = "No items to delete";

                return;

            }

            else if (this.lstDocs.SelectedIndex == -1)
            {

                lblError.Text = "Please select an item to delete";

                return;

            }

            else
            {

                //get temp of selected item

                string path = lstDocs.SelectedItem.Value;



                //delete the file

                System.IO.File.Delete(path);



                //Remove list item

                lstDocs.Items.Remove(lstDocs.SelectedItem);



                this.lblError.Text = "File deleted successfully.";

            }

        }

        catch (Exception ex)
        {

            Response.Write("Error Deleting File: " + ex.Message.ToString());

            Response.End();

        }

    }



    /// <summary>

    /// Check if it part of allowed extensions

    /// </summary>

    private bool CheckExtensions(string filename)
    {

        try
        {

            /*

            if ( (filename.ToLower().LastIndexOf(".doc") == -1) &&

                 (filename.ToLower().LastIndexOf(".pdf") == -1) &&

                 (filename.ToLower().LastIndexOf(".ppt") == -1) &&

                 (filename.ToLower().LastIndexOf(".txt") == -1) &&

                 (filename.ToLower().LastIndexOf(".xls") == -1)      )

            */

            if ((filename.ToLower().LastIndexOf(".exe") != -1))
            {

                this.lblError.Text = "This type of file cannot be uploaded.";

                return false;

            }

            else
            {
                return true;
            }
        }

        catch (Exception ex)
        {

            Response.Write("Error: " + ex.Message.ToString());

            Response.End();

            //The line below will never execute.

            return false;

        }

    }
    /// <summary>

    /// Checks if we have any items, and if so generates javascript for double click.

    /// </summary>

    protected override void OnPreRender(EventArgs e)
    {

        if (lstDocs.Items.Count > 0)
        {

            /*

            if you want to alert the value for error checking, use the following:

            this.lstDocs.Attributes["ondblclick"] = "alert(this.options[this.selectedIndex].text); window.open('" + Virtual_Path + "' + this.options[this.selectedIndex].text );";

            instead of

            */

            this.lstDocs.Attributes["ondblclick"] = "window.open('" + Virtual_Path + "' + this.options[this.selectedIndex].text );";

        }

        else
        {

            this.lstDocs.Attributes.Remove("ondblclick");

        }

        base.OnPreRender(e);

    }

}

