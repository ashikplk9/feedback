<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin_MasterPage.master" AutoEventWireup="true" CodeFile="add_dept.aspx.cs" Inherits="Admin_add_dept" %>

<%@ Register src="add_dept.ascx" tagname="add_dept" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <uc1:add_dept ID="add_dept1" runat="server" />
</asp:Content>

