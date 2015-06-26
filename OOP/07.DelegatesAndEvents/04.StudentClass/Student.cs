using System;

public delegate void PropertyChangeEventHandler(object sender, PropertyChangedEventArgs args);

class Student
{
    public event PropertyChangeEventHandler PropertyChange;

    private const int MinStudentAge = 7;

    private string name;
    private int age;

    public Student(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }


    public string Name
    {
        get { return this.name; }

        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException("value", "Name cannot be null, empty or white space");
            }

            if (this.PropertyChange != null)
            {
                this.PropertyChange(this,
                    new PropertyChangedEventArgs("Name", this.Name, value));
            }

            this.name = value;
        }
    }

    public int Age
    {
        get { return this.age; }

        set
        {
            if (value < MinStudentAge)
            {
                throw new ArgumentOutOfRangeException("value", "Invalid student age.");
            }

            if (this.PropertyChange != null)
            {
                this.PropertyChange(this,
                    new PropertyChangedEventArgs("Age", this.Age, value));
            }

            this.age = value;
        }
    }
}