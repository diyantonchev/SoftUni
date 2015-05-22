using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.LongestSequence
{
    class LongestSequence
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var currentSequence = new List<int>();
            var longest = new List<int>();
            var sequence = new List<int>();

            int prev;
            int next;
            bool isIncr = false;

            for (int i = 0; i < input.Length; i++)
            {
                prev = input[i];
                next = input[Math.Min((i + 1), input.Length - 1)];
                if (prev < next)
                {
                    Console.Write("{0} ", prev);
                    isIncr = true;
                }
                else
                {
                    Console.WriteLine("{0} ", input[i]);
                }

                if (isIncr)
                {
                    currentSequence.Add(input[i]);
                }
                else
                {
                    currentSequence.Add(input[i]);
                    if (longest.Count < currentSequence.Count)
                    {
                        longest.Clear();
                        for (int j = 0; j < currentSequence.Count; j++)
                        {
                            longest.Add(currentSequence[j]);
                        }
                    }
                    currentSequence.Clear();
                }
                isIncr = false;
            }
            Console.WriteLine("Longest: {0}", string.Join(" ", longest));
        }
    }
}
