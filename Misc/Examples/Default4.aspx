<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default4.aspx.cs" Inherits="Default4" StylesheetTheme="SkinFile" Theme="SkinFile" %>
<%@ Register TagName="a" TagPrefix="b" Src="~/WebUserControl.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <b:a ID="aaa" runat="server" />
        <asp:Menu ID="Menu1" runat="server" BackColor="#80FFFF" BorderColor="#8080FF" BorderStyle="Solid"
            Orientation="Horizontal" StaticDisplayLevels="2" StaticEnableDefaultPopOutImage="False"
            Style="z-index: 100; left: 200px; position: absolute; top: 291px" OnMenuItemClick="Menu1_MenuItemClick">
            <DynamicHoverStyle BackColor="Yellow" />
            <StaticSelectedStyle BackColor="Red" />
            <DynamicMenuItemStyle BackColor="Blue" />
            <Items>
                <asp:MenuItem NavigateUrl="~/Adrotator.aspx" Text="Home" Value="Home">
                    <asp:MenuItem NavigateUrl="~/Default.aspx" Text="Page1" Value="Page1">
                        <asp:MenuItem NavigateUrl="~/Default2.aspx" Text="Page2" Value="Page2">
                            <asp:MenuItem NavigateUrl="~/Default4.aspx" Text="Page3" Value="Page3"></asp:MenuItem>
                        </asp:MenuItem>
                        <asp:MenuItem NavigateUrl="~/multiview.aspx" Text="Page4" Value="Page4"></asp:MenuItem>
                    </asp:MenuItem>
                    <asp:MenuItem NavigateUrl="~/Default3.aspx" Text="Page5" Value="Page5"></asp:MenuItem>
                </asp:MenuItem>
            </Items>
            <StaticHoverStyle BackColor="#C000C0" />
        </asp:Menu>
        <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" />
        <asp:TreeView ID="TreeView1" runat="server" Style="z-index: 101; left: 491px; position: absolute;
            top: 195px" OnSelectedNodeChanged="TreeView1_SelectedNodeChanged">
            <Nodes>
                <asp:TreeNode Text="New Node" Value="New Node">
                    <asp:TreeNode Text="New Node" Value="New Node">
                        <asp:TreeNode Text="New Node" Value="New Node">
                            <asp:TreeNode Text="New Node" Value="New Node">
                                <asp:TreeNode Text="New Node" Value="New Node"></asp:TreeNode>
                                <asp:TreeNode Text="New Node" Value="New Node">
                                    <asp:TreeNode Checked="True" Selected="True" ShowCheckBox="True" Text="New Node"
                                        Value="New Node"></asp:TreeNode>
                                </asp:TreeNode>
                            </asp:TreeNode>
                            <asp:TreeNode Text="New Node" Value="New Node"></asp:TreeNode>
                        </asp:TreeNode>
                    </asp:TreeNode>
                    <asp:TreeNode Text="New Node" Value="New Node">
                        <asp:TreeNode Text="New Node" Value="New Node"></asp:TreeNode>
                    </asp:TreeNode>
                </asp:TreeNode>
            </Nodes>
        </asp:TreeView>
        <asp:SiteMapPath ID="SiteMapPath1" runat="server" Style="z-index: 102; left: 222px;
            position: absolute; top: 90px">
        </asp:SiteMapPath>
        <asp:Label ID="Label1" runat="server" SkinID="aaa" Style="z-index: 103; left: 458px;
            position: absolute; top: 57px" Text="Label" Width="167px"></asp:Label>
        <asp:Label ID="Label2" runat="server" SkinID="aaa" Style="z-index: 105; left: 466px;
            position: absolute; top: 115px" Text="Label" Width="161px"></asp:Label>
    
    </div>
    </form>
</body>
</html>
