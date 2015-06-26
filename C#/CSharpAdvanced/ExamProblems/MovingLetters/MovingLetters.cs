using System;
using System.Text;

class MovingLetters
{
    static void Main()
    {
        string[] inputMessage = Console.ReadLine().Split();

        int maxWordLength = 0;
        var strangeSequenceOfLetters = new StringBuilder();

        for (int i = 0; i < inputMessage.Length; i++)
        {
            if (inputMessage[i].Length > maxWordLength )
            {
                maxWordLength = inputMessage[i].Length;
            }
        }

        for (int i = 0; i < maxWordLength; i++)
        {
            for (int j = 0; j < inputMessage.Length; j++)
            {
                string currentWord = inputMessage[j];
                if (currentWord.Length > i)
                {
                    int lastLetterIndex = currentWord.Length - 1 - i;
                    strangeSequenceOfLetters.Append(currentWord[lastLetterIndex]);
                }
            }          
        }

        for (int i = 0; i < strangeSequenceOfLetters.Length; i++)
        {
            char currentSymbol = strangeSequenceOfLetters[i];
            int movementPositions = char.ToLower(currentSymbol) - 'a' + 1;
            int nextPositionIndex = (i + movementPositions) % strangeSequenceOfLetters.Length;
            strangeSequenceOfLetters.Remove(i, 1);
            strangeSequenceOfLetters.Insert(nextPositionIndex, currentSymbol);         
        }

        Console.WriteLine(strangeSequenceOfLetters);
    }
}