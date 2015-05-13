using System;

class Program
    {
        static void Main(string[] args)
        {
            int n = 5704; 
            int x = 109764;
            int y = 1234767;
            int z = 780;
            int v = 12345;

            bool checkN = (n / 100) % 10 == 7;
            Console.WriteLine(checkN); //true

            bool checkX = ((x / 100) % 100) % 10 == 7;
            Console.WriteLine(checkX); //true

            bool checkY = (((y / 100) % 1000) % 100) % 10 == 7;
            Console.WriteLine(checkY); //true

            bool checkZ = (z / 100) == 7;
            Console.WriteLine(checkZ); // true

            bool checkV = ((v / 100) % 100) % 10 == 7;
            Console.WriteLine(checkV); //false                  
        }
    }

