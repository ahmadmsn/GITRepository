<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:CheckBox ID="chkboxdefault" runat="server" Style="z-index: 100; left: 46px;
            position: absolute; top: 309px" />
        <asp:Button ID="update" runat="server" OnClick="update_Click" Style="z-index: 107;
            left: 70px; position: absolute; top: 345px" Text="Update" />
        <asp:Label ID="Label1" runat="server" Style="z-index: 102; left: 35px; position: absolute;
            top: 282px" Text="Check for default picture" Width="151px"></asp:Label>
        <asp:DropDownList ID="dropdowncolor" runat="server" Style="z-index: 103; left: 61px;
            position: absolute; top: 58px">
        </asp:DropDownList>
        <asp:RadioButtonList ID="Rdbtnborder" runat="server" RepeatColumns="2" Style="z-index: 104;
            left: 59px; position: absolute; top: 122px">
        </asp:RadioButtonList>
        <asp:Panel ID="Panel1" runat="server" Height="364px" Style="z-index: 105; left: 277px;
            position: absolute; top: 11px" Width="239px">
        </asp:Panel>
        <asp:Image ID="Img1" runat="server" Height="290px" Style="z-index: 106; left: 298px;
            position: absolute; top: 77px" Width="211px" />
    
    </div>
    </form>
</body>
</html>
