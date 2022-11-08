using DiscussIt.Controller;
using DiscussIt.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DiscussIt.Views
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            User u = (User)Session["user"];
            if (u == null || u.RoleId != 1)
            {
                Response.Redirect("AdminHome.aspx");
            }
            PostRepeater.DataSource = PostController.GetAllPost();
            PostRepeater.DataBind();
        }
        protected void ReplyLink_Click(object sender, EventArgs e)
        {
            LinkButton lb = (LinkButton)sender;
            string id = lb.CommandArgument;
            Response.Redirect("~/Views/Replies.aspx?id=" + id);
        }
        protected void EditLink_Click(object sender, EventArgs e)
        {
            LinkButton lb = (LinkButton)sender;
            string id = lb.CommandArgument;
            Response.Redirect("~/Views/EditPost.aspx?id=" + id);
        }

        protected void DeleteLink_Click(object sender, EventArgs e)
        {
            LinkButton lb = (LinkButton)sender;
            string id = lb.CommandArgument;
            int.TryParse(id, out int postId);

            bool IsDeleted = PostController.DeletePost(postId);
            if (IsDeleted)
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "alertMessage", "alert('Post succesfully removed')", true);
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "alertMessage", "alert('ERROR: Post not found!')", true);
            }
            Response.Redirect("~/Views/AdminHome.aspx");
           
          
        }
    }
}