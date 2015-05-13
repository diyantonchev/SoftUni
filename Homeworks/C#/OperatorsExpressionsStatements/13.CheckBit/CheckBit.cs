using System;

namespace _13.CheckBit
{
    class CheckBit
    {
        static void Main(string[] args)
        {
            int n = 7;
            int p = 4;
            int nRightP = n >> p;

            int bit = nRightP & 1;

            bool check = bit == 1;
            Console.WriteLine(check);
        }
    }
}
