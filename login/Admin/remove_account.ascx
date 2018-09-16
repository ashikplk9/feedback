<%@ Control Language="C#" AutoEventWireup="true" CodeFile="remove_account.ascx.cs" Inherits="Admin_remove_account" %>
<style type="text/css">
    .style1
    {
        width: 37%;
    }
    .style3
    {
        width: 191px;
    }
    .style4
    {
        width: 136px;
    }
    .style5
    {
        width: 100%;
    }
    .style8
    {
        width: 121px;
    }
    .style9
    {
        width: 257px;
    }
    .style10
    {
        width: 53px;
        height: 23px;
    }
    .style11
    {
        width: 257px;
        height: 23px;
    }
    .style12
    {
        width: 53px;
    }
</style>

<table class="style1">
    <tr>
        <td class="style4">
            Account ID</td>
        <td class="style3">
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
                onselectedindexchanged="DropDownList1_SelectedIndexChanged">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="style4">
            &nbsp;</td>
        <td class="style3">
            <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Remove" />
        </td>
    </tr>
</table>
<asp:Panel ID="Panel1" runat="server" Height="168px" Visible="False">
    <table class="style5">
        <tr>
            <td class="style10">
                Name</td>
            <td class="style11">
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style12">
                Designation</td>
            <td class="style9">
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style12">
                Department ID</td>
            <td class="style9">
                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style12">
                Email</td>
            <td class="style9">
                <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style12">
                Phone</td>
            <td class="style9">
                <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
            </td>
        </tr>
    </table>
</asp:Panel>

