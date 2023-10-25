using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace UserBlog.Models
{
    internal static class UserServices
    {
        static List<User> Users = new List<User>();

        public static void Register(string name , string surname, string password)
        {
            string username = name.ToLower() + "." + surname.ToLower();

        }

        public static void Login(string username , string password)
        {
            bool checkLogin = false;
            for (int i = 0; i < Users.Count; i++)
            {
                if (Users[i].Username == username && Users[i].Password == password)
                {
                    checkLogin = true;
                    break;
                }
            }
            if (checkLogin)
            {
                Console.WriteLine("You are logged in.");
            }
            else
            {
                Console.WriteLine("You are not logged in.");
            }

           }
        


     }
}
