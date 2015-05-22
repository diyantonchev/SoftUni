using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string phoneNumbers = "359-2-222-2222, +359/2/222/2222, +359-2 222 2222, +359 2-222-2222, +359-2-222-222, +359-2-222-22222, +359 2 222 2222, +359-2-222-2222";
        string pattern = @"\+359-2-\d{3}-\d{4}\b|\+359\s2\s\d{3}\s\d{4}\b";
        Regex rgx = new Regex(pattern);
        MatchCollection matches = rgx.Matches(phoneNumbers);

        foreach (var match in matches)
        {
            Console.WriteLine(match);
        }
    }
}

