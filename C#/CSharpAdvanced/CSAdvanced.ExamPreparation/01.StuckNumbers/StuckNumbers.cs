using System;
using System.Collections.Generic;
using System.Linq;

internal class StuckNumbers
{
    private static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        var stuckNumbers = new List<string>();

        foreach (var a in numbers)
        {
            foreach (var b in numbers)
            {
                foreach (var c in numbers)
                {
                    stuckNumbers.AddRange(
                        from d in numbers 
                        where a != b && a != c & a != d && b != c && b != d && c != d
                        where a + b == c + d 
                        select string.Format("{0}|{1}=={2}|{3}", a, b, c, d));
                }
            }
        }
        Console.WriteLine(!stuckNumbers.Any() ? "No" : string.Join(Environment.NewLine, stuckNumbers));
    }
}