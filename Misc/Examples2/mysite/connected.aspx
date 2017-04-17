<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="connected.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        &nbsp;
        <asp:Label ID="Label2" runat="server" Style="z-index: 100; left: 245px; position: absolute;
            top: 163px" Text="Employee Name"></asp:Label>
        &nbsp; &nbsp; &nbsp;
        <asp:Label ID="Label3" runat="server" Style="z-index: 101; left: 244px; position: absolute;
            top: 119px" Text="Employee Id"></asp:Label>
        <asp:TextBox ID="txteid" runat="server" Style="z-index: 102; left: 366px; position: absolute;
            top: 114px"></asp:TextBox>
        <asp:TextBox ID="txtname" runat="server" Style="z-index: 103; left: 366px; position: absolute;
            top: 162px"></asp:TextBox>
        <asp:Label ID="lblerr" runat="server" Style="z-index: 104; left: 542px; position: absolute;
            top: 200px"></asp:Label>
        <asp:Button ID="cmdinsert" runat="server" Style="z-index: 105; left: 319px; position: absolute;
            top: 239px" Text="Insert" OnClick="cmdinsert_Click" />
        <asp:GridView ID="GridView1" runat="server" Style="z-index: 106; left: 356px; position: absolute;
            top: 271px">
        </asp:GridView>
        <asp:Button ID="cmddel" runat="server" OnClick="cmddel_Click" Style="z-index: 107;
            left: 388px; position: absolute; top: 239px" Text="Delete" />
        <asp:Button ID="cmdupdate" runat="server" OnClick="cmdupdate_Click" Style="z-index: 108;
            left: 460px; position: absolute; top: 238px" Text="Update" />
        <asp:Button ID="cmdshow" runat="server" OnClick="cmdshow_Click" Style="z-index: 109;
            left: 539px; position: absolute; top: 238px" Text="Show" Width="61px" />
        <asp:Button ID="cmdgrid" runat="server" OnClick="cmdgrid_Click" Style="z-index: 111;
            left: 622px; position: absolute; top: 239px" Text="ShowInGridView" />
    
    </div>
    </form>
</body>
</html>
