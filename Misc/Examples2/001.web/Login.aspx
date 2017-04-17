<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="_Default" Title="Untitled Page" Theme="SkinFile" StylesheetTheme="SkinFile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    &nbsp;
    <asp:Panel ID="Panel1" runat="server" Height="241px" Style="z-index: 100; left: 581px;
        position: absolute; top: 228px" Width="327px" BorderColor="Silver" BorderStyle="Groove">
    <asp:Label ID="Label1" runat="server" Style="z-index: 100; left: 12px; position: absolute;
        top: 68px" Text="User Name" Width="109px" BackColor="White" BorderColor="Silver" BorderStyle="Groove" Font-Bold="True" Font-Names="Bookman Old Style" Font-Size="Large"></asp:Label>
        &nbsp;
        <asp:TextBox ID="txtlname" runat="server" Style="z-index: 101; left: 154px; position: absolute;
            top: 72px"></asp:TextBox>
        <asp:TextBox ID="txtpwd" runat="server" Style="z-index: 102; left: 155px; position: absolute;
            top: 120px" TextMode="Password"></asp:TextBox>
        <asp:Button ID="cmdlbtn" runat="server" Font-Bold="True" Font-Names="Book Antiqua"
            OnClick="cmdlbtn_Click" Style="z-index: 103; left: 165px; position: absolute;
            top: 161px" Text="Login" />
        <asp:Label ID="lblerr" runat="server" Style="z-index: 104; left: 80px; position: absolute;
            top: 194px"></asp:Label>
        &nbsp;
        <asp:Label ID="Label2" runat="server" Style="z-index: 105; left: 14px; position: absolute;
            top: 112px" Text="Pasword" BackColor="White" BorderColor="#E0E0E0" BorderStyle="Groove" Font-Bold="True" Font-Names="Bookman Old Style"></asp:Label>
        <asp:Label ID="Label3" runat="server" BackColor="#C0C000" Font-Bold="True" Font-Names="Book Antiqua"
            Style="z-index: 106; left: 0px; position: absolute; top: 0px" Text="Enter User Name And Password To Login"
            Width="328px" Height="31px"></asp:Label>
        &nbsp;
    </asp:Panel>
    &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
    <a href="App_Themes/SkinFile/SkinFile.skin"></a>
</asp:Content>

