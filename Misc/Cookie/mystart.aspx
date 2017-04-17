<%@ Page Language="C#" AutoEventWireup="true" CodeFile="mystart.aspx.cs" Inherits="mystart" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Style="z-index: 100; left: 58px; position: absolute;
            top: 65px" Text="Enter yr ID" Width="130px"></asp:Label>
        <asp:TextBox ID="txtid" runat="server" Style="z-index: 101; left: 212px; position: absolute;
            top: 62px"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Style="z-index: 102; left: 57px; position: absolute;
            top: 108px" Text="Enter yr Password"></asp:Label>
        <asp:TextBox ID="txtpwd" runat="server" Style="z-index: 103; left: 214px; position: absolute;
            top: 106px"></asp:TextBox>
        <asp:Button ID="btnsubmit" runat="server" OnClick="btnsubmit_Click" Style="z-index: 104;
            left: 90px; position: absolute; top: 183px" Text="Submit" />
        <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" OnClick="LinkButton1_Click"
            PostBackUrl="~/Default.aspx" Style="z-index: 105; left: 218px; position: absolute;
            top: 188px">Create New Account</asp:LinkButton>
        <asp:RequiredFieldValidator ID="rfv1" runat="server" ControlToValidate="txtid" ErrorMessage="user name is mendatory"
            Style="z-index: 106; left: 392px; position: absolute; top: 62px">*</asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ID="rfv2" runat="server" ControlToValidate="txtpwd" ErrorMessage="password is mendatory"
            Style="z-index: 107; left: 393px; position: absolute; top: 108px">*</asp:RequiredFieldValidator>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" HeaderText="* IS MENDATORY FIELD"
            Style="z-index: 108; left: 66px; position: absolute; top: 307px" Width="477px" />
        &nbsp;
    
    </div>
    </form>
</body>
</html>
