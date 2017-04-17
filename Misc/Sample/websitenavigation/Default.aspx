<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Style="z-index: 100; left: 248px; position: absolute;
            top: 197px" Text="This Is 1st Page" Width="104px"></asp:Label>
    
    </div>
        <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" StartingNodeUrl="~/Web.sitemap" />
        <asp:TreeView ID="TreeView1" runat="server" DataSourceID="SiteMapDataSource1" Style="z-index: 101;
            left: 34px; position: absolute; top: 102px">
        </asp:TreeView>
        <asp:Menu ID="Menu1" runat="server" DataSourceID="SiteMapDataSource1" Style="z-index: 102;
            left: 165px; position: absolute; top: 106px">
        </asp:Menu>
        <asp:SiteMapPath ID="SiteMapPath1" runat="server" Font-Names="Verdana" Font-Size="0.8em"
            PathSeparator=" : " Style="z-index: 103; left: 289px; position: absolute; top: 14px">
            <PathSeparatorStyle Font-Bold="True" ForeColor="#5D7B9D" />
            <CurrentNodeStyle ForeColor="#333333" />
            <NodeStyle Font-Bold="True" ForeColor="#7C6F57" />
            <RootNodeStyle Font-Bold="True" ForeColor="#5D7B9D" />
        </asp:SiteMapPath>
        &nbsp;
    </form>
</body>
</html>
