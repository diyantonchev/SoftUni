using System;
using System.Collections.Generic;
using System.Linq;

class LogsAggregator
{
    static void Main()
    {
        var userIp = new Dictionary<string, SortedSet<string>>();
        var userDuration = new Dictionary<string, int>();
        int numberOfInputRows = int.Parse(Console.ReadLine());

        int counter = 0;
        while (counter < numberOfInputRows)
        {
            string[] logInformation = Console.ReadLine().Split();
            string ip = logInformation[0];
            string user = logInformation[1];
            int duration = int.Parse(logInformation[2]);

            if (!userIp.ContainsKey(user))
            {
                userIp[user] = new SortedSet<string>();
                userDuration[user] = 0;
            }
            userIp[user].Add(ip);
            userDuration[user] += duration;
            counter++;
        }

        var orderedInformation = userIp.OrderBy(user => user.Key);
        foreach (var information in orderedInformation)
        {
             Console.WriteLine("{0}: {1} [{2}]",
                 information.Key,
                 userDuration[information.Key],
                 string.Join(", ", information.Value));
        }
    }
}