<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ListBox ID="lst1" runat="server" Height="90px" Style="z-index: 100; left: 76px;
            position: absolute; top: 75px" Width="150px">
            <asp:ListItem>Supreme Leather drapey</asp:ListItem>
            <asp:ListItem>Threadbare Carpet</asp:ListItem>
            <asp:ListItem>Antique Lanp</asp:ListItem>
        </asp:ListBox>
        <asp:CheckBox ID="chk" runat="server" Style="z-index: 101; left: 81px; position: absolute;
            top: 201px" Text="Show Full Details" />
        <asp:Button ID="btn1" runat="server" OnClick="btn1_Click" Style="z-index: 102; left: 78px;
            position: absolute; top: 268px" Text="View Information" Width="187px" />
        <asp:Label ID="lbl1" runat="server" Style="z-index: 104; left: 304px; position: absolute;
            top: 222px" Text="Label" Width="198px"></asp:Label>
    
    </div>
    </form>
</body>
</html>
