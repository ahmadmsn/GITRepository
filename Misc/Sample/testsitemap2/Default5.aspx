<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default5.aspx.cs" Inherits="Default5" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" />
        <asp:SiteMapPath ID="SiteMapPath1" runat="server" Style="z-index: 100; left: 248px;
            position: absolute; top: 18px">
            <PathSeparatorStyle BackColor="#FFC0C0" BorderColor="Navy" BorderStyle="Ridge" />
            <CurrentNodeStyle BackColor="Lime" BorderColor="#C00000" BorderStyle="Inset" Font-Italic="True"
                Font-Underline="True" ForeColor="Black" />
            <RootNodeStyle BackColor="#FF80FF" />
        </asp:SiteMapPath>
    
    </div>
    </form>
</body>
</html>
