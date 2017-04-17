<%@ Page Language="C#" AutoEventWireup="true" CodeFile="mypage.aspx.cs" Inherits="mypage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ImageButton ID="ImageButton1" runat="server" Height="37px" ImageAlign="Left"
            ImageUrl="~/NewFolder1/kar89v.jpg" OnClick="ImageButton1_Click" Style="z-index: 100;
            left: 310px; position: absolute; top: 297px" Width="74px" />
        <asp:AdRotator ID="AdRotator1" runat="server" AdvertisementFile="~/XMLFile.xml" Height="200px"
            KeywordFilter="b" Style="z-index: 101; left: 243px; position: absolute; top: 29px"
            Width="206px" />
        <asp:Table ID="Table1" runat="server" Caption="MY Table" GridLines="Both" Height="98px"
            Style="z-index: 102; left: 41px; position: absolute; top: 116px" Width="176px">
            <asp:TableRow runat="server" HorizontalAlign="Justify" VerticalAlign="Top">
                <asp:TableCell runat="server">ok</asp:TableCell>
                <asp:TableCell runat="server">bye</asp:TableCell>
                <asp:TableCell runat="server">hello</asp:TableCell>
                <asp:TableCell runat="server">hi</asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server">
                <asp:TableCell runat="server">aa</asp:TableCell>
                <asp:TableCell runat="server">bb</asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server">
                <asp:TableCell runat="server">dd</asp:TableCell>
            </asp:TableRow>
        </asp:Table>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Style="z-index: 106;
            left: 104px; position: absolute; top: 251px" Text="Button" />
        <asp:BulletedList ID="BulletedList1" runat="server" BorderStyle="Groove" BorderWidth="2px"
            BulletImageUrl="~/NewFolder1/greendot.jpg" BulletStyle="Circle" Style="z-index: 104;
            left: 515px; position: absolute; top: 281px" Width="44px">
            <asp:ListItem>aaa</asp:ListItem>
            <asp:ListItem>bbb</asp:ListItem>
            <asp:ListItem>ccc</asp:ListItem>
        </asp:BulletedList>
    
    </div>
        <asp:HiddenField ID="HiddenField1" runat="server" OnValueChanged="HiddenField1_ValueChanged"
            Value="67" />
        <asp:Label ID="Label1" runat="server" Style="z-index: 105; left: 14px; position: absolute;
            top: 47px"></asp:Label>
    </form>
</body>
</html>
