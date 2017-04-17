<%@ Page Language="C#" AutoEventWireup="true" CodeFile="sitemappath.aspx.cs" Inherits="sitemappath" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:SiteMapPath ID="SiteMapPath1" runat="server" Style="z-index: 100; left: 170px;
            position: absolute; top: 13px" Visible="False">
            <PathSeparatorStyle BackColor="Fuchsia" />
            <CurrentNodeStyle BackColor="#80FF80" Font-Italic="False" />
            <NodeStyle BackColor="#E0E0E0" BorderColor="Gainsboro" BorderStyle="Solid" />
            <RootNodeStyle BackColor="#FFC0C0" />
        </asp:SiteMapPath>
        &nbsp;
        <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" StartingNodeUrl="~/sitemappath.aspx" />
    
    </div>
    </form>
</body>
</html>
