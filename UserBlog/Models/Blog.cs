using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserBlog.Models
{
    internal class Blog
    {
        private int _id;
        public int Id { get; set; }
        public  string Title { get; set; }
        public string Description { get; set; }
        public  Blog( string title, string description)
        {
            Id = ++ _id;
            Title = title;
            Description = description;
        }


    }
}
