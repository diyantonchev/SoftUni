using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class CouplesFrequency
{
    static void Main()
    {
        var couples = new Dictionary<string,int>();

        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int couplesCounter = 0;
        for (int i = 0; i < numbers.Length - 1; i++)
        { 
            var couple = new StringBuilder(string.Format("{0} {1}",numbers[i],numbers[i+1]));
            if (!couples.ContainsKey(couple.ToString()))
            {
                couples[couple.ToString()] = 0;
            }
            couples[couple.ToString()] += 1;
            couplesCounter += 1;
        }

        foreach (var couple in couples)
        {
            double frequencyOfAppearance = ((double)couple.Value / couplesCounter) * 100;
            Console.WriteLine("{0} -> {1:F2}%",couple.Key,frequencyOfAppearance);
        }
    }
}