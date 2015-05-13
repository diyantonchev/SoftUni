using System;

    class MultiplicationSign
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            if (a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine("0");
            }
            else { 
                if ((a >= 1 && b >= 1 && c >= 1) || (a < 1 && b < 1 ^ c < 1) || (b < 1 && a < 1 ^ c < 1) || (c < 1 && a < 1 ^ b < 1))
                {
                    Console.WriteLine("+");
                }
                else if ((a < 1 && b < 1 && c < 1) || (a < 1 ^ b < 1 ^ c < 1))
                {
                    Console.WriteLine("-");
                }                            
            }
        }
    }

