<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default3.aspx.cs" Inherits="Default3" StylesheetTheme="SkinFile" Theme="SkinFile" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:FileUpload ID="FileUpload1" runat="server" Style="z-index: 100; left: 70px;
            position: absolute; top: 94px" />
        <asp:SiteMapPath ID="SiteMapPath1" runat="server" Style="z-index: 101; left: 139px;
            position: absolute; top: 29px">
        </asp:SiteMapPath>
        &nbsp;
        <asp:Wizard ID="Wizard1" runat="server" ActiveStepIndex="1" Height="81px" OnFinishButtonClick="Wizard1_FinishButtonClick"
            Style="z-index: 102; left: 352px; position: absolute; top: 35px" Width="170px" BackColor="#FFFBD6" BorderColor="#FFDFAD" BorderWidth="1px" DisplaySideBar="False" Font-Names="Verdana" Font-Size="0.8em">
            <WizardSteps>
                <asp:WizardStep runat="server" StepType="Start" Title="start">
                </asp:WizardStep>
                <asp:WizardStep runat="server" Title="eneter name">
                    <asp:TextBox ID="TextBox1" runat="server" Style="z-index: 100; left: 223px; position: absolute;
                        top: 65px" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
                </asp:WizardStep>
                <asp:WizardStep runat="server" AllowReturn="False" Title="enter adress">
                    <asp:TextBox ID="TextBox2" runat="server" Style="z-index: 100; left: 211px; position: absolute;
                        top: 73px"></asp:TextBox>
                </asp:WizardStep>
                <asp:WizardStep runat="server" AllowReturn="False" Title="enter contactno">
                    <asp:TextBox ID="TextBox3" runat="server" Style="z-index: 100; left: 221px; position: absolute;
                        top: 97px"></asp:TextBox>
                </asp:WizardStep>
                <asp:WizardStep runat="server" AllowReturn="False" StepType="Finish" Title=" finish ">
                </asp:WizardStep>
                <asp:WizardStep runat="server" StepType="Complete" Title="complete">
                    <asp:Label ID="Label1" runat="server" Style="z-index: 100; left: 149px; position: absolute;
                        top: 52px" Text="U have successfully entered ur details"></asp:Label>
                    <asp:Label ID="Label2" runat="server" Style="z-index: 102; left: 178px; position: absolute;
                        top: 97px" Text="Label"></asp:Label>
                </asp:WizardStep>
            </WizardSteps>
            <SideBarStyle BackColor="#990000" Font-Size="0.9em" VerticalAlign="Top" />
            <NavigationButtonStyle BackColor="White" BorderColor="#CC9966" BorderStyle="Solid"
                BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#990000" />
            <SideBarTemplate>
                <asp:DataList ID="SideBarList" runat="server" Height="42px" Width="68px">
                    <SelectedItemStyle Font-Bold="True" />
                    <ItemTemplate>
                        <asp:LinkButton ID="SideBarButton" runat="server"></asp:LinkButton>
                    </ItemTemplate>
                </asp:DataList>
            </SideBarTemplate>
            <SideBarButtonStyle ForeColor="White" />
            <HeaderStyle BackColor="#FFCC66" BorderColor="#FFFBD6" BorderStyle="Solid" BorderWidth="2px"
                Font-Bold="True" Font-Size="0.9em" ForeColor="#333333" HorizontalAlign="Center" />
            <FinishNavigationTemplate>
                <asp:Button ID="FinishPreviousButton" runat="server" CausesValidation="False" CommandName="MovePrevious"
                    Text="Previous" />
                <asp:Button ID="FinishButton" runat="server" CommandName="MoveComplete" Text="Finish" />
            </FinishNavigationTemplate>
            <HeaderTemplate>
                errerere
            </HeaderTemplate>
        </asp:Wizard>
        &nbsp; &nbsp;
        <asp:Wizard ID="Wizard2" runat="server" Style="z-index: 103; left: -28px; position: absolute;
            top: 0px">
            <WizardSteps>
                <asp:WizardStep runat="server" Title="Step 1">
                </asp:WizardStep>
                <asp:WizardStep runat="server" Title="Step 2">
                </asp:WizardStep>
            </WizardSteps>
        </asp:Wizard>
        
        <asp:TextBox ID="TextBox5" runat="server" Style="z-index: 104; left: 50px; position: absolute;
            top: 259px"></asp:TextBox>
        <asp:TextBox ID="TextBox11" runat="server" Style="z-index: 110; left: 5px; position: absolute;
            top: 136px"></asp:TextBox>
        <asp:TextBox ID="TextBox10" runat="server" Style="z-index: 106; left: 60px; position: absolute;
            top: 403px"></asp:TextBox>
        <asp:TextBox ID="TextBox6" runat="server" Style="z-index: 107; left: 409px; position: absolute;
            top: 337px"></asp:TextBox>
        
        <asp:Panel ID="Panel1" runat="server" BackColor="#00C000" BorderColor="Red" Height="65px"
            Style="z-index: 108; left: 510px; position: absolute; top: 217px" Width="164px">
            &nbsp;
                <asp:TextBox ID="TextBox4" runat="server" Style="z-index: 100; left: 0px; position: absolute;
             top: 298px"></asp:TextBox>
                <asp:Label ID="Label3" runat="server" Style="z-index: 101; left: 111px; position: absolute;
            top: 283px" Text="hello" Width="110px"></asp:Label>
            <asp:TextBox ID="TextBox7" runat="server" Style="z-index: 102; left: -238px; position: absolute;
                top: -29px"></asp:TextBox>
            <asp:TextBox ID="TextBox8" runat="server" Style="z-index: 104; left: -231px; position: absolute;
                top: 15px"></asp:TextBox>
        </asp:Panel>
        <asp:Panel ID="Panel2" runat="server" BackColor="#FFFF80" Height="157px" Style="z-index: 109;
            left: 108px; position: absolute; top: 174px" Width="316px">
            <asp:TextBox ID="TextBox9" runat="server" Style="z-index: 100; left: 45px; position: absolute;
                top: 26px"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Style="z-index: 102;
            left: 78px; position: absolute; top: 75px" Text="Upload File" />
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
