<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ContactDetails.aspx.cs" Inherits="SampleWebApp.ContactDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="First name :"></asp:Label>
            <asp:Label ID="lblFirstname" runat="server"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Last name :"></asp:Label>
            <asp:Label ID="lblLastname" runat="server"></asp:Label>
            <br />
            Email&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :<asp:Label ID="lblEmail" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
