using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

class Enigma
{
    static void Main()
    {
        int lines = int.Parse(Console.ReadLine());
        var encryptedText = new List<string>();

        for (int i = 0; i < lines; i++)
        {
            encryptedText.Add(Console.ReadLine());
        }
        string decryptedText = RunEnigma(encryptedText);
        Console.WriteLine(decryptedText);
    }

    private static string RunEnigma(List<string> encryptedText)
    {
        const string Pattern = @"[^\d\s]";
        var regex = new Regex(Pattern);

        var decryptedMessage = new StringBuilder();
        foreach (var line in encryptedText)
        {
            var matches = regex.Matches(line);
            int m = matches.Count / 2;
            foreach (var letter in line)
            {
                char decryptedLetter = letter;
                bool isMatch = regex.IsMatch(letter.ToString());
                if (isMatch)
                {
                    decryptedLetter = (char)(letter + m);
                }
                decryptedMessage.Append(decryptedLetter);
            }
            decryptedMessage.AppendLine();
        }
        return decryptedMessage.ToString().Trim();
    }
}