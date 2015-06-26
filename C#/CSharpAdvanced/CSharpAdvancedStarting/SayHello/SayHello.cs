using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayHello
{
    class SayHello
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your first name: ");
            string name = Console.ReadLine();
            PrintHello(name);

        }
        static void PrintHello(string name) 
        {
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}
