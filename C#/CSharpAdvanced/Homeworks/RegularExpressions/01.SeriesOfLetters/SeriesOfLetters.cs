using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        Regex rgx = new Regex("(.)\\1+");
        Console.WriteLine(rgx.Replace(input,"$1"));
    }
}
