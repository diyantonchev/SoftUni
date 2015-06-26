using System;
using System.Text.RegularExpressions;

public abstract class Animal
{
    const string Pattern = @"^m$|^f$|^male$|^female$";

    private string name;
    private int age;
    private string gender;

  public Animal(string name, int age, string gender)
    {
        this.Name = name;
        this.Age = age;
        this.Gender = gender;
    }


    public string Name
    {
        get { return this.name; }
        set
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentNullException("The name cannot be null or empty");
            this.name = value;
        }
    }

    public int Age
    {
        get { return this.age; }

        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException("The age cannot be negative.");
            this.age = value;
        }
    }

   virtual public string Gender
    {
        get { return this.gender; }

        set
        {
            Regex regex = new Regex(Pattern);
            Match match = regex.Match(value);
            if (string.IsNullOrEmpty(match.ToString()))
                throw new ArgumentException("The gender is not correct.");
            this.gender = value;
        }
    }
}
