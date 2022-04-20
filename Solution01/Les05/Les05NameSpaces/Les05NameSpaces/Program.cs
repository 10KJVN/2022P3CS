using System;
using gangshit;

namespace Les05NameSpaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chiraq Sosa = new ();
            Sosa.EmptyClip();
        }
    }

}

namespace gangshit
{
    public class Chiraq
    {
        public void EmptyClip()
        {
            string ChiefSosa = "Everybody love Sosa";
            Console.WriteLine(ChiefSosa);
        }
    }
}