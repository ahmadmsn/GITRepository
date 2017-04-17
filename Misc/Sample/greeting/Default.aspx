<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body text="#0000d">
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" BackColor="Silver" BorderColor="#400000" Style="z-index: 100;
            left: 41px; position: absolute; top: 16px" Text="Choose a Background Colour"></asp:Label>
        <asp:DropDownList ID="backcolor" runat="server" Style="z-index: 101; left: 41px;
            position: absolute; top: 43px">
        </asp:DropDownList>
        <asp:Label ID="Label2" runat="server" BackColor="#FFC0C0" Style="z-index: 102; left: 41px;
            position: absolute; top: 70px" Text="Choose a Font"></asp:Label>
        <asp:DropDownList ID="fontname" runat="server" Style="z-index: 103; left: 41px;
            position: absolute; top: 96px">
        </asp:DropDownList>
        <asp:Label ID="Label3" runat="server" Style="z-index: 104; left: 41px; position: absolute;
            top: 122px" Text="Specify Numeric Font Size:"></asp:Label>
        <asp:TextBox ID="txtfontsize" runat="server" Style="z-index: 105; left: 41px; position: absolute;
            top: 145px" Width="66px"></asp:TextBox>
        &nbsp; &nbsp;
        <asp:Label ID="Label4" runat="server" Style="z-index: 106; left: 41px; position: absolute;
            top: 170px" Text="Choose a Border Style"></asp:Label>
        &nbsp;&nbsp;
        <asp:RadioButtonList ID="borderlistbtn" runat="server" Style="z-index: 107; left: 41px;
            position: absolute; top: 192px" RepeatColumns="2">
        </asp:RadioButtonList>
        &nbsp; &nbsp;
        <asp:CheckBox ID="Chkbox" runat="server" Style="z-index: 109; left: 41px; position: absolute;
            top: 327px" Text="Add The Default Picture" />
        <asp:TextBox ID="msg" runat="server" Height="42px" Style="z-index: 110; left: 41px;
            position: absolute; top: 454px" TextMode="MultiLine" SkinID="aaa"></asp:TextBox>
        &nbsp;
        <asp:Label ID="Label5" runat="server" Style="z-index: 111; left: 41px; position: absolute;
            top: 427px" Text="Enter A Greetings Text Below"></asp:Label>
        <asp:Label ID="Label6" runat="server" Style="z-index: 112; left: 107px; position: absolute;
            top: 350px" Text="OR"></asp:Label>
        <asp:FileUpload ID="FileUpload1" runat="server" Style="z-index: 113; left: 41px;
            position: absolute; top: 373px" />
        <asp:Button ID="cmdupdate" runat="server" Style="z-index: 114; left: 65px; position: absolute;
            top: 509px" Text="Update" OnClick="cmdupdate_Click" />
        <asp:Button ID="cmddownload" runat="server" Style="z-index: 115; left: 52px; position: absolute;
            top: 395px" Text="Download" OnClick="cmddownload_Click" />
        <asp:DropDownList ID="filelst" runat="server" OnSelectedIndexChanged="filelst_SelectedIndexChanged"
            Style="z-index: 116; left: 147px; position: absolute; top: 397px">
            <asp:ListItem Selected="True" Value="-1">Select Picture</asp:ListItem>
        </asp:DropDownList>
        &nbsp;&nbsp;
        <asp:Panel ID="pnl" runat="server" BackColor="#FFC0C0" Height="443px" Style="z-index: 117;
            left: 310px; position: absolute; top: 40px" Width="340px">
            &nbsp;
            <asp:Label ID="lblgreeting" runat="server" Style="z-index: 100; left: 38px; position: absolute;
                top: 29px" Height="80px" Width="248px"></asp:Label>
            <asp:Image ID="Image1" runat="server" Height="241px" ImageUrl="~/image/rani89.jpg" Style="z-index: 102;
                left: 16px; position: absolute; top: 183px" Width="300px" />
        </asp:Panel>
        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtfontsize"
            ErrorMessage="RangeValidator" MaximumValue="50" MinimumValue="10" Style="z-index: 118;
            left: 132px; position: absolute; top: 147px"></asp:RangeValidator>
        <asp:Label ID="mylabl" runat="server" BackColor="Lime" BorderColor="#400040" BorderStyle="Double"
            Style="z-index: 119; left: 369px; position: absolute; top: 5px" Width="127px"></asp:Label>
        
    
    </div>
    </form>
</body>
</html>
