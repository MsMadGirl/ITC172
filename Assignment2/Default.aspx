<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home Calendar</title>
    <link rel="stylesheet" type="text/css" href="StyleSheet.css">
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Home Calendar</h1>

        <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
        <asp:Label ID="DateLabel" runat="server" Text=""></asp:Label>
        <p><asp:Button ID="Button1" runat="server" Text="Check Date" OnClick="Button1_Click" /></p>
        <asp:Label ID="EventLabel" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
