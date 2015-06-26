using System;

   public class Kitten : Cat
    {
        public Kitten(string name, int age, string gender) : base(name, age, gender) 
        {
                
        }
        public override string Gender
        {
            get
            {
                return base.Gender;
            }
            set
            {
                if (value != "female" && value != "f")
                {
                    throw new ArgumentException("The kitten cannot have balls.");
                }
                base.Gender = value;
            }
        }
    }

