using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldWriter.Providers
{
    class ConsoleWriter: IMessageWriter
    {
        public bool WriteMessage(string message)
        {
            Console.WriteLine(message);
            return true;
        }

    }
}
