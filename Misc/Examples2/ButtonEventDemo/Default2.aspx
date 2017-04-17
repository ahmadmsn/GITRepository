<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
    <script type="text/javascript">
    function checkevent()
    {
        if(event.keyCode==13)
        {
            location.href="redirectpage.aspx";
        } 
    }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        &nbsp;
        <asp:Button ID="btnDefaulr" runat="server" Style="z-index: 100; left: 189px; position: absolute;
            top: 94px" Text="DefaultButton" UseSubmitBehavior="False" OnClick="btnDefaulr_Click" />
        <asp:Button ID="btnNormal" runat="server" Style="z-index: 101; left: 187px; position: absolute;
            top: 128px" Text="NormalButton" OnClick="btnNormal_Click" />
        <asp:TextBox ID="TextBox1" runat="server" Style="z-index: 103; left: 189px; position: absolute;
            top: 172px"></asp:TextBox>
    
    </div>
    </form>
</body>
</html>
