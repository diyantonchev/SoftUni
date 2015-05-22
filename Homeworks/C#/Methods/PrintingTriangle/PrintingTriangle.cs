using System;

namespace PrintingTriangle
{
    class PrintingTriangle
    {
        static void Main()
        {
            int n = Read();
            Console.WriteLine();
            PrintTriangle(n);
        }
        static int Read()
        {
            int n = int.Parse(Console.ReadLine());
            return n;
        }

        static void Write(int number)
        {
            Console.Write("{0} ", number);
        }

        static void NewLine()
        {
            Console.WriteLine();
        }

        static void PrintTriangle(int n)
        {
            int count = 1;
            for (int i = 1; i <= n * 2 - 1; i++)
            {
                PrintRow(count);

                if (i < n)
                {
                    count++;
                }
                else
                {
                    count--;
                }
            }
        }

        static void PrintRow(int numb)
        {
            for (int i = 1; i <= numb; i++)
            {
                Write(i);
            }
            NewLine();
        }
    }
}
