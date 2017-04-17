<%@ Page Language="C#" AutoEventWireup="true" CodeFile="tabexample.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Table ID="Tab" runat="server" BackColor="White" BorderColor="#804040" BorderStyle="Dotted"
            BorderWidth="2px" CellPadding="2" CellSpacing="2" Style="z-index: 100; left: 275px;
            position: absolute; top: 117px" Width="2px">
            <asp:TableRow runat="server">
                <asp:TableCell runat="server" BorderStyle="Solid" BorderWidth="1px">row1col1</asp:TableCell>
                <asp:TableCell runat="server" BorderStyle="Solid" BorderWidth="1px">row1col2</asp:TableCell>
                <asp:TableCell runat="server" BorderStyle="Solid" BorderWidth="1px">row1col3</asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server">
                <asp:TableCell runat="server" BorderStyle="Solid" BorderWidth="1px">row2col1</asp:TableCell>
                <asp:TableCell runat="server" BorderStyle="Solid" BorderWidth="1px">row2col2</asp:TableCell>
            </asp:TableRow>
        </asp:Table>
        <asp:Button ID="btn" runat="server" OnClick="btn_Click" Style="z-index: 101; left: 326px;
            position: absolute; top: 208px" Text="ShowValue" />
        <asp:Label ID="lbl" runat="server" Height="116px" Style="z-index: 103; left: 224px;
            position: absolute; top: 244px" Width="292px"></asp:Label>
    
    </div>
    </form>
</body>
</html>
