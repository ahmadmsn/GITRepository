<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>
<%@ PreviousPageType VirtualPath ="~/Default.aspx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Style="z-index: 100; left: 195px; position: absolute;
            top: 50px" Text="Label" Width="276px"></asp:Label>
        <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Default.aspx" Style="z-index: 102;
            left: 219px; position: absolute; top: 103px">LinkButton</asp:LinkButton>
    
    </div>
    </form>
</body>
</html>
