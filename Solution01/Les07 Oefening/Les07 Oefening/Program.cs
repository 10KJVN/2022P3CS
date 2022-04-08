using System;

namespace Les07_Oefening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}

class Student
{
    public override string ToString()
    {
        return base.ToString();
    }
}

internal abstract class Skill
{
    internal string name;
    internal abstract void Use();
    internal virtual void OnActivate()
    {

    }
}

internal class FireBall : Skill
{
    internal override void Use()
    {
        throw new NotImplementedException();
        //spawn fireball!
    }

    internal override void OnActivate()
    {
        base.OnActivate();
        //Extra fire protection activated!
    }
}
