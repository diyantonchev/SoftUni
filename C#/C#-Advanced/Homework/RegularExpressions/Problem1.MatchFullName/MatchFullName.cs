using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class MatchFullName
{
    static void Main()
    {
        string names = "ivan ivanov, Ivan ivanov, ivan Ivanov, IVan Ivanov, Ivan Ivanov, Ivan IvAnov, Ivan  Ivanov";

        string pattern = @"\b[A-Z][a-z]{3}\s?[A-Z][a-z]{5}\b";
        Regex rgx = new Regex(pattern);

        Match match = rgx.Match(names);
        Console.WriteLine(match);

        MatchCollection matches = rgx.Matches(names);

        foreach (var matchName in matches)
        {
            Console.WriteLine(matchName);
        }
    }
}
