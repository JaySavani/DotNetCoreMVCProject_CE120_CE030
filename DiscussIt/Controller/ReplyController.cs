using DiscussIt.Handler;
using DiscussIt.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiscussIt.Controller
{
    public class ReplyController
    {
        public static dynamic GetAllReply(int post_id)
        {
            if (PostController.GetPostById(post_id) == null)
            {
                return null;
            }

            return ReplyHandler.GetAllReply(post_id);
        }

        internal static string CreateNewReply(string content, User u, Post p)
        {
            if (String.IsNullOrEmpty(content))
            {
                return "Content cannot be empty!";
            }

            ReplyHandler.CreateNewReply(content, u, p);

            return null;
        }
    }
}