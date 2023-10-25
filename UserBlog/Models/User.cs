using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserBlog.Models
{
    internal class User
    {
        private int _id;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }

        public string Password { get; set; }

        public User( )
        {
            Id = ++_id;
            string pattern = "^(?=.*[A-Za-z])(?=.*\\d)[A-Za-z\\d]{8,}$";
            Regex rg= new Regex(pattern);
        }

    

       
    }
}
