<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" StartingNodeUrl="~/Default.aspx" />
        <asp:SiteMapPath ID="SiteMapPath1" runat="server" Style="z-index: 100; left: 265px;
            position: absolute; top: 23px">
            <RootNodeStyle BackColor="Silver" BorderStyle="Inset" />
        </asp:SiteMapPath>
        <asp:TreeView ID="TreeView1" runat="server" DataSourceID="SiteMapDataSource1" Style="z-index: 102;
            left: 5px; position: absolute; top: 123px">
        </asp:TreeView>
    
    </div>
    </form>
</body>
</html>
