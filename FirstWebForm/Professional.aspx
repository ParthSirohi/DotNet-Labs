<%@ Page MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="Professional.aspx.cs" Inherits="FirstWebForm.Professional" %>



<asp:Content ContentPlaceHolderID="Pages" runat="server">
    <form runat="server">
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
        <h2>This is a content page</h2>
    <p>Add New Employee</p>   
        <asp:TextBox ID="TextName" runat="server" Width="190px" placeholder="Enter Name "></asp:TextBox>
        <asp:TextBox ID="TextDesg" runat="server" Width="190px" placeholder="Enter Designation"></asp:TextBox>
        <asp:TextBox ID="TextSalary" runat="server" width="190px" placeholder="Enter Salary"></asp:TextBox>
        <br />
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextName" ErrorMessage="EmpName is Mandatory"></asp:RegularExpressionValidator>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Add Employee" OnClick="Button1_Click" />
        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextSalary" ErrorMessage="Invalid Range" MaximumValue="99999999" MinimumValue="300000" SetFocusOnError="True"></asp:RangeValidator>
        <br />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextSalary" ErrorMessage="Salary Cannot be Empty" Font-Bold="True" Font-Size="X-Large" ForeColor="#CC3300"></asp:RequiredFieldValidator>
        <asp:ValidationSummary ID="ValidationSummary2" runat="server" />
    <h3>Databinding with Database</h3>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="EmpId" DataSourceID="SqlDataSource1" AllowSorting="True">
        <Columns>
            <asp:CommandField ShowSelectButton="True" />
            <asp:BoundField DataField="EmpId" HeaderText="EmpId" InsertVisible="False" ReadOnly="True" SortExpression="EmpId" />
            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
            <asp:BoundField DataField="Designation" HeaderText="Designation" SortExpression="Designation" />
            <asp:BoundField DataField="Salary" HeaderText="Salary" SortExpression="Salary" />
            <asp:CommandField />
            <asp:CommandField ShowEditButton="True" />
            <asp:CommandField ShowDeleteButton="True" />
        </Columns>
        <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
        <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
        <RowStyle BackColor="White" ForeColor="#330099" />
        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
        <SortedAscendingCellStyle BackColor="#FEFCEB" />
        <SortedAscendingHeaderStyle BackColor="#AF0101" />
        <SortedDescendingCellStyle BackColor="#F6F0C0" />
        <SortedDescendingHeaderStyle BackColor="#7E0000" />
    </asp:GridView>
  <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:KpmgDbConnectionString %>" SelectCommand="SELECT * FROM [Employees]" DeleteCommand="DELETE FROM [Employees] WHERE [EmpId] = @EmpId" InsertCommand="INSERT INTO [Employees] ([Name], [Designation], [Salary]) VALUES (@Name, @Designation, @Salary)" UpdateCommand="UPDATE [Employees] SET [Name] = @Name, [Designation] = @Designation, [Salary] = @Salary WHERE [EmpId] = @EmpId">
      <DeleteParameters>
          <asp:Parameter Name="EmpId" Type="Int32" />
      </DeleteParameters>
      <InsertParameters>
          <asp:Parameter Name="Name" Type="String" />
          <asp:Parameter Name="Designation" Type="String" />
          <asp:Parameter Name="Salary" Type="Double" />
      </InsertParameters>
      <UpdateParameters>
          <asp:Parameter Name="Name" Type="String" />
          <asp:Parameter Name="Designation" Type="String" />
          <asp:Parameter Name="Salary" Type="Double" />
          <asp:Parameter Name="EmpId" Type="Int32" />
      </UpdateParameters>
        </asp:SqlDataSource>
</form>
</asp:Content>


