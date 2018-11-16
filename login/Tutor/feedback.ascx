<%@ Control Language="C#" AutoEventWireup="true" CodeFile="feedback.ascx.cs" Inherits="Tutor_feedback" %>
<style type="text/css">
    .style1
    {
        width: 100%;
    }
    .style2
    {
        height: 23px;
    }
    .style3
    {
        width: 593px;
    }
    .style4
    {
        height: 23px;
        width: 593px;
    }
    .style5
    {
        width: 593px;
        height: 26px;
    }
    .style6
    {
        height: 26px;
    }
    .style7
    {
        height: 23px;
        width: 591px;
    }
    .style10
    {
        width: 591px;
    }
</style>

<table class="style1">
    <tr>
        <td class="style3">
            &nbsp;</td>
        <td>
            <asp:TextBox ID="TextBox6" runat="server" Enabled="False"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style4">
            Department Id</td>
        <td class="style2">
            <asp:DropDownList ID="DropDownList4" runat="server" AutoPostBack="True" 
                onselectedindexchanged="DropDownList4_SelectedIndexChanged">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="style3">
            Course</td>
        <td>
            <asp:TextBox ID="TextBox1" runat="server" AutoPostBack="True"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style4">
            Branch</td>
        <td class="style2">
            <asp:TextBox ID="TextBox2" runat="server" AutoPostBack="True"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style3">
            Semester</td>
        <td>
            <asp:DropDownList ID="DropDownList5" runat="server" AutoPostBack="True" 
                onselectedindexchanged="DropDownList5_SelectedIndexChanged">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="style5">
            Subject</td>
        <td class="style6">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style5">
            Teacher</td>
        <td class="style6">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style3">
            Date</td>
        <td>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style3">
            &nbsp;</td>
        <td>
            <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="OK" />
        &nbsp;<asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
                Text="DELETE" />
        </td>
    </tr>
</table>

<asp:Panel ID="Panel1" runat="server" Visible="False">
    <table class="style1">
        <tr>
            <td class="style7">
                Subject</td>
            <td class="style2">
                <asp:DropDownList ID="DropDownList3" runat="server" AutoPostBack="True" 
                    onselectedindexchanged="DropDownList3_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="style10">
                Teacher</td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server" ontextchanged="TextBox3_TextChanged"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style10">
                Subject Code</td>
            <td>
                <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style10">
                <asp:Button ID="Button3" runat="server" onclick="Button3_Click" Text="Start" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    <br />
    <br />
    <br />
</asp:Panel>


