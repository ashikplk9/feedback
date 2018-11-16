<%@ Control Language="C#" AutoEventWireup="true" CodeFile="add_sem.ascx.cs" Inherits="Tutor_add_sem" %>
<style type="text/css">
    .style1
    {
        width: 83%;
    }
    .style2
    {
        width: 443px;
    }
    .style3
    {
        width: 443px;
        height: 23px;
    }
    .style4
    {
        height: 23px;
    }
    .style5
    {
        width: 100%;
    }
    .style6
    {
        width: 447px;
    }
</style>

<table class="style1">
    <tr>
        <td colspan="2" style="text-align: center">
            Add Details</td>
    </tr>
    <tr>
        <td class="style2">
            Course</td>
        <td>
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
                onselectedindexchanged="DropDownList1_SelectedIndexChanged">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="style2">
            Branch</td>
        <td>
            <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" 
                onselectedindexchanged="DropDownList2_SelectedIndexChanged">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="style2">
            No of sems</td>
        <td>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style3">
            Department Id</td>
        <td class="style4">
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
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
            <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                Text="Add Subjects" />
        </td>
    </tr>
</table>
<asp:Panel ID="Panel1" runat="server" Height="174px" Visible="False" 
    Width="889px">
    <table class="style5">
        <tr>
            <td class="style6">
                Sem No</td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style6">
                Subject Code</td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style6">
                Subject</td>
            <td>
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style6">
                <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="Submit" />
            </td>
            <td>
                <asp:Button ID="Button3" runat="server" onclick="Button3_Click" Text="Save" />
            </td>
        </tr>
    </table>
</asp:Panel>

