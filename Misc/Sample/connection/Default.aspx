<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblroll" runat="server" Height="19px" Style="z-index: 100; left: 10px;
            position: absolute; top: 66px" Text="Enter Your RollNumber"></asp:Label>
        <asp:TextBox ID="txtname" runat="server" Style="z-index: 101; left: 172px; position: absolute;
            top: 119px"></asp:TextBox>
        <asp:TextBox ID="txtaddress" runat="server" OnTextChanged="TextBox2_TextChanged"
            Style="z-index: 102; left: 172px; position: absolute; top: 183px"></asp:TextBox>
        <asp:Label ID="lblinfo" runat="server" Height="42px" Style="z-index: 103; left: 142px;
            position: absolute; top: 370px" Width="575px"></asp:Label>
        &nbsp;
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" Height="10px" Style="z-index: 104;
            left: 141px; position: absolute; top: 299px" />
        <asp:TextBox ID="txtdispname" runat="server" Style="z-index: 105; left: 332px; position: absolute;
            top: 92px"></asp:TextBox>
        <asp:TextBox ID="txtdispadd" runat="server" Style="z-index: 106; left: 332px; position: absolute;
            top: 149px"></asp:TextBox>
        <asp:Label ID="lblname" runat="server" Height="19px" Style="z-index: 107; left: 10px;
            position: absolute; top: 118px" Text="Enter Your Name"></asp:Label>
        <asp:Label ID="lbladdress" runat="server" Style="z-index: 108; left: 10px; position: absolute;
            top: 183px" Text="Enter Your Address"></asp:Label>
        <asp:TextBox ID="txtroll" runat="server" Style="z-index: 109; left: 172px; position: absolute;
            top: 64px"></asp:TextBox>
        &nbsp;
        <asp:DropDownList ID="ddlroll" runat="server" Style="z-index: 110; left: 388px;
            position: absolute; top: 66px" AutoPostBack="True" OnSelectedIndexChanged="ddlroll_SelectedIndexChanged">
        </asp:DropDownList>
        <asp:Button ID="btnupdate" runat="server" OnClick="btnupdate_Click" Style="z-index: 111;
            left: 220px; position: absolute; top: 250px" Text="Update" Height="29px" />
        <asp:Button ID="btndel" runat="server" OnClick="btndel_Click" Style="z-index: 112;
            left: 296px; position: absolute; top: 252px" Text="Delete" Height="25px" Width="56px" />
        <asp:Button ID="btnshow" runat="server" OnClick="btnshow_Click" Style="z-index: 120;
            left: 373px; position: absolute; top: 252px" Text="Show" />
        <asp:Label ID="lbl1" runat="server" Style="z-index: 114; left: 496px; position: absolute;
            top: 92px" Width="176px"></asp:Label>
        <asp:Label ID="lbl2" runat="server" Style="z-index: 115; left: 496px; position: absolute;
            top: 153px" Width="174px"></asp:Label>
        <asp:Button ID="btninsert" runat="server" OnClick="btninsert_Click" Style="z-index: 116;
            left: 144px; position: absolute; top: 249px" Text="Insert" Height="28px" Width="62px" />
        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtroll"
            ErrorMessage="RangeValidator" MaximumValue="100" MinimumValue="1" SetFocusOnError="True"
            Style="z-index: 117; left: 346px; position: absolute; top: 64px" Type="Integer">*</asp:RangeValidator>
        <asp:Label ID="Label1" runat="server" Style="z-index: 118; left: 29px; position: absolute;
            top: 18px" Text="Label" Width="81px"></asp:Label>
        &nbsp;
        <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
            Style="z-index: 119; left: 516px; position: absolute; top: 235px">
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
