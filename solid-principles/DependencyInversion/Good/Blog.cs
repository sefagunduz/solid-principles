namespace solid_principles.DependencyInversion.Good
{
    public class Blog
    {
        // high level class
        IContent content;
        public Blog()
        {
            content = new Post();
        }

        public void Create()
        {
            content.CreatePost(true);
        }

    }
}
