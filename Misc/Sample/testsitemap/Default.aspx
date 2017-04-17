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
        <asp:TreeView ID="TreeView1" runat="server" DataSourceID="SiteMapDataSource1" ImageSet="Faq"
            Style="z-index: 100; left: 13px; position: absolute; top: 130px">
        </asp:TreeView>
        <asp:Menu ID="Menu1" runat="server" DataSourceID="SiteMapDataSource1" Style="z-index: 103;
            left: 282px; position: absolute; top: 163px">
        </asp:Menu>
    
    </div>
        <asp:SiteMapPath ID="SiteMapPath1" runat="server" Style="z-index: 102; left: 278px;
            position: absolute; top: 18px">
            <PathSeparatorStyle BackColor="#80FFFF" />
            <CurrentNodeStyle BackColor="#FF80FF" />
            <RootNodeStyle BackColor="#00C000" />
        </asp:SiteMapPath>
    </form>
</body>
</html>
