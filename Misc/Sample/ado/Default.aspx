<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Style="z-index: 100; left: 123px; position: absolute;
            top: 81px" Text="Enter Roll Number"></asp:Label>
        <asp:Label ID="Label2" runat="server" Style="z-index: 101; left: 123px; position: absolute;
            top: 154px" Text="Enter Name"></asp:Label>
        <asp:Label ID="Label3" runat="server" Style="z-index: 102; left: 123px; position: absolute;
            top: 209px" Text="Enter Address"></asp:Label>
        <asp:TextBox ID="txtroll" runat="server" Style="z-index: 103; left: 303px; position: absolute;
            top: 81px"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Style="z-index: 104;
            left: 139px; position: absolute; top: 288px" Text="Insert" />
        <asp:Button ID="Button2" runat="server" Style="z-index: 105; left: 297px; position: absolute;
            top: 291px" Text="Update" />
        <asp:Button ID="Button3" runat="server" Style="z-index: 109; left: 485px; position: absolute;
            top: 287px" Text="Delete" />
        <asp:TextBox ID="txtname" runat="server" Style="z-index: 107; left: 303px; position: absolute;
            top: 145px"></asp:TextBox>
        <asp:TextBox ID="txtaddress" runat="server" Style="z-index: 108; left: 303px; position: absolute;
            top: 211px"></asp:TextBox>
    
    </div>
    </form>
</body>
</html>
