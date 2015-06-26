using System;
using System.Text;
  
class OnsiteStudent : CurrentStudent
    {
        private int numberOfVisits;

        public OnsiteStudent(string firstName, string lastName, int age, int studentNumber, string currentCourse, int numberOfVisits)
            : base (firstName, lastName, age, studentNumber, currentCourse)
        {
            this.NumberOfVisits = numberOfVisits;
        }

        public OnsiteStudent(string firstName, string lastName, int age, int studentNumber, double? averageGrade, string currentCourse, int numberOfVisits)
            : base(firstName, lastName, age, studentNumber,  averageGrade, currentCourse)
        {
            this.NumberOfVisits = numberOfVisits;
        }

        public int NumberOfVisits 
        {
            get {return this.numberOfVisits ;} 
            set
            {
                if (value < 0)
                    throw new ArgumentException("Number of visits can not be negative!");
                this.numberOfVisits = value;
            }
        }

        public override string ToString()
        {
            var onsiteStudent = new StringBuilder();

            onsiteStudent.AppendLine(base.ToString());
            onsiteStudent.Append(string.Format("Number of Visits: {0}", numberOfVisits));

            return onsiteStudent.ToString();
        }
    }