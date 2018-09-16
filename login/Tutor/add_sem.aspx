<%@ Page Title="" Language="C#" MasterPageFile="~/Tutor/Tutor_MasterPage.master" AutoEventWireup="true" CodeFile="add_sem.aspx.cs" Inherits="Tutor_add_sem" %>

<%@ Register src="add_sem.ascx" tagname="add_sem" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <uc1:add_sem ID="add_sem1" runat="server" />
</asp:Content>

