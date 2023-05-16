<%@ Page Title="" Language="C#" MasterPageFile="~/WebMasterForms/Master.Master" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="KPopZtation.Views.Guest.LogIn" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h1>LogIn</h1>
    </div>
    <div>
        <input id="emailBox" type="text" runat="server" placeholder="email"/>
    </div>
    <div>
        <input id="passwordBox" type="password" runat="server" placeholder="password"/>
    </div>
    <div>
        <asp:CheckBox ID="rememberMe" runat="server" text="Remember Me"/>
    </div>
    <div style="color:red">
        <asp:Label ID="error" runat="server" Text=""></asp:Label>
    </div>
    <div>
        <asp:Button ID="logInButton" runat="server" Text="Log In"  OnClick="logInButton_Click"/>
    </div>
</asp:Content>
