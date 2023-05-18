<%@ Page Title="" Language="C#" MasterPageFile="~/WebMasterForms/Master.Master" AutoEventWireup="true" CodeBehind="AlbumDetail.aspx.cs" Inherits="KPopZtation.Views.Shared.AlbumDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="AlbumGridView" runat="server">
    </asp:GridView>

    <%if (userRole == "cust")
        { %>
    <div>
        <asp:Label ID="qtyLbl" runat="server" Text="Quantity " ></asp:Label>
        <input id="qtyTbx" type="number" runat="server" />
    </div>
    <asp:Button ID="cartBtn" runat="server" Text="Add to cart" OnClick="cartBtn_Click" />
    <%} %>
</asp:Content>
