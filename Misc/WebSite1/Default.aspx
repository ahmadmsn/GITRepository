<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <br />
    <br />
    <br />
    <br />
        <asp:TextBox ID="TextBox1" runat="server" Height="203px" Style="z-index: 100; left: 18px;
            position: absolute; top: 22px" TextMode="MultiLine" Width="521px"></asp:TextBox>
    <br />
    <br />
    <br />
    <br />
        &nbsp;&nbsp;&nbsp&nbsp;&nbsp;&nbsp&nbsp;&nbsp;&nbsp<asp:Button ID="btnShow" runat="server" Text="Show" style="z-index: 101; left: 140px; position: absolute; top: 243px" OnClick="btnShow_Click" />
        <asp:GridView ID="GridView1" runat="server" Style="z-index: 102; left: 579px; position: absolute;
            top: 72px">
        </asp:GridView>
        <asp:Button ID="btnShowProduct" runat="server" OnClick="btnShowProduct_Click" Style="z-index: 103;
            left: 202px; position: absolute; top: 243px" Text="ShowProduct" />
        <asp:Button ID="btnShowText" runat="server" OnClick="btnShowText_Click" Style="z-index: 104;
            left: 34px; position: absolute; top: 244px" Text="ShowText" />
        <asp:Button ID="btnCreateDir" runat="server" Style="z-index: 106; left: 336px; position: absolute;
            top: 244px" Text="Button" />
    </div>
    </form>
</body>
</html>
