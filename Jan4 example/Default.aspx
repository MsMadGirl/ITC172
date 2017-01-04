 <%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
        <p><asp:Label ID="lbName" runat="server" Text="Enter your name&nbsp&nbsp"></asp:Label>
        <asp:TextBox ID="tbName" runat="server"></asp:TextBox></p>
        <p><asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" /></p>
        <p><asp:Label ID="lblResult" runat="server" Text=""></asp:Label></p>
    </div>
    </form>
</body>
</html>
