using System;

namespace _12.ExtractBitFromInt
{
    class ExtractBitFromInt
    {
        static void Main(string[] args)
        {
            int random = 10;
            int p = 7;

            int rRightP = random >> p;

            int extractBit = rRightP & 1;
            Console.WriteLine(extractBit);
        }
    }
}
