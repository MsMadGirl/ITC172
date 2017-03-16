<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Login</h1>
    <table>
        <tr>
            <td>User Name</td>
            <td>
                <asp:TextBox ID="UsernameTextBox" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Password</td>
            <td>
                <asp:TextBox ID="PasswordTextBox" runat="server" TextMode="Password"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="LoginButton" runat="server" Text="Log in" OnClick="LoginButton_Click" /></td>
            <td>
                <asp:Label ID="ResultLabel" runat="server" Text=""></asp:Label>
                </td>
        </tr>
    </table>
        <asp:LinkButton ID="RegisterLinkButton" runat="server" PostBackUrl="~/Register.aspx">Register</asp:LinkButton>
        &nbsp; &nbsp;
        <asp:LinkButton ID="ViewGrantsLinkButton" runat="server" PostBackUrl="ViewGrants.aspx">View Your Grants</asp:LinkButton>
    </div>
    </form>
</body>
</html>
