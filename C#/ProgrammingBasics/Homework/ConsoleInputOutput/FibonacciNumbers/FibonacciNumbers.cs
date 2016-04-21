using System;

namespace FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert a number!");

            try
            {
                 int n = int.Parse(Console.ReadLine());
                 int a = 0;
                 int b = 1;
 
                 for (int i = 0; i < n; i++)
                 {
                     int c = a;
                     a = b;
                     b += c ;
                     Console.Write("{0} ",a);
                 }
            }
            catch (FormatException)
            {

                Console.WriteLine("Invalid number."); ;
            }
           
        }
    }
}
