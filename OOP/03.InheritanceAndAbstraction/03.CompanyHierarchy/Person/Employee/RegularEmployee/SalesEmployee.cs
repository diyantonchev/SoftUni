using System;
using System.Collections.Generic;
using Interfaces;

namespace Person.Employee
{
    public class SalesEmployee : RegularEmployee, ISalesEmployee
    {
        private ISet<Sale> sales;

        public SalesEmployee(string id, string firstName, string lastName) : base (id,firstName,lastName)
        {

        }

        public SalesEmployee(string id, string firstName, string lastName, double salary, Department department)
            : base(id, firstName, lastName, salary,department)
        {
                
        }

        public SalesEmployee(string id, string firstName, string lastName, double salary, Department department, ISet<Sale> sales) 
            : this (id, firstName, lastName, salary,department)
        {
            this.Sales = sales;
        }


        public ISet<Sale> Sales
        {
            get { return this.sales; }
            
            set
            {
                this.sales = value;
            }
        }
    }
}