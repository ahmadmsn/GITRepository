<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lbl1" runat="server" Height="93px" Style="z-index: 100; left: 199px;
            position: absolute; top: 51px" Width="309px"></asp:Label>
        <asp:Label ID="lbl2" runat="server" Style="z-index: 101; left: 138px; position: absolute;
            top: 195px" Text="Name" Width="108px"></asp:Label>
        <asp:TextBox ID="txt1" runat="server" Style="z-index: 102; left: 284px; position: absolute;
            top: 191px"></asp:TextBox>
        <asp:Button ID="btn1" runat="server" OnClick="btn1_Click" Style="z-index: 104; left: 476px;
            position: absolute; top: 189px" Text="Cookie Created" />
    
    </div>
    </form>
</body>
</html>
