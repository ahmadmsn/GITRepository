using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Data;
using System.Data.SqlClient;
using System.Xml;
using System.Collections;
using MyInfoWebService.Classes;



[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
public class Service : System.Web.Services.WebService
{
    public Service () 
    {
        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    //[WebMethod]
    //public string HelloWorld()
    //{
    //    return "Hello World";
    //}
    [WebMethod]
    /// <summary>
    /// This method validated the admin user login againest his loginid and password.
    /// </summary>
    /// <param name="strLoginId">Admin LoginId</param>
    /// <param name="strPassword">Admin Password</param>
    /// <returns></returns>
    public XmlDocument ValidateAdmin(string strLoginId, string strPassword)
    {
        DataSet oLoginDataSet = new DataSet();
        ArrayList oArrList = new ArrayList();
        XmlDocument oXmlDoc = new XmlDocument();
        XmlDocument oXmlDocResult = new XmlDocument();
        string strHashedPassword = string.Empty;
        try
        {
            strHashedPassword = HashSecurity.GetHashValue(strPassword);
            oXmlDoc = new XmlDocument();
            oXmlDoc.Load(System.Web.HttpContext.Current.Server.MapPath(@"XML\PrivilegeModal.xml"));

            XmlNode oXmlNode = oXmlDoc.SelectSingleNode("PRIVILEGES/USER[LOGINID='" + strLoginId + "' and PASSWORD='" + strHashedPassword + "']");
            //XmlNode oXmlNode = oXmlDoc.SelectSingleNode("PRIVILEGES/USER[translate(@LOGINID,'ABCDEFGHIJKLMNOPQRSTUVWXYZ','abcdefghijklmnopqrstuvwxyz')='"+ strLoginId.ToLower() + "' and PASSWORD='" + strHashedPassword + "']");
            if (oXmlNode != null && oXmlNode.ChildNodes.Count > 0)
            {
                oArrList.Add(true);
                oXmlDocResult.LoadXml("<USER></USER>");
                XmlElement oXmlElement = oXmlDocResult.CreateElement("VALID");
                oXmlElement.InnerText = "TRUE";
                oXmlDocResult.DocumentElement.AppendChild(oXmlElement);
                oXmlElement = oXmlDocResult.CreateElement("TYPE");
                oXmlElement.InnerText = oXmlDoc.SelectSingleNode("PRIVILEGES/USER[LOGINID='" + strLoginId + "' and PASSWORD='" + strHashedPassword + "']").Attributes.Item(0).Value;
                oXmlDocResult.DocumentElement.AppendChild(oXmlElement);
                oXmlElement = oXmlDocResult.CreateElement("LOC");
                oXmlElement.InnerText = oXmlDoc.SelectSingleNode("PRIVILEGES/USER[LOGINID='" + strLoginId + "' and PASSWORD='" + strHashedPassword + "']").Attributes.Item(1).Value;
                oXmlDocResult.DocumentElement.AppendChild(oXmlElement);
                oXmlElement = oXmlDocResult.CreateElement("CENTER");
                oXmlElement.InnerText = oXmlDoc.SelectSingleNode("PRIVILEGES/USER[LOGINID='" + strLoginId + "' and PASSWORD='" + strHashedPassword + "']/CENTER").InnerText;
                oXmlDocResult.DocumentElement.AppendChild(oXmlElement);
                oXmlElement = oXmlDocResult.CreateElement("HT");
                oXmlElement.InnerText = oXmlDoc.SelectSingleNode("PRIVILEGES/USER[LOGINID='" + strLoginId + "' and PASSWORD='" + strHashedPassword + "']/OPTIONS/HT").InnerText;
                oXmlDocResult.DocumentElement.AppendChild(oXmlElement);
                oXmlElement = oXmlDocResult.CreateElement("QC");
                oXmlElement.InnerText = oXmlDoc.SelectSingleNode("PRIVILEGES/USER[LOGINID='" + strLoginId + "' and PASSWORD='" + strHashedPassword + "']/OPTIONS/QC").InnerText;
                oXmlDocResult.DocumentElement.AppendChild(oXmlElement);
                oXmlElement = oXmlDocResult.CreateElement("HQCA");
                oXmlElement.InnerText = oXmlDoc.SelectSingleNode("PRIVILEGES/USER[LOGINID='" + strLoginId + "' and PASSWORD='" + strHashedPassword + "']/OPTIONS/HQCA").InnerText;
                oXmlDocResult.DocumentElement.AppendChild(oXmlElement);
                oXmlElement = oXmlDocResult.CreateElement("EMAIL");
                oXmlElement.InnerText = oXmlDoc.SelectSingleNode("PRIVILEGES/USER[LOGINID='" + strLoginId + "' and PASSWORD='" + strHashedPassword + "']/EMAIL").InnerText;
                oXmlDocResult.DocumentElement.AppendChild(oXmlElement);
            }
            else
            {
                oXmlDocResult.LoadXml("<USER></USER>");
                XmlElement oXmlElement = oXmlDocResult.CreateElement("VALID");
                oXmlElement.InnerText = "FALSE";
                oXmlDocResult.DocumentElement.AppendChild(oXmlElement);
            }
        }
        catch (Exception Exp)
        {
            throw Exp;
        }
        return oXmlDocResult;
    }
    [WebMethod]
    public bool ChangePassword(string strLoginId, string strOldPassword, string strNewPassword)
    {
        DataSet oLoginDataSet = new DataSet();
        bool bPasswordChanged = false;
        try
        {
            oLoginDataSet.ReadXml(System.Web.HttpContext.Current.Server.MapPath(@"XML\PrivilegeModal.xml"));
            DataRow[] oDRLogin = oLoginDataSet.Tables[0].Select("LOGINID = '" + strLoginId + "' and PASSWORD = '" + HashSecurity.GetHashValue(strOldPassword) + "'");
            if (oDRLogin.Length > 0)
            {
                oDRLogin[0]["PASSWORD"] = HashSecurity.GetHashValue(strNewPassword);
                oLoginDataSet.WriteXml(System.Web.HttpContext.Current.Server.MapPath(@"XML\PrivilegeModal.xml"));
                bPasswordChanged = true;
            }
        }
        catch (Exception Exp)
        {
            throw Exp;
        }
        return bPasswordChanged;
    }

    
}
