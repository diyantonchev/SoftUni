  public class Trainer : Person
    {
      public Trainer(string firstName, string lastName, int age) : base(firstName, lastName, age)
      {

      }

      public  void CreateCourse (string courseName)
      {
          System.Console.WriteLine("The course {0} has been created.", courseName);
      }
    }

