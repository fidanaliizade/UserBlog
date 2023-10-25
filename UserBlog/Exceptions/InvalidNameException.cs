using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserBlog.Exceptions
{
    internal class InvalidNameException:Exception
    {
        public InvalidNameException(): base("Invalid name!")
        {

        }
    }
}
