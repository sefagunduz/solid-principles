using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_principles.LiskovSubstitution.Bad
{
    public abstract class User
    {
        public virtual void Login()
        {
            // login process
        }

        public virtual void AdminPrivileges()
        {
            // admin privileges
        }

    }
}
