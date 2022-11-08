using DiscussIt.Handler;
using DiscussIt.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiscussIt.Controller
{
    public class PostController
    {
        public static dynamic GetAllPost()
        {
            return PostHandler.GetAllPost();
        }

        public static Post GetPostById(int id)
        {
            return PostHandler.GetPostById(id);
        }

        public static string CreateNewPost(string title, string content, User u)
        {
            if (!IsValidTitle(title))
            {
                return "Title cannot be less than 3 characters or longer than 200!";
            } else if (!IsValidContent(content))
            {
                return "Content cannot be less than 5 characters or longer than 600!";
            } else
            {
                PostHandler.CreatePost(title, content, u);
            }

            return null;
        }

        internal static dynamic GetMyPost(int userId)
        {
            return PostHandler.GetMyPost(userId);
        }

        internal static string EditPost(string title, string content, Post p)
        {

            if (!IsValidTitle(title))
            {
                return "Title cannot be less than 3 characters or longer than 200!";
            }
            else if (!IsValidContent(content))
            {
                return "Content cannot be less than 5 characters or longer than 250!";
            }
            else
            {
                PostHandler.EditPost(title, content, p);
            }
            return null;
        }

        private static bool IsValidTitle(string title)
        {
            if (title == null || title == "")
            {
                return false;
            }  else if (title.Length < 3 || title.Length > 200)
            {
                return false;
            }

            return true;
        }

        private static bool IsValidContent(string content)
        {
            if (content == null || content == "")
            {
                return false;
            } else if (content.Length < 5 || content.Length > 600)
            {
                return false;
            }
            return true;
        }

        internal static bool DeletePost(int postId)
        {
            return PostHandler.DeletePost(postId);
        }
    }
}