using System;
using System.Linq;
using System.Text.RegularExpressions;

class SumOfAllValues
{
    static void Main()
    {
        const string Keys = @"(?<startKey>^[A-Za-z_]*)(?=\d).*(?<=\d)(?<endKey>[A-Za-z_]*)";
        var keysMatcher = new Regex(Keys);

        string keysString = Console.ReadLine();
        string startKey = keysMatcher.Match(keysString).Groups["startKey"].Value;
        string endKey = keysMatcher.Match(keysString).Groups["endKey"].Value;

        if (string.IsNullOrEmpty(startKey) || string.IsNullOrEmpty(endKey))
        {
            Console.WriteLine("<p>A key is missing</p>");
            return;
        }

        string Pattern = string.Format("(?:{0}){1}(?:{2})", startKey, @"(\d*\.?\d+)", endKey);
        var numbersMatcher = new Regex(Pattern);

        string textString = Console.ReadLine();
        var matches = numbersMatcher.Matches(textString);

        var numbers = (from Match number in matches select double.Parse(number.Groups[1].Value)).ToList();

        if (numbers.Count == 0)
        {
            Console.WriteLine("<p>The total value is: <em>nothing</em></p>");
        }
        else
        {
            double sum = numbers.Sum();
            Console.WriteLine("<p>The total value is: <em>{0}</em></p>",sum);
        }
    }
}