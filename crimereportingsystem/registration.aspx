<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registration.aspx.cs" Inherits="crimereportingsystem.registration" MasterPageFile="~/Site1.Master"%>


        <asp:Content ID="titiksha" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div align="center">
        <table border="0" cellspacing="10px" cellpadding="10px">
            <tr>
                <th>Username:</th>
                <td>
                    <asp:TextBox ID="txtusername" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <th>Fullname:</th>
                <td>
                    <asp:TextBox ID="txtfullname" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
            <th>Phoneno:</th> 
                <td>
                    <asp:TextBox ID="txtphoneno" runat="server"></asp:TextBox></td>            
               
                </tr>
            <tr>
            <th>Address</th>
                <td>
                    <textarea id="TextArea1" cols="20" rows="2" runat="server"></textarea></td>
            </tr>
            <tr>
                <th>EmailID</th>
                <td>
                    <asp:TextBox ID="txtemailid" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <th>Password</th>
                <td>
                    <asp:TextBox ID="txtpassword" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <th>Gender</th>
                <td>
                    <asp:RadioButton ID="rdomale" runat="server" Text="Male" /></td>
                <td>
                    <asp:RadioButton ID="rdofemale" runat="server" Text="Female"/>
                    </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click"/></td>
                <td><asp:Button ID="Button2" runat="server" Text="Cancel" OnClick="Button2_Click"/></td>
            </tr>
        </table>
    </div>
            </asp:Content>
    
