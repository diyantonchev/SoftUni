using System;

    class House
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}{1}{0}", new string('.', n / 2), new string('*', 1));

            int count = 1;
            int count2 = 1;

            for (int i = 1; i < (n - 1) / 2; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}",
                      new string('.', (n / 2) - count),
                      new string('*', 1),
                      new string('.', count2));
                count++;
                count2 += 2;
            }
            Console.WriteLine("{0}", new string('*', n));

            for (int i = 1; i < (n - 1) / 2; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', n / 4),
                    new string('*', 1),
                    new string('.', (n - 2 - ((n / 4) * 2))));
            }
            Console.WriteLine("{0}{1}{0}", new string('.', n / 4), new string('*', n - ((n / 4) * 2)));
        }
    }

