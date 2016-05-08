using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

internal class TextTransformer
{
    private static void Main()
    {
        const string Pattern = @"([$%&'])([^$%&']+)\1";
        var regex = new Regex(Pattern);

        var specialSymbols = new Dictionary<char, int> { { '$', 1 }, { '%', 2 }, { '&', 3 }, { '\'', 4 } };

        string input = Console.ReadLine();
        var nakovsGiberish = new StringBuilder();

        while (input != "burp")
        {
            nakovsGiberish.Append(input);

            input = Console.ReadLine();
        }

        string gibersh = Regex.Replace(nakovsGiberish.ToString(), @"\s+", " ");

        MatchCollection matches = regex.Matches(gibersh);

        var output = new StringBuilder();

        foreach (var match in matches)
        {
            string message = match.ToString();
            var specialSymbol = message[0];

            bool isEven = true;
            for (int i = 1; i < message.Length - 1; i++)
            {
                char currentSymblol = message[i];

                if (isEven)
                {
                    currentSymblol += (char)specialSymbols[specialSymbol];
                }
                else
                {
                    currentSymblol -= (char)specialSymbols[specialSymbol];
                }

                output.Append(currentSymblol);
                isEven = !isEven;
            }
            output.Append(" ");
        }

        Console.WriteLine(output.ToString().Trim());
    }
}