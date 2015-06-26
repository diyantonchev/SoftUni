using System;
using System.Text;

namespace Person.Employee
{
    public abstract class RegularEmployee : Employee
    {
        public RegularEmployee(string id, string firstName, string lastName) : base(id, firstName, lastName) 
        {
                
        }

        public RegularEmployee(string id, string firstName, string lastName, double salary, Department department)
            : base (id, firstName, lastName, salary, department)
        {

        }
    }
}
