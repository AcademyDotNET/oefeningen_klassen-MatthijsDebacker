using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello World!";
            Console.WriteLine(str);

            Test(str);
            Console.WriteLine(str);
        }

        static void Test(string str)
        {
            str += " Hello World!";
        }
    }
}
