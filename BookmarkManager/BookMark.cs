using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookmarkManager
{
    class BookMark
    {
        public string Name { get; set; }
        public string URL { get; set; }

        public void OpenSite()
        {
            if (URL == "")
            {
                Console.WriteLine("INVALID URL");
            }
            else
            {
                Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", URL);
            }
        }
    }
}
