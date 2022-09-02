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
