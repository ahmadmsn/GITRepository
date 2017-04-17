<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="TextBox1" runat="server" Style="z-index: 100; left: 106px; position: absolute;
            top: 154px"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Style="z-index: 101; left: 153px; position: absolute;
            top: 203px" Text="Button" />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1"
            ErrorMessage="RequiredFieldValidator" Style="z-index: 103; left: 120px; position: absolute;
            top: 122px"></asp:RequiredFieldValidator>
    
    </div>
    </form>
</body>
</html>
