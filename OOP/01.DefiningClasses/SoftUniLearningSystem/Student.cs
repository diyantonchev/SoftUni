using System;
using System.Text;

 public abstract class Student : Person
{
    private int studentNumber;
    private double? averageGrade;

    public Student(string firstName, string lastName, int age, int studentNumber)
        : base(firstName, lastName, age)
    {
        this.StudentNumber = studentNumber;
    }

    public Student(string firstName, string lastName, int age, int studentNumber, double? averageGrade)
        : this (firstName, lastName, age, studentNumber) 
    {
        this.AverageGrade = averageGrade;
    }

    public int StudentNumber
    {
        get {return this.studentNumber;}
        set
        {
            if (value < 0 || value == 0)
                throw new ArgumentException("Student number cannot be negative or null!");
            this.studentNumber = value;
        }
    }

    public double? AverageGrade
    {
        get { return this.averageGrade; }
        set
        {
            if (value < 2 || value > 6)
                throw new ArgumentException("invalid grade!");
            this.averageGrade = value;
        }
    }

    public override string ToString()
    {
        var student = new StringBuilder();

        student.AppendLine(base.ToString());
        student.AppendLine(string.Format("Student number: {0}", studentNumber));
        if (averageGrade != null)
        {
            student.AppendLine(string.Format("Average grade: {0:F2}", averageGrade));
        }
        return student.ToString();
    }
}

