using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_principles.DependencyInversion.Good
{
    public interface IContent
    {
        void CreatePost(bool picture);
    }
}
