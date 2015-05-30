using System;

    class PowerNumber
    {
        static void Main()
        {
            double n = double.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            double result = Power(n, p, true);
            Console.WriteLine(result);
        }
        
        static double Power (double number, int power)
        {
            double result = 1;
            for (double i = 0; i < power; i++)
            {
                result *= number;             
            }
            return result;
        }

        static double Power(double number, int power, bool roundDown)
        {
            double result = Power(number, power);
            
            if (roundDown)
            {
                result = Math.Floor(result);
            }
            return result;
        }
  }
 


