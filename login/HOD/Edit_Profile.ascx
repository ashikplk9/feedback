<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Edit_Profile.ascx.cs" Inherits="HOD_Edit_Profile" %>
<style type="text/css">
    .style1
    {
        width: 100%;
    }
    .style2
    {
        width: 538px;
    }
    .style3
    {
        width: 538px;
        height: 23px;
    }
    .style4
    {
        height: 23px;
    }
    .style5
    {
        width: 538px;
        height: 26px;
    }
    .style6
    {
        height: 26px;
    }
</style>

<table class="style1">
    <tr>
        <td colspan="2" style="text-align: center">
            Update Profile Details</td>
    </tr>
    <tr>
        <td class="style3">
            Department ID</td>
        <td class="style4">
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style2">
            Account Id</td>
        <td>
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
                onselectedindexchanged="DropDownList1_SelectedIndexChanged">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="style2">
            Name</td>
        <td>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style5">
            Email</td>
        <td class="style6">
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style2">
            Phone 
        </td>
        <td>
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style2">
            Status</td>
        <td>
            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style2">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style2">
           &nbsp;</td>
        <td>
            <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Update" />
        </td>
    </tr>
</table>

