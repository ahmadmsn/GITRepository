<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">

    <title>Untitled Page</title>
    
</head>
<body>
    <form id="form1" runat="server" defaultbutton="btnDefault">
    <div>
    
        <asp:Button ID="btnNormal" runat="server" OnClick="btnNormal_Click" Style="left: 213px;
            position: relative; top: 27px" TabIndex="1" Text="NormalButton" UseSubmitBehavior="False" />
        <asp:Button ID="btnDefault" runat="server" OnClick="btnDefault_Click" Style="left: 89px;
            position: relative; top: 84px" TabIndex="2" Text="DefaultButton" UseSubmitBehavior="False" />
        <asp:TextBox ID="TextBox1" runat="server" Style="left: -29px; position: relative;
            top: 133px"></asp:TextBox></div>
    </form>
</body>
</html>
<script type="text/javascript">
    function checkevent()
    {
        if(window.event.keyCode==13)
        {
            location.href="redirectpage.aspx";
        }
    }
    </script>