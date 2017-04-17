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
using System.Drawing.Text;
using System.Drawing.Design;
using System.Windows.Forms;
using Infragistics.WebUI.UltraWebGrid;
using Microsoft.Win32;
using System.IO;
using System.Xml;

public partial class Default2 : System.Web.UI.Page
{
    string connectionstring = WebConfigurationManager.ConnectionStrings["mydb"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
        UltraWebGrid1.DataBind();
        string file=Path.Combine(Request.PhysicalApplicationPath,@"app_data\myfile.xml");
        DataSet ds = new DataSet();
        ds.ReadXml(file);
        UltraWebGrid2.DataSource = ds;
        UltraWebGrid2.DataBind();

    }
    protected override void OnInit(EventArgs e)
    {
       
        initializecomponent();
        base.OnInit(e);
    }
    private void initializecomponent()
    {
        SqlConnection con = new SqlConnection(connectionstring);
        string select = "select * from emp";
        SqlCommand cmd = new SqlCommand(select, con);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds, "mytable");
        UltraWebGrid1.DataSource = ds;       
        //UltraWebGrid1.BorderStyle = BorderStyle.Solid;
        UltraWebGrid1.PageIndexChanged += new Infragistics.WebUI.UltraWebGrid.PageIndexChangedEventHandler(ultrawebgrid1_pageindexchanged);
        UltraWebGrid1.InitializeLayout += new InitializeLayoutEventHandler(UltraWebGrid1_InitializeLayout);
    }
    private void ultrawebgrid1_pageindexchanged(Object sender,Infragistics.WebUI.UltraWebGrid.PageEventArgs e)
    {
        UltraWebGrid1.DisplayLayout.Pager.CurrentPageIndex = e.NewPageIndex;
        UltraWebGrid1.DataBind();
    }
    private void UltraWebGrid1_InitializeLayout(object sender, System.Windows.Forms.LayoutEventArgs e)
    {
        UltraWebGrid1.Bands[0].Columns.FromKey("eid").HeaderText="EmployeeId";
        UltraWebGrid1.Bands[0].Columns.FromKey("eid").CellStyle.HorizontalAlign = HorizontalAlign.Center;
        UltraWebGrid1.Bands[0].Columns.FromKey("name").Width = new Unit("120px");
        UltraWebGrid1.Bands[0].Columns.FromKey("name").Hidden = true;
        UltraWebGrid1.Bands[0].DefaultColWidth = new Unit("180 px");
        UltraWebGrid1.Bands[1].DefaultColWidth = new Unit("100 px");

        UltraWebGrid1.Bands[1].SelectTypeCol = SelectType.Extended;
        UltraWebGrid1.Bands[1].HeaderClickAction = HeaderClickAction.Select;

        UltraWebGrid1.DisplayLayout.Bands[0].Columns[0].Header.Caption = "Employee ID";
        UltraWebGrid1.DisplayLayout.Bands[0].Columns[1].Header.Caption = "Employee Name";
    }
    protected void ug1_databind(object sender, EventArgs e)
    {
    }
    protected void UltraWebGrid1_InitializeLayout(object sender, Infragistics.WebUI.UltraWebGrid.LayoutEventArgs e)
    {

    }
}
