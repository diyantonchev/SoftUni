    class GraduateStudent : Student
    {
        public GraduateStudent(string firstName, string lastName, int age, int studentNumber)
            : base (firstName, lastName,age, studentNumber)
        {

        }

        public GraduateStudent(string firstName, string lastName, int age, int studentNumber, double? averageGrade)
            : base(firstName, lastName, age, studentNumber, averageGrade)
        {

        }
    }
