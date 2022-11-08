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
    public partial class CreatePostPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("~/Views/Home.aspx");
            }
        }

        protected void ButtonPost_Click(object sender, EventArgs e)
        {
            string content = tbContent.Text;
            string title = tbTitle.Text;

            User u = (User)Session["user"];
            string msg = PostController.CreateNewPost(title, content, u);

            if(msg == null)
            {
                Response.Redirect("~/Views/MyPost.aspx");
            }
            else
            {
                lblError.Text = msg;
            }
        }
    }
}