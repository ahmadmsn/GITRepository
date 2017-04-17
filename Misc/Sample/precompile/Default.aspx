<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblinfo" runat="server" Style="z-index: 100; left: 637px; position: absolute;
            top: 179px"></asp:Label>
        <asp:Button ID="btn1" runat="server" OnClick="btn1_Click" Style="z-index: 106; left: 443px;
            position: absolute; top: 277px" Text="Enter" />
        <asp:Label ID="lbl2" runat="server" Style="z-index: 102; left: 313px; position: absolute;
            top: 207px" Text="Last Name"></asp:Label>
        <asp:TextBox ID="txtfirst" runat="server" Style="z-index: 103; left: 407px; position: absolute;
            top: 150px"></asp:TextBox>
        <asp:TextBox ID="txtlast" runat="server" Style="z-index: 104; left: 405px; position: absolute;
            top: 207px"></asp:TextBox>
        <asp:Label ID="lbl1" runat="server" Style="z-index: 105; left: 312px; position: absolute;
            top: 152px" Text="FirstName"></asp:Label>
    
    </div>
    </form>
</body>
</html>
