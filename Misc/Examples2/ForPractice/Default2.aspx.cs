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
using RKLib.ExportData;
using System.IO;
using System.Data.OleDb;
using System.Xml;
using System.Net;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Data.SqlClient;
using System.Configuration;


public partial class Default2 : System.Web.UI.Page
{
    string ConnectioString = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
        //Close.Attributes.Add("OnClick", "return CloseWindow()");
        Show.Attributes.Add("OnClick", "return ShowMessage()");
        //CrossPage Posting
        /*string strInformation = PreviousPage.txtInformation.Text;
        Response.Write("<script>alert('" +strInformation+"')</script>");
        Response.Write(strInformation);*/
        
        //QueryString
        //TextBox1.Text = Request.QueryString["str"].ToString();
        if (!Page.IsPostBack)
        {
            Text1.Style["font-size"] = "20px";
            Text1.Style["color"] = "red";
            TextBox1.Style.Add("background-color", "lightyellow");
            Text1.Value = "<Enter E-Mail Address >";
            Text1.Attributes["onfocus"] = "alert(Text1.Value)";
           
        }
    }
    protected void btnRedirect_Click(object sender, EventArgs e)
    {
       Response.Redirect("Default.aspx");
       //Response.Redirect("http://www.google.co.in");
        
    }
    protected void btnTransfer_Click(object sender, EventArgs e)
    {
        //Response.Redirect("http://www.google.co.in");
        Server.Transfer("Default.aspx");
    }
    protected void Decode_Click(object sender, EventArgs e)
    {
        string line = "hhh mm & ll";
        string a = Server.HtmlEncode(line);
        string c = Server.HtmlDecode(line);
        string b = a;
    }
    protected void btnCommon_Click(object sender, EventArgs e)
    {
        Trace.Write("Common Button is Clicked");
        
    }
    protected void btnAlert_Click(object sender, EventArgs e)
    {
        //Page.RegisterStartupScript("a1", "<script> alert('Hi.., you clicked on Alert Button')</script>");
        //ClientScript.RegisterStartupScript(this.GetType(), "a1", "<script> alert('Hi.., you clicked on Alert Button')</script>");
        Response.Write("<script>alert('Hi.., you clicked on Alert Button'+'aa')</script>");
    }
    protected void btnExport_Click(object sender, EventArgs e)
    {
        try
        {
            string strConnectionString = "Data Source=onam;Initial Catalog=master;uid=sa;pwd=";
            SqlConnection oConnection = new SqlConnection(strConnectionString);
            string strSelMyTable = "select * from mytable";
            SqlCommand oCmdMyTable = new SqlCommand(strSelMyTable, oConnection);
            SqlDataAdapter oDataAdapMyTable = new SqlDataAdapter(oCmdMyTable);
            DataTable odtMyTable = new DataTable();
            oDataAdapMyTable.Fill(odtMyTable);
            int[] arColumns ={ 0,1, 2, 3, 4, 5, 6};
            RKLib.ExportData.Export oExport = new RKLib.ExportData.Export("Web");
            oExport.ExportDetails(odtMyTable, arColumns, Export.ExportFormat.Excel, "D:\\ForExport.xls");
        }
        catch (Exception ex)
        {
            Lbl1.Text = ex.Message;
        }
        
    }
    protected void btnInsertImage_Click(object sender, EventArgs e)
    {
        try
        {
            string strConnectionString = "Data Source=onam;Initial Catalog=master;uid=sa;pwd=";
            SqlConnection oConnection = new SqlConnection(strConnectionString);
            string image = "C:\\a.bmp";
            FileStream fs;
            fs = new FileStream(image, FileMode.Open, FileAccess.Read);
            byte[] picbyte = new byte[fs.Length];
            fs.Read(picbyte, 0, Convert.ToInt32(fs.Length));
            fs.Close();
            string insert = "insert insertimage (pic) values (@Picture)";
            SqlCommand oCmd = new SqlCommand(insert, oConnection);
            oCmd.Parameters.Add("@Picture", SqlDbType.Image).Value = picbyte;
            oConnection.Open();
            oCmd.ExecuteNonQuery();
            oConnection.Close();
        }
        catch (Exception ex)
        {
            Lbl1.Text = ex.Message;
        }
    }
    protected void btnRetrieveImage_Click(object sender, EventArgs e)
    {
      //  string strConnectionString = "Data Source=onam;Initial Catalog=master;uid=sa;pwd=";
      //  SqlConnection oConnection = new SqlConnection(strConnectionString);
      //  oConnection.Open();
      //  string retrieve = "select top 1 pic from insertimage";
      //  SqlCommand oCmd = new SqlCommand(retrieve,oConnection);
      
      ////  SqlDataReader oReader;
      //  byte[] picbyte = new byte[50000];
      // // oReader.Read();

      //  picbyte = (byte[])oCmd.ExecuteScalar();
      //  oConnection.Close();
      //  MemoryStream oMemoryStream = new MemoryStream(picbyte);
      //  string strPath = @"C:\Image\a.bmp";
      //  FileStream oFileStream = new FileStream(strPath, FileMode.Create,FileAccess.ReadWrite);
      //  oMemoryStream.WriteTo(oFileStream);
      //  oMemoryStream.Close();
      //  oFileStream.Close();


        string strConnectionString = "Data Source=onam;Initial Catalog=master;uid=sa;pwd=";
        SqlConnection oConnection = new SqlConnection(strConnectionString);
        oConnection.Open();
        //string retrieve = "select top 1 * from insertimage";
        string retrieve = "select * from insertimage";
        SqlCommand oCmd = new SqlCommand(retrieve, oConnection);

        SqlDataReader oReader;
        byte[] picbyte = new byte[50000];
        
        oReader = oCmd.ExecuteReader();
        oReader.Read();
        picbyte = (byte[])oReader[1];
        oConnection.Close();
        oReader.Close();
        MemoryStream oMemoryStream = new MemoryStream(picbyte);
        string strPath = @"C:\Image\a.bmp";
        FileStream oFileStream = new FileStream(strPath, FileMode.Create, FileAccess.ReadWrite);
        oMemoryStream.WriteTo(oFileStream);
        oMemoryStream.Close();
        oFileStream.Close();




        
    }
    protected void btnImport_Click(object sender, EventArgs e)
    {
        string path= string.Empty;
        //path = File1.Value; This For HtmlControl like <input id="File11" type="File" />
        path = FileUpload1.PostedFile.FileName;

        string strConnection = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " + path + ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=1'";
        OleDbConnection con = new OleDbConnection(strConnection);
        //Show the Excel datas in grid view
        OleDbDataAdapter ad = new OleDbDataAdapter("select * from [Sheet1$]", con);
        DataTable dt = new DataTable();
        ad.Fill(dt);
        GridView1.DataSource = dt;
        GridView1.DataBind();


        string strConnectionString = "Data Source=onam;Initial Catalog=master;uid=sa;pwd=";
        //SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ToString());
        SqlConnection Conn = new SqlConnection(strConnectionString);
        Conn.Open();

        // OleDbCommand cmd = new OleDbCommand("select * from [Sheet1$]", con);
        // OleDbDataReader dr;
        //con.Open();
        // dr = cmd.ExecuteReader();
        SqlBulkCopy bulk = new SqlBulkCopy(Conn);
        bulk.DestinationTableName = "mytable";
        bulk.WriteToServer(dt);
        //Response.Write("DATA IMPORTED");
        //  dr.Close();
        Conn.Close();
        con.Close();
    }
    protected void btnXmlWrite_Click(object sender, EventArgs e)
    {
        string strFilePath = Path.Combine(Request.PhysicalApplicationPath, @"App_Data\myfile.xml");
        FileStream fs = new FileStream(strFilePath, FileMode.Create);
        XmlTextWriter oXmlTexWriter = new XmlTextWriter(fs, null);
        oXmlTexWriter.WriteStartDocument();
        oXmlTexWriter.WriteStartElement("myfile");
        oXmlTexWriter.WriteComment("this is my file");
        oXmlTexWriter.WriteStartElement("product");
        oXmlTexWriter.WriteAttributeString("Name", "chair");
        oXmlTexWriter.WriteAttributeString("id", "1");

        oXmlTexWriter.WriteStartElement("price");
        oXmlTexWriter.WriteString("49.33");
        oXmlTexWriter.WriteEndElement();

        oXmlTexWriter.WriteEndElement();

        oXmlTexWriter.WriteStartElement("product");
        oXmlTexWriter.WriteAttributeString("Name", "car");
        oXmlTexWriter.WriteAttributeString("id", "2");

        oXmlTexWriter.WriteStartElement("price");
        oXmlTexWriter.WriteString("49.33");
        oXmlTexWriter.WriteEndElement();

        oXmlTexWriter.WriteEndElement();
        oXmlTexWriter.WriteEndElement();
        oXmlTexWriter.WriteEndDocument();
        oXmlTexWriter.Close();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {

    }
    protected void btnException_Click(object sender, EventArgs e)
    {
        try
        {
            string strTest = "Hello";
            try
            {
                string strTest2 = string.Empty;
                if (strTest2 == "")
                {
                    throw new ApplicationException("Hello");
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("String Is Empty");
            }
        }
        catch (Exception ex)
        {
        }
    }
    protected void cmdSession_Click(object sender, EventArgs e)
    {
        Session["Name"] = "Suresh";
        Session.Timeout = 1;
        string a = "a";
        string name = Session["Name"].ToString();

    }
    protected void cmdCookie_Click(object sender, EventArgs e)
    {
        //HttpCookie oCookie = new HttpCookie("MyCookie","Suresh");
        HttpCookie oCookie = new HttpCookie("MyCookie");
        //oCookie["a"] = "Hello";
        oCookie["a"] ="20";
        Response.Cookies.Add(oCookie);
        int b = Convert.ToInt32(oCookie["a"]);
        Response.Redirect("Default.aspx");
    }
    protected void Close_Click(object sender, EventArgs e)
    {
        

    }
    protected void btnSerialize_Click(object sender, EventArgs e)
    {
        Profile1 oProfile = new Profile1();
        oProfile.name = "James";
        oProfile.address = "USA";
        oProfile.age = "20";

        byte[] abyProfile = new byte[4000];
        abyProfile = getByteArrayWithObject(oProfile);

        
        Profile1 oDesezProfile = (Profile1)getObjectWithByteArray(abyProfile);
    }

    public byte[] getByteArrayWithObject(Object o)
    {
        MemoryStream oStream = new MemoryStream();
        BinaryFormatter oFormatter = new BinaryFormatter();
        oFormatter.Serialize(oStream, o);
        return oStream.ToArray();
    }

    public object getObjectWithByteArray(byte[] abyProfile)
    {
        MemoryStream oStream = new MemoryStream(abyProfile);
        BinaryFormatter oFormatter = new BinaryFormatter();
        oStream.Position = 0;

        return oFormatter.Deserialize(oStream);
    }


    public MyTestClass SerializeDemo()
    {
       
            //string strXmlFilePath = Path.Combine(Request.PhysicalApplicationPath, @"App_Data\Profile.xml");
        //string strXmlFilePath = @"D:\ad\asp\ForPractice\App_Data\Profile1.xml";
        //byte[] abyXmlProfile = new byte[8000];
        //abyXmlProfile = System.Text.Encoding.ASCII.GetBytes(strXmlFilePath);
        //MemoryStream oMs = new MemoryStream(abyXmlProfile);

        //XmlSerializer oSerialize = new XmlSerializer(typeof(Profile1));
        //Profile1 oProfile;// = new Profile1();
        //oProfile = (Profile1)oSerialize.Deserialize(oMs);
        //return oProfile;

        //XmlSerializer oSerialize = new XmlSerializer(typeof(Profile1));
        //FileStream oFileStream = new FileStream(strXmlFilePath, FileMode.Open);
        //Profile1 oProfile = (Profile1)oSerialize.Deserialize(oFileStream);
        //return oProfile;

        string xmlPath = @"D:\ad\asp\ForPractice\myTestClass.xml";

         byte[] abyXmlProfile = new byte[4000];
         abyXmlProfile = System.Text.Encoding.ASCII.GetBytes(xmlPath);
        MemoryStream oMs = new MemoryStream(abyXmlProfile);
         MyTestClass oMyTestClass = new MyTestClass();
         XmlSerializer oSerialize = new XmlSerializer(typeof(MyTestClass));

         oMyTestClass = (MyTestClass)oSerialize.Deserialize(oMs);
         return oMyTestClass;




    }
    protected void btnXmlSerialize_Click(object sender, EventArgs e)
    {
        string xmlPath = @"D:\ad\asp\ForPractice\myTestClass.xml";
        MyTestClass oMyTestClass = new MyTestClass();

        //oMyTestClass.aStrMyArray[0] = "qwerty";
        //oMyTestClass.aStrMyArray[1] = "asdfgh";
        //oMyTestClass.aStrMyArray[2] = "zxcvbn";
        //oMyTestClass.aStrMyArray[3] = "123456";

        //XmlSerializer oMySerializer = new XmlSerializer(typeof(MyTestClass));
        //StreamWriter oMyWriter = new StreamWriter(xmlPath);
        //oMySerializer.Serialize(oMyWriter, oMyTestClass);
        //oMyWriter.Close();


        XmlSerializer mySerializer = new XmlSerializer(typeof(MyTestClass));
        FileStream oFileStream = new FileStream(xmlPath, FileMode.Open);
        MyTestClass oMyTestClass1 = (MyTestClass)mySerializer.Deserialize(oFileStream);

    }
    protected void btnXmlSerialize2_Click(object sender, EventArgs e)
    {
        MyTestClass p1 = SerializeDemo();
    }

    protected void btnFStream_Click(object sender, EventArgs e)
    {
        string strDestFilePath = Server.MapPath("Temp") + "\\";
        string[] Filelist = Directory.GetFiles(strDestFilePath);
        ArrayList oArrayList = new ArrayList();
        for (int nCount = 0; nCount < Filelist.Length; nCount++)
        {
            oArrayList.Add(Filelist[nCount]);
        }
    }
    protected void btnStream_Click(object sender, EventArgs e)
    {
        //string strDestFilePath = Server.MapPath("Temp") + "\\";
        string strDestFilePath = "D:\\ad\\temp";
        string[] Filelist = Directory.GetFiles(strDestFilePath);
       
        
       

        ArrayList oArrayList = new ArrayList();
        for (int nCount = 0; nCount < Filelist.Length; nCount++)
        {
            int Index = Filelist[nCount].LastIndexOf("\\")+1;
            int index1 = Filelist[nCount].Length;
            int index2 = index1 - Index;

            string FileName = Filelist[nCount].Substring(Filelist[nCount].LastIndexOf("\\")+1,index2);
            oArrayList.Add(FileName);
        }
        for (int nCount1 = 0; nCount1 < oArrayList.Count; nCount1++)
        {
            try
            {
                if (File.Exists(Filelist[nCount1]))
                {
                    string FullPath = Filelist[nCount1].ToString();
                    FileInfo f1 = new FileInfo(FullPath);
                    int nFileCreationTime = f1.CreationTime.Hour * 60 + f1.CreationTime.Minute;
                    int nCurrentTime = DateTime.Now.Hour * 60 + DateTime.Now.Minute;
                    if ((nCurrentTime - nFileCreationTime) > 30)
                    {
                        File.Delete(FullPath);
                    }
                }
            }
            catch (Exception ex)
            {
            }
            
           
         //int nCreationTime=  


        }
    }
    protected void btnGridView_Click(object sender, EventArgs e)
    {

    }
    protected void btnInsert_Click(object sender, EventArgs e)
    {
        string strInsert = "insert into gridTest (name,address) values(@name,@address)";
        SqlConnection oConnection = new SqlConnection(ConnectioString);
        SqlCommand oCmd = new SqlCommand(strInsert, oConnection);
        oCmd.Parameters.Add("@name", SqlDbType.VarChar).Value = txtName.Text;
        oCmd.Parameters.Add("@address", SqlDbType.VarChar).Value = txtAddress.Text;
        try
        {
            oConnection.Open();

            oCmd.ExecuteNonQuery();
        }
        finally
        {
            oConnection.Close();            
            Response.Write("<script>alert('Records is inserted successfully....')</script>");
        }
    }
    protected void btnShow_Click(object sender, EventArgs e)
    {
        string strSelect = "select * from gridTest";
        SqlConnection oConnection = new SqlConnection(ConnectioString);
        SqlCommand oCmd = new SqlCommand(strSelect, oConnection);
        //DataSet ds = new DataSet();
        DataTable oDataTable = new DataTable();
        SqlDataAdapter oDataAdapter = new SqlDataAdapter(oCmd);
        //oDataAdapter.Fill(ds);   
        oDataAdapter.Fill(oDataTable);
        //GridView1.DataSource = ds;
        
        GridView1.DataSource = oDataTable;
        GridView1.DataBind();        
    }
    protected void btnWildShow_Click(object sender, EventArgs e)
    {
        string strWildSelect = "select * from gridtest where name like " +"'"+txtWild.Text+"'";
        SqlConnection oConnection = new SqlConnection(ConnectioString);
        SqlCommand oCmd = new SqlCommand(strWildSelect, oConnection);      
        DataTable oDataTable = new DataTable();
        SqlDataAdapter oDataAdapter = new SqlDataAdapter(oCmd);       
        oDataAdapter.Fill(oDataTable);
        GridView1.DataSource = oDataTable;
        GridView1.DataBind();        
    }
}
