using System;

    class NumberComparer
    {
        static void Main()
        {
            Console.WriteLine("Enter two numbers and I will tell you whis one is greater!");
            
            double number = double.Parse(Console.ReadLine());
            double numb = double.Parse(Console.ReadLine());

            double greater = Math.Max(number, numb);
            Console.WriteLine(greater + " is greater");


        }
    }

