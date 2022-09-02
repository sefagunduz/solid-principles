namespace solid_principles.DependencyInversion.Good
{
    public class Post : IContent
    {
        // low level class
        public void CreatePost(bool picture)
        {
            // process
        }
    }
}
