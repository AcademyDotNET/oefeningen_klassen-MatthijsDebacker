using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapGenerator.FileHandling
{
    class TextFileHandler : IFileHandler
    {
        public string ReadFromFile(string path, string name)
        {
            return "";
        }

        public void WriteToFile(string path, string name)
        {
            throw new NotImplementedException();
        }
    }
}
