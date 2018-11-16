<%@ Page Title="" Language="C#" MasterPageFile="~/Tutor/Tutor_MasterPage.master" AutoEventWireup="true" CodeFile="feedback.aspx.cs" Inherits="Tutor_feedback" %>

<%@ Register src="feedback.ascx" tagname="feedback" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <uc1:feedback ID="feedback1" runat="server" />
</asp:Content>

