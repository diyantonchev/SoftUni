using System;
using System.Collections.Generic;

class NightLife
{
    static void Main()
    {
        var data = new Dictionary<string, SortedDictionary<string, SortedSet<string>>>();

        string city = string.Empty;
        string venue = string.Empty;
        var performer = string.Empty;

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "END")
            {
                break;
            }
            string[] inputArray = input.Split(';');

            city = inputArray[0];
            venue = inputArray[1];
            performer = inputArray[2];

            if (!data.ContainsKey(city))
            {
                data[city] = new SortedDictionary<string, SortedSet<string>>();
            }
            if (!data[city].ContainsKey(venue))
            {
                data[city][venue] = new SortedSet<string>();
            }
            data[city][venue].Add(performer);          
        }
        foreach (var cities in data)
        {
            Console.WriteLine(cities.Key);
            foreach (var venueWithPerformers in cities.Value)
            {
                Console.WriteLine("->{0}: {1}",
                    venueWithPerformers.Key,string.Join(", ",venueWithPerformers.Value));
            }
        }
    }
}

