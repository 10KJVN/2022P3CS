using System;

namespace Les05GettersEnSetters
{
    class Program
    {
        private static void Main(string[] args)
        {
            var dog = new dog("MyDawg");
            dog.pet();
            var age = dog.getAge();
        }
    }
}
