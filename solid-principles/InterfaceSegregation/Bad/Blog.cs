using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_principles.InterfaceSegregation.Bad
{
    public class Blog : IBlog
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
