<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Show.aspx.cs" Inherits="Show" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        &nbsp;<asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" StartingNodeUrl="~/Web.sitemap" />
        <asp:TreeView ID="TreeView1" runat="server" DataSourceID="SiteMapDataSource1" Style="z-index: 100;
            left: 9px; position: absolute; top: 112px">
        </asp:TreeView>
    
    </div>
    </form>
</body>
</html>
