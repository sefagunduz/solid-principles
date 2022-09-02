# Liskov Substitution
The Liskov substitution principle: "Functions that use pointers or references to base classes must be able to use objects of derived classes without knowing it." See also design by contract.

## Bad

```cs

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

    public class Personal : User
    {
        public override void Login()
        {
            // login process
        }

        public override void AdminPrivileges()
        {
            throw new NotImplementedException();
        }
    }

```


## Good

```cs

    public class User
    {
        public virtual void Login()
        {
            // login process
        }
    }

    public interface IPriveleged
    {
        public void AdminPrivileges();
    }

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

    public class Personal : User
    {
        public override void Login()
        {
            // login process
        }
    }

```