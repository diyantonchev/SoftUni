using System;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;

class UppercaseWords
{
    static void Main()
    {
        const string UppercaseWordsPattern = "(?<![a-zA-Z])[A-Z]+(?![a-zA-Z])";
        var uppercaseWordsMatcher = new Regex(UppercaseWordsPattern);

        var text = new StringBuilder(Console.ReadLine());
   
        while (text.ToString() != "END")
        {
            var upperCaseWords = uppercaseWordsMatcher.Matches(text.ToString());
           
            int offset = 0;
            foreach (Match match in upperCaseWords)
            {
                string word = match.Value;
                string reversedWord = ReverseWord(word);

                if (reversedWord == word)
                {
                    reversedWord = DoubleEachLetter(reversedWord);
                }

                int index = match.Index;
                text.Remove(index + offset, word.Length);
                text.Insert(index + offset, reversedWord);
                offset += reversedWord.Length - word.Length;
            }

            Console.WriteLine(SecurityElement.Escape(text.ToString()));
            text = new StringBuilder(Console.ReadLine());
        }
    }

    private static string DoubleEachLetter(string word)
    {
        var doubledLettersWord = new StringBuilder();
        for (int i = 0; i < word.Length; i++)
        {
            doubledLettersWord.AppendFormat("{0}{1}", word[i], word[i]);
        }

        return doubledLettersWord.ToString();
    }

    private static string ReverseWord(string word)
    {
        var reversedWord = new StringBuilder();
        for (int i = word.Length - 1; i >= 0; i--)
        {
            reversedWord.Append(word[i]);
        }

        return reversedWord.ToString();
    }
}