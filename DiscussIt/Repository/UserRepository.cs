using DiscussIt.Factory;
using DiscussIt.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiscussIt.Repository
{
    public class UserRepository
    {
        private static readonly DiscussItDatabaseEntities DatabaseEntity = new DiscussItDatabaseEntities();

        public static User GetUser(string email, string password)
        {
            User user = DatabaseEntity.Users.Where(x => x.UserEmail.Equals(email) && x.UserPassword.Equals(password)).FirstOrDefault();

            return user;
        }
        public static User GetAdmin(string email, string password)
        {
            User user = DatabaseEntity.Users.Where(x => x.UserEmail.Equals(email) && x.UserPassword.Equals(password) && x.RoleId.Equals(1)).FirstOrDefault();
            return user;
        }
        internal static User GetPostByEmail(string email)
        {
            return DatabaseEntity.Users.Where(x => x.UserEmail.Equals(email)).FirstOrDefault();
        }

        private static bool IsEmailRegistered(string email)
        {
            if (DatabaseEntity.Users.Where(x => x.UserEmail.Equals(email)).FirstOrDefault() != null)
            {
                return true;
            }

            return false;
        }
        private static bool Isoldpass(string email,string oldpassword)
        {
            if (DatabaseEntity.Users.Where(x => x.UserEmail.Equals(email) && x.UserPassword.Equals(oldpassword)).FirstOrDefault() != null)
            {
                return true;
            }

            return false;
        }


        public static User CreateUser(string name, string email, string password)
        {
            if (IsEmailRegistered(email))
            {
                return null;
            }

            User u = UserFactory.CreateUser(name, email, password);
  
            DatabaseEntity.Users.Add(u);
            DatabaseEntity.SaveChanges();
            return u;
        }
        public static User Checkoldpass(string username, string newpassword, string email, string oldpassword)
        {
            if (!Isoldpass(email,oldpassword))
            {
                return null;
            }
            else
            {
                User u = GetPostByEmail(email);
                if (u != null)
                {
                    u.UserName = username;
                    u.UserPassword = newpassword;
                    DatabaseEntity.SaveChanges();
                }
                return u;
            }           
        }
        public static User Checkoldpassuname(string username, string email, string oldpassword)
        {
            if (!Isoldpass(email, oldpassword))
            {
                return null;
            }
            else
            {
                User u = GetPostByEmail(email);
                if (u != null)
                {
                    u.UserName = username;
                    DatabaseEntity.SaveChanges();
                }
                return u;
            }
        }
        public static User Checkoldpasspass(string newpassword, string email, string oldpassword)
        {
            if (!Isoldpass(email, oldpassword))
            {
                return null;
            }
            else
            {
                User u = GetPostByEmail(email);
                if (u != null)
                {
                    u.UserPassword = newpassword;
                    DatabaseEntity.SaveChanges();
                }
                return u;
            }
        }
    }
}