<%@ Control Language="C#" AutoEventWireup="true" CodeFile="update_profile.ascx.cs" Inherits="Admin_update_profile" %>
<style type="text/css">
    .style1
    {
        width: 74%;
    }
</style>

<table class="style1">
    <tr>
        <td>
            Account ID</td>
        <td>
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
                onselectedindexchanged="DropDownList1_SelectedIndexChanged">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td>
            Staff Name</td>
        <td>
            <asp:TextBox ID="TextBox1" runat="server" Enabled="False"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            Department ID</td>
        <td>
            <asp:TextBox ID="TextBox2" runat="server" Enabled="False"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            Designation</td>
        <td>
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" 
                RepeatDirection="Horizontal">
                <asp:ListItem>Tutor</asp:ListItem>
                <asp:ListItem>HOD</asp:ListItem>
            </asp:RadioButtonList>
        </td>
    </tr>
    <tr>
        <td>
            Email</td>
        <td>
            <asp:TextBox ID="TextBox3" runat="server" Enabled="False"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            Phone</td>
        <td>
            <asp:TextBox ID="TextBox4" runat="server" Enabled="False"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Update" />
        </td>
    </tr>
</table>

