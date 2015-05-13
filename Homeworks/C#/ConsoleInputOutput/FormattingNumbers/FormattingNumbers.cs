using System;

class FormattingNumbers
    {
        static void Main()
        {
            Console.WriteLine("Enter 3 numbers!");

            ushort a = ushort.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());

            Console.WriteLine("|{0,-10:X}|{1,-10:0}|{2,10:F2}|{3,-10:F3}|",a, a, b, c);
        }
    }

