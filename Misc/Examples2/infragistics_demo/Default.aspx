 <%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Assembly="Infragistics2.WebUI.Misc.v8.2, Version=8.2.20082.1000, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb"
    Namespace="Infragistics.WebUI.Misc" TagPrefix="igmisc" %>
<%@ Register Assembly="Infragistics2.WebUI.UltraWebCalcManager.v8.2, Version=8.2.20082.1000, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb"
    Namespace="Infragistics.WebUI.UltraWebCalcManager" TagPrefix="igcalc" %>
<%@ Register Assembly="Infragistics2.WebUI.UltraWebNavigator.v8.2, Version=8.2.20082.1000, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb"
    Namespace="Infragistics.WebUI.UltraWebNavigator" TagPrefix="ignav" %>

<%@ Register Assembly="Infragistics2.WebUI.UltraWebGrid.v8.2, Version=8.2.20082.1000, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb"
    Namespace="Infragistics.WebUI.UltraWebGrid" TagPrefix="igtbl" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
    <tr>
    <td style="width: 389px; height: 344px" >
        &nbsp;&nbsp;
        <igmisc:WebPageStyler ID="WebPageStyler1" runat="server" Style="z-index: 101; left: 0px;
            position: absolute; top: 0px" StyleSetName="" />
        <igcalc:UltraWebCalcManager ID="UltraWebCalcManager1" runat="server">
        </igcalc:UltraWebCalcManager>
        <ignav:UltraWebMenu ID="UltraWebMenu1" runat="server" BackColor="#F0F0F0" BorderColor="#F0F0F0"
            BorderStyle="Outset" BorderWidth="2px" FileUrl="" Font-Names="Microsoft Sans Serif"
            Font-Size="9pt" JavaScriptFilename="" JavaScriptFileNameCommon="" LeafItemImageUrl=""
            ParentItemImageUrl="" Style="z-index: 102; left: 243px; position: absolute; top: 379px"
            StyleSetName="" TargetFrame="" TargetUrl="" TopItemSpacing="Compact"><Styles>
<ignav:Style BorderStyle="Outset" Cursor="Default" CssClass="TopHover4" BorderWidth="1px"></ignav:Style>
<ignav:Style BorderStyle="Solid" CssClass="TopClass4" BorderWidth="1px" BorderColor="#F0F0F0"></ignav:Style>
</Styles>

<ItemStyle BorderStyle="Solid" BorderWidth="1px" BorderColor="#F0F0F0"></ItemStyle>

<Images>

</Images>

<IslandStyle BorderStyle="Outset" Cursor="Default" ForeColor="Black" BorderWidth="1px" BorderColor="Black" BackColor="#F0F0F0" Font-Size="8pt" Font-Names="MS Sans Serif"></IslandStyle>

<HoverItemStyle BorderStyle="Solid" Cursor="Default" ForeColor="White" BorderWidth="1px" BorderColor="Gray" BackColor="DarkBlue"></HoverItemStyle>

<DisabledStyle ForeColor="LightGray"></DisabledStyle>

<SeparatorStyle CustomRules="background-repeat:repeat-x; " BackgroundImage=""></SeparatorStyle>

<ExpandEffects Type="Slide" ShadowColor="DarkGray"></ExpandEffects>
            <MenuClientSideEvents InitializeMenu="" ItemChecked="" ItemClick="" ItemHover=""
                SubMenuDisplay="" />
