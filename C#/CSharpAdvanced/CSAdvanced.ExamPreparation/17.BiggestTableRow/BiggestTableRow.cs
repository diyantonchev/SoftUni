using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class BiggestTableRow
{
    static void Main()
    {
        const string Pattern = @"<tr><td>.*<\/td><td>(.*?)<\/td><td>(.*?)<\/td><td>(.*?)<\/td><\/tr>";
        var regex = new Regex(Pattern);

        string input = Console.ReadLine();
        var htmlTable = new StringBuilder();
        while (input != "</table>")
        {
            htmlTable.AppendLine(input);
            input = Console.ReadLine();
        }

        MatchCollection matches = regex.Matches(htmlTable.ToString());

        double bestSum = double.MinValue;
        string bestStore1 = string.Empty;
        string bestStore2 = string.Empty;
        string bestStore3 = string.Empty;
        foreach (Match match in matches)
        {
            double currentStore1 = 0;
            double currentStore2 = 0;
            double currentStore3 = 0;

            if (match.Groups[1].Value != "-")
            {
                currentStore1 = double.Parse(match.Groups[1].Value);
            }

            if (match.Groups[2].Value != "-")
            {
                currentStore2 = double.Parse(match.Groups[2].Value);              
            }
                      
            if (match.Groups[3].Value != "-")
            {
                currentStore3 = double.Parse(match.Groups[3].Value);              
            }

            double sum = currentStore1 + currentStore2 + currentStore3;

            if (sum > bestSum)
            {
                bestSum = sum;
                bestStore1 = match.Groups[1].Value;
                bestStore2 = match.Groups[2].Value;
                bestStore3 = match.Groups[3].Value;
            }
        }
        var stores = new List<string>() {bestStore1,bestStore2,bestStore3};
        stores.RemoveAll(s => s == "-");
        List<string> output = new List<string>(stores.Where(store => !string.IsNullOrEmpty(store)));

        if (output.Any())
        {
            Console.WriteLine("{0} = {1}", bestSum, string.Join(" + ",output));
        }
        else
        {
            Console.WriteLine("no data");
        }
    }
}