using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DiscussIt.Model;

namespace DiscussIt.Factory
{
    public class UserFactory
    {
       
        public static User CreateUser(string name, string email, string password)
        {
            User u = new User
            {
                UserName = name,
                UserEmail = email,
                UserPassword = password,
                RoleId = 2
            };
            return u;
        }
    }
}