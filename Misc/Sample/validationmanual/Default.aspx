<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Style="z-index: 100; left: 289px; position: absolute;
            top: 120px" Text="A Number 1 to 10"></asp:Label>
        <asp:Label ID="Label2" runat="server" Style="z-index: 101; left: 292px; position: absolute;
            top: 210px" Text="Not Validated"></asp:Label>
        <asp:TextBox ID="txt2" runat="server" Style="z-index: 102; left: 436px; position: absolute;
            top: 210px"></asp:TextBox>
        <asp:TextBox ID="txt1" runat="server" Style="z-index: 103; left: 433px; position: absolute;
            top: 122px"></asp:TextBox>
        <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="This Number Is Out Of Range"
            MaximumValue="20" MinimumValue="10" Style="z-index: 104; left: 600px; position: absolute;
            top: 124px" ControlToValidate="txt1">*</asp:RangeValidator>
        <asp:Button ID="btn1" runat="server" OnClick="btn1_Click" Style="z-index: 105; left: 451px;
            position: absolute; top: 281px" Text="OK" />
        <asp:Label ID="Label3" runat="server" Height="79px" Style="z-index: 106; left: 357px;
            position: absolute; top: 387px" Text="Label" Width="339px"></asp:Label>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" Style="z-index: 108;
            left: 345px; position: absolute; top: 483px" />
    
    </div>
    </form>
</body>
</html>
