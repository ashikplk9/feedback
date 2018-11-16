<%@ Control Language="C#" AutoEventWireup="true" CodeFile="remove_dept.ascx.cs" Inherits="Admin_remove_dept" %>
<style type="text/css">
    .style1
    {
        width: 58%;
    }
    .style2
    {
        width: 381px;
    }
    .style3
    {
        width: 46%;
        height: 113px;
    }
    .style4
    {
        height: 37px;
    }
</style>

<table class="style1">
    <tr>
        <td class="style2">
            Select Department ID</td>
        <td>
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
                onselectedindexchanged="DropDownList1_SelectedIndexChanged" 
                style="width: 77px">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="style2">
            &nbsp;</td>
        <td>
            <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Remove" />
        </td>
    </tr>
</table>
<div id="div1">
</div>

<asp:Panel ID="Panel1" runat="server" Height="127px" Visible="False" 
    Width="874px">
    <table class="style3">
        <tr>
            <td class="style4">
                Course</td>
            <td class="style4">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Stream</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                No of sem</td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
        </tr>
    </table>
</asp:Panel>


