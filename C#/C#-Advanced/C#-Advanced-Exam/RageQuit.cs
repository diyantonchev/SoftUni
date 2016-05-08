using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class RageQuit
{
    static void Main()
    {
        const string Pattern = @"([^\d]+(?=\d))((?<=[^\d])[0-9]+)";
        var regex = new Regex(Pattern);

        string input = Console.ReadLine();

        var matches = regex.Matches(input);

        var currentResult = new StringBuilder();
        var result = new StringBuilder();
        foreach (Match match in matches)
        {
            string currentString = match.Groups[1].Value;
            int currentNumber = int.Parse(match.Groups[2].Value);

            for (int i = 0; i < currentNumber; i++)
            {
                currentResult.Append(currentString.ToUpper());
            }

            result.Append(currentResult);
            currentResult.Clear();
        }

       string count = new string(result.ToString().Distinct().ToArray());

       Console.WriteLine("Unique symbols used: {0}",count.Length);
        Console.WriteLine(result);
    }
}