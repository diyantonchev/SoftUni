using System;

    class BonusScore
    {
        static void Main()
        {
            int score = Int32.Parse(Console.ReadLine());
            
            if (score >= 1 && score <= 9)
            {
                if (score >= 1 && score <= 3)
                {
                    score *= 10;
                }
                if (score >= 4 && score <= 6)
                {
                    score *= 100;
                }
                if (score >=7 && score <= 9)
                {
                    score *= 1000;
                }
                Console.WriteLine(score);
            }
            else 
            {
                Console.WriteLine("Invalid score");
            }

        }
    }

