<%@ Page Title="" Language="C#" MasterPageFile="~/WebMasterForms/Master.Master" AutoEventWireup="true" CodeBehind="UpdateProfile.aspx.cs" Inherits="KPopZtation.Views.Shared.UpdateProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Update Profile</h1>
    <main>
        <asp:GridView ID="currentProfileGridView" runat="server">

        </asp:GridView>

        <div>
            <asp:Label ID="nameLbl" runat="server" Text="Name: Name must be between 5 and 50 characters"></asp:Label>
        <asp:TextBox ID="nameTxt" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="genderLbl" runat="server" Text="Gender"></asp:Label>
            <asp:DropDownList ID="genderDDL" runat="server"></asp:DropDownList>
        </div>
        <div>
            <asp:Label ID="addressLbl" runat="server" Text="Address: Address must end with 'Street'"></asp:Label>
            <asp:TextBox ID="addressTxt" runat="server" ></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="emailLbl" runat="server" Text="Email: Email must be unique"></asp:Label>
            <asp:TextBox ID="emailTxt" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="passwordLbl" runat="server" Text="Password: Fill password with alphanumeric characters"></asp:Label>
            <asp:TextBox ID="passwordTxt"  runat="server" TextMode="Password" ></asp:TextBox>
        </div>
        <div style="color:red">
        <asp:Label ID="errorLbl" runat="server" Text=""></asp:Label>
    </div>
        <asp:Button ID="updateProfileBtn" runat="server" Text="Update Profile" OnClick="updateProfileBtn_Click"/>
    </main>
</asp:Content>
