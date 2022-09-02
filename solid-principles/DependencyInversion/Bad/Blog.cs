namespace solid_principles.DependencyInversion.Bad
{
    public class Blog
    {
        // high level class 
        public void Create()
        {
            Post post = new Post();
            post.CreatePost(true);
        }
    }
}
