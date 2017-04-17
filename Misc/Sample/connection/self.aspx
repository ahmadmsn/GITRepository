<%@ Page Language="C#" AutoEventWireup="true" CodeFile="self.aspx.cs" Inherits="self" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Style="z-index: 100; left: 154px; position: absolute;
            top: 102px" Text="Label"></asp:Label>
        <asp:TextBox ID="txt1" runat="server" Style="z-index: 101; left: 246px; position: absolute;
            top: 106px"></asp:TextBox>
        <asp:DropDownList ID="dd1" runat="server" Style="z-index: 102; left: 494px; position: absolute;
            top: 96px">
        </asp:DropDownList>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Style="z-index: 104;
            left: 300px; position: absolute; top: 177px" Text="insert" />
    </form>
</body>
</html>
