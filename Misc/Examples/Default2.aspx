<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2"  %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Panel ID="Panel1" runat="server" BackColor="#FFFF80" Height="353px" Style="z-index: 100;
            left: 30px; position: absolute; top: 378px" Width="501px">
            <asp:TextBox ID="TextBox1" runat="server" Style="z-index: 100; left: 14px; position: absolute;
                top: 32px"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Style="z-index: 101;
                left: 172px; position: absolute; top: 32px" Text="Button" />
            <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"
                Style="z-index: 103; left: 178px; position: absolute; top: 57px"></asp:Calendar>
        </asp:Panel>
        <asp:SiteMapPath ID="SiteMapPath1" runat="server" Font-Names="Verdana" Font-Size="0.8em"
            PathSeparator=" : " Style="z-index: 101; left: 252px; position: absolute; top: 43px">
            <PathSeparatorStyle Font-Bold="True" ForeColor="#990000" />
            <CurrentNodeStyle ForeColor="#333333" />
            <NodeStyle Font-Bold="True" ForeColor="#990000" />
            <RootNodeStyle Font-Bold="True" ForeColor="#FF8000" />
        </asp:SiteMapPath>
        &nbsp;&nbsp;
        <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
        <asp:Calendar ID="Calendar2" runat="server" OnDayRender="Calendar2_DayRender" OnSelectionChanged="Calendar2_SelectionChanged"
            Style="z-index: 102; left: 58px; position: absolute; top: 87px"></asp:Calendar>
        &nbsp;
    
    </div>
    </form>
</body>
</html>
