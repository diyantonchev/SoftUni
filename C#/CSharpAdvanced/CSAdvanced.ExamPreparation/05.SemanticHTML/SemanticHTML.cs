using System;
using System.Text.RegularExpressions;

public class SemanticHtml
{
    public static void Main()
    {
        const string OpeningTagPattern = @"<\s*div\s+(?<first>.*?)(?:id|class)\s*=\s*""(?<tagName>main|header|nav|article|section|aside|footer)""(?<second>.*?)\s*>";
        const string ClosingTagPattern = @"<\/div>\s*<!--\s*(?<tagName>main|header|nav|article|section|aside|footer)\s*-->";

        string input = Console.ReadLine();

        while (input != "END")
        {
            if (Regex.IsMatch(input, OpeningTagPattern))
            {
                var match = Regex.Match(input, OpeningTagPattern);

                string first = match.Groups["first"].ToString();
                string second = match.Groups["second"].ToString();
                string tagName = match.Groups["tagName"].ToString();

                string tag = string.Format("{0} {1} {2}", tagName, first, second);
                tag = Regex.Replace(tag, @"\s+", " ").Trim();
                tag = "<" + tag + ">";

                Console.WriteLine(tag);
            }
            else if (Regex.IsMatch(input, ClosingTagPattern))
            {
                var match = Regex.Match(input, ClosingTagPattern);

                string tagName = match.Groups["tagName"].ToString();

                string tag = string.Format("</{0}>", tagName);

                Console.WriteLine(tag);
            }
            else
            {
                Console.WriteLine(input);
            }

            input = Console.ReadLine();
        }
    }
}