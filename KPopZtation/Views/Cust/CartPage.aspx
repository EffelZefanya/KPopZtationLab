<%@ Page Title="" Language="C#" MasterPageFile="~/WebMasterForms/Master.Master" AutoEventWireup="true" CodeBehind="CartPage.aspx.cs" Inherits="KPopZtation.Views.Cust.CartPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="cartGridView" runat="server" AutoGenerateColumns="False" OnRowDeleting="cartGridView_RowDeleting">
        <Columns>
            <asp:BoundField DataField="AlbumId" HeaderText="Album ID" SortExpression="AlbumId" />
            <asp:BoundField DataField="Album.AlbumName" HeaderText="Album Name " SortExpression="Album.AlbumName" />
            <asp:BoundField DataField="Qty" HeaderText="Quantity" SortExpression="Qty" />
            <asp:CommandField ButtonType="Button" HeaderText="Actions" ShowDeleteButton="True" ShowHeader="True" />
        </Columns>
    </asp:GridView>
    <asp:Label runat="server" Text="" ID="errorLbl"></asp:Label> <br />

    <asp:Button ID="checkOutBtn" runat="server" Text="Check Out" OnClick="checkOutBtn_Click" />
</asp:Content>
