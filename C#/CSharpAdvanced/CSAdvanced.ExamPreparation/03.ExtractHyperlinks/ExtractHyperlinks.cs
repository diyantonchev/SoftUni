using System;
using System.Text;
using System.Text.RegularExpressions;

class ExtractHyperlinks
{

    private static void Main()
    {
        const string Pattern = @"<\s*a\s+(?:[^<>]*\s+)?href\s*=\s*(?:(?:'([^'>]+)')|(?:""([^"">]+)"")|([^\s>]+))[^>]*>";
        var hyperLinksMatcher = new Regex(Pattern);
        var htmlCode = new StringBuilder();

        var input = Console.ReadLine();

        while (input != "END")
        {
            htmlCode.AppendFormat(" {0}",input);
            input = Console.ReadLine();
        }

        var hyperLinks = hyperLinksMatcher.Matches(htmlCode.ToString());

        foreach (Match link in hyperLinks)
        {
            if (!string.IsNullOrEmpty(link.Groups[1].Value))
            {
                Console.WriteLine(link.Groups[1].Value);
            }
            else if (!string.IsNullOrEmpty(link.Groups[2].Value))
            {
                Console.WriteLine(link.Groups[2].Value);
            }
            else if (!string.IsNullOrEmpty(link.Groups[3].Value))
            {
                Console.WriteLine(link.Groups[3].Value);
            }
        }
    }
}