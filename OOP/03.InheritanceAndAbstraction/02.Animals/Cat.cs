using System;

public class Cat : Animal, ISoundProducible
{
    public Cat(string name, int age, string gender)
        : base(name, age, gender)
    {

    }

    public virtual void ProduceSound()
    {
        Console.WriteLine("Myau");
    }
}

