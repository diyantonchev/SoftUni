using System;
using System.Globalization;
using System.Threading;

    class BeerTime
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
            Console.Write("Enter time \"hh:mm tt\": ");
            
            try
            {
                DateTime time = DateTime.Parse(Console.ReadLine());
                Console.WriteLine(time.ToString("hh:mm tt"));
                
                DateTime startTime = DateTime.Parse("1:00 PM");
                DateTime endTime = DateTime.Parse("3:00 PM");

                if (time >= startTime && time < endTime)
                {
                    Console.WriteLine("beer time");
                }
                else
                {
                    Console.WriteLine("non-beer time");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid time."); 
            }
        }
    }

