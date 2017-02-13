<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Donate.aspx.cs" Inherits="Donate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Donate</h1>
        <p>How much do you want to donate?</p>
        <p>
            <asp:TextBox ID="DonateTB" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="DonateButton" runat="server" Text="Button" OnClick="DonateButton_Click" />
        </p>
        <p>
            <asp:Label ID="ErrorLabel" runat="server" Text=""></asp:Label>
        </p>
    </div>
    </form>
</body>
</html>
