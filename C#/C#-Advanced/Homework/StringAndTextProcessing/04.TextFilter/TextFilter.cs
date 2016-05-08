using System;
using System.Text;
using System.Text.RegularExpressions;

class TextFilter
{
    static void Main()
    {
        string banList = Console.ReadLine();
        string text = Console.ReadLine();

        string[] banedWords = banList.Split(' ', ',');
        string result = string.Empty;

        string pattern = banedWords[0];
        Regex rgx = new Regex(pattern);
        string replacement = new string('*', pattern.Length);
        result = rgx.Replace(text, replacement);

        for (int i = 1; i < banedWords.Length; i++)
        {
            pattern = banedWords[i];
            rgx = new Regex(pattern);
            replacement = new string('*', pattern.Length);               
            result = rgx.Replace(result, replacement);
        }
        Console.WriteLine();
        Console.WriteLine(result);      
    }
}

