using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class LastDigit
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(GetLastDigitAsWord(number));
        }

        static string GetLastDigitAsWord(int numb)
        {
             string str = numb.ToString();
             string lastDigit = str[str.Length-1].ToString();
           
             switch (lastDigit)
             {
                 case "0": return "zero";
                 case "1": return "one";
                 case "2": return "two";
                 case "3": return "three";
                 case "4": return "four";
                 case "5": return "five";
                 case "6": return "six";
                 case "7": return "seven";
                 case "8": return "eight";
                 case "9": return "nine";
                 default: return "Invalid input.";                   
             }
        }
    }

