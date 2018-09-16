<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin_MasterPage.master" AutoEventWireup="true" CodeFile="remove_dept.aspx.cs" Inherits="Admin_remove_dept" %>

<%@ Register src="remove_dept.ascx" tagname="remove_dept" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <uc1:remove_dept ID="remove_dept1" runat="server" />
</asp:Content>

