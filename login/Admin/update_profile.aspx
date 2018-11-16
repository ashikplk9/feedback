<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin_MasterPage.master" AutoEventWireup="true" CodeFile="update_profile.aspx.cs" Inherits="Admin_update_profile" %>

<%@ Register src="update_profile.ascx" tagname="update_profile" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <uc1:update_profile ID="update_profile1" runat="server" />
</asp:Content>

