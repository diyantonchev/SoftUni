using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            DateTime ClockInfoFromSystem = DateTime.Now;
            Console.WriteLine(ClockInfoFromSystem.DayOfWeek.ToString());
            
            DayOfWeek today = DateTime.Today.DayOfWeek;
            Console.WriteLine(today);
        }
    }

