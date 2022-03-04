using System;

namespace Functies
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadLine();
            DateTime dt = new DateTime();
            Console.WriteLine(dt.ToString());
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt.ToString());
            Console.WriteLine(DateTime.Now.ToShortDateString());
        }
    }
}
