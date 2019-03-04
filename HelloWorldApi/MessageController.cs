using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorldWriter;

namespace HelloWorldApi
{
    public class MessageController
    {
        public bool WriteMessage(string action, string message)
        {
            var writer = MessageWriterFactory.GetWriter(action);
            return writer.WriteMessage(message);
        }
    }
}
