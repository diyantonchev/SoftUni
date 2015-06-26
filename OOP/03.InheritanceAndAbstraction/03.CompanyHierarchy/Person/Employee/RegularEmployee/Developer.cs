using System;
using System.Collections.Generic;
using System.Text;
using Interfaces;

namespace Person.Employee
{
    public class Developer : RegularEmployee, IDeveloper
    {
        private ISet<Project> projects;

        public Developer(string id, string firstName, string lastName)
            : base(id, firstName, lastName)
        {

        }

        public Developer(string id, string firstName, string lastName, double salary, Department department)
            : base(id, firstName, lastName, salary, department)
        {

        }

        public Developer(string id, string firstName, string lastName, double salary, Department department, ISet<Project> projects)
            : this(id, firstName, lastName, salary, department)
        {
            this.Projects = projects;
        }

        public ISet<Project> Projects
        {
            get { return this.projects; }

            set { this.projects = value; }
        }
    }
}
