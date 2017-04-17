<%@ Page Language="C#" AutoEventWireup="true" CodeFile="stylesheet.aspx.cs" Inherits="Default3" StylesheetTheme="SkinFile" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div style="table-layout: auto; color: green; font-family: 'Comic Sans MS'; border-collapse: separate; background-color: gray; text-decoration: underline">
        <asp:Label ID="Label1" runat="server" Style="z-index: 100; left: 82px; color: green;
            position: absolute; top: 82px; text-decoration: underline" Text="Enter Here Something" SkinID="aaa"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" Style="z-index: 101; left: 255px; position: absolute;
            top: 86px"></asp:TextBox>
        &nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" Style="z-index: 102; left: 270px; position: absolute;
            top: 164px"></asp:TextBox>
        <asp:TextBox ID="TextBox3" runat="server" Style="z-index: 105; left: 288px; position: absolute;
            top: 240px"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Style="z-index: 104; left: 90px; position: absolute;
            top: 198px" Text="Label" Width="142px"></asp:Label>
    
    </div>
    </form>
</body>
</html>
