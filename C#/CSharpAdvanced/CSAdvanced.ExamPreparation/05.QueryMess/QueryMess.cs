using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class QueryMess
{
    static void Main()
    {
        var output = new Dictionary<string, List<string>>();

        string input = Console.ReadLine();

        while (input != "END")
        {
            string[] queryMess = input
                .Split(new char[] {'&'},StringSplitOptions.RemoveEmptyEntries);

            foreach (string couple in queryMess)
            {
                string[] currentCouple = couple
                    .Split(new char[]{'='}, StringSplitOptions.RemoveEmptyEntries);

                string currentKey = Regex.Replace(currentCouple[0], @"%20", " ").Replace(@"+", " ").Trim();
                
                if (currentKey.IndexOf('?') > 0)
                {
                    string[] editKey = currentKey.Split('?');

                    currentKey = editKey[1];
                }
  
                string currentValue = Regex.Replace(currentCouple[1], @"%20", " ").Replace(@"+", " ").Trim();
                currentValue = Regex.Replace(currentValue, @"\s+", " ");
                 
                if (!output.ContainsKey(currentKey))
                {
                    output[currentKey] = new List<string>();
                }
                output[currentKey].Add(currentValue);
            }

            foreach (var pair in output)
            {
                Console.Write("{0}=[{1}]",pair.Key, string.Join(", ", pair.Value));
            }

            output.Clear();
            Console.WriteLine();
            input = Console.ReadLine();
        }     
    }
}