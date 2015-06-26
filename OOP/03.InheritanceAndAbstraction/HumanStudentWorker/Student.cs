using System;
using System.Text.RegularExpressions;

 public class Student : Human
    {
        const string pattern = @"^[\w]{5,10}$";

        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber) : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber; 
        }

        public string FacultyNumber
        {
            get { return this.facultyNumber;}

            set 
            {
                Regex regex = new Regex(pattern);
                Match match = regex.Match(value);
                if (string.IsNullOrEmpty(match.ToString()))
                {
                    throw new ArgumentException("The faculty number must be between 5-10 digits/letters.");
                }
                this.facultyNumber = value;
            }
        }
    }
