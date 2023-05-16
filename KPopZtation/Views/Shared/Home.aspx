<%@ Page Title="" Language="C#" MasterPageFile="~/WebMasterForms/Master.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="KPopZtation.Views.Shared.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Welcome to Home!</h1>
    <main>
        <asp:GridView ID="artistGridView" runat="server" AutoGenerateColumns="False" OnRowDeleting="artistGridView_RowDeleting" OnRowEditing="artistGridView_RowEditing">
            <Columns>
                <asp:ImageField DataImageUrlField="ArtistImage" HeaderText="Artist's Image">
                </asp:ImageField>
                <asp:BoundField DataField="ArtistName" HeaderText="Artist's Name" />
                <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="Artist's Detail" ShowHeader="True" Text="See More" />
                <asp:CommandField ButtonType="Button" HeaderText="Actions" ShowDeleteButton="True" ShowEditButton="True" ShowHeader="True" />
            </Columns>
    </asp:GridView>
    </main>
</asp:Content>
