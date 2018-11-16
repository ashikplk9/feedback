<%@ Page Title="" Language="C#" MasterPageFile="~/HOD/HOD_MasterPage.master" AutoEventWireup="true" CodeFile="Edit_profile.aspx.cs" Inherits="HOD_Edit_profile" %>

<%@ Register src="Edit_Profile.ascx" tagname="Edit_Profile" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <uc1:Edit_Profile ID="Edit_Profile1" runat="server" />
</asp:Content>

