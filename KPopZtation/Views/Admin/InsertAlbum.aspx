<%@ Page Title="" Language="C#" MasterPageFile="~/WebMasterForms/Master.Master" AutoEventWireup="true" CodeBehind="InsertAlbum.aspx.cs" Inherits="KPopZtation.Views.Admin.InsertAlbum" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Insert Album</h1>
    <div>
        <asp:Label ID="nameLbl" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="nameTbx" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="descLbl" runat="server" Text="Description"></asp:Label>
        <asp:TextBox ID="descTbx" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="priceLbl" runat="server" Text="Price"></asp:Label>
        <input id="priceTbx" type="number" runat="server"  />
    </div>
    <div>
        <asp:Label ID="stockLbl" runat="server" Text="Stock"></asp:Label>
        <input id="stockTbx" type="number" runat="server"  />
    </div>
    <div>
        <asp:Label ID="imageLbl" runat="server" Text="Artist Image"></asp:Label
            ><asp:FileUpload ID="albumImageFile" runat="server" />
    </div>
    <asp:Label ID="errorLbl" runat="server" Text=""></asp:Label>
    <asp:Button ID="insertAlbumBtn" runat="server" Text="Insert" OnClick="InsertAlbumBtn_Click" />
</asp:Content>
