using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookmarkExtra
{
    class HiddenBookmark : BookMark
    {
        public override void OpenSite()
        {
            if (URL == "")
            {
                Console.WriteLine("INVALID URL");
            }
            else
            {
                Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "-incognito " + URL);
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()}\t---HIDDEN---"; 
        }
    }
}
