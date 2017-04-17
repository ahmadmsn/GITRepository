<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Login.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server" action="Login.aspx" >
    <div>
    <table style="z-index: 102; left: 304px; width: 398px; position: absolute; top: 175px; height: 142px; border-right: olive thin outset; border-top: olive thin outset; border-left: olive thin outset; color: blue; border-bottom: olive thin outset; font-family: 'Bookman Old Style';">
    <tr>
    <td colspan="2">
    <asp:Label ID="Label1" runat="server" Style="z-index: 101; left: -136px;
            top: -109px;" Text="Enter User Name and Password" BackColor="#80FFFF" Font-Bold="True" ForeColor="#FF8080" Width="391px"></asp:Label>
    </td>
    </tr>
    <tr>
    <td style="width: 110px; height: 6px;"  >
     <asp:Label ID="lblUserName" runat="server" Style="z-index: 102; left: -51px; top: -79px"
            Text="UserName :"></asp:Label>
        </td>   
    <td style="width: 51px; height: 6px;">
    <asp:TextBox ID="txtuid" runat="server" Style="z-index: 101; left: 0px;
            top: 0px"></asp:TextBox>
    </td>   
    </tr>
    <tr>
    <td style="width: 110px; height: 9px;" >
    <asp:Label ID="lblPassword" runat="server" Style="z-index: 100; left: 0px; top: 0px" Text="Password :"></asp:Label>
    </td>
    <td style="width: 51px; height: 9px;">
    <asp:TextBox ID="txtpwd" runat="server" Style="z-index: 101; left: 0px; top: 0px" TextMode="Password" Width="151px"></asp:TextBox>
    </td>
    </tr>
    <tr>
    <td colspan="2">
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;&nbsp;
    <asp:Button ID="btnLogin" runat="server" Style="z-index: 101; left: 0px;
            top: 0px" Text="Login" Font-Bold="True" ForeColor="Blue" OnClick="btnLogin_Click"  />
        <asp:HyperLink ID="HyperLink1" runat="server" Style="z-index: 100; left: 592px; position: absolute;
            top: -102px">HyperLink</asp:HyperLink>
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; 
    <asp:Button ID="btnCancel" runat="server" Style="z-index: 101; left: 0px; top: 0px"
            Text="Cancel" Font-Bold="True" ForeColor="Blue"  />
    </td>
    </tr>
    </table>
        <asp:Label ID="lblerr" runat="server" Style="z-index: 103; left: 452px; position: absolute;
            top: 376px"></asp:Label>
        
        </div>
    </form>
</body>
</html>



