using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_principles.InterfaceSegregation.Bad
{
    public interface IBlog
    {
        public void Write();
        public void Read();
    }
}
