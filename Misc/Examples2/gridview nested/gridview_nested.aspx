<%@ Page Language="C#" AutoEventWireup="true" CodeFile="gridview_nested.aspx.cs" Inherits="gridview_examples_gridview_nested" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="grdV_categories" runat="server" AutoGenerateColumns="False" ShowHeader="False"
            DataKeyNames="categoryid">
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <table border="0" cellpadding="0" cellspacing="0">
                            <tr>
                                <td>
                                    <b>Product list of
                                        <%#DataBinder.Eval(Container.DataItem,"CategoryName") %>
                                        :</b></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:GridView ID="grdV_products" runat="server" AutoGenerateColumns="False" ShowHeader="False">
                                        <Columns>
                                            <asp:TemplateField>
                                                <ItemTemplate>
                                                    <%#DataBinder.Eval(Container.DataItem,"ProductName") %>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                        </Columns>
                                    </asp:GridView>
                                </td>
                            </tr>
                        </table>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    
    </div>
    
    <br />
    <br />
               <div style="margin-top:20px;width:500px;">
                <b>Coding Support Provided By <a href="http://www.top54u.com">www.top54u.com</a><br />
                    <a href="http://programming.top54u.com">Programming Ezine</a></b><br />
                <br />
            </div>
    </form>
</body>
</html>
