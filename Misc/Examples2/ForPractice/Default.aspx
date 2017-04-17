<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
   
        <table style="z-index: 108; left: 474px; width: 194px; position: absolute; top: 86px;
            height: 108px">
            <tr>
                <td>                            
                </td>
                <td>
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td>
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td>
                </td>
                <td>
                </td>
            </tr>
        </table>
        <asp:Button ID="test" runat="server" OnClick="test_Click" Style="z-index: 100; left: 435px;
            position: absolute; top: 257px" Text="Test" Width="80px" />
        <asp:Panel ID="Panel1" runat="server" Height="50px" Style="z-index: 101; left: 224px;
            position: absolute; top: 423px" Width="125px">
        </asp:Panel>
        <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
        <asp:Button ID="btnDownLoad" runat="server" OnClick="btnDownLoad_Click" Style="z-index: 102;
            left: 563px; position: absolute; top: 316px" Text="DownLoad" />
        &nbsp;
        <asp:FileUpload ID="FileUpload1" runat="server" Style="z-index: 103; left: 314px;
            position: absolute; top: 317px" />
        <asp:TextBox ID="TextBox1" runat="server" Style="z-index: 104; left: 581px; position: absolute;
            top: 242px"></asp:TextBox>
        <asp:Button ID="btnQuery" runat="server" OnClick="btnQuery_Click" Style="z-index: 105;
            left: 724px; position: absolute; top: 267px" Text="Query" />
        <asp:Button ID="btnCross" runat="server" OnClick="btnCross_Click" PostBackUrl="~/Default2.aspx"
            Style="z-index: 109; left: 788px; position: absolute; top: 266px" Text="CrossPage" />
        <asp:Button ID="btnWait" runat="server" OnClick="btnWait_Click" Style="left: 275px;
            position: relative; top: 2px" Text="Wait" />
    </form>
</body>
</html>
