using DiscussIt.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DiscussIt.Views
{
    public partial class Template : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            User u = (User)Session["user"];
            if (u != null)
            {
                if (u.RoleId == 1)
                {
                    LoginPanel.Visible = true;
                    HomePanel.Visible = false;
                    PostPanel.Visible = true;
                    AdminHomePanel.Visible = true;
                    GuestPanel.Visible = false;
                    ProfileName.Text = u.UserName;
                }
                else
                {
                    AdminHomePanel.Visible = false;
                    HomePanel.Visible = true;
                    LoginPanel.Visible = true;
                    PostPanel.Visible = true;
                    GuestPanel.Visible = false;
                    ProfileName.Text = u.UserName;
                }
            }
            else
            {
                HomePanel.Visible = true;
                AdminHomePanel.Visible = false;
                PostPanel.Visible = false;
                LoginPanel.Visible = false;
                GuestPanel.Visible = true;
            }
        }

        protected void CreatePostLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("CreatePostPage.aspx");
        }
    }
}