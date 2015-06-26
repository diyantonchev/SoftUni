using System;
using System.Text;
using Interfaces;

namespace Person
{
    public abstract class Person : IPerson
    {
        private string id;
        private string firstName;
        private string lastName;

        public Person(string id, string firstName, string lastName)
        {
            this.ID = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string ID 
        {
            get { return this.id;}
            
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("value","The ID cannot be null, empty or white space.");
                }
                this.id = value;
            }
        }

        public string FirstName
        {
            get { return this.firstName; }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("value", "The first name cannot be null, empty or white space.");
                }
                this.firstName = value;
            }        
        }

        public string LastName 
        {
            get { return this.lastName; }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("value", "The last name cannot be null, empty or white space.");
                }
                this.lastName = value;
            }
        }

        public override string ToString()
        {
            var person = new StringBuilder();

            person.Append(string.Format("{0} {1} ID: {2}", this.FirstName, this.LastName, this.ID));

            return person.ToString();
        }
    }

}
