<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body bgcolor="lightgrey">
    <form id="form1" runat="server">
    <div>
        <asp:Panel ID="pnl2" runat="server" BackColor="#8080FF" BorderColor="Gray" BorderStyle="Solid"
            Height="155px" Style="z-index: 100; left: 32px; position: absolute; top: 51px"
            Width="933px" BackImageUrl="~/image/background1.png">
            <asp:Label ID="Label1" runat="server" BackColor="#C00000" BorderColor="Fuchsia" BorderStyle="None"
                Font-Size="Large" Style="z-index: 100; left: 73px; position: absolute; top: 23px"
                Text="Select Author" Width="113px" Font-Bold="True" ForeColor="Silver"></asp:Label>
            <asp:DropDownList ID="ddl" runat="server" AutoPostBack="True" BackColor="#C00000"
                Font-Bold="True" Font-Overline="True" Font-Strikeout="False" Font-Underline="True"
                ForeColor="Silver" Height="36px" Style="z-index: 101; left: 235px; position: absolute;
                top: 21px; font-weight: bolder; text-transform: capitalize; cursor: hand; text-decoration: none;" OnSelectedIndexChanged="ddl_SelectedIndexChanged">
                <asp:ListItem Selected="True">SelectName</asp:ListItem>
            </asp:DropDownList>
            <asp:Button ID="btnupdate" runat="server" BackColor="#0000C0" BorderColor="Fuchsia"
                Style="z-index: 102; left: 441px; position: absolute; top: 20px; font-weight: bolder; background-image: url(image/background.jpg);" Text="Update" ForeColor="Silver" OnClick="btnupdate_Click" />
            <asp:Button ID="btndelete" runat="server" BackColor="#0000C0" BorderColor="Fuchsia"
                Style="z-index: 103; left: 509px; position: absolute; top: 20px; font-weight: bolder; background-image: url(image/background.jpg);" Text="Delete"
                Width="63px" ForeColor="Silver" OnClick="btndelete_Click" />
            <asp:Label ID="Label2" runat="server" BackColor="#FFC0C0" BorderColor="Fuchsia" ForeColor="Red"
                Style="z-index: 104; left: 73px; position: absolute; top: 94px" Text="OR"></asp:Label>
            <asp:Button ID="btncreate" runat="server" BackColor="#0000C0" BorderColor="Fuchsia"
                Style="z-index: 105; left: 223px; position: absolute; top: 94px; font-weight: bolder; background-image: url(image/background.jpg);" Text="Create New" ForeColor="Silver" OnClick="btncreate_Click" />
            <asp:Button ID="btninsert" runat="server" BackColor="#0000C0" BorderColor="Fuchsia"
                Style="z-index: 106; left: 339px; position: absolute; top: 94px; font-weight: bolder; background-image: url(image/background.jpg);" Text="Insert New" ForeColor="Silver" OnClick="btninsert_Click" />
            <asp:Image ID="Image1" runat="server" ImageUrl="~/image/nextdown.jpg" Style="z-index: 107;
                left: 197px; position: absolute; top: 21px" />
            <asp:Image ID="Image3" runat="server" Height="53px" Style="z-index: 108; left: 144px;
                position: absolute; top: 228px" />
            <asp:Image ID="Image5" runat="server" Height="1px" ImageUrl="~/image/topGradRepeat.jpg"
                Style="z-index: 110; left: 73px; position: absolute; top: 66px" Width="720px" />
        </asp:Panel>
        &nbsp;
        <asp:Image ID="Image4" runat="server" Height="0px" ImageUrl="~/image/topGradRepeat.jpg"
            Style="z-index: 105; left: 108px; position: absolute; top: 111px" Width="693px" />
        <asp:Panel ID="pnl3" runat="server" BackColor="#C04000" BorderColor="Gray" BorderStyle="Solid"
            Height="326px" Style="z-index: 102; left: 31px; position: absolute; top: 233px"
            Width="932px">
            <asp:Panel ID="pnl4" runat="server" BackColor="#E0E0E0" BorderColor="#FF80FF" BorderStyle="Double"
                Height="77px" Style="z-index: 100; left: 423px; position: absolute; top: 196px"
                Width="492px">
                <asp:Label ID="lblinfo" runat="server" BorderColor="#404040" BorderStyle="Double"
                    Height="65px" Style="z-index: 100; left: 2px; position: absolute; top: 2px" Width="480px" BackColor="LemonChiffon"></asp:Label>
            </asp:Panel>
            <asp:Label ID="Label3" runat="server" Style="z-index: 101; left: 51px; position: absolute;
                top: 42px" Text="Unique ID:" BackColor="#C00000" BorderColor="Violet" BorderStyle="None" Font-Size="Medium" Height="20px" Width="76px" Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Underline="True" ForeColor="Silver"></asp:Label>
            <asp:Label ID="Label4" runat="server" Style="z-index: 102; left: 51px; position: absolute;
                top: 72px" Text="First Name:" BackColor="#C00000" BorderColor="Fuchsia" BorderStyle="None" Font-Size="Medium" Height="20px" Width="82px" Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Underline="True" ForeColor="Silver"></asp:Label>
            <asp:Label ID="Label5" runat="server" Style="z-index: 103; left: 51px; position: absolute;
                top: 102px" Text="Last Name:" BackColor="#C00000" BorderColor="Fuchsia" BorderStyle="None" Font-Size="Medium" Height="20px" Width="82px" Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Underline="True" ForeColor="Silver"></asp:Label>
            <asp:Label ID="Label6" runat="server" Style="z-index: 104; left: 51px; position: absolute;
                top: 132px" Text="Phone:" BackColor="#C00000" BorderColor="Fuchsia" BorderStyle="None" Font-Size="Medium" Height="20px" Width="43px" Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Underline="True" ForeColor="Silver"></asp:Label>
            <asp:Label ID="Label7" runat="server" Style="z-index: 105; left: 51px; position: absolute;
                top: 162px" Text="Address:" BackColor="#C00000" BorderColor="Fuchsia" BorderStyle="None" Font-Size="Medium" Height="20px" Width="56px" Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Underline="True" ForeColor="Silver"></asp:Label>
            <asp:Label ID="Label8" runat="server" Style="z-index: 106; left: 51px; position: absolute;
                top: 192px" Text="City:" BackColor="#C00000" BorderColor="Fuchsia" BorderStyle="None" Font-Size="Medium" Height="20px" Width="30px" Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Underline="True" ForeColor="Silver"></asp:Label>
            <asp:Label ID="Label9" runat="server" Style="z-index: 107; left: 51px; position: absolute;
                top: 222px" Text="State:" BackColor="#C00000" BorderColor="Fuchsia" BorderStyle="None" Font-Size="Medium" Height="20px" Width="36px" Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Underline="True" ForeColor="Silver"></asp:Label>
            <asp:Label ID="Label10" runat="server" Style="z-index: 108; left: 51px; position: absolute;
                top: 254px" Text="Zip Code:" BackColor="#C00000" BorderColor="Fuchsia" BorderStyle="None" Font-Size="Medium" Height="20px" Width="73px" Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Underline="True" ForeColor="Silver"></asp:Label>
            <asp:TextBox ID="txtid" runat="server" BackColor="#E0E0E0" BorderColor="Fuchsia"
                Font-Size="Large" ForeColor="Navy" Style="z-index: 109; left: 208px; position: absolute;
                top: 41px"></asp:TextBox>
            <asp:TextBox ID="txtfname" runat="server" BackColor="#E0E0E0" BorderColor="Fuchsia"
                Font-Size="Large" Style="z-index: 110; left: 208px; position: absolute; top: 71px"></asp:TextBox>
            <asp:TextBox ID="txtlname" runat="server" BackColor="#E0E0E0" BorderColor="Fuchsia"
                Font-Size="Large" Style="z-index: 111; left: 208px; position: absolute; top: 101px"></asp:TextBox>
            <asp:TextBox ID="txtphone" runat="server" BackColor="#E0E0E0" BorderColor="Fuchsia"
                Font-Size="Large" Style="z-index: 112; left: 208px; position: absolute; top: 131px"></asp:TextBox>
            <asp:TextBox ID="txtaddress" runat="server" BackColor="#E0E0E0" BorderColor="Fuchsia"
                Font-Size="Large" Style="z-index: 113; left: 208px; position: absolute; top: 161px"></asp:TextBox>
            <asp:TextBox ID="txtcity" runat="server" BackColor="#E0E0E0" BorderColor="Fuchsia"
                Font-Size="Large" Style="z-index: 114; left: 208px; position: absolute; top: 191px"></asp:TextBox>
            <asp:TextBox ID="txtstate" runat="server" BackColor="#E0E0E0" BorderColor="Fuchsia"
                Font-Size="Large" Style="z-index: 115; left: 208px; position: absolute; top: 221px"></asp:TextBox>
            <asp:TextBox ID="txtzip" runat="server" BackColor="#E0E0E0" BorderColor="Fuchsia"
                Font-Size="Large" Style="z-index: 116; left: 208px; position: absolute; top: 253px"></asp:TextBox>
            <asp:Button ID="btnfirst" runat="server" Style="z-index: 117; left: 207px; position: absolute;
                top: 299px; font-weight: bolder; background-image: url(image/background.jpg); font-family: Arial, 'Arial Black', 'Arial Narrow';" Text="First" Width="45px" BackColor="Navy" BorderColor="Fuchsia" ForeColor="Silver" Height="24px" OnClick="btnfirst_Click" />
            <asp:Button ID="btnlast" runat="server" Style="z-index: 118; left: 368px; position: absolute;
                top: 299px; font-weight: bolder; background-attachment: scroll; background-image: url(image/background.jpg); background-repeat: repeat-y;" Text="Last" Width="48px" BackColor="#0000C0" BorderColor="#C000C0" ForeColor="Silver" Height="25px" />
            <asp:Button ID="btnprev" runat="server" Style="z-index: 119; left: 299px; position: absolute;
                top: 299px; font-weight: bolder; background-image: url(image/background.jpg);" Text="Previous" Width="68px" BackColor="#0000C0" BorderColor="#C000C0" ForeColor="Silver" Height="24px" />
            <asp:Button ID="btnnxt" runat="server" Style="z-index: 121; left: 254px; position: absolute;
                top: 300px; font-weight: bolder; background-image: url(image/background.jpg); cursor: auto; font-family: Sylfaen, Tahoma;" Text="Next" Width="43px" BackColor="#0000C0" BorderColor="Fuchsia" ForeColor="Silver" Height="24px" OnClick="btnnxt_Click" />
        </asp:Panel>
        <asp:Image ID="Image2" runat="server" Height="232px" ImageUrl="~/image/topGradRepeat.jpg"
            Style="z-index: 103; left: 190px; position: absolute; top: 280px" Width="1px" />
        <asp:Panel ID="pnl1" runat="server" BackColor="Silver" BorderColor="#FFC0FF" BorderStyle="Inset"
            Height="24px" Style="z-index: 104; left: 88px; position: absolute; top: 5px"
            Width="758px">
            <marquee behaviour = "alternate" > <font color= "maroon"> MY WEBSITE</font> </marquee>
           
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
