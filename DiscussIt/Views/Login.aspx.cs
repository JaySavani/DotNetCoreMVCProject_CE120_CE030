using DiscussIt.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DiscussIt.Views
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                Response.Redirect("Home.aspx");
            }
        }

        protected void ButtonLogin_Click(object sender, EventArgs e)
        {
            string email = tbEmail.Text;
            string password = tbPassword.Text;

            string msg = UserController.ValidateLogin(email, password);

            if (msg != null)
            {
                lblError.Text = msg;
            } else
            {
                Session["user"] = UserController.GetUser(email, password);
                Response.Redirect("Home.aspx");
            }
            
        }
    }
}