using System;

namespace Exercise
{
    class PersonTest
    {
        static void Main()
        {
            //var coko = new Person("CokoCoka", "SmetkataZaToka", 40);
  
            //var zaprqn = new Person("Zaprqn", null, 20);
            //var mecho = new Person(string.Empty, "Mechkat", 41);
            //var pesho = new Person("NemojeBez", "Pesho", -5);

            try
            {
                var goshko = new Person("Gosho", "Pochivka", 123);
            }
            catch(ArgumentNullException exception)
            {
                Console.WriteLine("Exeption thrown {0}", exception.Message);
            }
            catch (ArgumentOutOfRangeException exception)
            {
                Console.WriteLine("Exeption thrown {0}", exception.Message);
            }

            try
            {
                var ceko = new Person(null, "Sifonq", 12);
            }
            catch (ArgumentNullException exception)
            {
                Console.WriteLine("Exeption thrown {0}", exception);
            }
            catch (ArgumentOutOfRangeException exception)
            {
                Console.WriteLine("Exeption thrown {0}", exception);
            }
        }
    }
}
