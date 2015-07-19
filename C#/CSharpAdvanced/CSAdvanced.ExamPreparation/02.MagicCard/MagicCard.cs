using System;
using System.Collections.Generic;

class MagicCard
{
    static void Main()
    {
        var cards = new Dictionary<string, int>
                        {
                            {"2",20},
                            {"3",30},
                            {"4",40},
                            {"5",50},
                            {"6",60},
                            {"7",70},
                            {"8",80},
                            {"9",90},
                            {"10",100},
                            {"J",120},
                            {"Q",130},
                            {"K",140},
                            {"A",150},
                        };
        var hand = Console.ReadLine().Split();
        
        string oddOrEven = Console.ReadLine();
        int n = 0;
        if (oddOrEven == "odd")
        {
            n = 1;
        }    
        string magicCard = Console.ReadLine();
        string magicCardFace = magicCard[0].ToString();
        string magicCardSuit = magicCard[1].ToString();
        if (magicCard.Length == 3)
        {
            magicCardFace += magicCard[1];
            magicCardSuit = magicCard[2].ToString();
        }
       
        int sum = 0;
        for (int card = n; card < hand.Length; card += 2)
        {
            string currentCard = hand[card];
            string cardFace = currentCard[0].ToString();
            string cardSuit = currentCard[1].ToString();
            if (currentCard.Length == 3)
            {
                cardFace += currentCard[1];
                cardSuit = currentCard[2].ToString();
            }

            sum += cards[cardFace];
            if (cardSuit == magicCardSuit && cardFace != magicCardFace)
            {
                sum += cards[cardFace];
            }
            if (cardFace == magicCardFace && cardSuit != magicCardSuit)
            {
                sum += cards[cardFace] * 2;
            }
            if (cardFace == magicCardFace && cardSuit == magicCardSuit)
            {
                sum += cards[cardFace] * 5;
            }
        }
        Console.WriteLine(sum);
    }
}