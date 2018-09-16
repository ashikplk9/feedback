<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin_MasterPage.master" AutoEventWireup="true" CodeFile="remove_account.aspx.cs" Inherits="Admin_remove_account" %>

<%@ Register src="remove_account.ascx" tagname="remove_account" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <uc1:remove_account ID="remove_account1" runat="server" />
</asp:Content>

