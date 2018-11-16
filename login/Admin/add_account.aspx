<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin_MasterPage.master" AutoEventWireup="true" CodeFile="add_account.aspx.cs" Inherits="Admin_add_account" %>

<%@ Register src="add_account.ascx" tagname="add_account" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <uc1:add_account ID="add_account1" runat="server" />
</asp:Content>

