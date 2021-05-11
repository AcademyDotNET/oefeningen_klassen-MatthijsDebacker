using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapGenerator.Logging
{
    class ConsoleLogger : ILogger
    {
        public void LogError(string error)
        {
            Console.Write($"ERROR\n{error}\nERROR");
        }

        public void LogMessage(string message)
        {
            Console.Write($"MESSAGE\n{message}\nMESSAGE");
        }

        public void LogWarning(string warning)
        {
            Console.Write($"WARNING\n{warning}\nWARNING");
        }
    }
}
