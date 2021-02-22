<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Driver.aspx.cs" Inherits="VirtualLab.Driver" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 208px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="font-family:Arial">
                <tr>
                    <td colspan="2"><b>Driver Details Form</b></td>
                </tr>
                <tr>
                    <td>First Name :</td>
                    <td><asp:TextBox ID="txtFirstName" runat="server" Width="248px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Last Name :</td>
                    <td><asp:TextBox ID="txtLastName" runat="server" Width="244px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>City :</td>
                    <td> <asp:DropDownList ID="drpCity" runat="server" OnSelectedIndexChanged="drpCity_SelectedIndexChanged"> </asp:DropDownList></td>
                </tr>
                <tr>
                    <td>Gender :</td>
                    <td>
                       
                        <asp:RadioButtonList ID="rdoGender" runat="server" OnSelectedIndexChanged="rdoGender_SelectedIndexChanged" RepeatDirection="Horizontal">
                            <asp:ListItem Value="M">Male</asp:ListItem>
                            <asp:ListItem Value="F">Female</asp:ListItem>
                            <asp:ListItem Value="U">Unknown</asp:ListItem>
                        </asp:RadioButtonList>
                       
                    </td>
                </tr>
                <tr>
                    <td>Education :</td>
                    <td> <asp:CheckBox ID="chkGraduate" runat="server" Text="Graduate" /><asp:CheckBox ID="chkPostGraduate" runat="server" Text="PostGraduate" /><asp:CheckBox ID="chkDoctorate" runat="server" Text="Doctorate" /></td>
                </tr>
                <tr>
                    <td></td>
                    <td> &nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="btnRegister" runat="server" Text="Register Driver" OnClick="btnRegister_Click" OnClientClick="alert(&quot;You are about to submit this page&quot;)" />

                       &nbsp;&nbsp;&nbsp;
                        <asp:LinkButton ID="lnkDelete" runat="server" OnClick="lnkDelete_Click" OnClientClick="return confirm(&quot;Are you sure you want to delete this record?&quot;)"
                            >Delete</asp:LinkButton>

                    </td>
                </tr>
            </table>
                   
        </div>
    </form>
</body>

</html>
