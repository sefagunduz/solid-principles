# Dependency Inversion
The dependency inversion principle: "Depend upon abstractions, [not] concretions.

## Bad

```cs

    public class Blog
    {
        // high level class 
        public void Create()
        {
            Post post = new Post();
            post.CreatePost(true);
        }
    }

    public class Post
    {
        // low level class
        public void CreatePost(bool picture)
        {
            // process
        }
    }

```

## Good

```cs

    public interface IContent
    {
        void CreatePost(bool picture);
    }

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

    public class Post : IContent
    {
        // low level class
        public void CreatePost(bool picture)
        {
            // process
        }
    }

```