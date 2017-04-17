<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<script language="javascript" type="text/javascript">
function ShowVal(obj)
{
    //window.ModalDialog("New.aspx?"+obj.value,winow,"");
}
</script>
    <asp:GridView ID="GridView1" runat="server" Style="z-index: 100; left: 3px; position: absolute;
        top: 106px" AllowPaging="True"  BorderColor="#C04000" BorderStyle="Groove" Caption="Records from Dictation Details" CaptionAlign="Top" CellPadding="4" Font-Names="Book Antiqua" ForeColor="Blue" Height="306px" Width="400px" AutoGenerateColumns="False" Font-Size="Smaller" OnPageIndexChanging="GridView1_PageIndexChanging" PageSize="5"   DataKeyNames="DD_FILENAME" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <EditRowStyle BackColor="#999999" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <HeaderStyle BackColor="Silver" Font-Bold="True" ForeColor="Red" BorderColor="Maroon" Font-Names="Book Antiqua" />
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>         
        <asp:BoundField DataField="DD_DICTATIONID" HeaderText="DICTATIONID" >
            <ItemStyle Font-Size="Small" />
           
        </asp:BoundField>
        <asp:BoundField DataField="DD_TRANSCRIPTID" HeaderText="TRANSCRIPTID" >
            <ItemStyle Font-Size="Small" />
        </asp:BoundField>
            <asp:TemplateField HeaderText="FILE NAME" ShowHeader="False" >
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="false" CommandName="Select"
                         Text='<%# Eval("DD_FILENAME") %>' ></asp:LinkButton>
                        
                </ItemTemplate>
                <ItemStyle Width="450px" />
            </asp:TemplateField>
            <asp:TemplateField HeaderText="OWNER">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("DD_OWNER") %>' ></asp:TextBox>
                </EditItemTemplate>
                <ItemStyle Font-Size="Small" />
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("DD_OWNER") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
        <asp:BoundField DataField="DD_DICTATIONDATE" HeaderText="DICTATIONDATE" >
            <ItemStyle Font-Size="Small"/>
        </asp:BoundField>
        <asp:BoundField DataField="DD_DOCSTATUS" HeaderText="DOCSTATUS" >
            <ItemStyle Font-Size="Small" />
        </asp:BoundField>
        <asp:BoundField DataField="DD_STAT" HeaderText="STAT" >
            <ItemStyle Font-Size="Small" />
        </asp:BoundField>
        <asp:BoundField DataField="DD_TIMEDUEBACK" HeaderText="TIMEDUEBACK" >
            <ItemStyle Font-Size="Small" />
             </asp:BoundField>
        
       </Columns>
       <SelectedRowStyle BackColor="Control" ForeColor="AliceBlue" Font-Bold="True" /> 
        
    </asp:GridView>
    <asp:Label ID="Label1" runat="server" Style="z-index: 101; left: 415px; position: absolute;
        top: 13px" Text="Label"></asp:Label>
    <asp:Button ID="cmdshow" runat="server" Font-Bold="True" OnClick="cmdshow_Click"
        Style="z-index: 102; left: 265px; position: absolute; top: 10px" Text="Show Records" />
    <asp:GridView ID="GridView2" runat="server" Style="z-index: 104; left: 777px; position: absolute;
        top: 163px" AutoGenerateColumns="False">
        <Columns>
        <asp:BoundField DataField="el_slno" HeaderText="SeriolNo" />
        <asp:BoundField DataField="el_dictationid" HeaderText="DictationId" />
        <asp:BoundField DataField="el_transcriptid" HeaderText="TranscripId" />
        <asp:BoundField DataField="el_actiondate" HeaderText="ActionDate" />
        <asp:BoundField DataField="el_eventid" HeaderText="EventId" />
        <asp:BoundField DataField="el_actorid" HeaderText="ActorId" />
        <asp:BoundField DataField="el_source" HeaderText="Source" />
        <asp:BoundField DataField="el_destination" HeaderText="Destination" />
        
        </Columns>
    </asp:GridView>
</asp:Content>


<%--
 <Columns>
            <asp:BoundField DataField="empid" HeaderText="Employee ID" ReadOnly="True" SortExpression="empid" />
            <asp:BoundField DataField="fname" HeaderText="First Name" SortExpression="fname" />
            <asp:BoundField DataField="lname" HeaderText="Last Name" SortExpression="lname" />
            <asp:BoundField DataField="birthdate" HeaderText="Birthdate" SortExpression="birthdate" />
--%>
