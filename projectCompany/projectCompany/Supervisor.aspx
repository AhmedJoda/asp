<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Supervisor.aspx.cs" Inherits="projectCompany.Supervisor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width: 100%">
    <tr>
        <td colspan="2">
            <asp:Label ID="Label3" runat="server" ForeColor="White" Text="Reports"></asp:Label>
        &nbsp;
            <br />
            <br />
            <asp:TextBox ID="TextBox4" runat="server" Height="66px" Width="497px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button10" runat="server" Text="Send Report" OnClick="Button10_Click" />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </td>
    </tr>
    <tr>
        <td style="height: 231px; width: 468px;">
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label6" runat="server" ForeColor="White" Text="Employees"></asp:Label>
            <br />
            <asp:GridView ID="GridView4" runat="server" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource1" ForeColor="White" HorizontalAlign="Center">
                <Columns>
                    <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                    <asp:BoundField DataField="username" HeaderText="username" SortExpression="username" />
                    <asp:BoundField DataField="salary" HeaderText="salary" SortExpression="salary" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:companyConnectionString5 %>" SelectCommand="SELECT * FROM [employees]"></asp:SqlDataSource>
            <br />
            <br />
            <br />
        </td>
        <td style="height: 231px">
            <asp:Label ID="Label4" runat="server" ForeColor="White" Text="ID"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
&nbsp;
            <asp:Button ID="Button9" runat="server" Text="Delete" OnClick="Button9_Click" />
            <br />
            <br />
&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button8" runat="server" Text="Update" OnClick="Button8_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <asp:Label ID="Label7" runat="server" Text="new salary"></asp:Label>
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
&nbsp; &nbsp;
            <asp:Button ID="Button7" runat="server" OnClick="Button1_Click" Text="Insert" Height="23px" />
            <asp:Label ID="Label12" runat="server" Text="user name"></asp:Label>
            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
&nbsp;
            <asp:Label ID="Label13" runat="server" Text="salary"></asp:Label>
            <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
            <br />
        </td>
    </tr>
    <tr>
        <td style="height: 202px; width: 468px;">
            <asp:Label ID="Label8" runat="server" ForeColor="White" Text="Cusromers"></asp:Label>
            <asp:GridView ID="GridView5" runat="server" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource2" ForeColor="White">
                <Columns>
                    <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                    <asp:BoundField DataField="username" HeaderText="username" SortExpression="username" />
                    <asp:BoundField DataField="address" HeaderText="address" SortExpression="address" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:companyConnectionString7 %>" SelectCommand="SELECT * FROM [customers]"></asp:SqlDataSource>
        </td>
        <td style="height: 202px">
            <asp:Label ID="Label9" runat="server" Text="ID"></asp:Label>
            <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="Button11" runat="server" OnClick="Button11_Click" Text="Delete" />
            <br />
            <br />
            <asp:Label ID="Label10" runat="server" Text="USer name"></asp:Label>
            <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
&nbsp;<asp:Label ID="Label11" runat="server" Text="Address"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button12" runat="server" OnClick="Button12_Click" Text="Insert" />
        </td>
    </tr>
    </table>
</asp:Content>
