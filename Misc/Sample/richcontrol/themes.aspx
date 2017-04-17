<%@ Page Language="C#" AutoEventWireup="true" CodeFile="themes.aspx.cs" Inherits="themes" StylesheetTheme="SkinFile" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="TextBox1" runat="server" Style="z-index: 100; left: 221px; position: absolute;
            top: 137px"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" Style="z-index: 101; left: 222px; position: absolute;
            top: 184px"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" SkinID="aaa" Style="z-index: 102; left: 65px;
            position: absolute; top: 139px" Text="Label" Width="105px"></asp:Label>
        <asp:Label ID="Label2" runat="server" SkinID="aaa" Style="z-index: 103; left: 79px;
            position: absolute; top: 191px" Text="Label" Width="119px"></asp:Label>
        <asp:Label ID="Label3" runat="server" SkinID="bbb" Style="z-index: 104; left: 241px;
            position: absolute; top: 64px" Text="Label"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server" Style="z-index: 106; left: 225px; position: absolute;
            top: 243px"></asp:TextBox>
    
    </div>
    </form>
</body>
</html>
