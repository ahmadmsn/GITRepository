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
using System.Web.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using Infragistics.WebUI.UltraWebGrid;
public partial class ultrawebgrid : System.Web.UI.Page
{
    string connectionstring=WebConfigurationManager.ConnectionStrings["mydb2"].ConnectionString;
    string connectionstring2 = WebConfigurationManager.ConnectionStrings["mydb"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {

        UltraWebGrid1.DisplayLayout.ActivationObject.BorderColor = Color.Red;
        UltraWebGrid1.DisplayLayout.ActivationObject.BorderStyle = BorderStyle.Solid;
        UltraWebGrid1.DisplayLayout.ActivationObject.BorderWidth = Unit.Pixel(3);
        UltraWebGrid1.BorderColor = Color.Red;
        UltraWebGrid1.BorderStyle = BorderStyle.Solid;
        UltraWebGrid1.BorderWidth = Unit.Pixel(5);

        UltraWebGrid1.DisplayLayout.RowAlternateStyleDefault.BackColor = Color.Red;

        UltraWebGrid1.DisplayLayout.ActiveRow = UltraWebGrid1.Rows[0];
        UltraWebGrid1.DisplayLayout.ActiveRow.Style.BackColor = Color.Pink;

        UltraWebGrid1.DisplayLayout.Rows[0].Selected = true;
        UltraWebGrid1.DisplayLayout.SelectedRows.Clear();
        UltraWebGrid1.DisplayLayout.SelectedRowStyleDefault.BackColor = Color.Purple;

        string text = UltraWebGrid1.Rows[4].Cells[1].Text;
        Label1.Text = text;
        UltraWebGrid1.DisplayLayout.AddNewBox.Hidden = false;
        UltraWebGrid1.DisplayLayout.AllowAddNewDefault = Infragistics.WebUI.UltraWebGrid.AllowAddNew.Yes;
        //UltraWebGrid1.DisplayLayout.AddNewBox

        UltraWebGrid1.DisplayLayout.Rows.Add();
       UltraWebGrid1.Columns[0].Width=Unit.Pixel(200);

       UltraWebGrid1.DisplayLayout.SelectTypeRowDefault = Infragistics.WebUI.UltraWebGrid.SelectType.Single;
       UltraWebGrid1.DisplayLayout.SelectedRowStyleDefault.BackColor = Color.Orchid;

      

       
       

        
    }

    private void aftercellupdate()
    {
        throw new Exception("The method or operation is not implemented.");
    }

      
    protected void Page_Init(object sender, EventArgs e)
    {
        databinding();
    }

    protected void databinding()
    {
        SqlConnection con = new SqlConnection(connectionstring);
        SqlConnection con2=new SqlConnection(connectionstring2);
        string select = "select * from mytable2";
        string select2 = "select * from emp";
        SqlCommand cmd = new SqlCommand(select, con);
        SqlCommand cmd2 = new SqlCommand(select2, con2);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
        DataSet ds = new DataSet();
        DataSet ds2 = new DataSet();
       
        UltraWebGrid1.DisplayLayout.ViewType = Infragistics.WebUI.UltraWebGrid.ViewType.Hierarchical;

        da.Fill(ds, "mytable2");
        da.Fill(ds, "emp");
        //da2.Fill(ds2, "emp");
        ds.Relations.Add("emp", ds.Tables["mytable2"].Columns["eid"], ds.Tables["emp"].Columns["eid"]);
        
        
        UltraWebGrid1.DataSource = ds;
        UltraWebGrid1.DataBind();

        
        //UltraWebGrid2.DataSource = ds2;
        //UltraWebGrid2.DataBind();






        WebCombo1.DataSource = ds;
        WebCombo1.DataBind();
        WebCombo1.DataTextField = "ename";
        WebCombo1.DataValueField = "eid";
    }
    protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
    {

    }
}
