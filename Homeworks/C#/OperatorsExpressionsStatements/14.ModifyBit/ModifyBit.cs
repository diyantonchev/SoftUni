using System;

    class Program
    {
        static void Main()
        {
            int n = 15;
            int p = 2;
            int v = 0;
             
            int mask = ~(1 << p);
            int result = n & mask;
            Console.WriteLine(result);

            bool check = v == ((result >> p) & 1);
            Console.WriteLine(check);
        }
    }

