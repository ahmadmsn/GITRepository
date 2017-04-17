<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default3.aspx.cs" Inherits="Default3" %>
<%@ Register TagPrefix="apress" TagName="footer" Src="~/webUserControl.ascx"%>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Footer Host</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>A Page With A footer</h1><hr />
    Static page Text<br /><br />
    <apress:footer ID="footer1" runat="server" />
    </div>
    </form>
</body>
</html>
