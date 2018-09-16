<%@ Control Language="C#" AutoEventWireup="true" CodeFile="add_dept.ascx.cs" Inherits="Admin_WebUserControl" %>
<script language="javascript" type="text/javascript">
// <![CDATA[

    function Select1_onclick() {

    }

// ]]>
</script>

<style type="text/css">
    .style1
    {
        width: 100%;
    }
    .style2
    {
        width: 427px;
    }
    .style3
    {
        width: 427px;
        height: 26px;
    }
    .style4
    {
        height: 26px;
    }
    #Select1
    {
        width: 123px;
    }
</style>

<table class="style1">
    <tr>
        <td class="style2">
            <asp:Label ID="Label1" runat="server" Text="Department ID"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style2">
            <asp:Label ID="Label2" runat="server" Text="Course"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style3">
            <asp:Label ID="Label3" runat="server" Text="Stream"></asp:Label>
        </td>
        <td class="style4">
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style2">
            <asp:Label ID="Label4" runat="server" Text="No of Sem"></asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="DropDownList1" runat="server" Width="125px">
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
                <asp:ListItem>5</asp:ListItem>
                <asp:ListItem>6</asp:ListItem>
                <asp:ListItem>7</asp:ListItem>
                <asp:ListItem>8</asp:ListItem>
                <asp:ListItem></asp:ListItem>
            </asp:DropDownList>
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

