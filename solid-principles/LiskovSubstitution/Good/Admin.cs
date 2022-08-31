using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_principles.LiskovSubstitution.Good
{
    public class Admin : User, IPriveleged
    {
        public override void Login()
        {
            // login process
        }

        public void AdminPrivileges()
        {
            // admin privileges
        }
    }
}
