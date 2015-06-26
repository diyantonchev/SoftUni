using System;
using System.Text;

public class DropoutStudent : Student
{
    private string dropoutReason;

    public DropoutStudent(string firstName, string lastName, int age, int studentNumber, string dropoutReason)
        : base(firstName, lastName, age, studentNumber)
    {
        this.DropoutReason = dropoutReason;
    }

    public DropoutStudent(string firstname, string lastName, int age, int studentNumber, double? averageGrade, string dropoutReason)
        : base(firstname, lastName, age, studentNumber, averageGrade)
    {
        this.DropoutReason = dropoutReason;
    }

    public string DropoutReason
    {
        get { return this.dropoutReason; }

        set 
            {
                if (string.IsNullOrEmpty(value.Trim()))
                    throw new ArgumentException("Incorrect dropout reason!");
                this.dropoutReason = value;
            }
    }
    public override string ToString()
    {
        var dropoutStudent = new StringBuilder();

        dropoutStudent.AppendLine(base.ToString());
        dropoutStudent.Append(string.Format("Dropout reason: {0}", dropoutReason));

        return dropoutStudent.ToString();
    }
}
