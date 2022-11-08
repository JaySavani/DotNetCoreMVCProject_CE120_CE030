<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Template.Master" AutoEventWireup="true" CodeBehind="EditPost.aspx.cs" Inherits="DiscussIt.Views.EditPost" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="margin: 3% 20% 5% 20%;">
        <h3 class="Title mb-4" style="text-align: center; text-transform: uppercase; margin-bottom: 3%;">Edit Question</h3>
        <div class="mb-3">
            <b><asp:Label runat="server" Text="Label" class="form-label">Title</asp:Label></b>
            <small id="emailtitleHelp" class="form-text text-muted">Be specific and imagine you’re asking a question to another person</small>
            <asp:TextBox runat="server" class="form-control" ID="tbTitle"></asp:TextBox>
        </div>
        <div class="mb-3">
            <b><asp:Label runat="server" Text="Label" class="form-label">Content</asp:Label></b>
            <small id="emailcontentHelp" class="form-text text-muted">Include all the information someone would need to answer your question</small>
            <asp:TextBox class="form-control" ID="tbContent" runat="server" TextMode="MultiLine" Rows="10" style="width:100%; resize: none"></asp:TextBox>
        </div>
        <div style="display:flex; justify-content:center">
            <asp:Button ID="BtnUpdatePost" runat="server" OnClientClick="return confirm('Are you sure you want to Update this post?');" OnClick="BtnUpdatePost_Click" Text="Update" CssClass="btn btn-outline-primary pb-1" class="btn"/>
        </div>
        
        <div class="mb-3">
            <asp:Label ID="lblError" Text="" runat="server" style="color: red;"/>
        </div>
    </div>
</asp:Content>
