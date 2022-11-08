<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Template.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="DiscussIt.Views.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
      <div class="row">
         <div class="col-12">
            <div class="card mt-5">
               <div class="card-body">
                  <div class="row">
                     <div class="col">
                        <center>
                            <img width="80px" src="../assets/images/generaluser.png" />
                        </center>
                     </div>
                  </div>
                   <div class="row">
                     <div class="col">
                        <center>
                           <h3><asp:Label ID="lbluser" runat="server" Text=""></asp:Label></h3>
                        </center>
                     </div>
                  </div>
                    <div class="row">
                     <div class="col">
                        <center>
                           <h6><asp:Label ID="lbluseremail" runat="server" Text=""></asp:Label></h6>
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <hr>
                     </div>
                  </div>
                  <div class="row mb-3">
                     <div class="col-md-6">
                        <label>Username</label>
                        <div class="form-group">
                           <div class="input-group">
                              <asp:TextBox runat="server" class="form-control" ID="tbName" ViewStateMode="Inherit"></asp:TextBox>
                           </div>
                        </div>
                     </div>
                      <div class="col-md-6">
                        <label>Old Password</label>
                        <div class="form-group">
                           <div class="input-group">
                              <asp:TextBox CssClass="form-control" TextMode="Password" ID="oldpass" runat="server"></asp:TextBox>
                           </div>
                        </div>
                     </div>
                   </div>
                   <div class="row mb-3">
                      <div class="col-md-6">
                        <label>New Password</label>
                        <div class="form-group">
                           <div class="input-group">
                              <asp:TextBox CssClass="form-control" TextMode="Password" ID="newpass" runat="server"></asp:TextBox>
                           </div>
                        </div>
                     </div>
                      <div class="col-md-6">
                        <label>Confirm New Password</label>
                        <div class="form-group">
                           <div class="input-group">
                              <asp:TextBox CssClass="form-control" TextMode="Password" ID="cnewpass" runat="server"></asp:TextBox>
                           </div>
                        </div>
                     </div>
                  </div>
                  <div class="row mt-2">
                         
                      <div class="col-md-4">
                             <center>
                             <asp:Button ID="Button1" class="btn btn-lg btn-block btn-outline-warning" runat="server" Text="Change Username" OnClick="updateprofileuname_Click" />
                              <center>
                         </div>
                      <div class="col-md-4">
                             <center>
                                <asp:Button ID="Button2" class="btn btn-lg btn-block btn-outline-warning" runat="server" Text="Change Password" OnClick="updateprofilepass_Click" />
                             <center>
                         </div>
                       <div class="col-md-4">
                              <center>
                             <asp:Button ID="Button3" class="btn btn-lg btn-block btn-outline-warning" runat="server" Text="Change Both" OnClick="updateprofileboth_Click" />
                         </center>
                                  </div>
                  </div>

                   <div class="mb-3">
                        <asp:Label ID="lblError" Text="" runat="server" style="color: red;"/>
                    </div>
               </div>
            </div>
         </div>
        
      </div>
   </div>
</asp:Content>
