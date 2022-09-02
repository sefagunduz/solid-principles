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
