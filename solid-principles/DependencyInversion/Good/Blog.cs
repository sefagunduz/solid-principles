using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_principles.DependencyInversion.Good
{
    public class Blog
    {
        // high level class
        IContent content;
        public Blog()
        {
            content = new Post();
        }

        public void Create()
        {
            content.CreatePost(true);
        }

    }
}
