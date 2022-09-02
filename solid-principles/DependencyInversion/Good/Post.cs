using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_principles.DependencyInversion.Good
{
    public class Post : IContent
    {
        // low level class
        public void CreatePost(bool picture)
        {
            // process
        }
    }
}
