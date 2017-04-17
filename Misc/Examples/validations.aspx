<%@ Page Language="C#" AutoEventWireup="true" CodeFile="validations.aspx.cs" Inherits="validations" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="TextBox1" runat="server" Style="z-index: 100; left: 185px; position: absolute;
            top: 77px" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Style="z-index: 101; left: 281px; position: absolute;
            top: 454px" Text="Button" OnClick="Button1_Click" />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" Style="z-index: 113;
            left: 529px; position: absolute; top: 65px" />
        <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="TextBox6"
            ErrorMessage="CustomValidator" OnServerValidate="CustomValidator1_ServerValidate"
            Style="z-index: 103; left: 429px; position: absolute; top: 411px"></asp:CustomValidator>
        <asp:TextBox ID="TextBox6" runat="server" Style="z-index: 104; left: 218px; position: absolute;
            top: 413px"></asp:TextBox>
        <asp:TextBox ID="TextBox5" runat="server" Style="z-index: 105; left: 207px; position: absolute;
            top: 357px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1"
            ErrorMessage=" mandatory field" Style="z-index: 106; left: 388px; position: absolute;
            top: 76px"></asp:RequiredFieldValidator>
        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox2"
            ErrorMessage="RangeValidator" MaximumValue="30" MinimumValue="20" Style="z-index: 107;
            left: 393px; position: absolute; top: 153px" Type="Integer"></asp:RangeValidator>
        <asp:TextBox ID="TextBox2" runat="server" Style="z-index: 108; left: 188px; position: absolute;
            top: 151px"></asp:TextBox>
        <asp:TextBox ID="TextBox3" runat="server" Style="z-index: 109; left: 193px; position: absolute;
            top: 222px"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox3"
            ErrorMessage="enter valid url" Style="z-index: 110; left: 396px; position: absolute;
            top: 217px" ValidationExpression="\d{5}"></asp:RegularExpressionValidator>
        <asp:TextBox ID="TextBox4" runat="server" Style="z-index: 111; left: 201px; position: absolute;
            top: 287px"></asp:TextBox>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox4"
            ControlToValidate="TextBox5" ErrorMessage="password mismatch" Style="z-index: 112;
            left: 331px; position: absolute; top: 324px"></asp:CompareValidator>
    
    </div>
    </form>
</body>
</html>
