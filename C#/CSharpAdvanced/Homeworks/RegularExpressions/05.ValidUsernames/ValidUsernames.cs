using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

    class ValidUsernames
    {
        static void Main()
        {
            string input = Console.ReadLine();
            var validUsernames = new List<string>();

            string pattern = @"[\w\d]{2,24}";
            Regex rgx = new Regex(pattern);        
            MatchCollection matches = rgx.Matches(input);

            foreach (var match in matches)
            {
                if (char.IsLetter(match.ToString().First()))
                {
                    validUsernames.Add(match.ToString());
                }
            }
            int sum = 0;
            int index = 0;
            for (int i = 0; i < validUsernames.Count-1; i++)
            {
                int currentSum = validUsernames[i].Length + validUsernames[i + 1].Length;
                if (currentSum > sum)
                {
                    sum = currentSum;
                    index = i;
                }
            }
            Console.WriteLine(validUsernames[index]);
            Console.WriteLine(validUsernames[index+1]);
        }
    }