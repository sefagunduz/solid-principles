# Interface Segregation
The interface segregation principle: "Clients should not be forced to depend upon interfaces that they do not use."

## Bad

```cs

    public interface IBlog
    {
        public void Write();
        public void Read();
    }

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

```


## Good

```cs

    public interface IBlogRead
    {
        public void Read();
    }

    public interface IBlogWrite
    {
        public void Write();
    }

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

```