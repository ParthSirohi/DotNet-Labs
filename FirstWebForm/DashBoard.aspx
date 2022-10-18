<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DashBoard.aspx.cs" Inherits="FirstWebForm.DashBoard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <p>
            <asp:Button ID="Button2" runat="server" Text="Button" />
            <asp:Button ID="Button3" runat="server" Text="View Cookie Data" />
        </p>
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True">
        </asp:DropDownList>
        <asp:ListBox ID="ListBox1" runat="server" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged">
            <asp:ListItem Value="01">Item 1</asp:ListItem>
            <asp:ListItem Value="02">Item 2</asp:ListItem>
        </asp:ListBox>
        <asp:ListBox ID="ListBox2" runat="server"></asp:ListBox>
        <p>
            <asp:Label ID="lblSelected" runat="server" Text="Label"></asp:Label>
        </p>
    </form>
</body>
</html>
