using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_principles.InterfaceSegregation.Good
{
    public class Blog : IBlogRead, IBlogWrite
    {
        public void Read()
        {
            // read blog
        }

        public void Write()
        {
            // write blog
        }
    }
}
