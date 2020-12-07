<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="datagridview.aspx.cs" Inherits="crimereportingsystem.datagridview" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ComplaintNo" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="ComplaintNo" HeaderText="ComplaintNo" InsertVisible="False" ReadOnly="True" SortExpression="ComplaintNo" />
                <asp:BoundField DataField="Date" HeaderText="Date" SortExpression="Date" />
                <asp:BoundField DataField="Fullname" HeaderText="Fullname" SortExpression="Fullname" />
                <asp:BoundField DataField="ComplaintFor" HeaderText="ComplaintFor" SortExpression="ComplaintFor" />
                <asp:BoundField DataField="Reason" HeaderText="Reason" SortExpression="Reason" />
                <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" />
            </Columns>
        </asp:GridView>
    
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:dbtitikshaConnectionString %>" SelectCommand="SELECT tblcomplaint.ComplaintNo, tblcomplaint.Date, tblcrime.Fullname, tblcomplaint.ComplaintFor, tblcomplaint.Reason, tblcrime.Address FROM tblcomplaint INNER JOIN tblcrime ON tblcomplaint.ID = tblcrime.Id"></asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
