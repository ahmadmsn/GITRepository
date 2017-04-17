<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" StylesheetTheme="SkinFile" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body bgcolor="#00cc00" vlink="#ffcc00">
    <form id="form1" runat="server">
    <div>
        &nbsp; &nbsp;
        <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="#3366CC"
            BorderWidth="1px" CellPadding="1" FirstDayOfWeek="Sunday" Font-Names="Verdana"
            Font-Size="8pt" ForeColor="#003399" Height="200px" OnSelectionChanged="Calendar1_SelectionChanged"
            SelectedDate="2008-06-26" Style="z-index: 100; left: 407px; position: absolute;
            top: 337px" Width="220px">
            <SelectedDayStyle BackColor="#009999" BorderStyle="Solid" Font-Bold="True" ForeColor="#CCFF99" />
            <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
            <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
            <DayStyle BackColor="DarkGray" />
            <WeekendDayStyle BackColor="#C04000" />
            <OtherMonthDayStyle ForeColor="#999999" />
            <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
            <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
            <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True"
                Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
        </asp:Calendar>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Style="z-index: 101;
            left: 627px; position: absolute; top: 401px" Text="Show Calender" />
        <asp:Calendar ID="Calendar2" runat="server" BackColor="#FFFFCC" BorderColor="#FFCC66"
            BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt"
            ForeColor="#663399" Height="200px" OnDayRender="Calendar2_DayRender" OnSelectionChanged="Calendar2_SelectionChanged"
            ShowGridLines="True" Style="z-index: 102; left: 404px; position: absolute; top: 131px"
            Width="220px">
            <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
            <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
            <SelectorStyle BackColor="#FFCC66" />
            <OtherMonthDayStyle ForeColor="#CC9966" />
            <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
            <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
            <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
        </asp:Calendar>
        <asp:Wizard ID="Wizard1" runat="server" Style="z-index: 103; left: 12px; position: absolute;
            top: 266px" ActiveStepIndex="0" BackColor="#E6E2D8" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" Height="34px" Width="157px">
            <WizardSteps>
                <asp:WizardStep runat="server" Title="Step 1 colors">
                    &nbsp;
                </asp:WizardStep>
                <asp:WizardStep runat="server" Title="Step 2">
                </asp:WizardStep>
                <asp:WizardStep runat="server">
                </asp:WizardStep>
                <asp:WizardStep runat="server">
                </asp:WizardStep>
            </WizardSteps>
            <StepStyle BackColor="#F7F6F3" BorderColor="#E6E2D8" BorderStyle="Solid" BorderWidth="2px" />
            <SideBarStyle BackColor="#1C5E55" Font-Size="0.9em" VerticalAlign="Top" />
            <NavigationButtonStyle BackColor="White" BorderColor="#C5BBAF" BorderStyle="Solid"
                BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#1C5E55" />
            <SideBarButtonStyle ForeColor="White" />
            <HeaderStyle BackColor="#666666" BorderColor="#E6E2D8" BorderStyle="Solid" BorderWidth="2px"
                Font-Bold="True" Font-Size="0.9em" ForeColor="White" HorizontalAlign="Center" />
            <FinishNavigationTemplate>
                <asp:Button ID="FinishPreviousButton" runat="server" BackColor="White" BorderColor="#C5BBAF"
                    BorderStyle="Solid" BorderWidth="1px" CausesValidation="False" CommandName="MovePrevious"
                    Font-Names="Verdana" Font-Size="0.8em" ForeColor="#1C5E55" Text="Previous" />
                <asp:Button ID="FinishButton" runat="server" BackColor="White" BorderColor="#C5BBAF"
                    BorderStyle="Solid" BorderWidth="1px" CommandName="MoveComplete" Font-Names="Verdana"
                    Font-Size="0.8em" ForeColor="#1C5E55" Text="Finish" />
            </FinishNavigationTemplate>
        </asp:Wizard>
        &nbsp; &nbsp; &nbsp;
        &nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Style="z-index: 104;
            left: 624px; position: absolute; top: 436px" Text="Hide Calender" />
        <asp:TextBox ID="TextBox1" runat="server" Style="z-index: 105; left: 632px; position: absolute;
            top: 371px"></asp:TextBox>
        <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
    
    </div>
        &nbsp;&nbsp;&nbsp;
    </form>
</body>
</html>
