using DiscussIt.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiscussIt.Factory
{
    public class ReplyFactory
    {
        internal static Reply CreateReply(string content, User u, Post p)
        {
            return new Reply
            {
                ReplyContent = content,
                PostId = p.Id,
                UserId = u.Id,
                PostDate = DateTime.Now,
            };
        }
    }
}