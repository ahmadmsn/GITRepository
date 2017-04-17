<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Panel ID="Panel1" runat="server" Height="170px" Style="z-index: 100; left: 32px;
            position: absolute; top: 35px" Width="552px">
        </asp:Panel>
        <asp:ListBox ID="ListBox1" runat="server" Height="155px" Style="z-index: 101; left: 58px;
            position: absolute; top: 329px" Width="152px"></asp:ListBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Style="z-index: 106;
            left: 353px; position: absolute; top: 256px" Text="Button" />
        <asp:Label ID="Label1" runat="server" Height="144px" Style="z-index: 103; left: 47px;
            position: absolute; top: 48px" Text="Label" Width="465px"></asp:Label>
        <asp:Button ID="btn1" runat="server" OnClick="btn1_Click" Style="z-index: 104; left: 233px;
            position: absolute; top: 334px" Text="More Information" Width="117px" />
        <asp:Label ID="Label2" runat="server" Height="99px" Style="z-index: 105; left: 231px;
            position: absolute; top: 374px" Text="Label" Width="362px"></asp:Label>
        &nbsp;
    
    </div>
    </form>
</body>
</html>
