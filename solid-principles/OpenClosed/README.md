# Open Closed
The open–closed principle: "Software entities ... should be open for extension, but closed for modification."

## Bad

```cs

    public enum SavingType
    {
        xml, json, txt
    }

    public class Log
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public SavingType savingType { get; set; }

        public void Add(Log log)
        {
            if (log.savingType == SavingType.xml)
            {
                // saving xml log
            }
            if (log.savingType == SavingType.json)
            {
                // saving json log
            }
            if (log.savingType == SavingType.txt)
            {
                // saving txt log
            }
        }
    }

```


## Good

```cs

    public class Log
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }

    public abstract class Logger
    {
        public abstract void Add(Log log);
    }

    public class XmlLogger : Logger
    {
        public override void Add(Log log)
        {
            // saving xml log
        }
    }

    public class JsonLogger : Logger
    {
        public override void Add(Log log)
        {
            // saving json log
        }
    }

    public class TxtLogger : Logger
    {
        public override void Add(Log log)
        {
            // saving txt log
        }
    }

```