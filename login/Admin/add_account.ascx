<%@ Control Language="C#" AutoEventWireup="true" CodeFile="add_account.ascx.cs" Inherits="Admin_add_account" %>
<style type="text/css">
    .style1
    {
        width: 70%;
    }
    .style2
    {
        text-align: center;
    }
    .style3
    {
        width: 353px;
    }
    .style4
    {
        width: 353px;
        height: 23px;
    }
    .style5
    {
        height: 23px;
    }
</style>

<table  class="style1">
    <tr>
        <td class="style2" colspan="2">
            Account Information</td>
    </tr>
    <tr>
        <td align="center" class="style3">
            Account ID</td>
        <td>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td align="center" class="style3">
            Staff Name</td>
        <td>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td align="center" class="style3">
            Designation</td>
        <td>
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>HOD</asp:ListItem>
                <asp:ListItem>Tutor</asp:ListItem>
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td align="center" class="style3">
            Department ID</td>
        <td>
            <asp:DropDownList ID="DropDownList2" runat="server">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td align="center" class="style4">
            Email</td>
        <td align="center" class="style5">
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td align="center" class="style4">
            Phone</td>
        <td align="center" class="style5">
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style3">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td align="center" class="style3">
            <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                Text="Register" />
        </td>
        <td align="center">
            <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="Reset" />
        </td>
    </tr>
</table>

