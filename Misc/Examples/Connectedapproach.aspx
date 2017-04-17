<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Connectedapproach.aspx.cs" Inherits="Connectedapproach" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="TextBox1" runat="server" Style="z-index: 100; left: 139px; position: absolute;
            top: 36px"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" Style="z-index: 101; left: 138px; position: absolute;
            top: 98px"></asp:TextBox>
        <asp:TextBox ID="TextBox3" runat="server" Style="z-index: 102; left: 138px; position: absolute;
            top: 169px"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Style="z-index: 103;
            left: 181px; position: absolute; top: 220px" Text="Insert" />
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"
            Style="z-index: 104; left: 452px; position: absolute; top: 35px">
        </asp:DropDownList>
        &nbsp;
        <asp:TextBox ID="TextBox5" runat="server" Style="z-index: 105; left: 416px; position: absolute;
            top: 87px"></asp:TextBox>
        <asp:TextBox ID="TextBox6" runat="server" Style="z-index: 106; left: 415px; position: absolute;
            top: 132px"></asp:TextBox>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Style="z-index: 107;
            left: 415px; position: absolute; top: 199px" Text="Update" />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Style="z-index: 109;
            left: 529px; position: absolute; top: 199px" Text="Delete" />
    
    </div>
    </form>
</body>
</html>
