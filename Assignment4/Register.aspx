<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
        <tr>
            <td>
                Last Name
            </td>
            <td>
                <asp:TextBox ID="LastNameTB" runat="server" OnTextChanged="LastNameTB_TextChanged"></asp:TextBox>
            </td>
            
            <td>
                <asp:RequiredFieldValidator ID="LastnameValidator" runat="server" ErrorMessage="Last Name is Required" ControlToValidate="LastNameTB"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                First Name
            </td>
            <td>
                <asp:TextBox ID="FirstNameTB" runat="server"></asp:TextBox>
            </td>
            <td>

            </td>
        </tr>
        <tr>
            <td>
                Email
            </td>
            <td>
                <asp:TextBox ID="EmailTB" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="EmailValidator" runat="server" ErrorMessage="Email is Required" ControlToValidate="EmailTB"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="EmailREValidator" runat="server" ErrorMessage="Email is Invalid" ControlToValidate="EmailTB" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td>
                Apartment Number
            </td>
            <td>
                <asp:TextBox ID="ApartmentNumberTB" runat="server"></asp:TextBox>
            </td>
            <td>

            </td>
        </tr>
        <tr>
            <td>
                Street Address
            </td>
            <td>
                <asp:TextBox ID="StreetAddressTB" runat="server"></asp:TextBox>
            </td>
            <td>

            </td>
        </tr>
        <tr>
            <td>
                City
            </td>
            <td>
                <asp:TextBox ID="CityTB" runat="server"></asp:TextBox>
            </td>
            <td>

            </td>
        </tr>
        <tr>
            <td>
                State
            </td>
            <td>
                <asp:TextBox ID="StateTB" runat="server"></asp:TextBox>
            </td>
            <td>

            </td>
        </tr>
        <tr>
            <td>
                Zip Code
            </td>
            <td>
                <asp:TextBox ID="ZipTB" runat="server"></asp:TextBox>
            </td>
            <td>

            </td>
        </tr>
        <tr>
            <td>
                Home Phone
            </td>
            <td>
                <asp:TextBox ID="HomePhoneTB" runat="server"></asp:TextBox>
            </td>
            <td>

            </td>
        </tr>
        <tr>
            <td>
                Work Phone
            </td>
            <td>
                <asp:TextBox ID="WorkPhoneTB" runat="server"></asp:TextBox>
            </td>
            <td>

            </td>
        </tr>
        <tr>
            <td>
                Password
            </td>
            <td>
                <asp:TextBox ID="PasswordTB" runat="server" TextMode="Password"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="PasswordValidator" runat="server" ErrorMessage="Password is Required" ControlToValidate="PasswordTB"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                Confirm Password
            </td>
            <td>
                <asp:TextBox ID="ConfirmPasswordTB" runat="server" TextMode="Password"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="ConfirmPasswordValidator" runat="server" ErrorMessage="Password Confirmation is Required" ControlToValidate="ConfirmPasswordTB">
                </asp:RequiredFieldValidator><asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Passwords Don't Match" ControlToValidate="ConfirmPasswordTB" ControlToCompare="PasswordTB"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="Submit" runat="server" Text="Submit" OnClick="Submit_Click" style="height: 26px" />
            </td>
            <td>
                <asp:Label ID="ResultLabel" runat="server" Text=""></asp:Label>
            </td>
            <td>

            </td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
