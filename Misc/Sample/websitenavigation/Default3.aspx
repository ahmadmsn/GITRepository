<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default3.aspx.cs" Inherits="Default3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        &nbsp;
        <asp:SiteMapPath ID="SiteMapPath1" runat="server" Style="z-index: 100; left: 263px;
            position: absolute; top: 17px">
        </asp:SiteMapPath>
        <asp:TreeView ID="TreeView1" runat="server" DataSourceID="SiteMapDataSource1" Style="z-index: 101;
            left: 241px; position: absolute; top: 170px">
        </asp:TreeView>
        <asp:Menu ID="Menu1" runat="server" DataSourceID="SiteMapDataSource1" Style="z-index: 102;
            left: 238px; position: absolute; top: 126px">
        </asp:Menu>
        &nbsp;
    
    </div>
        <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" StartingNodeUrl="~/Default3.aspx" />
    </form>
</body>
</html>
