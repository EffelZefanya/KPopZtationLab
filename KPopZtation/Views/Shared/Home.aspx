<%@ Page Title="" Language="C#" MasterPageFile="~/WebMasterForms/Master.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="KPopZtation.Views.Shared.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
    <h1>Welcome to Home!</h1>
    <main>
        <%if (userRole == "admin")
            { %>
        <asp:GridView ID="artistGridView" runat="server" AutoGenerateColumns="False" OnRowDeleting="artistGridView_RowDeleting" OnRowEditing="artistGridView_RowEditing">
            <Columns>
                <asp:BoundField DataField="ArtistId" HeaderText="ID" SortExpression="ArtistId" />
                <asp:ImageField DataImageUrlField="ArtistImage" HeaderText="Image">
                </asp:ImageField>
                <asp:BoundField DataField="ArtistName" HeaderText="Name" SortExpression="ArtistName" />
                <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="Details" ShowHeader="True" Text="More details" />
                <asp:CommandField ButtonType="Button" HeaderText="Actions" ShowCancelButton="False" ShowDeleteButton="True" ShowEditButton="True" ShowHeader="True" />
            </Columns>
    </asp:GridView>
        <asp:Button ID="InsertBtn" runat="server" Text="Insert New Artist" OnClick="InsertBtn_Click" />
        <%} %>

        <%else
            { %>
        <asp:GridView ID="artistGridView1" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="ArtistId" HeaderText="ID" SortExpression="ArtistId" />
                <asp:ImageField DataImageUrlField="ArtistImage" HeaderText="Image">
                </asp:ImageField>
                <asp:BoundField DataField="ArtistName" HeaderText="Name" SortExpression="ArtistName" />
                <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="Details" ShowHeader="True" Text="More details" />
            </Columns>
    </asp:GridView>
        <%} %>
    </main>
</asp:Content>
