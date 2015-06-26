using System;
 
public class Student
{
    private const double MinGrade = 2;
    private const double MaxGrade = 6;

    private string name;
    private double grade;

    public Student(string name, double grade)
    {
        this.Name = name;
        this.Grade = grade;
    }
    
    public string Name 
    {
        get { return this.name; }
        
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentNullException("The name cannot be null, empty or white space.");
            this.name = value;
        }
    }

    public double Grade 
    {
        get { return this.grade; }
        
        set
        {
            if (value < MinGrade || value > MaxGrade)
                throw new ArgumentOutOfRangeException("Grade must be in range [ 2 ]....[ 6 ]");
            this.grade = value;
        }
    }
}