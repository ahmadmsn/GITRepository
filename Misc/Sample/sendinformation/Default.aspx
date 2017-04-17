<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Style="z-index: 100; left: 49px; position: absolute;
            top: 102px" Text="Enter First Name" Width="118px"></asp:Label>
        <asp:Label ID="Label2" runat="server" Style="z-index: 101; left: 49px; position: absolute;
            top: 155px" Text="Enter Last Name" Width="126px"></asp:Label>
        <asp:TextBox ID="txt1" runat="server" Style="z-index: 102; left: 219px; position: absolute;
            top: 102px"></asp:TextBox>
        <asp:Button ID="Btn" runat="server" Style="z-index: 103; left: 124px; position: absolute;
            top: 218px" Text="Post Button" Width="144px" PostBackUrl="~/Default2.aspx" OnClick="Btn_Click" />
        <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" OnClick="LinkButton1_Click"
            PostBackUrl="~/Default2.aspx" Style="z-index: 104; left: 149px; position: absolute;
            top: 267px">Post Back</asp:LinkButton>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default2.aspx" Style="z-index: 108;
            left: 151px; position: absolute; top: 318px">second page</asp:HyperLink>
        <asp:TextBox ID="txt2" runat="server" Style="z-index: 106; left: 216px; position: absolute;
            top: 154px"></asp:TextBox>
        <asp:LinkButton ID="LinkButton2" runat="server" PostBackUrl="~/Default2.aspx" Style="z-index: 107;
            left: 212px; position: absolute; top: 383px">LinkButton</asp:LinkButton>
            
    
    </div>
    </form>
</body>
</html>
