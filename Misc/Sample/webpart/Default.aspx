<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:WebPartManager ID="WebPartManager1" runat="server">
        </asp:WebPartManager>
        <asp:WebPartZone ID="WebPartZone1" runat="server" BorderColor="#CCCCCC" Font-Names="Verdana"
            Height="1px" Padding="6" Style="z-index: 100; left: 12px; position: absolute;
            top: 115px" Width="1px">
            <PartChromeStyle BackColor="#E3EAEB" BorderColor="#C5BBAF" Font-Names="Verdana" ForeColor="#333333" />
            <MenuLabelHoverStyle ForeColor="Yellow" />
            <EmptyZoneTextStyle Font-Size="0.8em" />
            <MenuLabelStyle ForeColor="#333333" />
            <MenuVerbHoverStyle BackColor="#E3EAEB" BorderColor="#CCCCCC" BorderStyle="Solid"
                BorderWidth="1px" ForeColor="#333333" />
            <HeaderStyle Font-Size="0.7em" ForeColor="#CCCCCC" HorizontalAlign="Center" />
            <ZoneTemplate>
                <asp:Image ID="Image1" runat="server" Height="248px" ImageUrl="~/image/ran9h.jpg"
                    Style="z-index: 61; left: 0px; top: 0px" />
            </ZoneTemplate>
            <MenuVerbStyle BorderColor="#1C5E55" BorderStyle="Solid" BorderWidth="1px" ForeColor="White" />
            <PartStyle Font-Size="0.8em" ForeColor="#333333" />
            <TitleBarVerbStyle Font-Size="0.6em" Font-Underline="False" ForeColor="White" />
            <MenuPopupStyle BackColor="#1C5E55" BorderColor="#CCCCCC" BorderWidth="1px" Font-Names="Verdana"
                Font-Size="0.6em" />
            <PartTitleStyle BackColor="#1C5E55" Font-Bold="True" Font-Size="0.8em" ForeColor="White" />
        </asp:WebPartZone>
        <asp:WebPartZone ID="WebPartZone2" runat="server" BorderColor="#CCCCCC" Font-Names="Verdana"
            Height="239px" Padding="6" Style="z-index: 102; left: 391px; position: absolute;
            top: 130px" Width="287px">
            <PartChromeStyle BackColor="#E3EAEB" BorderColor="#C5BBAF" Font-Names="Verdana" ForeColor="#333333" />
            <MenuLabelHoverStyle ForeColor="Yellow" />
            <EmptyZoneTextStyle Font-Size="0.8em" />
            <MenuLabelStyle ForeColor="#333333" />
            <MenuVerbHoverStyle BackColor="#E3EAEB" BorderColor="#CCCCCC" BorderStyle="Solid"
                BorderWidth="1px" ForeColor="#333333" />
            <HeaderStyle Font-Size="0.7em" ForeColor="#CCCCCC" HorizontalAlign="Center" />
            <ZoneTemplate>
                <asp:Calendar ID="Calendar1" runat="server" Style="z-index: 142; left: 0px; top: 0px">
                </asp:Calendar>
            </ZoneTemplate>
            <MenuVerbStyle BorderColor="#1C5E55" BorderStyle="Solid" BorderWidth="1px" ForeColor="White" />
            <PartStyle Font-Size="0.8em" ForeColor="#333333" />
            <TitleBarVerbStyle Font-Size="0.6em" Font-Underline="False" ForeColor="White" />
            <MenuPopupStyle BackColor="#1C5E55" BorderColor="#CCCCCC" BorderWidth="1px" Font-Names="Verdana"
                Font-Size="0.6em" />
            <PartTitleStyle BackColor="#1C5E55" Font-Bold="True" Font-Size="0.8em" ForeColor="White" />
        </asp:WebPartZone>
    
    </div>
    </form>
</body>
</html>
