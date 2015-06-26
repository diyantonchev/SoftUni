using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SequencesofEqualStrings
{
    class SequenceOfStrings
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            Console.Write("{0} ",input[0]);
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == input[i -1])
                {
                    Console.Write("{0} ",input[i]);
                }
                else
                {
                    Console.Write("\n\r{0} ",input[i]);
                }
            }
        }
    }
}
