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
using System.Management;
using System.Management.Instrumentation;
using System.Data.SqlClient;

public partial class Retrieve_SysInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
    //{
    //    ManagementObjectSearcher searcher = new ManagementObjectSearcher("Select Name from Win32_CDROMDrive");
    //    foreach (ManagementObject cdrom in searcher.Get())
    //    {
    //        TextBox1.Text = cdrom.GetPropertyValue("Name").ToString();
    //        //Console.WriteLine("Name: {0}\n",
    //                     // cdrom.GetPropertyValue("Name"));
    //    }
        //System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToString();
        //Label1.Text = System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToString();
        //Label2.Text = System.Environment.MachineName.ToString();
        //Label2.Text=System.Environment.UserDomainName.ToString();
       // string[] arr =System.Environment.GetLogicalDrives();
        //Label2.Text = "";
        //for(int i = 0; i<arr.Length;i++)
        //{
            
        //    Label2.Text += arr[i].ToString();
        //}
        //Label2.Text = System.Net.Dns.GetHostName;
        //Label2.Text = System.Net.Dns.GetHostName().ToString();
        

     //Request.Browser.

        //System.Net.IPHostEntry host = System.Net.Dns.GetHostByAddress(Request.ServerVariables.Item("Remote_Host"));
       // //string strComputerName = host.HostName;
       // System.Net.IPHostEntry host = new System.Net.IPHostEntry();
      //  host = System.Net.Dns.GetHostByAddress(Request.ServerVariables["REMOTE_HOST"]);
       // string strComputerName = host.HostName; 
       // host = System.Net.Dns.GetHostByAddress( Request.ServerVariables["REMOTE_ADDR"] );
        //string strComputerName = host.HostName;
        //host = System.Net.Dns.GetHostByAddress(Request.ServerVariables("REMOTE_ADDR");
       // Response.Write(strComputerName);

        //string ss = Convert.ToString( System.Net.Dns.GetHostByName);
        //Response.Write(ss);
      //  System.Net.Dns.GetHostByName;



        //string ss = Request.ServerVariables["REMOTE_HOST"];
        //Response.Write(ss);

        //string[] computer_name = null;



        //computer_name = Strings.Split(System.Net.Dns.Resolve(Request.ServerVariables("remote_addr")).HostName, ".");

        //response.write(computer_name(0).ToUpper);

        string[] computer_name = System.Net.Dns.GetHostEntry(Request.ServerVariables["remote_addr"]).HostName.Split(new Char[] { '.' });
      //  string ip = Convert.ToString("127.0.0.1");
       // string ip1= Request.ServerVariables["remote_addr"].ToString();
       // string[] computer_name = System.Net.Dns.GetHostEntry(ip).HostName.Split(new Char[] { '.' });
        String ecn = System.Environment.MachineName;
        string str = computer_name[0].ToString();
        Response.Write(str);

        string oLevelID = "Level1";
        string oLevel = "Level2";

        SqlCommand oCmdTatDistribution = new SqlCommand();
        oCmdTatDistribution.CommandText = "SELECT" + oLevelID + " as PercentUsedTAT," + oLevel + " as PercentTATLeft FROM MF_TAT_DISTRIBUTION,VS_TRANS_SUBGROUP WHERE TD_GROUPID = TG_GROUPID AND TG_SUBGROUPID = 334";
        string test = oCmdTatDistribution.CommandText.ToString();

    }



    
}



