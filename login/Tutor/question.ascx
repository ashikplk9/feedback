<%@ Control Language="C#" AutoEventWireup="true" CodeFile="question.ascx.cs" Inherits="Tutor_question" %>
<style type="text/css">
    .style1
    {
        width: 100%;
    }
    .style2
    {
        width: 215px;
    }
    .style3
    {
        width: 215px;
        height: 23px;
    }
    .style4
    {
        height: 23px;
    }
</style>

<table class="style1">
    <tr>
        <td class="style3">
            &nbsp;</td>
        <td class="style4">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style3">
        </td>
        <td class="style4">
&nbsp;<asp:Label ID="Label6" runat="server" Text="Month"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;:&nbsp;<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label7" runat="server" Text="Year"></asp:Label>
            &nbsp;:<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="style2">
            &nbsp;Subject: :<asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        </td>
        <td>
            &nbsp;Teacher&nbsp;&nbsp;: 
            <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label8" runat="server" Text="Feedback ID"></asp:Label>
            :<asp:Label ID="Label9" runat="server" Text="Label"></asp:Label>
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
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label5" runat="server"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine" Width="379px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style2">
            &nbsp;</td>
        <td>
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" 
                RepeatDirection="Horizontal" Width="477px">
                <asp:ListItem>Excellent</asp:ListItem>
                <asp:ListItem>Very good</asp:ListItem>
                <asp:ListItem>Good</asp:ListItem>
                <asp:ListItem>Average</asp:ListItem>
                <asp:ListItem>Poor</asp:ListItem>
                <asp:ListItem>Very Poor</asp:ListItem>
            </asp:RadioButtonList>
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
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style2">
            <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                Text="Prevous" />
        </td>
        <td>
            <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="Next" />
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
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style2">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
</table>

