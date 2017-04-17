<%@ Page Language="C#" AutoEventWireup="true" CodeFile="disconnected.aspx.cs" Inherits="disconnected" %>

<%@ Register Assembly="Infragistics2.WebUI.UltraWebGrid.v8.2, Version=8.2.20082.1000, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb"
    Namespace="Infragistics.WebUI.UltraWebGrid" TagPrefix="igtbl" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Connected And Disconnected Demo</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label2" runat="server" Style="z-index: 100; left: 377px; position: absolute;
            top: 202px" Text="Employee Name"></asp:Label>
        <asp:Label ID="Label3" runat="server" Style="z-index: 101; left: 374px; position: absolute;
            top: 150px" Text="Employee Id"></asp:Label>
        <asp:TextBox ID="txteid" runat="server" Style="z-index: 102; left: 501px; position: absolute;
            top: 149px"></asp:TextBox>
        <asp:TextBox ID="txtname" runat="server" Style="z-index: 103; left: 499px; position: absolute;
            top: 199px"></asp:TextBox>
        <asp:Label ID="lblerr" runat="server" Style="z-index: 104; left: 676px; position: absolute;
            top: 361px"></asp:Label>
        <asp:Button ID="cmdinsert" runat="server" OnClick="cmdinsert_Click" Style="z-index: 105;
            left: 374px; position: absolute; top: 255px" Text="Insert" />
        <asp:GridView ID="GridView1" runat="server" Style="z-index: 106; left: 409px; position: absolute;
            top: 413px">
        </asp:GridView>
        <asp:GridView ID="GridView2" runat="server" AllowPaging="True" AutoGenerateColumns="False"
            DataKeyNames="eid" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="GridView2_SelectedIndexChanged"
            Style="z-index: 107; left: 605px; position: absolute; top: 409px">
            <Columns>
                <asp:BoundField DataField="eid" HeaderText="eid" ReadOnly="True" SortExpression="eid" />
                <asp:BoundField DataField="ename" HeaderText="ename" SortExpression="ename" />
                <asp:BoundField DataField="sal" HeaderText="sal" SortExpression="sal" />
                <asp:BoundField DataField="doj" HeaderText="doj" SortExpression="doj" />
                <asp:CommandField ShowEditButton="True" />
                <asp:CommandField ShowDeleteButton="True" />
                <asp:CommandField ShowSelectButton="True" />
                <asp:TemplateField>
                    <EditItemTemplate>
                        <asp:CheckBox ID="CheckBox1" runat="server" />
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:CheckBox ID="CheckBox1" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:masterConnectionString %>"
            DeleteCommand="DELETE FROM [mytable2] WHERE [eid] = @eid" InsertCommand="INSERT INTO [mytable2] ([eid], [ename], [sal], [doj]) VALUES (@eid, @ename, @sal, @doj)"
            SelectCommand="SELECT * FROM [mytable2]" UpdateCommand="UPDATE [mytable2] SET [ename] = @ename, [sal] = @sal, [doj] = @doj WHERE [eid] = @eid">
            <DeleteParameters>
                <asp:Parameter Name="eid" Type="String" />
            </DeleteParameters>
            <UpdateParameters>
                <asp:Parameter Name="ename" Type="String" />
                <asp:Parameter Name="sal" Type="Int32" />
                <asp:Parameter Name="doj" Type="DateTime" />
                <asp:Parameter Name="eid" Type="String" />
            </UpdateParameters>
            <InsertParameters>
                <asp:Parameter Name="eid" Type="String" />
                <asp:Parameter Name="ename" Type="String" />
                <asp:Parameter Name="sal" Type="Int32" />
                <asp:Parameter Name="doj" Type="DateTime" />
            </InsertParameters>
        </asp:SqlDataSource>
        <asp:Button ID="cmddel" runat="server" OnClick="cmddel_Click" Style="z-index: 108;
            left: 444px; position: absolute; top: 257px" Text="Delete" />
        <asp:Button ID="cmdupdate" runat="server" OnClick="cmdupdate_Click" Style="z-index: 109;
            left: 534px; position: absolute; top: 256px" Text="Update" />
        <asp:Button ID="cmdshow" runat="server" OnClick="cmdshow_Click" Style="z-index: 110;
            left: 617px; position: absolute; top: 252px" Text="Show" Width="61px" />
        <asp:Button ID="cmdgrid" runat="server" OnClick="cmdgrid_Click" Style="z-index: 111;
            left: 448px; position: absolute; top: 304px" Text="ShowInGridView" />
        <igtbl:UltraWebGrid ID="UltraWebGrid1" runat="server" Height="200px" Style="z-index: 112;
            left: 19px; position: absolute; top: 134px" Width="325px">
            <Bands>
                <igtbl:UltraGridBand AllowAdd="Yes" AllowColSizing="Free" AllowDelete="Yes" AllowRowNumbering="Continuous"
                    AllowUpdate="Yes" ColHeadersVisible="Yes" Expandable="Yes" SelectTypeCell="Extended"
                    SelectTypeCol="Extended" SelectTypeRow="Single">
                    <SelectedRowStyle BackColor="#00C000" BorderColor="Green" />
                    <EditCellStyle BackColor="#E0E0E0" BorderColor="#FFC0C0" BorderStyle="Double">
                        <BorderDetails ColorBottom="255, 128, 128" ColorLeft="Red" ColorRight="192, 0, 0"
                            ColorTop="Maroon" />
                    </EditCellStyle>
                    <AddNewRow View="NotSet" Visible="NotSet">
                    </AddNewRow>
                    <FilterOptions AllowRowFiltering="OnClient" ApplyOnAdd="True">
                        <FilterRowStyle BackColor="Red" BorderColor="Maroon" BorderStyle="Groove">
                        </FilterRowStyle>
                    </FilterOptions>
                    <SelectedHeaderStyle BackColor="Blue" BorderColor="#804000">
                    </SelectedHeaderStyle>
                </igtbl:UltraGridBand>
            </Bands>
            <DisplayLayout AllowAddNewDefault="Yes" AllowColSizingDefault="Free" AllowColumnMovingDefault="OnServer"
                AllowDeleteDefault="Yes" AllowSortingDefault="OnClient" AllowUpdateDefault="Yes"
                BorderCollapseDefault="Separate" HeaderClickActionDefault="SortMulti" Name="UltraWebGrid1"
                RowHeightDefault="20px" RowSelectorsDefault="No" SelectTypeRowDefault="Extended"
                StationaryMargins="Header" StationaryMarginsOutlookGroupBy="True" TableLayout="Fixed"
                Version="4.00" ViewType="OutlookGroupBy">
                <GroupByBox>
                    <BoxStyle BackColor="ActiveBorder" BorderColor="Window">
                    </BoxStyle>
                </GroupByBox>
                <GroupByRowStyleDefault BackColor="Control" BorderColor="Window">
                </GroupByRowStyleDefault>
                <ActivationObject BorderColor="" BorderWidth="">
                </ActivationObject>
                <FooterStyleDefault BackColor="LightGray" BorderStyle="Solid" BorderWidth="1px">
                    <BorderDetails ColorLeft="White" ColorTop="White" WidthLeft="1px" WidthTop="1px" />
                </FooterStyleDefault>
                <RowStyleDefault BackColor="Window" BorderColor="Silver" BorderStyle="Solid" BorderWidth="1px"
                    Font-Names="Microsoft Sans Serif" Font-Size="8.25pt">
                    <BorderDetails ColorLeft="Window" ColorTop="Window" />
                    <Padding Left="3px" />
                </RowStyleDefault>
                <FilterOptionsDefault>
                    <FilterOperandDropDownStyle BackColor="White" BorderColor="Silver" BorderStyle="Solid"
                        BorderWidth="1px" CustomRules="overflow:auto;" Font-Names="Verdana,Arial,Helvetica,sans-serif"
                        Font-Size="11px">
                        <Padding Left="2px" />
                    </FilterOperandDropDownStyle>
                    <FilterHighlightRowStyle BackColor="#151C55" ForeColor="White">
                    </FilterHighlightRowStyle>
                    <FilterDropDownStyle BackColor="White" BorderColor="Silver" BorderStyle="Solid" BorderWidth="1px"
                        CustomRules="overflow:auto;" Font-Names="Verdana,Arial,Helvetica,sans-serif"
                        Font-Size="11px" Height="300px" Width="200px">
                        <Padding Left="2px" />
                    </FilterDropDownStyle>
                </FilterOptionsDefault>
                <HeaderStyleDefault BackColor="LightGray" BorderStyle="Solid" HorizontalAlign="Left">
                    <BorderDetails ColorLeft="White" ColorTop="White" WidthLeft="1px" WidthTop="1px" />
                </HeaderStyleDefault>
                <EditCellStyleDefault BorderStyle="None" BorderWidth="0px">
                </EditCellStyleDefault>
                <FrameStyle BackColor="Window" BorderColor="InactiveCaption" BorderStyle="Solid"
                    BorderWidth="1px" Font-Names="Microsoft Sans Serif" Font-Size="8.25pt" Height="200px"
                    Width="325px">
                </FrameStyle>
                <Pager MinimumPagesForDisplay="2">
                    <PagerStyle BackColor="LightGray" BorderStyle="Solid" BorderWidth="1px">
                        <BorderDetails ColorLeft="White" ColorTop="White" WidthLeft="1px" WidthTop="1px" />
                    </PagerStyle>
                </Pager>
                <AddNewBox Hidden="False">
                    <BoxStyle BackColor="Window" BorderColor="InactiveCaption" BorderStyle="Solid" BorderWidth="1px">
                        <BorderDetails ColorLeft="White" ColorTop="White" WidthLeft="1px" WidthTop="1px" />
                    </BoxStyle>
                </AddNewBox>
            </DisplayLayout>
        </igtbl:UltraWebGrid>
        &nbsp;&nbsp;
    
    </div>
    </form>
</body>
</html>
