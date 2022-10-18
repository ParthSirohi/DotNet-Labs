<%@ Page MasterPageFile="~/Site.Master"  Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="FirstWebForm.Login" %>


<asp:Content ContentPlaceHolderID="Pages" runat="server">
    <p style="font-family: 'Times New Roman', Times, serif; font-size: 30px; background-color: #FF0000">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; SNEAKER SHOP</p>
    <form id="form1" runat="server" style="background-image: url('Pictures/sneakerBackground.jpg')">
        <div style="background-image: none; font-size: 23px;">
            Q:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            Hello Sneakerhead!&nbsp; How are you?</div>
        ANS:<asp:TextBox ID="Name" runat="server" OnTextChanged="TextBox1_TextChanged" style="margin-left: 50px" Width="142px" TextMode="MultiLine"></asp:TextBox>
    <p style="font-size: 24px">
        Q: What type of sneakers are you interested in?</p>
        <p>
            ANS:
            <asp:CheckBox ID="CheckBox1" runat="server" Font-Size="20pt" Text="High Tops" />
            <asp:CheckBox ID="CheckBox2" runat="server" Font-Size="20pt" Text="Mids" />
            <asp:CheckBox ID="CheckBox3" runat="server" Font-Size="20pt" Text="Lows" />
        </p>
        <p style="font-size: 26px">
            Q: Choose a Color</p>
        <p>
            ANS:
            <asp:CheckBox ID="BlackShoe" runat="server" Font-Size="20pt" Text="Black" />
            <asp:CheckBox ID="RedShoe" runat="server" Font-Size="20pt" Text="Red" />
            <asp:CheckBox ID="BlueShoe" runat="server" Font-Size="20pt" Text="Blue" />
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" BackColor="Red" Font-Bold="True" Height="42px" OnClick="Button1_Click" Text="Get my Recommendation" Width="183px" />
&nbsp;</p>
        <p>
            <asp:Button ID="Button2" runat="server" BackColor="#FF3300" OnClick="Button2_Click" Text="I want to Buy!" />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="View Data" />
        </p>
        <p>
            <asp:Image ID="blackshoepic" runat="server" ImageUrl="~/Pictures/blackHigh.jpg" Visible="False" />
        </p>
        <p>
            <asp:Image ID="redshoepic" runat="server" ImageUrl="~/Pictures/RedHigh.jpg" Visible="False" />
        </p>
        <p>
            <asp:Image ID="blueshoepic" runat="server" ImageUrl="~/Pictures/BlueHigh.jpg" Visible="False" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
    </asp:Content>
