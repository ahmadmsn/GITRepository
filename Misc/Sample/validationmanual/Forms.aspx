<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Forms.aspx.cs" Inherits="Forms" %>

<%@ Register Src="WebUserControl.ascx" TagName="WebUserControl" TagPrefix="uc1" %>




<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lblname" runat="server" Style="z-index: 100; left: 134px; position: absolute;
            top: 48px" Text="User Name"></asp:Label>
        <asp:TextBox ID="txtname" runat="server" Style="z-index: 101; left: 271px; position: absolute;
            top: 42px"></asp:TextBox>
        <asp:TextBox ID="txtpwd" runat="server" Style="z-index: 102; left: 271px; position: absolute;
            top: 79px" TextMode="Password"></asp:TextBox>
        <asp:TextBox ID="txtpwd2" runat="server" Style="z-index: 103; left: 271px; position: absolute;
            top: 120px" TextMode="Password"></asp:TextBox>
        <asp:TextBox ID="txtmail" runat="server" Style="z-index: 104; left: 271px; position: absolute;
            top: 156px"></asp:TextBox>
        <asp:TextBox ID="txtage" runat="server" Style="z-index: 105; left: 271px; position: absolute;
            top: 194px"></asp:TextBox>
        <asp:TextBox ID="txtreffered" runat="server" Style="z-index: 106; left: 271px; position: absolute;
            top: 234px"></asp:TextBox>
            
        <asp:Label ID="lblpwd" runat="server" Style="z-index: 107; left: 134px; position: absolute;
            top: 86px" Text="Password"></asp:Label>
        <asp:Label ID="lblpwd2" runat="server" Style="z-index: 108; left: 134px; position: absolute;
            top: 124px" Text="Password(ReType)"></asp:Label>
        <asp:Label ID="lblemail" runat="server" Style="z-index: 109; left: 134px; position: absolute;
            top: 162px" Text="EMail"></asp:Label>
        <asp:Label ID="lblage" runat="server" Style="z-index: 110; left: 134px; position: absolute;
            top: 201px" Text="Age"></asp:Label>
        <asp:Label ID="Lblreffered" runat="server" Style="z-index: 111; left: 134px; position: absolute;
            top: 235px" Text="Referred Code"></asp:Label>
            
        <asp:Button ID="btnsubmit" runat="server" Style="z-index: 112; left: 177px; position: absolute;
            top: 306px" Text="Submit" OnClick="btnsubmit_Click" ValidationGroup="1" />
        <asp:Button ID="btncancel" runat="server" Style="z-index: 113; left: 271px; position: absolute;
            top: 302px" Text="Cancel" CausesValidation="False" />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtname"
            ErrorMessage="You Must Enter User Name" Style="z-index: 114; left: 440px; position: absolute;
            top: 43px" ValidationGroup="1">*</asp:RequiredFieldValidator>
        &nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtpwd"
            ErrorMessage="You Must Enter Password" Style="z-index: 115; left: 437px; position: absolute;
            top: 81px" Width="9px" ValidationGroup="1">*</asp:RequiredFieldValidator>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtpwd"
            ControlToValidate="txtpwd2" ErrorMessage="Your Password does not match" Style="z-index: 116;
            left: 437px; position: absolute; top: 110px" Width="1px" ValidationGroup="1">*</asp:CompareValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtpwd2"
            ErrorMessage="You Must Confirm Your Password" Style="z-index: 117; left: 437px;
            position: absolute; top: 135px" ValidationGroup="1">*</asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtmail"
            ErrorMessage="This Email is Missing @ Symbol" Height="6px" Style="z-index: 118;
            left: 440px; position: absolute; top: 162px" ValidationExpression="\S+@\S+\.\S+" ValidationGroup="1">*</asp:RegularExpressionValidator>
        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtage"
            ErrorMessage="This Age Is Not Between 0 to 120" MaximumValue="100" MinimumValue="0"
            Style="z-index: 119; left: 440px; position: absolute; top: 193px" CultureInvariantValues="True" Display="Dynamic" Type="Integer" ValidationGroup="1">*</asp:RangeValidator>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" Style="z-index: 120;
            left: 140px; position: absolute; top: 414px" ValidationGroup="1" />
        <asp:Label ID="Label1" runat="server" Height="29px" Style="z-index: 127; left: 140px;
            position: absolute; top: 514px" Text="Label" Width="164px"></asp:Label>
        &nbsp;&nbsp;&nbsp;
        <asp:CustomValidator ID="CustomValidator2" runat="server" ControlToValidate="txtreffered"
            ErrorMessage="Try a string Thats starts with 014" OnServerValidate="CustomValidator2_ServerValidate"
            Style="z-index: 122; left: 441px; position: absolute; top: 239px" Height="17px" ValidationGroup="1">*</asp:CustomValidator>
        <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" Style="z-index: 123;
            left: 385px; position: absolute; top: 402px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox1"
            ErrorMessage="RequiredFieldValidator" Style="z-index: 124; left: 546px; position: absolute;
            top: 404px" ValidationGroup="2"></asp:RequiredFieldValidator>
        <asp:Button ID="Button1" runat="server" Style="z-index: 125; left: 417px; position: absolute;
            top: 451px" Text="Button" ValidationGroup="2" />
        <asp:Button ID="btnnew" runat="server" OnClick="btnnew_Click" Style="z-index: 126;
            left: 356px; position: absolute; top: 302px" Text="New" />
        <uc1:WebUserControl ID="WebUserControl1" runat="server" />
        
        
    
    </div>
    </form>
</body>
</html>
