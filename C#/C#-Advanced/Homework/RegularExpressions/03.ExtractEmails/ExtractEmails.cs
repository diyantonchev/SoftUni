using System;
using System.Text.RegularExpressions;

class ExtractEmails
{
    static void Main()
    {
        string text = Console.ReadLine();

        string pattern = @"(?<=\s|^)[a-z0-9]+[_.-]?[a-z0-9]*@[a-z]+\-?[a-z]+(\.[a-z]+)+\b"; // stolen :)
        Regex rgx = new Regex(pattern);

        MatchCollection matches = rgx.Matches(text);

        foreach (var match in matches)
        {
            Console.WriteLine(match);
        }
    }
}