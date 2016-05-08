using System;
using System.Collections.Generic;

class LogsAgregator
{
    static void Main()
    {
        var logsAgregator = new SortedDictionary<string,SortedDictionary<double, SortedSet<string>>>();

        var duration = new SortedDictionary<string, double>();
        var ipAdress = new SortedDictionary<string, SortedSet<string>>();

        int n = int.Parse(Console.ReadLine());
      
        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();

            double currentNumber = double.Parse(input[2]);           

            if (!ipAdress.ContainsKey(input[1]))
            {
                ipAdress[input[1]] = new SortedSet<string>();
                ipAdress[input[1]].Add(input[0]);
            }
            else if (ipAdress.ContainsKey(input[1]))
            {              
                if (!ipAdress[input[1]].Contains(input[0]))
                {
                    ipAdress[input[1]].Add(input[0]);
                }
            }
            if (!duration.ContainsKey(input[1]))
            {
                duration[input[1]] = currentNumber;
            }
            else
            {
                duration[input[1]] += currentNumber;
            }
        }
        foreach (var nameAndDuration in duration)
        {
            foreach (var nameAndIp in ipAdress)
            {
                if (nameAndDuration.Key == nameAndIp.Key)
                {
                    string name = nameAndDuration.Key;
                    var ip = new SortedSet<string>();
                    ip = nameAndIp.Value;
                    double currentDuration = nameAndDuration.Value;
                    
                    var durationAndIP = new SortedDictionary<double, SortedSet<string>>();
                    durationAndIP[currentDuration] = ip;

                    logsAgregator[name] = durationAndIP;                    
                }
            }
        }
        foreach (var entry in logsAgregator)
        {
            var durationAndIP = new SortedDictionary<double, SortedSet<string>>();
            durationAndIP = entry.Value;
            Console.Write("{0}: ", entry.Key);
            foreach (var couple in durationAndIP)
            {
                Console.WriteLine("{0} [{1}]",couple.Key, string.Join(", ",couple.Value));
            }
        }
    }
}
