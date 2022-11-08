using DiscussIt.Factory;
using DiscussIt.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiscussIt.Repository
{
    public class ReplyRepository
    {
        private static readonly DiscussItDatabaseEntities DatabaseEntity = new DiscussItDatabaseEntities();
        internal static dynamic GetAllReply(int post_id)
        {
            return DatabaseEntity.Replies.Where(x => x.PostId == post_id).ToList();
        }

        internal static void CreateReply(string content, User u, Post p)
        {
            Reply r = ReplyFactory.CreateReply(content, u, p);

            DatabaseEntity.Replies.Add(r);
            DatabaseEntity.SaveChanges();
        }
    }
}