namespace solid_principles.LiskovSubstitution.Bad
{
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
}
