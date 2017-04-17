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
    protected void Page_Load(object sender, EventArgs e)
    {
        tbl.BorderStyle = BorderStyle.Inset;
        tbl.BorderWidth = Unit.Pixel(1);
    }
    protected void cmdcreate_Click(object sender, EventArgs e)
    {
        tbl.Controls.Clear();

        int rows = Int32.Parse(txtrow.Text);
        int cols = Int32.Parse(txtcol.Text);

        for (int row = 0; row < rows; row++)
        {
            TableRow rownew = new TableRow();
            tbl.Controls.Add(rownew);

            for (int col = 0; col < cols; col++)
            {
                TableCell cellnew = new TableCell();

                rownew.Controls.Add(cellnew);

                Label lblnew = new Label();
                lblnew.Text = "Example cell (" + row.ToString() + "," + col.ToString() + ")";
                System.Web.UI.WebControls.Image newimage = new System.Web.UI.WebControls.Image();
                newimage.ImageUrl = "wpaflag.jpg";
                cellnew.Controls.Add(lblnew);
                cellnew.Controls.Add(newimage);
                
                
                
                //cellnew.Text = "Example Cell (" + row.ToString() + ",";
                //ellnew.Text += col.ToString() + ")";

                if (chkborder.Checked)
                {
                    cellnew.BorderStyle = BorderStyle.Inset;
                    cellnew.BorderWidth = Unit.Pixel(10);
                    
                }
                
            }
        }
    }
}
