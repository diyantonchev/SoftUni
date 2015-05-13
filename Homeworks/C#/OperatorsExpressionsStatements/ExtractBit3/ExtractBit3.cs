using System;

    class ExtractBit
     {
        static void Main(string[] args)
        {
            uint n = 343532;
            uint nRight = n >> 3;
            uint bit = nRight & 1;
            Console.WriteLine(bit);

        }
    }

