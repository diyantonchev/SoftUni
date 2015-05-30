using System;

    class PrintingNumbers
    {
        static void Main() 
        {
           int minRange = int.Parse(Console.ReadLine());
           int maxRange = int.Parse(Console.ReadLine());

           PrintEvenNumbers(minRange, maxRange);
            
        }
     static void PrintEvenNumbers (int minRage, int MaxRange)
        {          
            for (int i = minRage; i <= MaxRange; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

