using System;
using System.Collections.Generic;
using Interfaces;

namespace Person.Employee
{
    public class Manager : Employee, IManager
    {
        private ISet<Employee> employees;

        public Manager(string id, string firstName, string lastName)
            : base(id, firstName, lastName)
        {

        }

        public Manager(string id, string firstName, string lastName, double salary, Department department)
            : base(id, firstName, lastName, salary, department)
        {

        }

        public Manager(string id, string firstName, string lastName, double salary, Department department, ISet<Employee> employees)
            :base (id, firstName, lastName, salary, department)
        {
            this.Employees = employees;
        }

        public ISet<Employee> Employees 
        {
            get { return this.employees; }
            
            set
            {
                this.employees = value;
            }
        }
    }
}