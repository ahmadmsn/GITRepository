<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        &nbsp;
        <asp:Label ID="Label2" runat="server" Style="z-index: 100; left: 111px; position: absolute;
            top: 54px" Text="To"></asp:Label>
        &nbsp;
        <asp:Label ID="Label4" runat="server" Style="z-index: 101; left: 108px; position: absolute;
            top: 127px" Text="Subject"></asp:Label>
        <asp:Label ID="Label5" runat="server" Style="z-index: 102; left: 110px; position: absolute;
            top: 163px" Text="Attachment"></asp:Label>
        <asp:TextBox ID="txtto" runat="server" Style="z-index: 103; left: 208px; position: absolute;
            top: 49px"></asp:TextBox>
        &nbsp;
        <asp:TextBox ID="txtsub" runat="server" Style="z-index: 104; left: 208px; position: absolute;
            top: 131px"></asp:TextBox>
        &nbsp;&nbsp;
        <asp:FileUpload ID="File1" runat="server" Style="z-index: 105; left: 207px;
            position: absolute; top: 168px" />
        <asp:Button ID="btnattachfile" runat="server" OnClick="btnattachfile_Click" Style="z-index: 106;
            left: 467px; position: absolute; top: 166px" Text="AttachFile" UseSubmitBehavior="False" Width="100px" />
        &nbsp;
        <asp:ListBox ID="FileList" runat="server" Height="96px" Style="z-index: 107; left: 600px;
            position: absolute; top: 32px" Width="185px"></asp:ListBox>
        <asp:Button ID="btnremove" runat="server" Style="z-index: 108; left: 604px; position: absolute;
            top: 159px" Text="Remove Attachment" />
        <asp:TextBox ID="txtwrite" runat="server" Height="229px" Style="z-index: 109; left: 136px;
            position: absolute; top: 222px" Width="485px" TextMode="MultiLine"></asp:TextBox>
        <asp:Button ID="btnsendemail" runat="server" OnClick="btnsendemail_Click" Style="z-index: 110;
            left: 137px; position: absolute; top: 480px" Text="SendEmail" />
        &nbsp;
    
    </div>
    </form>
</body>
</html>
