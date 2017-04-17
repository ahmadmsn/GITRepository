using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Serialization;

/// <summary>
/// Summary description for Profile
/// </summary>
/// 
//[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]

[Serializable]
public class Profile1
{
    public string name = string.Empty;

    //public string Name
    //{
    //    get { return name; }
    //    set { name = value; }
    //}
    public string address = string.Empty;

    //public string Address
    //{
    //    get { return address; }
    //    set { address = value; }
    //}
    public string age = string.Empty;

    //public string Age
    //{
    //    get { return age; }
    //    set { age = value; }
    //}
   
	public Profile1()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}
