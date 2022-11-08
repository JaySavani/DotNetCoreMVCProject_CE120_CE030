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
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PostRepeater.DataSource = PostController.GetAllPost();
            PostRepeater.DataBind();
        }

        protected void ReplyLink_Click(object sender, EventArgs e)
        {
            LinkButton lb = (LinkButton)sender;
            string id = lb.CommandArgument;
            Response.Redirect("~/Views/Replies.aspx?id="+id);
        }

    }
}