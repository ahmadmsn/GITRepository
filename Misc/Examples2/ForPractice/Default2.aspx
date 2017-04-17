<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" ValidateRequest="false" %>

<%@ PreviousPageType VirtualPath="~/Default.aspx"%>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
<link href="StyleSheet.css" type="text/css" rel="stylesheet" id="stylesheet" />
    <script type="text/javascript">
    function DisplayAlert()
    {
        alert('You Clicked on Alert Button'); 
    }
    function CloseWindow()
    {
        window.close()
    }
    function ShowMessage()
    {
        alert(document.form1.TextBox1.value);
        return false;
     }
               
    </script>
    
    <title>Untitled Page</title>
    
</head>
<body class="body" id="MyBody1" runat="server">
    <form id="form1" runat="server">
    <div  class="div1"  id="sc" runat="server" >
     <a href=Default.aspx style="left: 26px; width: 61px; position: absolute; top: 46px"> TEST </a>
        &nbsp; &nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" Style="z-index: 100; left: 45px; position: absolute;
            top: 91px" Height="50px" TextMode="MultiLine"></asp:TextBox>
        &nbsp;&nbsp;
        <asp:Button ID="btnAlert" runat="server" OnClick="btnAlert_Click" Style="z-index: 101;
            left: 175px; position: relative; top: 75px" Text="Alert" Width="80px" />&nbsp;
        <asp:Button ID="btnScript" runat="server" Style="z-index: 102; left: 360px; position: absolute;
            top: 89px" Text="JavaScript" OnClientClick="DisplayAlert()" Width="80px" />
        &nbsp;
        <asp:Button ID="btnExport" runat="server" OnClick="btnExport_Click" Style="z-index: 103;
            left: 467px; position: absolute; top: 89px" Text="Export" Width="60px" />
        <asp:Button ID="btnInsertImage" runat="server" OnClick="btnInsertImage_Click" Style="z-index: 104;
            left: 550px; position: absolute; top: 89px" Text="InsertImage" Width="80px" />
        <asp:Button ID="btnRetrieveImage" runat="server" OnClick="btnRetrieveImage_Click"
            Style="z-index: 105; left: 652px; position: absolute; top: 88px" Text="RetrieveImage" Width="100px" />
        <asp:FileUpload ID="FileUpload1" runat="server" Style="z-index: 106; left: 41px;
            position: absolute; top: 160px" />
        <asp:Button ID="btnImport" runat="server" OnClick="btnImport_Click" Style="z-index: 107;
            left: 289px; position: absolute; top: 159px" Text="Import" Width="70px" />
    <asp:Button ID="btnTransfer" Text="Transfer" runat="server" OnClick="btnTransfer_Click" style="left: 905px; position: absolute; top: 81px" Width="70px" />    
    <asp:Label ID="Lbl1" Text="<b>This is my Label &lt &nbsp &nbsp &nbsp &nbsp  Finish" runat="server" style="left: 212px; position: absolute; top: 44px"></asp:Label>
    <asp:Button ID="btnCommon" Text="Common" runat="server" OnClick="btnCommon_Click" style="left: 107px; position: absolute; top: 42px" Width="81px" />
            <input id="Text1" type="Text" value="<Enter E-Mail Address >" onfocus="alert(Text.value)"  runat="server" style="left: 547px; position: absolute; top: 40px" />
           <input type="button" value="ClickMe" onclick="DisplayAlert()" style="left: 450px; position: absolute; top:41px; width: 80px;"  id="Button1" />
    <asp:Button ID="btnRedirect" Text="Redirect" runat="server" OnClick="btnRedirect_Click" style="left: 789px; position: absolute; top: 89px" Width="70px"  />
    <asp:Button ID="Decode" Text="Test_encode" runat="server" OnClick="Decode_Click" style="left: 834px; position: absolute; top: 39px" Width="100px" />
        <asp:Button ID="btnXmlWrite" runat="server" OnClick="btnXmlWrite_Click" Style="left: 369px;
            position: absolute; top: 159px" Text="XmlFile_Write" Width="100px" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Style="left: 327px;
            position: relative; top: 127px" Text="XMLFILE_WRITE2" Width="120px" />
        <asp:Button ID="btnException" runat="server" OnClick="btnException_Click" Style="left: 374px;
            position: relative; top: 133px" Text="ExceptionTest" />
        <asp:Button ID="cmdSession" runat="server" OnClick="cmdSession_Click" Style="left: 420px;
            position: relative; top: 137px" Text="SessionTest" />
        <asp:Button ID="cmdCookie" runat="server" OnClick="cmdCookie_Click" Style="left: -480px;
            position: relative; top: 191px" Text="CookiesTest" Width="100px" />
        <asp:Button ID="btnSerialize" runat="server" OnClick="btnSerialize_Click" Style="left: 459px;
            position: absolute; top: 212px" Text="Serialize" Width="60px" />
        <asp:Button ID="btnXmlSerialize" runat="server" OnClick="btnXmlSerialize_Click" Style="left: -79px;
            position: relative; top: 185px" Text="XMLSerialize" />
        <asp:Button ID="btnXmlSerialize2" runat="server" OnClick="btnXmlSerialize2_Click"
            Style="left: 465px; position: relative; top: 235px" Text="XmlSerialize2" />
        <asp:Button ID="btnStream" runat="server" OnClick="btnStream_Click" Style="left: 528px;
            position: relative; top: 170px" Text="FStream" />
        <asp:Button ID="btnFStream" runat="server" OnClick="btnFStream_Click" Style="left: -532px;
            position: relative; top: 238px" Text="FileStream" Width="85px" />
        <asp:Button ID="btnGridView" runat="server" OnClick="btnGridView_Click" Style="left: 612px;
            position: relative; top: 211px" Text="GridViewTest" Width="85px" />
        <asp:Button ID="btnInsert" runat="server" OnClick="btnInsert_Click" Style="left: 767px;
            position: relative; top: 262px" Text="Insert" />
        <asp:TextBox ID="txtName" runat="server" Style="left: 709px; position: relative;
            top: 147px"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" Style="left: 450px; position: relative; top: 159px"
            Text="Name"></asp:Label>
        <asp:TextBox ID="txtAddress" runat="server" Style="left: 457px; position: relative;
            top: 216px" TextMode="MultiLine"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Style="left: 194px; position: relative; top: 220px"
            Text="Address"></asp:Label>
        <asp:Button ID="btnShow" runat="server" OnClick="btnShow_Click" Style="left: 342px;
            position: relative; top: 264px" Text="Show" />
        <asp:Button ID="btnWildShow" runat="server" Style="left: 127px; position: relative; top: 266px"
            Text="SearchWildChar" OnClick="btnWildShow_Click" Width="120px" />
        <asp:TextBox ID="txtWild" runat="server" Style="left: 9px; position: relative; top: 295px"
            Width="107px"></asp:TextBox></div>
    <asp:GridView ID="GridView1" runat="server" Style="z-index: 109; left: 17px; position: absolute;
            top: 268px" BackColor="#E0E0E0" BorderColor="#FF8080" Font-Bold="True" ForeColor="Lime">
        </asp:GridView>
        <asp:Button ID="Close" Text="CloseWindow" runat="server" OnClick="Close_Click" OnClientClick="javascript:CloseWindow()" style="left: 320px; position: absolute; top: 213px" Width="100px" />
        <asp:Button ID="Show" runat="server"  Text="ShowMessage" style="left: 194px; position: absolute; top: 219px" Width="100px" /><div>
       
    </div>
    </form>
</body>
</html>
