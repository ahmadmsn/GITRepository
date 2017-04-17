<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="TextBox1" runat="server" Style="z-index: 100; left: 216px; position: absolute;
            top: 99px"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" Style="z-index: 101; left: 218px; position: absolute;
            top: 142px"></asp:TextBox>
        <asp:Login ID="Login1" runat="server" BackColor="#F7F6F3" BorderColor="#E6E2D8" BorderPadding="4"
            BorderStyle="Solid" BorderWidth="1px" CreateUserUrl="~/Default2.aspx" Font-Names="Verdana"
            Font-Size="0.8em" ForeColor="#333333" PasswordRecoveryText="hello" Style="z-index: 108;
            left: 102px; position: absolute; top: 360px" UserName="hello">
            <TitleTextStyle BackColor="#5D7B9D" Font-Bold="True" Font-Size="0.9em" ForeColor="White" />
            <InstructionTextStyle Font-Italic="True" ForeColor="Black" />
            <TextBoxStyle Font-Size="0.8em" />
            <LoginButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px"
                Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284775" />
            <HyperLinkStyle BackColor="#804000" />
        </asp:Login>
        <asp:Button ID="btn1" runat="server" OnClick="Button1_Click" Style="z-index: 103;
            left: 245px; position: absolute; top: 265px" Text="Add" />
        <asp:Label ID="Label1" runat="server" Height="46px" Style="z-index: 104; left: 427px;
            position: absolute; top: 140px" Width="125px"></asp:Label>
        <asp:Button ID="btn2" runat="server" Style="z-index: 105; left: 309px; position: absolute;
            top: 268px" Text="Subtract" OnClick="btn2_Click" />
        <asp:Button ID="btn3" runat="server" Style="z-index: 106; left: 390px; position: absolute;
            top: 268px" Text="Multiplication" OnClick="btn3_Click" />
        <asp:Button ID="btn4" runat="server" Style="z-index: 107; left: 512px; position: absolute;
            top: 267px" Text="Division" OnClick="btn4_Click" />
    
    </div>
    </form>
</body>
</html>
