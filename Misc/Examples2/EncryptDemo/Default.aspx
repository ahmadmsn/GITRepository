<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="txtlogin" runat="server" Style="z-index: 100; left: 418px; position: absolute;
            top: 129px"></asp:TextBox>
        <asp:TextBox ID="txtpwd" runat="server" Style="z-index: 101; left: 422px; position: absolute;
            top: 168px"></asp:TextBox>
        <asp:Button ID="btnInsert" runat="server" OnClick="btnInsert_Click" Style="z-index: 102;
            left: 418px; position: absolute; top: 249px" Text="Insert" />
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Style="z-index: 103;
            left: 478px; position: absolute; top: 248px" Text="Login" />
        <asp:Button ID="btnDecrypt" runat="server" OnClick="btnDecrypt_Click" Style="z-index: 105;
            left: 546px; position: absolute; top: 251px" Text="Decrypt" />
    
    </div>
    </form>
</body>
</html>
