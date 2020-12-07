<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="complaintpage.aspx.cs" Inherits="crimereportingsystem.complaintpage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblfullname" runat="server" Text="Fullname"></asp:Label>
        <asp:TextBox ID="txtfullname" runat="server"  Enabled="false"></asp:TextBox><br /><br />
        <asp:Label ID="lblphoneno" runat="server" Text="Phoneno"></asp:Label>
        <asp:TextBox ID="txtphoneno" runat="server" Enabled="false"></asp:TextBox><br /><br />
        <asp:Label ID="lbladdress" runat="server" Text="Address"></asp:Label>
        <asp:TextBox ID="txtaddress" runat="server" Enabled="false"></asp:TextBox><br /><br />
        <asp:Label ID="lblcomplaintfor" runat="server" Text="Complaint For"></asp:Label>
        <asp:TextBox ID="txtcomplaintfor" runat="server"></asp:TextBox><br /><br />
        <asp:Label ID="lblcomplaintreason" runat="server" Text="Complaint Reason"></asp:Label>
        <asp:TextBox ID="txtcomplaintreason" runat="server"></asp:TextBox><br /><br />
        <asp:Label ID="lbldate" runat="server" Text="Date"></asp:Label>
        <asp:TextBox ID="txtdate" runat="server" ></asp:TextBox>
        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar><br />

        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click"/>
        <asp:Button ID="Button2" runat="server" Text="Cancel" OnClick="Button2_Click"/>

    
    </div>
    </form>
</body>
</html>
