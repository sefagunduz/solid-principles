using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_principles.DependencyInversion.Bad
{
    public class Blog
    {
        // high level class 
        public void Create()
        {
            Post post = new Post();
            post.CreatePost(true);
        }
    }
}
