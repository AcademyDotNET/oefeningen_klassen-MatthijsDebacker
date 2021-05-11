using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapGenerator.Logging
{
    interface ILogger
    {
        public void LogMessage(string message);

        public void LogWarning(string warning);

        public void LogError(string error);
    }
}
