<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Style="z-index: 100; left: 72px; position: absolute;
            top: 54px" Text="ENTER YR FIRST NAME"></asp:Label>
        <asp:TextBox ID="fname" runat="server" Style="z-index: 101; left: 294px; position: absolute;
            top: 51px"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Style="z-index: 102; left: 72px; position: absolute;
            top: 93px" Text="Enter Yr LAST NAME"></asp:Label>
        <asp:TextBox ID="lname" runat="server" Style="z-index: 103; left: 294px; position: absolute;
            top: 91px"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" Style="z-index: 104; left: 72px; position: absolute;
            top: 140px" Text="ENTER YR SEX"></asp:Label>
        <asp:DropDownList ID="sex" runat="server" Style="z-index: 105; left: 294px; position: absolute;
            top: 141px">
        </asp:DropDownList>
        <asp:Label ID="Label4" runat="server" Height="2px" Style="z-index: 106; left: 72px;
            position: absolute; top: 196px" Text="ADDRESSl"></asp:Label>
        <asp:TextBox ID="add" runat="server" Style="z-index: 107; left: 294px; position: absolute;
            top: 196px"></asp:TextBox>
        <asp:Label ID="Label5" runat="server" Style="z-index: 108; left: 72px; position: absolute;
            top: 253px" Text="ACCOUNT TYPE"></asp:Label>
        <asp:DropDownList ID="acc" runat="server" Style="z-index: 109; left: 294px; position: absolute;
            top: 252px">
        </asp:DropDownList>
        <asp:Label ID="Label6" runat="server" Style="z-index: 110; left: 72px; position: absolute;
            top: 321px" Text="ANNUAL INCOME"></asp:Label>
        <asp:TextBox ID="amt" runat="server" Style="z-index: 111; left: 293px; position: absolute;
            top: 323px"></asp:TextBox>
        <asp:Button ID="submit" runat="server" OnClick="submit_Click" Style="z-index: 112;
            left: 171px; position: absolute; top: 435px" Text="submit" Width="155px" />
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="fname"
            ErrorMessage="Should Not Contain any Digits.." Style="z-index: 113; left: 459px;
            position: absolute; top: 52px" ValidationExpression="[A-Za-z]*\s*[A-Za-z]*" Width="243px"></asp:RegularExpressionValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="fname"
            ErrorMessage="First Name is Mandatory" Style="z-index: 115; left: 463px; position: absolute;
            top: 52px" Width="163px"></asp:RequiredFieldValidator>
    
    </div>
    </form>
</body>
</html>
