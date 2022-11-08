using DiscussIt.Model;
using DiscussIt.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiscussIt.Handler
{
    public class UserHandler
    {
        public static User GetUser(string email, string password)
        {
            return UserRepository.GetUser(email, password);
        }
        public static User GetAdmin(string email, string password)
        {
            return UserRepository.GetAdmin(email, password);
        }

        public static User CreateUser(string name, string email, string password)
        {
            return UserRepository.CreateUser(name, email, password);
        }
        public static User Checkoldpass(string username,string newpassword,string email, string oldpassword)
        {
            return UserRepository.Checkoldpass(username,newpassword,email, oldpassword);
        }
        public static User Checkoldpassuname(string username, string email, string oldpassword)
        {
            return UserRepository.Checkoldpassuname(username, email, oldpassword);
        }
        public static User Checkoldpasspass( string newpassword, string email, string oldpassword)
        {
            return UserRepository.Checkoldpasspass( newpassword, email, oldpassword);
        }
    }
}