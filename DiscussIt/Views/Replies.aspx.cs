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
    public partial class Resplies : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Session["user"] == null)
            {
                ReplyPanel.Visible = false;
            }

            Post p = ValidatePostExist();
            
            if (!IsPostBack)
            {
                LoadReply(p);
                LoadPost(p);
            } 
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

        private void LoadReply(Post p)
        {
            ReplyRepeater.DataSource = ReplyController.GetAllReply(p.Id);
            ReplyRepeater.DataBind();
        }

        private void LoadPost(Post p)
        {
            TitleLbl.Text = p.PostTitle;
            ContentLbl.Text = p.PostContent;
            NameLbl.Text =  p.User.UserName.ToString();
            DateLbl.Text = p.PostDate.ToString();
            
        }

        protected void PostReplyBtn_Click(object sender, EventArgs e)
        {
            User u = (User)Session["user"];

            string content = tbContent.Text.Trim();

            int.TryParse(Request.QueryString["id"], out int id);
            Post post = PostController.GetPostById(id);

            ReplyController.CreateNewReply(content, u, post);
            
            Response.Redirect(Request.RawUrl);
        }
    }
}