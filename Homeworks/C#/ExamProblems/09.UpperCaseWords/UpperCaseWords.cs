using System;
using System.Collections.Generic;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;

class UpperCaseWords
{
    static void Main()
    {
        string pattern = @"(?<![a-zA-Z])[A-Z]+(?![a-zA-Z])";
        Regex regex = new Regex(pattern);

        StringBuilder inputLine = new StringBuilder(Console.ReadLine());
        while (inputLine.ToString() != "END")
        {          
            MatchCollection matches = regex.Matches(inputLine.ToString());

            int offset = 0;
            foreach (Match match in matches)
            {
                string word = match.Value;
                string reversedWord = Reverse(word); 
         
                if (reversedWord == word)
                {
                    reversedWord = DoubleEachLetter(reversedWord);
                }

                int index = match.Index;
                inputLine.Remove(index + offset, word.Length);
                inputLine.Insert(index + offset, reversedWord);
                offset += reversedWord.Length - word.Length;
            }
            Console.WriteLine(SecurityElement.Escape(inputLine.ToString()));
            inputLine = new StringBuilder(Console.ReadLine());
        }
    }

    private static string DoubleEachLetter(string reversedWord)
    {
        var doubledWord = new StringBuilder();
        for (int i = 0; i < reversedWord.Length; i++)
        {
            doubledWord.Append(new string(reversedWord[i], 2));
        }
        return doubledWord.ToString();
    }

    private static string Reverse(string value)
    {
        var reversed = new StringBuilder();
        for (int i = value.Length - 1; i >= 0; i--)
        {
            reversed.Append(value[i]);
        }
        return reversed.ToString();
    }
 
}
