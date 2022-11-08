using DiscussIt.Controller;
using DiscussIt.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace DiscussIt.Views
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            User u = (User)Session["user"];
            if (u != null)
            {
                if (!IsPostBack)
                {
                    lbluser.Text = u.UserName;
                    tbName.Text = u.UserName;
                    lbluseremail.Text = u.UserEmail;
                }
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }
        protected void updateprofileboth_Click(object sender, EventArgs e)
        {
            string username = tbName.Text;
            string oldpassword = oldpass.Text;
            string newpassword = newpass.Text;
            string cnewpassword = cnewpass.Text;
            string email = lbluseremail.Text;

            string msg = UserController.ValidateProfile(email,username, oldpassword, newpassword, cnewpassword);

            if (msg != null)
            {
                lblError.Text = msg;
            }
            else
            {
                Session["user"] = null;
                Response.Redirect("~/Views/Login.aspx");
                Response.Write("<script>alert('Profile updated login again!');</script>");
            }
        }
        protected void updateprofileuname_Click(object sender, EventArgs e)
        {
            string username = tbName.Text;
            string oldpassword = oldpass.Text;
            string email = lbluseremail.Text;

            string msg = UserController.ValidateProfileuname(email, username, oldpassword);

            if (msg != null)
            {
                lblError.Text = msg;
            }
            else
            {
                Session["user"] = null;
                Response.Redirect("~/Views/Login.aspx");
                Response.Write("<script>alert('Profile updated login again!');</script>");
            }
        }
        protected void updateprofilepass_Click(object sender, EventArgs e)
        {
            string newpassword = newpass.Text;
            string cnewpassword = cnewpass.Text;
            string oldpassword = oldpass.Text;
            string email = lbluseremail.Text;

            string msg = UserController.ValidateProfilepass(email, oldpassword, newpassword, cnewpassword); ;

            if (msg != null)
            {
                lblError.Text = msg;
            }
            else
            {
                Session["user"] = null;
                Response.Redirect("~/Views/Login.aspx");
                Response.Write("<script>alert('Profile updated login again!');</script>");
            }
        }


    }
}