<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ContactForm.aspx.cs" Inherits="SampleWebApp.ContactForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Firstname:"></asp:Label>
            <asp:TextBox ID="txtFirstname" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Lastname :"></asp:Label>
            <asp:TextBox ID="txtLastname" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Email:"></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" Text="Ok" />
        </div>
    </form>
</body>
</html>
