using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumber
{
    class ReverseNumber
    {
        static void Main(string[] args)
        {
            Console.Write("Insert a number: ");
            decimal number = decimal.Parse(Console.ReadLine());
            decimal reversed = Reverse(number);
            Console.WriteLine(reversed);
        }
        static decimal Reverse(decimal number)
        {
            string reversedString = new string(number.ToString().Reverse().ToArray());
            decimal reversed = decimal.Parse(reversedString);
            return reversed;
        }
    }
}
