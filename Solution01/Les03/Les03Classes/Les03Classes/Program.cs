using System;

namespace Rekenmachine
{
    class Rekenmachine
    {
        public int Optellen(int Getal1, int Getal2)
        {
            return Getal1 + Getal2;
        }

        public int Vermenigvuldigen(int Getal1, int Getal2)
        {
            return Getal1 * Getal2;
        }

        public int Delen(int Getal1, int Getal2)
        {
            return Getal1 / Getal2;
        }

    }
  
    class Program
    {
        static void Main(string[] args)
        {
            Rekenmachine Rekenmachine = new Rekenmachine();

            Console.WriteLine(Rekenmachine.Optellen(2, 2)); //Rekenmachine is de class
            Console.WriteLine(Rekenmachine.Vermenigvuldigen(6, 9)); //Optelen, verm en delen de functies hierboven
            Console.WriteLine(Rekenmachine.Delen(25, 5)); //Return geeft het getal terug, console laat het zien

        }
    }
}
