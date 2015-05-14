using System;
using System.Text;

    class CountSubstrings
    {
        static void Main()
        {
            string inputString = Console.ReadLine();
            string searchString = Console.ReadLine();

            int count = 0;
            for (int i = 0; i < inputString.Length - searchString.Length + 1; i++)
            {
               int comparison = string.Compare(inputString.Substring(i, searchString.Length), searchString, true);
                if (comparison == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }

