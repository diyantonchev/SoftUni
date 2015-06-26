using System;
using System.Text;

public abstract class Person
{
    private string firstName;
    private string lastName;
    private int age;

    public Person(string firstName, string lastName, int age)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age = age;
    }

    public string FirstName
    {
        get {return this.firstName ;}

        set 
        {
            if (string.IsNullOrEmpty(value.Trim()))
                throw new ArgumentException("Invalid firstName!");
            this.firstName = value;            
        }
    }

    public string LastName
    {
        get { return this.lastName; }

        set
        {
            if (string.IsNullOrEmpty(value.Trim()))
                throw new ArgumentException("Invalid firstName!");
            this.lastName = value;
        }
    }

    public int Age
    {
        get { return this.age;}

        set
        {
            if (value < 0)
                throw new ArgumentException("The age can not be negative!");
            this.age = value;
        } 
    }
    public override string ToString()
    {
        var person = new StringBuilder();

        person.AppendLine(string.Format("Name: {0} {1}",firstName, lastName));
        person.Append(string.Format("Age: {0}", age));
        return person.ToString();
    }
}
