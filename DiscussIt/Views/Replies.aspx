    <%@ Page Title="" Language="C#" MasterPageFile="~/Views/Template.Master" AutoEventWireup="true" CodeBehind="Replies.aspx.cs" Inherits="DiscussIt.Views.Resplies" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div class="card ms-4 me-5" style="border: solid 1px; margin: 1% 1%">
    <div class="card-header header-bg ">
         <div class="d-flex justify-content-between">
        <div>Posted By : <asp:Label ID="NameLbl" runat="server" Text="Label"></asp:Label></div>
        <p style="margin: 0">
            <asp:Label ID="DateLbl" runat="server" Text="Label"></asp:Label>
        </p>
        </div>
    </div>
    <div class="card-body">

        <h5 class="card-title">
            <asp:Label ID="TitleLbl" runat="server" Text="Label"></asp:Label>
        </h5>
        <p class="card-text">
            <asp:Label ID="ContentLbl" runat="server" Text="Label"></asp:Label>
        </p>
    </div>
   </div>

    <asp:Repeater ID="ReplyRepeater" runat="server">
        <ItemTemplate>
            <div class="card reply-container reply-area ms-5 me-4 mt-2">
                <div class="card-body">
                    <h6 class="card-subtitle mb-2 text-muted">
                        <div class="d-flex justify-content-between">
                            <div>Replied By : <asp:Label Text='<%# Eval("User.UserName") %>' runat="server" /></div> 
                        
                            <p style="margin: 0">
                                <asp:Label Text='<%# Eval("PostDate") %>' runat="server" />
                            </p>
                        </div>
                    </h6>
                    <p class="card-text"><asp:Label Text='<%# Eval("ReplyContent") %>' runat="server" /></p>
                </div>
            </div>
        </ItemTemplate>
    </asp:Repeater>
    
    <asp:Panel ID="ReplyPanel" runat="server" class="m-3">
        <div class="mb-3 mt-1">
            <asp:Label runat="server" Text="Label" class="form-label">Reply</asp:Label>
            <asp:TextBox class="form-control" ID="tbContent" runat="server" TextMode="MultiLine" Rows="7" style="width:100%; resize: none"></asp:TextBox>
        </div>
        <div style="display:flex; justify-content:flex-start; margin-right:1%;">
            <asp:Button ID="PostReplyBtn" runat="server"  Text="Reply" CssClass="btn btn-outline-primary pb-1" class="btn" OnClick="PostReplyBtn_Click"/>
        </div>
    </asp:Panel>
</asp:Content>
