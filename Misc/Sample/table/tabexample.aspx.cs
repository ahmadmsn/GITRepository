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


public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btn_Click(object sender, EventArgs e)
    {
        Table table = new Table();
        for (int j = 0; j < 3; j++)
        {
            TableRow rownew = new TableRow();
            for (int i = 0; i < 2; i++)
            {
                TableCell cellnew = new TableCell();
                cellnew.Text = "hello" + j.ToString()+","+i.ToString();
                rownew.Cells.Add(cellnew);
            }
            table.Rows.Add(rownew);
        }
        Page.Controls.Add(table);
        for (int j = 0; j < table.Rows.Count; j++)
            for (int i = 0; i < 2; i++)
            {
               // lbl.Text += table[j][i] + "&nbsp;";
            }

       // int rows= rownew.Cells();
      //  int cols= cellnew.ce();
       // for (int row = 0; row < rows; row++)
        {
         //   for (int col = 0; col < cols; col++)
            {
             //   lbl.Text = Response.Write(rows[row] + "," + cols[col]);
            }
        }
    }
}
