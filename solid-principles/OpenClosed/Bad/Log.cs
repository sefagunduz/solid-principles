namespace solid_principles.OpenClosed.Bad
{
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
}
