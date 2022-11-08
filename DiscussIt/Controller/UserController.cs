using DiscussIt.Handler;
using DiscussIt.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Web;

namespace DiscussIt.Controller
{
    
    public static class UserController
    {
        private static readonly Regex regex = new Regex("^[a-zA-Z0-9]*$");

        public static User GetUser(string email, string password)
        {
            return UserHandler.GetUser(email,password);
        }
        public static User GetAdmin(string email, string password)
        {
            return UserHandler.GetAdmin(email, password);
        }


        // TODO: Change to return User
        // Current return type is for testing
        public static string ValidateLogin(string email, string password)
        {
            if (IsEmptyInput(email) || IsEmptyInput(password))
            {
                return "Fields cannot be empty!!";
            }
           

            if (GetUser(email, password) == null)
            {
                return "Email or password is incorrect!";
            }
            else  if (!IsValidEmail(email))
            {
                return "Email is not valid!";
            } else if (!IsValidPassword(password))
            {
                return "Password must be alpha numeric";
            } else
            {
                return null;
            }
        }
        public static string ValidateAdminLogin(string email, string password)
        {
            if (IsEmptyInput(email) || IsEmptyInput(password))
            {
                return "Fields cannot be empty!!";
            }


            if (GetAdmin(email, password) == null)
            {
                return "😏 Only God can see all details 😎!";
            }
            else if (!IsValidEmail(email))
            {
                return "Email is not valid!";
            }
            else if (!IsValidPassword(password))
            {
                return "Password must be alpha numeric";
            }
            else
            {
                return null;
            }
        }


        public static string ValidateRegister(string name, string email, string password, string confirm)
        {
            if (IsEmptyInput(email) || IsEmptyInput(password) || IsEmptyInput(name))
            {
                return "Fields cannot be empty!!";
            }
            else if (!IsValidEmail(email))
            {
                return "Email is not valid!";
            }
            else if (!IsValidPassword(password))
            {
                return "Password must be alpha numeric";

            }
            else if (confirm != password)
            {

                return "Confirm password must be the same as password!";
            }
            else if (!IsValidName(name))
            {
                return "Name length cannot be less than 3 characters long and more than 50 characters long!";
            }
            else if (UserHandler.CreateUser(name, email, password) == null)
            {
                return "Email already exists!";
            }
            else
            {
                return null;
            }
            
        }


        public static string ValidateProfile(string email,string username, string oldpassword, string newpassword, string cnewpassword)
        {
            if (IsEmptyInput(username) || IsEmptyInput(oldpassword) || IsEmptyInput(newpassword) || IsEmptyInput(cnewpassword))
            {
                return "Fields cannot be empty!!";
            }
            else if (!IsValidPassword(newpassword) || !IsValidPassword(cnewpassword)|| !IsValidPassword(oldpassword))
            { 
                return "All Password must be alpha numeric";

            }
            else if (cnewpassword != newpassword)
            {

                return "Confirm password must be the same as password!";
            }
            else if (!IsValidName(username))
            {
                return "UserName length cannot be less than 3 characters long and more than 50 characters long!";
            }
            else if (UserHandler.Checkoldpass(username,newpassword,email, oldpassword) == null)
            {
                return "oldpassword is incorrect!";
            }
            else
            {
                return null;
            }

        }

        public static string ValidateProfileuname(string email, string username, string oldpassword)
        {
            if (IsEmptyInput(username) || IsEmptyInput(oldpassword))
            {
                return "Username and Oldpassword cannot be empty!!";
            }
            else if (!IsValidPassword(oldpassword))
            {
                return "All Password must be alpha numeric";

            }
            else if (!IsValidName(username))
            {
                return "UserName length cannot be less than 3 characters long and more than 50 characters long!";
            }
            else if (UserHandler.Checkoldpassuname(username, email, oldpassword) == null)
            {
                return "oldpassword is incorrect!";
            }
            else
            {
                return null;
            }

        }
        public static string ValidateProfilepass(string email, string oldpassword, string newpassword, string cnewpassword)
        {
            if (IsEmptyInput(oldpassword) || IsEmptyInput(newpassword) || IsEmptyInput(cnewpassword))
            {
                return "Password Fields cannot be empty!!";
            }
            else if (!IsValidPassword(newpassword) || !IsValidPassword(cnewpassword) || !IsValidPassword(oldpassword))
            {
                return "All Password must be alpha numeric";

            }
            else if (cnewpassword != newpassword)
            {

                return "Confirm password must be the same as password!";
            }
            else if (UserHandler.Checkoldpasspass( newpassword, email, oldpassword) == null)
            {
                return "oldpassword is incorrect!";
            }
            else
            {
                return null;
            }

        }

        public static bool IsEmptyInput(object obj)
        {
            if (obj == null)
            {
                return true;
            }

            return false;
        }

        public static bool IsValidName(string name)
        {
            if (name.Length < 3 || name.Length > 50)
            {
                return false;
            }
            return true;
        }

        public static bool IsValidEmail(string email)
        {

            try
            {
                MailAddress m = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private static bool IsValidPassword(string password)
        {
            if (password.Length >= 5 && regex.IsMatch(password))
            {
                return true;
            }

            return false;
        }
    }
}