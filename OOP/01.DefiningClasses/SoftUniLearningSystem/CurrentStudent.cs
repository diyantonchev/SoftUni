using System;
using System.Text;

class  CurrentStudent : Student
{
    private string currentCourse;

    public CurrentStudent(string firstName, string lastName, int age, int studentNumber, string currentCourse)
        : base(firstName, lastName, age, studentNumber)
    {
        this.CurrentCourse = currentCourse;
    }

    public CurrentStudent(string firtName, string lastName, int age, int studentNumber, double? averageGrade, string currentCourse)
        : base(firtName, lastName, age, studentNumber, averageGrade)
    {
        this.CurrentCourse = currentCourse;
    }

    public string CurrentCourse
    {
        get { return this.currentCourse; }

        set
             {
                 if (string.IsNullOrEmpty(value.Trim()))
                     throw new ArgumentException("Invalid current course name!");
                 this.currentCourse = value;
             }
    }
    public override string ToString()
    {
        var currentStudent = new StringBuilder();

        currentStudent.Append(base.ToString());
        currentStudent.AppendLine(string.Format("Current course: {0}", currentCourse));

        return currentStudent.ToString();
    }
}
