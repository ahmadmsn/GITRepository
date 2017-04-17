using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Security.Cryptography;
using System.Text;

public partial class _Default : System.Web.UI.Page 
{
    string connectionstring = WebConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
    SqlDataReader dr;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnInsert_Click(object sender, EventArgs e)
    {
        string strLogin = txtlogin.Text;
        string strPassword = txtpwd.Text;
        SqlConnection m_oConn = new SqlConnection(connectionstring);
        string insert = "insert into tblLogin values(@UserName,@Password)";//(" + txtlogin.Text + "," + txtpwd.Text_ + ")";
        SqlCommand m_oCmd = new SqlCommand(insert, m_oConn);
        SqlParameter ParamUserName;
        ParamUserName = new SqlParameter("@UserName", SqlDbType.VarChar, 10);
        ParamUserName.Value = strLogin;
        m_oCmd.Parameters.Add(ParamUserName);

        MD5CryptoServiceProvider md5Hasher = new MD5CryptoServiceProvider();
        byte[] hashedBytes;
        UTF8Encoding encoder = new UTF8Encoding();
        hashedBytes = md5Hasher.ComputeHash(encoder.GetBytes(strPassword));
        SqlParameter paramPwd;
        paramPwd = new SqlParameter("@Password", SqlDbType.Binary, 16);
        paramPwd.Value = hashedBytes;
        m_oCmd.Parameters.Add(paramPwd);

        try
        {
            m_oConn.Open();
            m_oCmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            Response.Write(ex);
        }
        finally
        {
            m_oConn.Close();
            Response.Write("Your Record Is Successfully Inserted");
        }
    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        string strLogin = txtlogin.Text;
        string strPassword = txtpwd.Text;
        SqlConnection m_oConn = new SqlConnection(connectionstring);

        string select = "Select count(*) from tblLogin where login=@UserName and password=@password";
        SqlCommand m_oCmd = new SqlCommand(select, m_oConn);
        SqlParameter ParamUserName = new SqlParameter("@UserName", SqlDbType.VarChar, 10);
        ParamUserName.Value = strLogin;
        m_oCmd.Parameters.Add(ParamUserName);

        MD5CryptoServiceProvider md5Hasher = new MD5CryptoServiceProvider();
        UTF8Encoding encoder=new UTF8Encoding();
        byte[] hashedDataBytes = md5Hasher.ComputeHash(encoder.GetBytes(strPassword));
        SqlParameter ParamPwd;
        ParamPwd = new SqlParameter("@Password", SqlDbType.Binary, 16);
        ParamPwd.Value = hashedDataBytes;
        m_oCmd.Parameters.Add(ParamPwd);
        int iResults=0;
        try
        {
            m_oConn.Open();
            iResults = Convert.ToInt32(m_oCmd.ExecuteScalar().ToString());            
        }
        catch (Exception ex)
        {
            Response.Write(ex);
        }
        finally
        {
            m_oConn.Close();            
        }
        if (iResults == 1)
        {
            Response.Write("You Are Valid User");
        }
        else
        {
            Response.Write("UserName Or Password Is Invalid");
        }
    }
    protected void btnDecrypt_Click(object sender, EventArgs e)
    {
        string strUserName=txtlogin.Text;
        string Password = txtpwd.Text;
        SqlConnection m_oconn = new SqlConnection(connectionstring);
        string select = "select * from tbllogin where login=@UserName and password=@Password";
        SqlCommand m_oCmd = new SqlCommand(select, m_oconn);
        SqlParameter m_oParam;
        m_oParam = new SqlParameter("@UserName", SqlDbType.VarChar, 10);
        m_oParam.Value = strUserName;
        m_oCmd.Parameters.Add(m_oParam);

        MD5CryptoServiceProvider md5hasher = new MD5CryptoServiceProvider();
        UTF32Encoding encoder = new UTF32Encoding();        
        byte[] hashbytes = md5hasher.ComputeHash(encoder.GetBytes(Password));
        SqlParameter m_oParm1;
        m_oParm1 = new SqlParameter("@Password", SqlDbType.Binary, 16);
        m_oParm1.Value = hashbytes;
        //aa=m_oParm1.Value;
        m_oCmd.Parameters.Add(m_oParm1);

        m_oconn.Open();
        dr = m_oCmd.ExecuteReader();
        dr.Read();
     

            string aa = dr[0].ToString();
        
        

      
        //try
        //{
        //    m_oconn.Open();
        //    dr = m_oCmd.ExecuteReader();
        //}
        //catch (Exception ex)
        //{
        //    Response.Write(ex);
        //}
        //finally
        //{
        //    m_oconn.Close();
        //}

        //while(dr.Read());
        //string aa = dr[0].ToString();
        //if ((dr[0].ToString() == strUserName)&(dr["Password"]==m_oParm1.Value))
        //{
        //    Response.Write(m_oParm1);
        //    Response.Write(strUserName);
        //    Response.Write("You Are Valid User");
        //}
    }
}
