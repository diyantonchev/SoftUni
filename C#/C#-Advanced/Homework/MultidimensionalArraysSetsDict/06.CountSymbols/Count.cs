using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Count
{
    static void Main()
    {
        string input = Console.ReadLine();
        var charArray = new List<char>();

        for (int i = 0; i < input.Length; i++)
        {
            charArray.Add(input[i]);
        }
        charArray.Sort();

        int occurrences = 0;
        int count = 0;
        for (int i = 0; i < charArray.Count; i+= occurrences)
        {
            for (int j = 0; j < charArray.Count; j++)
            {
                if (charArray[j] == charArray[i])
                {
                    count++;
                }
            }
            occurrences = count;
            Console.WriteLine("{0}: {1} time/s",charArray[i], occurrences);
            count = 0;
        }
    }
}
