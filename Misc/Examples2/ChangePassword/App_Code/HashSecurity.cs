using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
using System.Security.Cryptography;

/// <summary>
/// Summary description for HashSecurity
/// </summary>
namespace MyInfoWebService.Classes
{
    public class HashSecurity
    {
        public HashSecurity()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        public static string GetHashValue(string strValue)
        {
            //Convert input string to byte array
            byte[] bDataToHash = ConvertStringToByteArray(strValue);

            //Create hash value from String using MD5 instance returned by Crypto Config system
            byte[] bHashValue = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(bDataToHash);
            return BitConverter.ToString(bHashValue);
        }

        public static Byte[] ConvertStringToByteArray(String s)
        {
            return (new UnicodeEncoding()).GetBytes(s);
        }
        public static bool ValidateHashPassword(string strPassword1, string strPassword2)
        {
            string strHashedPassword = GetHashValue(strPassword1);
            bool bSame = true;
            if (strHashedPassword.Length == strPassword2.Length)
            {
                for (int i = 0; i < strPassword1.Length; i++)
                    if (strHashedPassword[i] != strPassword2[i])
                    {
                        bSame = false;
                        break;
                    }
            }
            else
                bSame = false;
            return bSame;
        }

    }
}
