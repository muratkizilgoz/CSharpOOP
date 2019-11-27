using System;

namespace Extensibility
{
    public class ConsoleLogger : ILogger
    {
        public void LogError(string mesaj)
        {
            Console.WriteLine(mesaj);
        }

        public void LogInfo(string mesaj)
        {
            Console.WriteLine(mesaj);
        }
    }
}