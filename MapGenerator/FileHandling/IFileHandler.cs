using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapGenerator.FileHandling
{
    interface IFileHandler
    {
        public void WriteToFile(string path, string name);

        public string ReadFromFile(string path, string name);
    }
}
