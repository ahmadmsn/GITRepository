<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Style="z-index: 100; left: 257px; position: absolute;
            top: 256px" Text="This Is 2nd Page"></asp:Label>
        <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" StartingNodeUrl="~/Default2.aspx" />
        <asp:SiteMapPath ID="SiteMapPath1" runat="server" Style="z-index: 101; left: 262px;
            position: absolute; top: 22px">
        </asp:SiteMapPath>
        <asp:TreeView ID="TreeView1" runat="server" DataSourceID="SiteMapDataSource1" Style="z-index: 103;
            left: 10px; position: absolute; top: 111px">
        </asp:TreeView>
    
    </div>
    </form>
</body>
</html>
