<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Students.aspx.cs" Inherits="UniversityManagementApp.Students" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="gridstudent" runat="server" OnSelectedIndexChanged="gridstudent_SelectedIndexChanged"></asp:GridView>
</asp:Content>
