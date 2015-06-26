using System;

class Person
{
    private string name;
    private int age;
    private string email;

    public Person(string name, int age, string email) : this(name, age)
    {
        this.Email = email;
    }

    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public string Name
    {
        get { return this.name; }
        set
        {
            if (String.IsNullOrEmpty(value))
                throw new ArgumentException("Invalid Name!");
            this.name = value;
        }
    }

    public int Age
    {
        get { return this.age; }
        set
        {
            if (value > 100 || value < 1)
                throw new ArgumentException("Invalid Age!");
            this.age = value;
        }
    }

    public string Email
    {
        get { return this.email; }
        set
        {
            if (!string.IsNullOrEmpty(value) && value.IndexOf('@') == -1)
                throw new ArgumentException("Invalid email!");
            this.email = value;
        }
    }

    public override string ToString()
    {
        return string.Format(
            "name: {0}, age: {1}, e-mail: {2}",
            this.name, 
            this.age,
            this.email ?? "no email");
    }
}