</ignav:UltraWebMenu>
        </td>
        <td style="width: 273px; height: 344px">
            <asp:Label ID="Label1" runat="server" Style="z-index: 100; left: 115px; position: absolute;
                top: 109px" Text="Hi This Is Utra Web Grid Control" Font-Bold="True" ForeColor="Red" Width="236px"></asp:Label>
        </td>
        </tr>
        
        </table>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:testConnectionString %>"
            SelectCommand="SELECT * FROM [emp]"></asp:SqlDataSource>
        <igmisc:WebAsyncRefreshPanel ID="WebAsyncRefreshPanel1" runat="server" BackColor="#FFC0C0"
            BorderColor="Red" BorderStyle="Solid" Height="141px" Style="z-index: 100; left: 23px;
            position: absolute; top: 424px" Width="280px">
            kukyjkjyk</igmisc:WebAsyncRefreshPanel>
        <igmisc:WebPanel ID="WebPanel1" runat="server" BackColor="White" Height="372px" Style="z-index: 102;
            left: 424px; position: absolute; top: 20px" Width="439px">
            <PanelStyle BorderStyle="Solid" BorderWidth="1px">
                <BorderDetails ColorBottom="0, 45, 150" ColorLeft="158, 190, 245" ColorRight="0, 45, 150"
                    ColorTop="0, 45, 150" />
                <Padding Bottom="5px" Left="5px" Right="5px" Top="5px" />
            </PanelStyle>
            <Header Text="Web Grid" TextAlignment="Left">
                <ExpandedAppearance>
                    <Styles BackgroundImage="" BorderStyle="Solid" BorderWidth="1px"
                        Font-Names="Times New Roman" Font-Size="9pt">
                        <BorderDetails ColorLeft="158, 190, 245" ColorRight="0, 45, 150" ColorTop="158, 190, 245"
                            WidthBottom="0px" />
                        <Padding Bottom="1px" Left="4px" Top="1px" />
                    </Styles>
                </ExpandedAppearance>
                <ExpansionIndicator Height="0px" Width="0px" />
            </Header>
            <Template>
        <igtbl:UltraWebGrid ID="UltraWebGrid1" runat="server" Browser="Xml" DataSourceID="SqlDataSource1"
            Style="z-index: 100; left: 14px; position: absolute; top: 24px" Height="257px" Width="409px" EnableAppStyling="True" OnInitializeLayout="UltraWebGrid1_InitializeLayout" DisplayLayout-AutoGenerateColumns="false">
            <Bands>
                <igtbl:UltraGridBand>
                    <AddNewRow View="NotSet" Visible="NotSet">
                    </AddNewRow>
                    <Columns>
                        <igtbl:UltraGridColumn BaseColumnName="eid" DataType="System.Decimal" IsBound="True"
                            Key="eid" >
                            <Header Caption="employee Id">
                            </Header>
                        </igtbl:UltraGridColumn>
                        <igtbl:UltraGridColumn BaseColumnName="name" IsBound="True" Key="name">
                            <Header Caption="Employee Name">
                                <RowLayoutColumnInfo OriginX="1" />
                            </Header>
                            <Footer>
                                <RowLayoutColumnInfo OriginX="1" />
                            </Footer>
                        </igtbl:UltraGridColumn>
                        <igtbl:UltraGridColumn>
                            <Header Caption="Emp Address">
                                <RowLayoutColumnInfo OriginX="2" />
                            </Header>
                            <Footer>
                                <RowLayoutColumnInfo OriginX="2" />
                            </Footer>
                        </igtbl:UltraGridColumn>
                    </Columns>
                </igtbl:UltraGridBand>
            </Bands>
            <DisplayLayout AllowAddNewDefault="Yes" AllowDeleteDefault="Yes" AllowSortingDefault="Yes"
                AllowUpdateDefault="Yes" BorderCollapseDefault="Separate" HeaderClickActionDefault="SortMulti"
                LoadOnDemand="Xml" Name="UltraWebGrid1" RowHeightDefault="20px" SelectTypeRowDefault="Single"
                StationaryMargins="Header" StationaryMarginsOutlookGroupBy="True" TableLayout="Fixed"
                Version="4.00">
                <ActivationObject BorderColor="Black" BorderStyle="Solid" BorderWidth="">
                </ActivationObject>
                <RowStyleDefault BackColor="#BCDAE8" BorderColor="Gray" BorderStyle="Solid" BorderWidth="1px">
                    <BorderDetails ColorLeft="188, 218, 232" ColorTop="188, 218, 232" />
                    <Padding Left="3px" />
                </RowStyleDefault>
                <FilterOptionsDefault AllowRowFiltering="OnClient" FilterUIType="HeaderIcons">
                    <FilterOperandDropDownStyle BackColor="White" BorderColor="Silver" BorderStyle="Solid"
                        BorderWidth="1px" CustomRules="overflow:auto;" Font-Names="Verdana,Arial,Helvetica,sans-serif"
                        Font-Size="11px">
                        <Padding Left="2px" />
                    </FilterOperandDropDownStyle>
                    <FilterHighlightRowStyle BackColor="#151C55" ForeColor="White">
                    </FilterHighlightRowStyle>
                    <FilterDropDownStyle BackColor="White" BorderColor="Silver" BorderStyle="Solid" BorderWidth="1px"
                        CustomRules="overflow:auto;" Font-Names="Verdana,Arial,Helvetica,sans-serif"
                        Font-Size="11px" Width="200px">
                        <Padding Left="2px" />
                    </FilterDropDownStyle>
                </FilterOptionsDefault>
                <SelectedRowStyleDefault BackColor="#9BBCCC" ForeColor="White">
                </SelectedRowStyleDefault>
                <HeaderStyleDefault BackColor="#5BA1C2" BorderColor="Black" BorderStyle="Solid" ForeColor="White">
                    <BorderDetails ColorLeft="White" ColorTop="White" WidthLeft="1px" WidthTop="1px" />
                </HeaderStyleDefault>
                <RowAlternateStyleDefault BackColor="#E9E9F7">
                    <BorderDetails ColorLeft="233, 233, 247" ColorTop="233, 233, 247" />
                </RowAlternateStyleDefault>
                <FrameStyle BorderColor="#C00000" BorderStyle="Solid" BorderWidth="3px" Cursor="Default" BackColor="#E0E0E0" Font-Bold="True" Font-Names="Book Antiqua" ForeColor="Blue" Height="257px" Width="409px">
                </FrameStyle>
                <Pager AllowPaging="True">
                </Pager>
                <AddNewBox Hidden="False">
                </AddNewBox>
            </DisplayLayout>
        </igtbl:UltraWebGrid>
            </Template>
        </igmisc:WebPanel>
    
    </div>
    </form>
</body>
</html>
