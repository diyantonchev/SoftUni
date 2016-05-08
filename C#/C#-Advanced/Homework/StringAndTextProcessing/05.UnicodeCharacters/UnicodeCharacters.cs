using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class UnicodeCharacters
{
    static void Main()
    {
        string input = Console.ReadLine();

        var unicodeChar = new StringBuilder();

        for (int character = 0; character < input.Length; character++)
        {
            unicodeChar.Append("\\u" + ((int)input[character]).ToString("X4"));
        }
        Console.WriteLine(unicodeChar.ToString());
    }
}

