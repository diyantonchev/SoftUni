using System;
using System.Linq;
using System.Text.RegularExpressions;

class TheNumbers
{
    static void Main()
    {
        var numbers =
            Regex.Split(Console.ReadLine(), @"[^\d]+")
                .Where(x => x != string.Empty)
                .Select(number => string.Format("0x{0:X4}", int.Parse(number)));

        Console.WriteLine(string.Join("-", numbers));
    }
}