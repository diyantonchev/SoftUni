using System;

 public class Tomcat : Cat
{
    public Tomcat(string name, int age, string gender)
        : base(name, age, gender)
    {
        
    }

    public override string Gender
    {
        get
        {
            return base.Gender;
        }
        set
        {
            if (value != "male" && value != "m")
            {
                throw new ArgumentException("The tomcat must have balls.");
            }
            base.Gender = value;
        }
    }

    public override void ProduceSound()
    {
        Console.WriteLine("Myauu, aма по-грубо");
    }
}
