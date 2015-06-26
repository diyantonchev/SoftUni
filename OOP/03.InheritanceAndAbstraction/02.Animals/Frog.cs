using System;

public class Frog : Animal, ISoundProducible
{
    public Frog(string name, int age, string gender) : base(name, age, gender)
    {

    }

    public void ProduceSound()
    {
        Console.WriteLine("Wrabek");
    }
}
