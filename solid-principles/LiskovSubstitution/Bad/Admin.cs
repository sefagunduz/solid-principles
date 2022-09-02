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
