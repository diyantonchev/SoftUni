using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Text;
using System.Text.RegularExpressions;

class UserLogs
{
    static void Main()
    {
        const string Pattern = @"(?:\=)([^\s]+)";
        Regex regex = new Regex(Pattern);

        var userLogs = new SortedDictionary<string, Dictionary<string, int>>();

        string log = Console.ReadLine();
        
        while (log !="end")
        {
            MatchCollection info = regex.Matches(log);
            string ip = info[0].Groups[1].Value;
            string user = info[2].Groups[1].Value;
                
            if (!userLogs.ContainsKey(user))
            {
                userLogs[user] = new Dictionary<string,int>();
            }

            if (!userLogs[user].ContainsKey(ip))
            {
                userLogs[user][ip] = 0;
            }

            userLogs[user][ip] += 1;

            log = Console.ReadLine();
        }

        var currentUser = new StringBuilder();
        var output = new StringBuilder();
        
        foreach (var user in userLogs)
        {
            currentUser.AppendLine(string.Format("{0}: ",user.Key));
            
            foreach (var ip in user.Value)
            {
               currentUser.Append(string.Format("{0} => {1}, ",ip.Key,ip.Value)); 
            }

            output.Append(currentUser.ToString().Trim().Trim(',')).AppendLine(".");
            currentUser.Clear();
        }

        Console.WriteLine(output.ToString().Trim());
    }
}