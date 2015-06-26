using System;

class FromOneToN
    {
        static void Main()
        {
            Console.WriteLine("Insert a integer!");

            try
            {
                int n = int.Parse(Console.ReadLine());

                for (int i = 1; i <= n; i++) 
                {
                    Console.WriteLine(i);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number.");
            }

           
        }
    }

