<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WebUserControl1.ascx.cs" Inherits="projectCompany.WebUserControl1" %>
<table style="width: 100%">
        <tr>
            <td style="text-align: center; width: 289px; height: 29px;">
                <asp:Label ID="Label1" runat="server" ForeColor="Black" Text="User name"></asp:Label>
            </td>
            <td style="text-align: left; ">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="RequiredFieldValidator" ForeColor="Red">please enter name</asp:RequiredFieldValidator>
                <br />
                <br />
            </td>
        </tr>
        <tr>
            <td style="text-align: center; width: 289px;">
                <asp:Label ID="Label2" runat="server" ForeColor="Black" Text="Passowrd"></asp:Label>
            </td>
            <td style="text-align: left">
                <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
                <br />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="RequiredFieldValidator" ForeColor="#FF3300">please enter password</asp:RequiredFieldValidator>
                <br />
                <br />
            </td>
        </tr>
        <tr>
            <td colspan="2" style="text-align: center">
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" />
                <br />
                <br />
                <br />
                <br />
                <br />
            </td>
        </tr>
        <tr>
            <td colspan="2" style="text-align: center">
                <asp:Label ID="Label3" runat="server" ForeColor="Red" Text="Error please enter a vaild content" Visible="False"></asp:Label>
            </td>
        </tr>
    </table>

