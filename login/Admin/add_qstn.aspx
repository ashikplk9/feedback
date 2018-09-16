<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin_MasterPage.master" AutoEventWireup="true" CodeFile="add_qstn.aspx.cs" Inherits="Admin_add_qstn" %>

<%@ Register src="add_qstn.ascx" tagname="add_qstn" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <uc1:add_qstn ID="add_qstn1" runat="server" />
</asp:Content>

