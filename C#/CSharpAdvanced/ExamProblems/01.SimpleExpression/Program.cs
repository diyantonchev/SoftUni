using System;
using System.Linq;
using System.Text.RegularExpressions;
class SimpleExpression
{
    static void Main()
    {
        string input = Console.ReadLine();

        string pattern = @"[\d.]+";
        Regex regex = new Regex(pattern);

        MatchCollection matches = regex.Matches(input);
        var numbers = new decimal[matches.Count];

        for (int i = 0; i < matches.Count; i++)
        {
            numbers[i] = decimal.Parse(matches[i].ToString());
        }

        string patternOperators = @"[+-]+";
        Regex rgx = new Regex(patternOperators);

        MatchCollection matchOperators = rgx.Matches(input);

        var operators = new string[matchOperators.Count];
        for (int i = 0; i < matchOperators.Count; i++)
        {
            operators[i] = matchOperators[i].ToString();
        }

        decimal sum = numbers[0];
        for (int i = 0; i < operators.Length; i++)
        {
            if (operators[i] == "+")
            {
                sum += numbers[i + 1];
            }
            else
            {
                sum -= numbers[i + 1];
            }
        }
        Console.WriteLine("{0:F7}", sum);
    }
}

