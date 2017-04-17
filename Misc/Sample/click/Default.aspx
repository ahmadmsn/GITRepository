<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="btn1" runat="server" OnClick="btn1_Click" Style="z-index: 100; left: 114px;
            position: absolute; top: 47px" Text="Increment" />
        <asp:Label ID="Lbl" runat="server" Style="z-index: 102; left: 118px; position: absolute;
            top: 92px" Width="80px"></asp:Label>
    
    </div>
    </form>
</body>
</html>
