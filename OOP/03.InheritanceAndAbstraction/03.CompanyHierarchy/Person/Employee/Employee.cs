using System;
using Interfaces;
using System.Text;

namespace Person.Employee
{
    public abstract class Employee : Person, IEmployee
    {
        private const double MinSalary = 1000;

        private double salary;
        private Department department;

        public Employee(string id, string firstName, string lastName)
            : base(id, firstName, lastName)
        {

        }

        public Employee(string id, string firstName, string lastName, double salary, Department department)
            : this(id, firstName, lastName)
        {
            this.Department = department;
            this.Salary = salary;
        }

        public double Salary 
        {
            get {return this. salary;}

            set
            {
                if (value < MinSalary)
                {
                    throw new ArgumentOutOfRangeException("Invalid salary.");
                }
                this.salary = value;
            }
        }

        public Department Department
        {
            get { return this.department; }

            set { this.department = value; }
        }

        public override string ToString()
        {
            var employee = new StringBuilder();
            employee.AppendLine(base.ToString());
            employee.AppendLine(string.Format("Department: {0}, Salary: {1}", this.Department, this.Salary));

            return employee.ToString();
        }
    }
}
