<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList ID="DropDownList1" runat="server" Style="z-index: 100; left: 661px;
            position: absolute; top: 64px">
        </asp:DropDownList>
        &nbsp;
        <asp:GridView ID="GridView1" runat="server" Style="left: 48px; position: relative;
            top: 106px" AllowPaging="True" OnPageIndexChanging="GridView1_PageIndexChanging" PageSize="2" AutoGenerateColumns="False">
            <PagerSettings PageButtonCount="5" />
            <Columns>
            <asp:TemplateField HeaderText="SelectItem">
            <ItemTemplate>
            <asp:RadioButton ID="RowSelector"  runat="server" GroupName="a" Text='<%# Eval("empid") %>' />
            </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="empid" HeaderText="EmpId"/>
            <asp:BoundField DataField="empfirstname" HeaderText="FirstName"/>
            <asp:BoundField DataField="empmiddlename" HeaderText="MiddleName"/>
            <asp:BoundField DataField="emplastname" HeaderText="LastName" ApplyFormatInEditMode="True"/>
            <asp:BoundField DataField="empaddress" HeaderText="Address"/>
            <asp:BoundField DataField="empmobno" HeaderText="MobileNo"/>
            <asp:BoundField DataField="empdob" HeaderText="DOB"/>                   
            </Columns>            
        </asp:GridView>
        <asp:Button ID="btnClick" runat="server" OnClick="btnClick_Click" Style="left: 53px;
            position: relative; top: 129px" Text="ClickMe" /></div>
    </form>
</body>
</html>
  <%--<asp:TemplateField HeaderText="SelectOne">
            <ItemTemplate>
            <input name="MyRadioButton" type=radio value='<%# Eval("empid") %>' />
            </ItemTemplate>
            </asp:TemplateField>--%>    
