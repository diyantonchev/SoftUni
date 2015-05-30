﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a year: ");
           int year =  int.Parse(Console.ReadLine());
           
            if (DateTime.IsLeapYear(year))
           {
               Console.WriteLine("The year is leap.");
           }
           else
           {
               Console.WriteLine("The year isn't leap.");
           }
        }
    }
}
