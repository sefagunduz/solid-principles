using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_principles.LiskovSubstitution.Bad
{
    public class Admin : User
    {
        public override void Login()
        {
            // login process
        }

        public override void AdminPrivileges()
        {
            // admin privileges
        }
    }
}
