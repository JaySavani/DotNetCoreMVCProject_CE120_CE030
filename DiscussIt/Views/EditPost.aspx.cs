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
    public partial class EditPost : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("~/Views/Home.aspx");
            }

            Post p = ValidatePostExist();

            if (!IsPostBack)
            {
                LoadForm(p);
            }
        }

        private void LoadForm(Post p)
        {
            tbTitle.Text = p.PostTitle;
            tbContent.Text = p.PostContent;
        }

        private Post ValidatePostExist()
        {
            bool isInt = int.TryParse(Request.QueryString["id"], out int id);

            if (!isInt)
            {
                Response.Redirect("~/Views/Home.aspx");
            }
            Post p = PostController.GetPostById(id);
            if (p == null)
            {
                Response.Redirect("~/Views/Home.aspx");
            }
            return p;
        }

        protected void BtnUpdatePost_Click(object sender, EventArgs e)
        {
            string title = tbTitle.Text;
            string content = tbContent.Text;
            Post p = ValidatePostExist();
            string msg = PostController.EditPost(title, content, p);
            if (msg != null)
            {
                lblError.Text = msg;
            } else
            {
                User u = (User)Session["user"];
                if (u.RoleId == 1)
                {
                    Response.Redirect("~/Views/AdminHome.aspx");
                }
                else
                {
                    Response.Redirect("~/Views/MyPost.aspx");
                }
            }
        }
    }
}