using System;
using System.Text.RegularExpressions;

class ReplaceTag
{
    static void Main()
    {
        string input = "<ul>\n <li>\n  <a href=http://softuni.bg>SoftUni</a>\n </li>\n</ul>";
        string pattern = @"<a href=(http:\/\/\w+\.\w{2,})\>(\w+)\<\/a>";
        Regex rgx = new Regex(pattern);
        MatchCollection matches = rgx.Matches(input);
        foreach (Match match in matches)
        {
            string link = match.Groups[1].ToString();
            string text = match.Groups[2].ToString();
            string replacement = "[URL href=" + link + "]" + text + "[/URL]";
            input = rgx.Replace(input, replacement);
        }
        Console.WriteLine(input);
    }
}
