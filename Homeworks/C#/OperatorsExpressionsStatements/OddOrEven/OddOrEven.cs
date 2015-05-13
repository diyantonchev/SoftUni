using System;
    class OddOrEvenI
    {
        static void Main()
        {
            Console.WriteLine("Write a integer!");

            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine("The integer is even.");
            } else if (n % 2 !=0) 
            {
                Console.WriteLine("The integer is odd.");
            }
        }
    }

