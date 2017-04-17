<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lbl1" runat="server" Style="z-index: 100; left: 96px; position: absolute;
            top: 276px" Text="Your Name"></asp:Label>
        <asp:Label ID="lbl2" runat="server" Style="z-index: 101; left: 93px; position: absolute;
            top: 313px" Text="Your Message"></asp:Label>
        <asp:Button ID="btnsubmit" runat="server" Style="z-index: 102; left: 233px; position: absolute;
            top: 514px" Text="Submit" OnClick="btnsubmit_Click" />
        &nbsp; &nbsp;
        <asp:GridView ID="guestbooklist" runat="server" Style="z-index: 103; left: 2px; position: absolute;
            top: -58px" AutoGenerateColumns="False" Height="22px" Width="200px">
            <Columns>
                <asp:TemplateField HeaderText="Guest Book Comment">
                    <HeaderStyle BackColor="#FF8080" />
                    <ItemTemplate>
                    Left By:
                    <%# Eval("Author") %>
                    <br />
                    <b><%#Eval("Message") %></b>
                    <br />
                    Left On:
                    <%# Eval("Submitted") %>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <asp:TextBox ID="txtname" runat="server" Style="z-index: 104; left: 232px; position: absolute;
            top: 273px" Width="338px"></asp:TextBox>
        <asp:TextBox ID="txtmessage" runat="server" Height="191px" Style="z-index: 105; left: 231px;
            position: absolute; top: 310px" Width="341px"></asp:TextBox>
        <asp:Label ID="lblerr" runat="server" Height="51px" Style="z-index: 107; left: 263px;
            position: absolute; top: 77px" Width="281px"></asp:Label>
        &nbsp; &nbsp;
    
    </div>
    </form>
</body>
</html>
