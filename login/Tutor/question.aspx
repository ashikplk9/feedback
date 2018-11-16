<%@ Page Title="" Language="C#" MasterPageFile="~/Tutor/Tutor_MasterPage.master" AutoEventWireup="true" CodeFile="question.aspx.cs" Inherits="Tutor_question" %>

<%@ Register src="question.ascx" tagname="question" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <uc1:question ID="question1" runat="server" />
</asp:Content>

