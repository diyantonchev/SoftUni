using System;

    class SeniorTrainer : Trainer
    {
        public SeniorTrainer(string firstName, string lastName, int age)
        : base(firstName, lastName, age)
    {

    }

        public void DeleteCourse(string courseName)
        {
            Console.WriteLine("The course {0} has been deleted.", courseName);
        }
    }

