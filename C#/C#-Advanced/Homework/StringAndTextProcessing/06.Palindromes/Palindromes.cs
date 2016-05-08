using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Palindromes
{
    static void Main()
    {
        string[] inputText = Console.ReadLine().Trim().Split(',', '.', '?', '!', ' ');
        var palindromes = new SortedSet<string>();

        for (int i = 0; i < inputText.Length; i++)
        {
            string reversed = ReverseString(inputText[i]);
            if (reversed == inputText[i])
            {
                if (!palindromes.Contains(inputText[i]))
                {
                    palindromes.Add(inputText[i]);
                }
            }
        }
        Console.WriteLine(string.Join(", ", palindromes));
    }
    static string ReverseString(string forReverse)
    {
        var reversed = new StringBuilder();

        for (int i = forReverse.Length - 1; i >= 0; i--)
        {
            reversed.Append(forReverse[i]);
        }
        return reversed.ToString();
    }
}