<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="testpage.aspx.cs" Inherits="testpage" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
        Style="z-index: 100; left: 360px; position: absolute; top: 168px">
    </asp:GridView>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Style="z-index: 102;
        left: 381px; position: absolute; top: 92px" Text="Button" />
</asp:Content>

