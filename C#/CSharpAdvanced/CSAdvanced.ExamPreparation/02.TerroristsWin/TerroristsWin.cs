using System;
using System.Text;
using System.Text.RegularExpressions;

class TerroristsWin
{
    static void Main()
    {
        const string BombPatern = @"\|[^|]*\|";
        Regex bombMatcher = new Regex(BombPatern);

        var inputText = Console.ReadLine();
        var bombs = bombMatcher.Matches(inputText);

        var destroyedText = new StringBuilder(inputText);
        foreach (Match bomb in bombs)
        {
            int bombPower = 0;
            int sumOfCharacters = 0;
            
            for (int index = 1; index < bomb.Length-1; index++)
            {
                sumOfCharacters += bomb.ToString()[index];
            }

            char lastChar = sumOfCharacters.ToString()[sumOfCharacters.ToString().Length - 1];
            bombPower = int.Parse(lastChar.ToString());

            int bombsStartIndex = destroyedText.ToString().IndexOf("|", StringComparison.InvariantCulture);
            int startIndexForDestroy = Math.Max(bombsStartIndex - bombPower, 0);
            int endIndexForDestroy =
                Math.Min(bombsStartIndex + bomb.Length - 1 + bombPower, destroyedText.Length - 1);

            for (int index = startIndexForDestroy;  index <= endIndexForDestroy; index++)
            {
                destroyedText[index] = '.';
            }
        }    
        Console.WriteLine(destroyedText);
    }
}