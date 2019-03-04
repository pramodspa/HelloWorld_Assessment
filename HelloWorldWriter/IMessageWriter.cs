using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldWriter
{
    public interface IMessageWriter
    {
       bool WriteMessage(string Message);
    }
}
