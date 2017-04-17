<%@ Page Language="C#" AutoEventWireup="true" CodeFile="greeting.aspx.cs" Inherits="greeting" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Greeting Card</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: left">
        Choose BackGround Colour:&nbsp;  
        
        <asp:DropDownList ID="DropDownList1" runat="server" Style="z-index: 100; left: 27px;
            position: absolute; top: 40px" Height="20px" Width="114px">
            <asp:ListItem>White</asp:ListItem>
            <asp:ListItem>Blue</asp:ListItem>
            <asp:ListItem>Black</asp:ListItem>
            <asp:ListItem>Red</asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="Label1" runat="server" Style="z-index: 101; left: 27px; position: absolute;
            top: 93px" Text="Choose Font" Width="114px" Height="20px"></asp:Label>
        <asp:DropDownList ID="DropDownList2" runat="server" Style="z-index: 102; left: 27px;
            position: absolute; top: 127px" Height="20px" Width="114px">
        </asp:DropDownList>
        <asp:TextBox ID="TextBox1" runat="server" Style="z-index: 103; left: 27px; position: absolute;
            top: 200px" Width="114px" Height="20px"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Style="z-index: 104; left: 27px; position: absolute;
            top: 165px" Text="Choose Numeric Font" Height="21px" Width="137px"></asp:Label>
        <asp:Label ID="Label3" runat="server" Style="z-index: 105; left: 27px; position: absolute;
            top: 247px" Text="Choose Border Style" Height="20px" Width="139px"></asp:Label>
        <asp:RadioButton ID="RadioButton1" runat="server" Style="z-index: 106; left: 27px;
            position: absolute; top: 295px" GroupName="a" Height="20px" Width="114px" />
        <asp:RadioButton ID="RadioButton2" runat="server" Style="z-index: 107; left: 27px;
            position: absolute; top: 326px" GroupName="a" Height="20px" Width="114px" />
        <asp:RadioButton ID="RadioButton3" runat="server" Style="z-index: 109; left: 27px;
            position: absolute; top: 361px" GroupName="a" />
    
    </div>
    </form>
</body>
</html>
