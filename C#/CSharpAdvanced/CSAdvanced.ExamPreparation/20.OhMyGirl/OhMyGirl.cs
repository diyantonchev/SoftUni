using System;
using System.Text;
using System.Text.RegularExpressions;

class OhMyGirl
{
    static void Main()
    {
        string inputKey = Console.ReadLine();
        string inputText = Console.ReadLine();
        var text = new StringBuilder();

        while (inputText != "END")
        {
            text.Append(inputText);
            inputText = Console.ReadLine();
        }

        string wordPattern = @"[A-Za-z]*";
        string digitPattern = @"[0-9]*";
        string firstSymbol = inputKey.Substring(0, 1);
        string lastSymbol = inputKey.Substring(inputKey.Length - 1, 1);
        string forReplace = inputKey.Substring(1, inputKey.Length - 2);

        //string replacement = Regex.Replace(forReplace, @"\W", @"[\W]*");
        //replacement = Regex.Replace(replacement, @"[A-Za-z]", wordPattern);
        //replacement = Regex.Replace(replacement, @"\d", digitPattern);
        

        //string pattern = string.Format("(?:{0}{1}{2}{3}{0}{1}{2})"
        //    , firstSymbol, replacement, lastSymbol, @"\s*([\w,]+)\s*");

        string pattern = @"(?:a[0-9]*#""[A-Za-z]*5)\s*([\w,]+)\s*(?:a[0-9]*#""[A-Za-z]*5)";
        
        var regex = new Regex(pattern);
        var matches =  regex.Matches(inputText);

        StringBuilder output = new StringBuilder();
        foreach (Match match in matches)
        {
            output.Append(match.Value);
        }

        Console.WriteLine(output);
    }
}