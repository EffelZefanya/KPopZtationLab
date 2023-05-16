<%@ Page Title="" Language="C#" MasterPageFile="~/WebMasterForms/Master.Master" AutoEventWireup="true" CodeBehind="UpdateArtists.aspx.cs" Inherits="KPopZtation.Views.Admin.UpdateArtists" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Update Artist</h1>
    <main>
        <div>
            <asp:Label ID="nameLbl" runat="server" Text="Artist Name"></asp:Label>
            <asp:TextBox ID="ArtistNameTb" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="imageLbl" runat="server" Text="Artist Image"></asp:Label
                ><asp:FileUpload ID="artistImgFile" runat="server" />
        </div>
        <div>
            <asp:Label ID="errorLbl" runat="server" Text=""></asp:Label>
        </div>
        <asp:Button ID="updateBtn" runat="server" Text="Update Artist Information" OnClick="updateBtn_Click" />
    </main>
</asp:Content>
