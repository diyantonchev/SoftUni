using System;

class NumbersInInterval
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter two numbers!");

                int start = int.Parse(Console.ReadLine());
                int end = int.Parse(Console.ReadLine());
                int p = 0;

                for (int i = start; i <= end; i++)
                {
                    if (i % 5 == 0)
                    {
                        p++;
                    }
                }
                Console.WriteLine(p);
            }
            catch (FormatException) 
            {
                Console.WriteLine("Invalid number.");
            }
        }
    }

