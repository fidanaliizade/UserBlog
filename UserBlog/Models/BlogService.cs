using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using UserBlog.Exceptions;

namespace UserBlog.Models
{
    internal static class BlogService
    {
        public static void AddBlog(Blog blog, BlogType blogtype)
        {
          
            BlogDatabase.Blogs.Add(blog);
        }

        public static void RemoveBlog(int id)
        {
            try
            {
                for (int i = 0; i < BlogDatabase.Users.Count; i++)
                {
                    if (BlogDatabase.Users[i].Id == id)
                    {
                        BlogDatabase.Users.RemoveAt(i);
                    }
                }

            }catch(BlogNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }



        public static void GetBlogById(int id)
        {
            try
            {
                for (int i = 0; i < BlogDatabase.Users.Count; i++)
                {
                    if (BlogDatabase.Users[i].Id == id)
                    {
                        Console.WriteLine($"User name: {BlogDatabase.Users[i].Name}, surname: {BlogDatabase.Users[i].Surname} , username : {BlogDatabase.Users[i].Username}");
                    }
                }

           
               
            }
            catch(BlogNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


            public static void GetAllBlogs()
            {
                foreach (Blog blog in BlogDatabase.Blogs)
                    Console.WriteLine(blog);
            }

            public static void GetBlogsByValue(string value)
            {

            }

        internal static void AddBlog(Blog? blog)
        {
            throw new NotImplementedException();
        }
    } 
}
