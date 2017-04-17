<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="TextBox1" runat="server" Style="z-index: 100; left: 235px; position: absolute;
            top: 113px"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Style="z-index: 101; left: 307px; position: absolute;
            top: 223px" Text="Button" />
        &nbsp;
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox1"
            ErrorMessage="RegularExpressionValidator" Style="z-index: 103; left: 409px; position: absolute;
            top: 115px" ValidationExpression="\d\d\d"></asp:RegularExpressionValidator>
    
    </div>
    </form>
</body>
</html>
