<%@ Page Title="" Language="C#" MasterPageFile="~/WebMasterForms/Admin.Master" AutoEventWireup="true" CodeBehind="ViewAlbum.aspx.cs" Inherits="KPopZtation.Views.Admin.ViewAlbum" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main>
        <header><h1>View Album Page</h1></header>
        <div>
            <asp:GridView ID="GridViewAlbum" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="AlbumId" HeaderText="ID" ReadOnly="true" SortExpression="AlbumId"/>
                    <asp:BoundField DataField="" />
                    <%-- Belum seleai karena harus ke artist dlu :" --%>
                </Columns>
            </asp:GridView>
        </div>
    </main>
</asp:Content>
