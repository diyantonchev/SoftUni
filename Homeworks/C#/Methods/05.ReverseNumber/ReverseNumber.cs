using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ReverseNumber
{
    class ReverseNumber
    {
        static void Main(string[] args)
        {
            decimal number = decimal.Parse(Console.ReadLine());

            decimal reversed = Reverse(number);
            Console.WriteLine(reversed);
        }

        static decimal Reverse(decimal number)
        {
            string reversedString = new string(number.ToString().Reverse().ToArray());
            decimal reversedNumber = decimal.Parse(reversedString);
            return reversedNumber;
        }
    }
}
