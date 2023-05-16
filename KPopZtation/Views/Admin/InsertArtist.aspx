<%@ Page Title="" Language="C#" MasterPageFile="~/WebMasterForms/Master.Master" AutoEventWireup="true" CodeBehind="InsertArtist.aspx.cs" Inherits="KPopZtation.Views.Admin.InsertArtist" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Insert Artist</h1>
    <main>
        <div>
            <asp:Image ID="artistImg" runat="server" />
        </div>
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
        <asp:Button ID="insertBtn" runat="server" Text="Insert Artist" OnClick="insertBtn_Click" />
    </main>
</asp:Content>
