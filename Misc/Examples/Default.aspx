<%@ Page Language="C#" AutoEventWireup="true"MasterPageFile="~/MasterPage.master"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

 

 <asp:Content ID="aaa" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
     
        <asp:CheckBox ID="CheckBox1" runat="server" Style="z-index: 100; left: 57px; position: absolute;
            top: 63px" Text="books" />
        <asp:RadioButton ID="RadioButton1" runat="server" GroupName="q" Style="z-index: 101;
            left: 439px; position: absolute; top: 60px" Text="male" OnCheckedChanged="RadioButton1_CheckedChanged" />
        <asp:CheckBox ID="CheckBox2" runat="server" Style="z-index: 102; left: 59px; position: absolute;
            top: 89px" Text="movies" />
        <asp:RadioButton ID="RadioButton2" runat="server" GroupName="q" Style="z-index: 103;
            left: 439px; position: absolute; top: 109px" Text="female" />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Style="z-index: 104;
            left: 311px; position: absolute; top: 165px" Text="Button" />
        <asp:Table ID="Table1" runat="server" BackColor="White" BorderColor="Fuchsia" BorderStyle="Solid"
            BorderWidth="2px" GridLines="Both" Style="z-index: 105; left: 47px; position: absolute;
            top: 215px" Width="121px" CssClass="aaa">
            <asp:TableRow runat="server">
                <asp:TableCell runat="server">1</asp:TableCell>
                <asp:TableCell runat="server">2</asp:TableCell>
                <asp:TableCell runat="server">3</asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server">
                <asp:TableCell runat="server">4</asp:TableCell>
                <asp:TableCell runat="server">5</asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server">
                <asp:TableCell runat="server">6</asp:TableCell>
            </asp:TableRow>
        </asp:Table>
        <table style="z-index: 114; left: 105px; position: absolute; top: 318px">
            <tr>
                <td style="width: 100px">
                </td>
                <td style="width: 100px">
                </td>
                <td style="width: 100px">
                </td>
            </tr>
            <tr>
                <td style="width: 100px; height: 21px;">
                </td>
                <td style="width: 100px; height: 21px;">
                </td>
                <td style="width: 100px; height: 21px;">
                </td>
            </tr>
            <tr>
                <td style="width: 100px">
                </td>
                <td style="width: 100px">
                </td>
                <td style="width: 100px">
                </td>
            </tr>
        </table>
        &nbsp;
        <asp:CheckBoxList ID="CheckBoxList1" runat="server" Style="z-index: 106; left: 183px;
            position: absolute; top: 60px">
            <asp:ListItem>cccccc</asp:ListItem>
            <asp:ListItem>bbbbb</asp:ListItem>
            <asp:ListItem>aaaaa</asp:ListItem>
        </asp:CheckBoxList>
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" Style="z-index: 107; left: 306px;
            position: absolute; top: 57px">
            <asp:ListItem>aaaa</asp:ListItem>
            <asp:ListItem>bbbbb</asp:ListItem>
            <asp:ListItem>cccc</asp:ListItem>
            <asp:ListItem>dddd</asp:ListItem>
        </asp:RadioButtonList>
        <asp:CheckBox ID="CheckBox3" runat="server" Style="z-index: 108; left: 60px; position: absolute;
            top: 119px" Text="internet" />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Style="z-index: 109;
            left: 68px; position: absolute; top: 177px" Text="Button" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Style="z-index: 110;
            left: 189px; position: absolute; top: 166px" Text="Button" />
        <asp:BulletedList ID="BulletedList1" runat="server" BulletStyle="Circle" Style="z-index: 111;
            left: 387px; position: absolute; top: 181px">
            <asp:ListItem>aaaa</asp:ListItem>
            <asp:ListItem>bbbb</asp:ListItem>
            <asp:ListItem>ccccc</asp:ListItem>
        </asp:BulletedList>
        <asp:SiteMapPath ID="SiteMapPath1" runat="server" Style="z-index: 112; left: 238px;
            position: absolute; top: 27px">
        </asp:SiteMapPath>
        <asp:HiddenField ID="HiddenField1" runat="server" Value="67" />
        
    
    
     </asp:Content>
