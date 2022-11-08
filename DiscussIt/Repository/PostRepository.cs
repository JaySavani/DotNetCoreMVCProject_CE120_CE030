using DiscussIt.Factory;
using DiscussIt.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiscussIt.Repository
{
    public class PostRepository
    {
        private static readonly DiscussItDatabaseEntities DatabaseEntity = new DiscussItDatabaseEntities();
        public static dynamic GetAllPost()
        {
            List<Post> posts= DatabaseEntity.Posts.ToList();

            return from p in posts
                   orderby p.Id descending
                   select p;
        }

        internal static Post GetPostById(int id)
        {
            return DatabaseEntity.Posts.Where(x => x.Id == id).FirstOrDefault();
        }

        internal static dynamic GetMyPost(int userId)
        {
            List<Post> posts = DatabaseEntity.Posts.Where(x => x.UserId == userId).ToList();
            if (posts.Count == 0)
            {
                return null;
            }

            return from p in posts
                   orderby p.Id descending
                   select p;
        }

        internal static void EditPost(string title, string content, Post oldPost)
        {
            Post post = GetPostById(oldPost.Id);
            if (post != null)
            {
                post.PostTitle = title;
                post.PostContent = content;
                DatabaseEntity.SaveChanges();
            }
        }

        internal static bool DeletePost(int postId)
        {
            Post post = GetPostById(postId);

            if (post == null)
            {
                return false;
            } else
            {
                DatabaseEntity.Posts.Remove(post);
                DatabaseEntity.SaveChanges();
                return true;
            }
        }

        internal static void CreatePost(string title, string content, User u)
        {
            Post p = PostFactory.CreatePost(title, content, u);

            DatabaseEntity.Posts.Add(p);
            DatabaseEntity.SaveChanges();
        }
    }
}