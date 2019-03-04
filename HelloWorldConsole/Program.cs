using System;
///
namespace HelloWorldConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorldApi.MessageController api = new HelloWorldApi.MessageController();
            api.WriteMessage("console", "Hello World");
            Console.ReadLine();
        }
    }
}
