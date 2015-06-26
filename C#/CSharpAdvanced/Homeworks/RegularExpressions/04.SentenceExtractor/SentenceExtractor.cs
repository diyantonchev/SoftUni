using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class SentenceExtractor
{
    static void Main()
    {
        string keyWord = Console.ReadLine();
        string text = Console.ReadLine();

        string pattern = @"\b[A-Z][\w\s\-\'\,\`]*[\.\?\!]";
        Regex rgx = new Regex(pattern);

        MatchCollection matches = rgx.Matches(text);

        foreach (var match in matches)
        {
            string[] sentenceExtract = match.ToString().Split(' ','.','!','?',',');
            foreach (var word in sentenceExtract)
            {
                if (word == keyWord)
                {
                    Console.WriteLine(match);
                }
            }

        }

    }
}
