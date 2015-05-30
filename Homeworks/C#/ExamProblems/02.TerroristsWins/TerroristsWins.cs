using System;
using System.Text;
using System.Text.RegularExpressions;

class TerroristsWins
{
    static void Main()
    {
        string input = Console.ReadLine();
        char[] output = input.ToCharArray();

        bool bombHasBeenPlanted = true;
        while (bombHasBeenPlanted)
        {
            int startIndexBomb = 0;
            int endIndexBomb = 0;
            for (int i = 0; i < output.Length; i++)
            {
                if (output[i] == '|')
                {
                    startIndexBomb = i;
                    for (int j = startIndexBomb + 1; j < output.Length; j++)
                    {
                        if (output[j] == '|')
                        {
                            endIndexBomb = j;
                            break;
                        }
                    }
                    break;
                }
            }
            if (endIndexBomb == 0)
            {
                bombHasBeenPlanted = false;
                break;
            }
            var bombChars = new StringBuilder();
            for (int i = startIndexBomb + 1; i < endIndexBomb; i++)
            {
                bombChars.Append(output[i]);
            }

            int sum = 0;
            for (int i = 0; i < bombChars.Length; i++)
            {
                sum += bombChars[i];
            }
            string sumAsString = sum.ToString();
            int bombPower = int.Parse(sumAsString[sumAsString.Length - 1].ToString());

            int startIndex = Math.Max((startIndexBomb - bombPower), 0);
            int endIndex = Math.Min((endIndexBomb + bombPower), output.Length - 1);
            for (int i = startIndex; i <= endIndex; i++)
            {
                output[i] = '.';
            }
        }
        Console.WriteLine(string.Join("", output));
    }
}
