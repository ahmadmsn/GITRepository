<%@ Page Language="C#" AutoEventWireup="true" CodeFile="viewfiles.aspx.cs" Inherits="viewfiles" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Style="z-index: 100; left: 43px;
            position: absolute; top: 68px" Text="Files In The FTP Directory:"></asp:Label>
        <asp:Label ID="lblinfo" runat="server" Height="123px" Style="z-index: 101; left: 266px;
            position: absolute; top: 120px" Width="201px"></asp:Label>
        <asp:ListBox ID="lstfiles" runat="server" Height="119px" OnSelectedIndexChanged="lstfiles_SelectedIndexChanged"
            Style="z-index: 102; left: 12px; position: absolute; top: 122px" Width="244px" AutoPostBack="True"></asp:ListBox>
        <asp:Button ID="btnref" runat="server" OnClick="btnref_Click" Style="z-index: 103;
            left: 76px; position: absolute; top: 278px" Text="Refresh" />
        <asp:Button ID="Btndel" runat="server" OnClick="Btndel_Click" Style="z-index: 106;
            left: 328px; position: absolute; top: 282px" Text="Delete" />
        <asp:Label ID="Label3" runat="server" Font-Bold="True" Style="z-index: 105; left: 274px;
            position: absolute; top: 67px" Text="Selected File Information:"></asp:Label>
    
    </div>
    </form>
</body>
</html>
