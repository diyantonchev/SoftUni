using System;
using System.Collections.Generic;
using System.Text;

class ActivityTracker
{
    static void Main()
    {
        var data = new SortedDictionary<int, SortedDictionary<string, double>>();

        int inputLines = int.Parse(Console.ReadLine());

        for (int i = 0; i < inputLines; i++)
        {
            string[] input = Console.ReadLine().Split();

            string[] date = input[0].Split('/');
            string user = input[1];
            double distance = double.Parse(input[2]);

            int month = int.Parse(date[1]);
          
            if (!data.ContainsKey(month))
            {
                data[month] = new SortedDictionary<string, double>();
            }
            if (!data[month].ContainsKey(user))
            {
                data[month][user] = 0;
            }

            data[month][user] += distance;
        }

        var currentInfo = new StringBuilder();
        var output = new StringBuilder();
        foreach (var info in data)
        {
            currentInfo.AppendFormat("{0}: ",info.Key);          
            foreach (var user in info.Value)
            {
                currentInfo.AppendFormat("{0}({1}), ", user.Key, user.Value);
            }

            output.AppendLine(currentInfo.ToString().Trim(',', ' '));
            currentInfo.Clear();
        }

        Console.WriteLine(output.ToString().Trim());
    }
}