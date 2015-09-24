using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Olympics
{
    static void Main()
    {
        const string SplitPattern = @"\s*\|\s*";
        var regex = new Regex(SplitPattern);

        var report = new Dictionary<string, List<string>>();
         
        string input = Console.ReadLine();

        while (input != "report")
        {
            string[] info = regex.Split(input.Trim());

            string participant = Regex.Replace(info[0].Trim(),@"\s+", " " );
            string country = Regex.Replace(info[1].Trim(), @"\s+", " ");

            if (!report.ContainsKey(country))
            {
                report[country] = new List<string>();
            }
            report[country].Add(participant);

            input = Console.ReadLine();
        }

        var output = report.OrderByDescending(r => r.Value.Count);

        foreach (var data in output)
        {
            Console.WriteLine("{0} ({1} participants): {2} wins",
                data.Key,
                data.Value.Distinct().Count(),
                data.Value.Count
                );
        }
    }
}