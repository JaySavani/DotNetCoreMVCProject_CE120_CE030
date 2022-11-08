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
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                Response.Redirect("Home.aspx");
            }
        }

        protected void RegisBtn_Click(object sender, EventArgs e)
        {
            string name = tbName.Text.Trim();
            string email = tbEmail.Text.Trim();
            string password = tbPassword.Text.Trim();
            string confirm = tbConfirm.Text.Trim();

            string msg = UserController.ValidateRegister(name, email, password, confirm);

            if (msg != null)
            {
                lblError.Text = msg;
            }
            else
            {
                Session["user"] = UserController.GetUser(email, password);
                Response.Redirect("Home.aspx");
            }
        }
    }
}