<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Template.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="DiscussIt.Views.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div  style="margin: 5% 20% 5% 20%;">
        <div class="mb-3">
            <asp:Label runat="server" Text="Label" class="form-label white-text">Name</asp:Label>
            <asp:TextBox runat="server" class="form-control" ID="tbName"></asp:TextBox>
        </div>

        <div class="mb-3">
            <asp:Label runat="server" Text="Label" class="form-label white-text">Email</asp:Label>
            <asp:TextBox runat="server" class="form-control" ID="tbEmail"></asp:TextBox>
            <div id="emailHelp" class="form-text disabled-text">We'll never share your email with anyone else.</div>
        </div>
        
        <div class="mb-3">
            <asp:Label runat="server" Text="Label" class="form-label white-text">Password</asp:Label>
            <asp:TextBox runat="server" class="form-control" TextMode="Password" ID="tbPassword"></asp:TextBox>
        </div>

        <div class="mb-3">
            <asp:Label runat="server" Text="Label" class="form-label white-text">Confirm Password</asp:Label>
            <asp:TextBox runat="server" class="form-control" TextMode="Password" ID="tbConfirm"></asp:TextBox>
        </div>
        
        <div style="display:flex; justify-content:center">
            <asp:Button ID="RegisBtn" runat="server" OnClick="RegisBtn_Click" Text="Register" class="btn"/>
        </div>

        <div class="mb-3">
            <asp:Label ID="lblError" Text="" runat="server" style="color: red;"/>
        </div>
    </div>

</asp:Content>
