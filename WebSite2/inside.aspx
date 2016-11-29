<%@ Page Language="C#" AutoEventWireup="true" CodeFile="inside.aspx.cs" Inherits="inside" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="logout.aspx">Logout</asp:HyperLink>
    
    </div>
    <p>
        User:
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
&nbsp;&nbsp; Clearance Level:
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
        THE SOCIETY BACKEND DOCUMENT RETRIEVAL SYSTEM</p>
    <p>
        Document ID Code:
        <form>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="Go" />
        </form>
    </p>
    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
    <br />
    <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
