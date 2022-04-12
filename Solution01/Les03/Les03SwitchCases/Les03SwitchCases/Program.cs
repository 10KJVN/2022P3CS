using System;

int myInt = 0;

switch (myInt)
{
    case 0:
        Console.WriteLine("hallo, dit is case 0");
        break;

    case 1:
        if (myInt == 1)
        {
            Console.WriteLine("Dit is case 1");
        }
        else myInt = default(int);
        {
            Console.WriteLine(myInt);
        }
        break;

    default:
        Console.WriteLine("hallo, dit is de default case");
        break;
}
