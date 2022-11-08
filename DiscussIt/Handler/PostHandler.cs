using DiscussIt.Model;
using DiscussIt.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiscussIt.Handler
{
    public class PostHandler
    {
        public static dynamic GetAllPost()
        {
            return PostRepository.GetAllPost();
        }


        internal static Post GetPostById(int id)
        {
            return PostRepository.GetPostById(id);
        }

        internal static void CreatePost(string title, string content, User u)
        {
            PostRepository.CreatePost(title, content, u);
        }

        internal static dynamic GetMyPost(int userId)
        {
            return PostRepository.GetMyPost(userId);
        }

        internal static bool DeletePost(int postId)
        {
            return PostRepository.DeletePost(postId);
        }

        internal static void EditPost(string title, string content, Post p)
        {
            PostRepository.EditPost(title, content, p);
        }
    }
}