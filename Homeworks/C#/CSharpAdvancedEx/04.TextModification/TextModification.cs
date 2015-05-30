using System;

class TextModification
{
    static void Main()
    {
        string text = Console.ReadLine();

        char[] letters = text.ToCharArray();

        for (int i = 0; i < letters.Length; i++)
        {
            if (letters[i] % 3 == 0)
            {
                letters[i] = Char.ToUpper(letters[i]);
            }
        }

        Console.WriteLine(letters);
    }
}

