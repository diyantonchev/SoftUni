using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

        var couples = new Dictionary<string, int>();

        int count = 0;
        for (int i = 1; i < input.Length; i++)
        {
            int first = input[i - 1];
            int second = input[i];
            string couple = first + " " + second;
            int occurrence = 1;

            if (!couples.ContainsKey(couple))
            {
                couples[couple] = occurrence;
                count++;
            }
            else
            {
                couples[couple] += 1;
                count++;
            }
        }
        foreach (var couple in couples)
        {
            double frequencies = ((double)couple.Value / count) * 100;
            Console.WriteLine("{0} -> {1:F2}%", couple.Key, frequencies);
        }
    }
}
