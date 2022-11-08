using DiscussIt.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiscussIt.Factory
{
    public class PostFactory
    {
        public static Post CreatePost(string title, string content, User user)
        {
            return new Post
            {
                PostTitle = title,
                PostContent = content,
                PostDate = DateTime.Now,
                UserId = user.Id
            };
        }
    }
}