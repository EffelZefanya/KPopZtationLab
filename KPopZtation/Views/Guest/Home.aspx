<%@ Page Title="" Language="C#" MasterPageFile="~/WebMasterForms/Master.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="KPopZtation.Views.Guest.GuestHome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Label ID="name" runat="server" Text="Name"></asp:Label>
    </div>
    <div id="listUserContainer" runat="server">
        <h1>List Users</h1>
        <asp:ListBox ID="listUser" runat="server" Height="300px"></asp:ListBox>
    </div>
    <div>
        <asp:Label ID="userLoggedInCount" runat="server" Text="0 User(s) online"></asp:Label>
    </div>
    <div>
        <asp:Button ID="LogOut" runat="server" Text="Log Out" OnClick="LogOut_Click"/>
    </div>
</asp:Content>
