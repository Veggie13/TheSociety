<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            font-size: xx-small;
        }
        .style2
        {
            font-size: x-large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <p class="style2">
        <strong>FRONT END SHIPPING Ltd.</strong></p>
    <p style="font-style: italic">
        We address your shipping needs!</p>
    <p>
        Call us at 403-555-SHIP today!</p>
    <p>
        <asp:Image ID="Image1" runat="server" ImageUrl="images/truck1.jpg" />
        <asp:Image ID="Image2" runat="server" ImageUrl="images/truck2.gif" />
    </p>
    <p>
        <asp:Image ID="Image3" runat="server" ImageUrl="images/truck3.jpg" />
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <div class="style1">
    
        Employee Login: 
        <asp:TextBox ID="TextBox1" runat="server" style="font-size: xx-small"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" style="font-size: xx-small"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
            style="font-size: xx-small" Text="Login" />
    
    </div>
    <p>
        &nbsp;</p>
    </form>
</body>
</html>
