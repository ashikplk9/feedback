<%@ Control Language="C#" AutoEventWireup="true" CodeFile="WebUserControl.ascx.cs" Inherits="WebUserControl" %>
<style type="text/css">
    .style1
    {
        width: 68%;
    }
    .style2
    {
        width: 342px;
    }
</style>

<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

<table  border="0" cellpadding="2" class="style1" align="center">
    <tr>
        <td>
            &nbsp;<asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>
        </td>
        <td class="style2">
            <asp:TextBox ID="textuser" runat="server" Width="167px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
        </td>
        <td class="style2">
            <asp:TextBox ID="textpass" runat="server" Width="165px" TextMode="Password" ></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Reset" 
                Height="27px" />
        </td>
        <td class="style2">
            <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="Login" 
                style="height: 26px" />
        </td>
    </tr>
</table>

<asp:Label ID="Label3" runat="server" Text="error" Visible="False"></asp:Label>
<asp:Label ID="Label4" runat="server" Text="Admin worked!" Visible="False"></asp:Label>
<asp:Label ID="Label5" runat="server" Text="HOD Worked" Visible="False"></asp:Label>


