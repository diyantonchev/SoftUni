using System;
using System.Text.RegularExpressions;

class LettersChangeNumbers
{
    static void Main()
    {
        const string Pattern = @"([a-zA-Z])([0-9]+)([a-zA-z])";
        Regex regex = new Regex(Pattern);

        MatchCollection strings = regex.Matches(Console.ReadLine());

        decimal sum = 0;

        foreach (Match str in strings)
        {
            char firstLetter = Convert.ToChar(str.Groups[1].Value);
            long number = int.Parse(str.Groups[2].Value);
            char secondLetter = Convert.ToChar(str.Groups[3].Value);

            decimal currentResult = 0;

            if (char.IsUpper(firstLetter))
            {
                currentResult = number / (decimal)((firstLetter - 'A') + 1);
            }
            else
            {
                currentResult = number * ((firstLetter - 'a') + 1);
            }

            if (char.IsUpper(secondLetter))
            {
                currentResult -= (secondLetter - 'A') + 1;
            }
            else
            {
                currentResult += (secondLetter - 'a') + 1;
            }

            sum += currentResult;
        }

        Console.WriteLine(sum.ToString("F2"));
    }
}
