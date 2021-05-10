using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDSports
{
    class Logger : ILogger
    {
        public void LogToConsole(string message)
        {
            Console.WriteLine(message);
        }
    }
}
