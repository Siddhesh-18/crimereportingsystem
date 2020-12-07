<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adminlogin.aspx.cs" Inherits="crimereportingsystem.adminlogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblusername" runat="server" Text="Username"></asp:Label>
        <asp:TextBox ID="txtusername" runat="server"></asp:TextBox>
        <asp:Label ID="lblpassword" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="txtpassword" runat="server"></asp:TextBox>
        <asp:Button ID="btnlogin" runat="server" Text="Login" OnClick="btnlogin_Click"/>
        <asp:Button ID="btncancel" runat="server" Text="Cancel" OnClick="btncancel_Click"/>
    </div>
    </form>
</body>
</html>
