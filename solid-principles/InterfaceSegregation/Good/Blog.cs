namespace solid_principles.InterfaceSegregation.Good
{
    public class Blog : IBlogRead, IBlogWrite
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
