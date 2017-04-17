<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Adrotator.aspx.cs" Inherits="Adrotator" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:AdRotator ID="AdRotator1" runat="server" AdvertisementFile="~/XMLFile.xml" Height="138px"
            KeywordFilter="a" Style="z-index: 100; left: 16px; position: absolute; top: 36px"
            Width="171px" OnAdCreated="AdRotator1_AdCreated" DataSourceID="XmlDataSource1" />
        <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/XMLFile.xml"></asp:XmlDataSource>
        &nbsp;
    
    </div>
    </form>
</body>
</html>
