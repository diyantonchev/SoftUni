using System;

 public abstract class Human
    {
       private string firstName;
       private string lastName;

       public Human(string firstName, string lastName)
       {
           this.FirstName = firstName;
           this.LastName = lastName;
       }

       public string FirstName 
       {
           get { return this.firstName;}

           set 
           {
               if (string.IsNullOrEmpty(value))
               {
                   throw new ArgumentNullException("The first name cannot be null ore empty.");
               }
               this.firstName = value;
           }
       }

       public string LastName
       {
           get { return this.lastName;}

           set 
           {
               if (string.IsNullOrEmpty(value))
               {
                   throw new ArgumentNullException("The last name cannot be null ore empty.");                 
               }
               this.lastName = value;
           }
       }
    }
