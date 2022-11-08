using DiscussIt.Model;
using DiscussIt.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiscussIt.Handler
{
    public class ReplyHandler
    {
        internal static dynamic GetAllReply(int post_id)
        {
            return ReplyRepository.GetAllReply(post_id);
        }

        internal static void CreateNewReply(string content, User u, Post p)
        {
            ReplyRepository.CreateReply(content, u, p);
        }
    }
}