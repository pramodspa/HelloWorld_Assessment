using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HelloWorldWriter;

namespace HelloWorldApi.Controllers
{
    public class MessageController : ApiController
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="messageAction"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public bool WriteMessage(string messageAction, string message )
        {
            var writer = MessageWriterFactory.GetWriter(messageAction);
            return writer.WriteMessage(message);
        }

    }
}
