<%@ Page Language="C#" AutoEventWireup="true" CodeFile="image.aspx.cs" Inherits="image" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:CheckBox ID="chkbox" runat="server" Style="z-index: 100; left: 153px; position: absolute;
            top: 120px" Text="Select Default Picture" Width="214px" />
        <asp:Image ID="Image1" runat="server" Style="z-index: 101; left: 149px; position: absolute;
            top: 194px" Width="227px" />
        <asp:Button ID="updatebtn" runat="server" OnClick="updatebtn_Click" Style="z-index: 103;
            left: 212px; position: absolute; top: 489px" Text="update" />
    
    </div>
    </form>
</body>
</html>
