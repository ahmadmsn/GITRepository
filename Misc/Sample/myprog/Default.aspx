<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="TextBox1" runat="server" Style="z-index: 100; left: 247px; position: absolute;
            top: 23px"></asp:TextBox>
        &nbsp;
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click" PostBackUrl="~/mypage.aspx?Name=num"
            Style="z-index: 101; left: 447px; position: absolute; top: 27px" Width="164px">Click me For MyPage</asp:LinkButton>
        &nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Style="z-index: 102;
            left: 114px; position: absolute; top: 52px" Text="Button" Width="165px" />
        <asp:Label ID="Label2" runat="server" Style="z-index: 103; left: 20px; position: absolute;
            top: 114px" Width="289px"></asp:Label>
        &nbsp;<br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        <br />
        <br />
        <br />
        <br />
        <br />
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp;&nbsp;
        <asp:Label ID="Label4" runat="server" Style="z-index: 104; left: 462px; position: absolute;
            top: 315px" Width="186px"></asp:Label>
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        <asp:Label ID="Label1" runat="server" Style="z-index: 105; left: 21px; position: absolute;
            top: 20px" Text="Enter Your Name" Width="194px"></asp:Label>
        <asp:HyperLink ID="HyperLink1" runat="server" ImageUrl="~/NewFolder1/imageeffects.jpg"
            NavigateUrl="~/mypage.aspx" Style="z-index: 106; left: 451px; position: absolute;
            top: 77px" Width="152px">HyperLink</asp:HyperLink>
        &nbsp;<br />
        <br />
        <asp:CheckBox ID="CheckBox2" runat="server" Style="z-index: 107; left: 468px; position: absolute;
            top: 404px" Text="Female" />
        <br />
        <br />
        <br />
        <br />
        <br />
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
        <asp:ImageButton ID="ImageButton1" runat="server" Height="27px" ImageUrl="~/NewFolder1/background.jpg"
            OnClick="ImageButton1_Click" Style="z-index: 108; left: 25px; position: absolute;
            top: 156px" Width="93px" />
        &nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataTextFormatString="hello"
            OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Style="z-index: 109;
            left: 454px; position: absolute; top: 113px">
            <asp:ListItem Value="aaaa"></asp:ListItem>
            <asp:ListItem>bbb</asp:ListItem>
            <asp:ListItem>ccc</asp:ListItem>
        </asp:DropDownList>
        <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged"
            Style="z-index: 110; left: 460px; position: absolute; top: 214px">
            <asp:ListItem>aaa</asp:ListItem>
            <asp:ListItem>bbb</asp:ListItem>
            <asp:ListItem>ccc</asp:ListItem>
            <asp:ListItem>ddd</asp:ListItem>
            <asp:ListItem>eeee</asp:ListItem>
            <asp:ListItem>ffff</asp:ListItem>
            <asp:ListItem>ggg</asp:ListItem>
        </asp:ListBox>
        <asp:CheckBox ID="CheckBox1" runat="server" Checked="True" Style="z-index: 111; left: 470px;
            position: absolute; top: 371px" Text="Male" />
        &nbsp;
        <asp:Label ID="Label3" runat="server" Style="z-index: 112; left: 449px; position: absolute;
            top: 158px" Width="129px"></asp:Label>
    
    </div>
    </form>
</body>
</html>
