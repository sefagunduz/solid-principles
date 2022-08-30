using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_principles.OpenClosed.Good
{
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


}
