<%@ Page Title="" Language="C#" MasterPageFile="~/WebMasterForms/Master.Master" AutoEventWireup="true" CodeBehind="ArtistDetail.aspx.cs" Inherits="KPopZtation.Views.Admin.ArtistDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Artist Detail</h1>
    <asp:GridView ID="artistGridView" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="ArtistId" HeaderText="ID" SortExpression="ArtistId" />
            <asp:ImageField DataImageUrlField="ArtistImage" HeaderText="Image">
            </asp:ImageField>
            <asp:BoundField DataField="ArtistName" HeaderText="Name" SortExpression="ArtistName" />
        </Columns>
    </asp:GridView>

    <h2>List of Albums</h2>
    <asp:GridView ID="AlbumGridView" runat="server" AutoGenerateColumns="False" OnRowDeleting="AlbumGridView_RowDeleting" OnRowEditing="AlbumGridView_RowEditing" OnSelectedIndexChanging="AlbumGridView_SelectedIndexChanging">
        <Columns>
            <asp:BoundField DataField="AlbumId" HeaderText="ID" SortExpression="AlbumId" />
            <asp:ImageField DataImageUrlField="AlbumImage" HeaderText="Image">
            </asp:ImageField>
            <asp:BoundField DataField="AlbumName" HeaderText="Name" SortExpression="AlbumName" />
            <asp:BoundField DataField="AlbumDescription" HeaderText="Description" SortExpression="AlbumDescription" />
            <asp:BoundField DataField="AlbumStock" HeaderText="Stock" SortExpression="AlbumStock" />
            <asp:BoundField DataField="AlbumPrice" HeaderText="Price" SortExpression="AlbumPrice" />
            <asp:CommandField ButtonType="Button" HeaderText="Actions" ShowCancelButton="False" ShowDeleteButton="True" ShowEditButton="True" ShowHeader="True" ShowSelectButton="True" />
        </Columns>
    </asp:GridView>
    <asp:Button id="InsertAlbumBtn" runat="server" Text="Insert" OnClick="InsertAlbumBtn_Click" />
</asp:Content>
