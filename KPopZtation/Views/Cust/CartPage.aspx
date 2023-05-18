<%@ Page Title="" Language="C#" MasterPageFile="~/WebMasterForms/Master.Master" AutoEventWireup="true" CodeBehind="CartPage.aspx.cs" Inherits="KPopZtation.Views.Cust.CartPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="cartGridView" runat="server"></asp:GridView>
    <asp:Button ID="checkOutBtn" runat="server" Text="Check Out" />
</asp:Content>
