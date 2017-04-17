<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN" "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server" />
        
        <div>
            &nbsp;<cc1:SliderExtender ID="SliderExtender1"  BehaviorID="txtSlider"
             BoundControlID="txtSlider_Bound" TargetControlID="txtSlider"
              Minimum="0" Maximum="10" Steps="10"  runat="server">
            </cc1:SliderExtender>
        
        </div>
        <asp:TextBox ID = "txtSlider" runat ="server" style="left: 168px; position: relative; top: 12px">
        </asp:TextBox>
        <asp:TextBox ID = "txtSlider_bound" runat ="server" style="left: 9px; position: relative; top: 61px" Width="31px"></asp:TextBox>
        
    </form>
</body>
</html>
