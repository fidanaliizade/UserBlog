using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserBlog.Exceptions
{
    internal class BlogNotFoundException:Exception
    {
        public BlogNotFoundException():base("Blog not found.")
        {

        }
    }
    
}
