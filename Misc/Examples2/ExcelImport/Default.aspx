<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body bgcolor="#cccccc">
    <form id="form1" runat="server">
    <div>
        &nbsp; &nbsp;
    
    </div>
        &nbsp;
        <table>
            <tr>
                <td style="width: 80px; height: 21px">
                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Arial" Text="Excel Import"
                        Width="167px"></asp:Label></td>
                <td style="height: 21px">
                </td>
            </tr>
            <tr>
                <td style="width: 80px">
        <input id="File1" runat="server" type="file" />
        <asp:Button ID="btnImport" runat="server" OnClick="Button1_Click" Text="ShowExcel and Import" /></td>
                <td>
                </td>
            </tr>
            <tr>
                <td style="width: 80px">
        <asp:GridView ID="GridView1" runat="server" CellPadding="4" Font-Names="Arial" Font-Size="X-Small"
            ForeColor="#333333" GridLines="None" Width="451px">
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <EditRowStyle BackColor="#999999" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        </asp:GridView>
                </td>
                <td>
                </td>
            </tr>
        </table>
        &nbsp;
    </form>
</body>
</html>
