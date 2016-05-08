using System;
using System.Linq;
using System.Text.RegularExpressions;

class SimpleExpression
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine();

        const string SignsPattern = @"[+-]+";
        var signsMatcher = new Regex(SignsPattern);

        const string NumbersPattern = @"[\d.]+";
        var numbersMatcher = new Regex(NumbersPattern);

        var matchedSigns = signsMatcher.Matches(input);
        var matchedNumbers = numbersMatcher.Matches(input);

        var numbers = (from Match number in matchedNumbers
                       select decimal.Parse(number.ToString())).ToList();

        var signs = (from Match sign in matchedSigns select sign.ToString()).ToList();

        decimal sum = numbers[0];
        for (int index = 1; index < numbers.Count; index++)
        {
            if (signs[index - 1] == "+")
            {
                sum += numbers[index];
            }
            else
            {
                sum -= numbers[index];
            }
        }
        Console.WriteLine(sum);
    }
}