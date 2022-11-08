<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Template.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="DiscussIt.Views.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Repeater ID="PostRepeater" runat="server" >
        <ItemTemplate>
            <div class="card mx-4 mb-5" style="border: solid 1px;border-color: rgb(167, 167, 167); margin: 2% 1%">
                <div class="card-header">
                     <div class="d-flex justify-content-between">
                        <div>Posted By:<b> <asp:Label runat="server" Text='<%# Eval("User.UserName")%>'></asp:Label></b>
                        </div>
                        <div>
                            <span style="margin: 0; width: 90%">
                                <asp:Label runat="server" Text='<%# Eval("PostDate")%>'></asp:Label>
                            </span>
                        </div>
                    </div>
                    

                </div>
                <div class="card-body">
                    <h5 class="card-title">
                        <asp:Label runat="server" Text='<%# Eval("PostTitle")%>'></asp:Label>
                    </h5>
                    <p class="card-content">
                        <asp:Label runat="server" CssClass="card-text" Text='<%# Eval("PostContent")%>'></asp:Label>
                    </p>
                    
                    <div class="btn-group mt-2" role="group" aria-label="Second group">
                        <asp:LinkButton ID="ReplyLink" OnClick="ReplyLink_Click" CommandArgument='<%#Eval("Id")%>' CssClass="btn btn-outline-primary pb-1" runat="server">
                            <i class="bx bx-chat" style="font-size: x-large"></i>
                        </asp:LinkButton>
                    </div>
                </div>
            </div>

        </ItemTemplate>
        
    </asp:Repeater>
</asp:Content>
