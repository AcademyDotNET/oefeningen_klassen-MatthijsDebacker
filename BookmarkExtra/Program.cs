using System;

namespace BookmarkExtra
{
    class Program
    {
        static void Main(string[] args)
        {
            HiddenBookmark hbm = new HiddenBookmark();
            hbm.Name = "Youtube";
            hbm.URL = "www.youtube.com";
            BookMark bm = new BookMark();
            bm.Name = "Google";
            bm.URL = "www.google.com";
            Console.WriteLine(hbm);
            Console.WriteLine(bm);
        }
    }
}
