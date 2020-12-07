<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="crimereportingsystem.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>LOGIN</h1>
                    
              
        <asp:TextBox ID="txtusername" runat="server"></asp:TextBox><br /><br />
        <asp:TextBox ID="txtpassword" runat="server"></asp:TextBox><br /><br />
        <asp:Button ID="btnlogin" runat="server" Text="Login" OnClick="Button1_Click" />
        <asp:Button ID="btncancel" runat="server" Text="Cancel" OnClick="Button2_Click"/>
            
    
    </div>
    </form>
        
</body>
</html>
