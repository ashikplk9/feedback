<%@ Control Language="C#" AutoEventWireup="true" CodeFile="mapping.ascx.cs" Inherits="HOD_mapping" %>
<style type="text/css">
    .style1
    {
        width: 100%;
    }
    .style2
    {
        width: 332px;
    }
    .style3
    {
        width: 299px;
    }
</style>

<table class="style1">
    <tr>
        <td class="style2">
            &nbsp;</td>
        <td class="style3">
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style2">
            Course</td>
        <td class="style3">
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style2">
            Stream</td>
        <td class="style3">
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style2">
            Sem</td>
        <td class="style3">
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
                onselectedindexchanged="DropDownList1_SelectedIndexChanged">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="style2">
            Subject</td>
        <td class="style3">
            <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" 
                onselectedindexchanged="DropDownList2_SelectedIndexChanged">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="style2">
            Teacher ID</td>
        <td class="style3">
            <asp:DropDownList ID="DropDownList3" runat="server" AutoPostBack="True" 
                onselectedindexchanged="DropDownList3_SelectedIndexChanged">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="style2">
            Teacher Name</td>
        <td class="style3">
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style2">
            &nbsp;</td>
        <td class="style3">
            <asp:Button ID="Button1" runat="server" Text="Save" onclick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
                Text="Genarate PDF" />
        </td>
    </tr>
</table>

