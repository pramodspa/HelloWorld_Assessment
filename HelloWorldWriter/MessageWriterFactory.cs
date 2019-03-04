using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorldWriter.Providers;

namespace HelloWorldWriter
{
    public static class MessageWriterFactory
    {
        public static IMessageWriter GetWriter(string action)
        {
            IMessageWriter writer = null;
            switch(action)
            {
                case "console":
                    writer = new ConsoleWriter();
                    break;
                case "database":
                    writer = new DBWriter();
                    break;
            }
            return writer;
        }
    }
}
