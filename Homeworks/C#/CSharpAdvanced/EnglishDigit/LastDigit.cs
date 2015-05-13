using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishDigit
{
    class LastDigit
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            EnglishDigit(input);
        }

        static void EnglishDigit(string number) 
        {
            char lastDigit = number[number.Length - 1];

            switch (lastDigit)
            {
                case '1': Console.WriteLine("one"); 
                    break;
                case '2': Console.WriteLine("two");
                    break;
                case '3': Console.WriteLine("three");
                    break;
                case '4': Console.WriteLine("four");
                    break;
                case '5': Console.WriteLine("five");
                    break;
                case '6': Console.WriteLine("six");
                    break;
                case '7': Console.WriteLine("seven");
                    break;
                case '8': Console.WriteLine("eight");
                    break;
                case '9': Console.WriteLine("nine");
                    break;
                default:
                    break;
            }
            
        }
    }
}
