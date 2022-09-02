using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_principles.DependencyInversion.Bad
{
    public class Post
    {
        // low level class
        public void CreatePost(bool picture)
        {
            // process
        }
    }
}
