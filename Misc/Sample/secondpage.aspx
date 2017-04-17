<%@ Page Language="C#" AutoEventWireup="true" CodeFile="secondpage.aspx.cs" Inherits="secondpage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>HELLO</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Style="z-index: 100; left: 242px; position: absolute;
            top: 93px" Width="85px" ForeColor="Lime"></asp:Label>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Style="z-index: 101;
            left: 76px; position: absolute; top: 95px" Text="Button" BackColor="Green" OnDataBinding="Button1_Click" />
       <asp:Button ID="HELLO" runat="server" Text="button" style="z-index: 103; left: 66px; position: absolute; top: 192px" OnClick="HELLO_Click" />
    
    </div>
    </form>
</body>
</html>
