<%@ Page Language="C#" AutoEventWireup="true" CodeFile="id.aspx.cs" Inherits="id" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" BackColor="#FFFF66" Height="26px" Style="z-index: 100;
            left: 105px; position: absolute; top: 115px" Text="yr id is           :" Width="326px"></asp:Label>
        <asp:Button ID="ok" runat="server" Height="39px" OnClick="ok_Click" Style="z-index: 101;
            left: 213px; position: absolute; top: 207px" Text="ok" Width="51px" />
        <asp:Label ID="Label2" runat="server" BackColor="#FFFF66" Height="26px" Style="z-index: 103;
            left: 105px; position: absolute; top: 154px" Text="yr password is : " Width="327px"></asp:Label>
    
    </div>
    </form>
</body>
</html>
