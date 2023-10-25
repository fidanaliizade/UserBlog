using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserBlog.Exceptions
{
    internal class InvalidSurNameException:Exception
    {
        public InvalidSurNameException():base("Invalid surname.")
        {

        }
    }
}
