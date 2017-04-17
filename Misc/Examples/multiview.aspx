<%@ Page Language="C#" AutoEventWireup="true" CodeFile="multiview.aspx.cs" Inherits="multiview" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"
            Style="z-index: 100; left: 234px; position: absolute; top: 6px">
            <asp:ListItem Value="0">view1</asp:ListItem>
            <asp:ListItem Value="1">view2</asp:ListItem>
            <asp:ListItem Value=" 2">view3</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:MultiView ID="MultiView1" runat="server">
            <asp:View ID="View1" runat="server">
                <asp:Label ID="Label1" runat="server" Style="z-index: 100; left: 130px; position: absolute;
                    top: 78px" Text="view1"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server" Style="z-index: 102; left: 299px; position: absolute;
                    top: 75px"></asp:TextBox>
            </asp:View>
            <asp:View ID="View2" runat="server">
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default2.aspx" Style="z-index: 100;
                    left: 64px; position: absolute; top: 143px">view2</asp:HyperLink>
            </asp:View>
            <asp:View ID="View3" runat="server">
                <asp:Calendar ID="Calendar1" runat="server" Style="z-index: 100; left: 48px; position: absolute;
                    top: 258px"></asp:Calendar>
                <asp:Label ID="Label2" runat="server" Style="z-index: 102; left: 134px; position: absolute;
                    top: 222px" Text="view3"></asp:Label>
                <br />
                <br />
                <br />
                <br />
                <asp:Localize ID="Localize1" runat="server"></asp:Localize><br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
            </asp:View>
        </asp:MultiView></div>
        <br />
        <br />
        <br />
    </form>
</body>
</html>
