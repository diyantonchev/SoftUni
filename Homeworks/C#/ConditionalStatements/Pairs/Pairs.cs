using System;

    class Pairs
    {
            static void Main(string[] args)
        {
            string n = Console.ReadLine();
            string[] line = n.Split(' ');

            int firstElement = int.Parse(line[0]);
            int secondElement = int.Parse(line[1]);

            int prevPair = firstElement + secondElement;
            int maxDiff = 0;

            for (int i = 2; i < line.Length - 1; i+=2)
            {   
                firstElement = int.Parse(line[i]);
                secondElement = int.Parse(line[i+1]);
                int lastPair = firstElement + secondElement;
                int diff = Math.Abs(lastPair - prevPair);
                maxDiff = Math.Max(diff, maxDiff);
                prevPair = lastPair;
            }
            if (maxDiff == 0)
            {
                Console.WriteLine("Yes, value={0}", prevPair);
            }
            else
            {
                Console.WriteLine("No, maxdiff={0}", maxDiff);
            }
        }
    }

