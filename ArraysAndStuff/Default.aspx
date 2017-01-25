<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Home Calendar</h1>

        <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
        <asp:Label ID="DateLabel" runat="server" Text=""></asp:Label>
        <p><asp:ListBox ID="ListBox1" runat="server" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged"></asp:ListBox></p>
        <asp:CheckBoxList ID="ProduceCheckBoxList" runat="server"></asp:CheckBoxList>
        <asp:Button ID="ProduceButton" runat="server" Text="Total" OnClick="ProduceButton_Click" /><br />
        <asp:Label ID="TotalLabel" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
