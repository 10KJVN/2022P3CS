using System;

namespace Les05Scopes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NewScope();
        }

        public static void NewScope()
        {
            Console.WriteLine("Let op dit is een nieuwe scope!");
            Console.WriteLine("Is dit een nieuwe scope?");
            float RandomVariable = 6.197f;
            Console.WriteLine(RandomVariable);
        }

    }
}
