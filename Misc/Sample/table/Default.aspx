<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Table Design</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        &nbsp;&nbsp;
        <asp:Label ID="rows" runat="server" Style="z-index: 100; left: 54px; position: absolute;
            top: 33px" Text="Rows"></asp:Label>
        <asp:TextBox ID="txtrow" runat="server" Style="z-index: 101; left: 130px; position: absolute;
            top: 31px"></asp:TextBox>
        &nbsp; &nbsp;
        <asp:Label ID="cols" runat="server" Style="z-index: 103; left: 359px; position: absolute;
            top: 34px" Text="Columns"></asp:Label>
        <asp:TextBox ID="txtcol" runat="server" Style="z-index: 104; left: 477px; position: absolute;
            top: 34px"></asp:TextBox>
        &nbsp; &nbsp;
        <asp:CheckBox ID="chkborder" runat="server" Style="z-index: 106; left: 51px; position: absolute;
            top: 103px" Text="Put Border Around Cells" />
        <asp:Button ID="cmdcreate" runat="server" Style="z-index: 107; left: 49px; position: absolute;
            top: 150px" Text="Create" Width="75px" OnClick="cmdcreate_Click" />
        <asp:Table ID="tbl" runat="server" Height="1px" Style="z-index: 108; left: 56px;
            position: absolute; top: 257px" Width="65px" CellPadding="20">
            <asp:TableRow runat="server" ID="row">
                <asp:TableCell ID="col" runat="server"></asp:TableCell>
            </asp:TableRow>
        </asp:Table>
        &nbsp;&nbsp;&nbsp; &nbsp; &nbsp;&nbsp;
    
    </div>
    </form>
</body>
</html>
