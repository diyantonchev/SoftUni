using System;
using System.Collections.Generic;

class SumCards
{
    static void Main()
    {
        var cards = new Dictionary<string, int>
                        {
                            {"2",2},
                            {"3",3},
                            {"4",4},
                            {"5",5},
                            {"6",6},
                            {"7",7},
                            {"8",8},
                            {"9",9},
                            {"10",10},
                            {"J",12},
                            {"Q",13},
                            {"K",14},
                            {"A",15},
                        };
        var hand = Console.ReadLine().Split();
        int sum = 0;
        int bonusSum = 0;
        string previuosCard = hand[0];
        bool isEqualCard = false;
        int lastValue = 0;
       
        foreach (var card in hand)
        {
            bool sequenceEnds = true;
            string currentCard = card[0].ToString();

            if (currentCard == "1")
            {
                if (card[1] == '0')
                {
                    currentCard = "10";
                }
            }
            if (currentCard == previuosCard)
            {
                bonusSum += cards[currentCard];
                sequenceEnds = false;
                isEqualCard = true;
            }
            if (sequenceEnds && isEqualCard)
            {
                sum += bonusSum + cards[previuosCard];
                bonusSum = 0;
                isEqualCard = false;
            }
            sum += cards[currentCard];
            previuosCard = currentCard;
            lastValue = cards[currentCard];
        }
        if (isEqualCard)
        {
            sum += bonusSum + lastValue;
        }
        Console.WriteLine(sum);
    }
}