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

public partial class gridview_examples_gridview_nested : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            bindGridViewCategories();
    }

    public void bindGridViewCategories()
    {
        // string variable to store the connection string
        // defined in appsettings section of web.config file.
        string connStr = ConfigurationManager.AppSettings["ConnectionString"].ToString();

        // object created for SqlConnection Class.
        SqlConnection mySQLconnection = new SqlConnection(connStr);

        // if condition that can be used to check the sql connection
        // whether it is already open or not.
        if (mySQLconnection.State == ConnectionState.Closed)
        {
            mySQLconnection.Open();
        }

        SqlCommand mySqlCommand = new SqlCommand("select categoryname,categoryid from categories", mySQLconnection);
        SqlDataAdapter mySqlAdapter = new SqlDataAdapter(mySqlCommand);
        DataSet myDataSet = new DataSet();
        mySqlAdapter.Fill(myDataSet);

        grdV_categories.DataSource = myDataSet;
        grdV_categories.DataBind();


        foreach(GridViewRow rIndex in grdV_categories.Rows)
        {
            bindGridViewProducts(Convert.ToInt32(grdV_categories.DataKeys[rIndex.RowIndex].Value), rIndex.RowIndex);
        }

        // if condition that can be used to check the sql connection
        // if it is open then close it.
        if (mySQLconnection.State == ConnectionState.Open)
        {
            mySQLconnection.Close();
        }

    }

    public void bindGridViewProducts(int catID,int rowIndex)
    {
        // string variable to store the connection string
        // defined in appsettings section of web.config file.
        string connStr = ConfigurationManager.AppSettings["ConnectionString"].ToString();

        // object created for SqlConnection Class.
        SqlConnection mySQLconnection = new SqlConnection(connStr);

        // if condition that can be used to check the sql connection
        // whether it is already open or not.
        if (mySQLconnection.State == ConnectionState.Closed)
        {
            mySQLconnection.Open();
        }

        SqlCommand mySqlCommand = new SqlCommand("select productname from products where categoryid=@categoryid", mySQLconnection);
        mySqlCommand.Parameters.Add("@categoryid", SqlDbType.Int).Value= catID;
        SqlDataAdapter mySqlAdapter = new SqlDataAdapter(mySqlCommand);
        DataSet myDataSet = new DataSet();
        mySqlAdapter.Fill(myDataSet);

        GridView grdV_products = new GridView();
        grdV_products = (GridView)grdV_categories.Rows[rowIndex].Cells[0].FindControl("grdV_products");
        grdV_products.DataSource = myDataSet;
        grdV_products.DataBind();

        // if condition that can be used to check the sql connection
        // if it is open then close it.
        if (mySQLconnection.State == ConnectionState.Open)
        {
            mySQLconnection.Close();
        }

    }
    
}
