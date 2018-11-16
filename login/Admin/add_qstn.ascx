<%@ Control Language="C#" AutoEventWireup="true" CodeFile="add_qstn.ascx.cs" Inherits="Admin_add_qstn" %>
<style type="text/css">
    .style1
    {
        width: 100%;
    }
    .style2
    {
        width: 498px;
    }
    #TextArea1
    {
        height: 80px;
        width: 278px;
    }
</style>

<table class="style1">
    <tr>
        <td class="style2">
            No</td>
        <td>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style2">
            &nbsp;</td>
        <td>
            <asp:TextBox ID="TextBox2" runat="server" Height="91px" TextMode="MultiLine" 
                Width="352px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style2">
            &nbsp;</td>
        <td>
            <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Submit" />
        </td>
    </tr>
</table>

