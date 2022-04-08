using System;
using System.Threading;

namespace Console3Les1
{
    internal class DateTime
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            System.DateTime dt = new System.DateTime();
            Console.WriteLine(dt.ToString());
            Console.WriteLine(dt.ToString());
            Console.WriteLine(System.DateTime.Now.ToString());
            while (true)
            {
                System.DateTime.Now.ToString();
                Console.WriteLine(System.DateTime.Now.ToString());
                Thread.Sleep(1000);
            }

        }
    }
}


