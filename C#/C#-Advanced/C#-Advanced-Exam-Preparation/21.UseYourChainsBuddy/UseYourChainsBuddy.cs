using System;
using System.Text;
using System.Text.RegularExpressions;

class UseYourChainsBuddy
{
    static void Main()
    {
        const string Pattern = @"(?:<p>([^\/]*))";
        Regex regex = new Regex(Pattern);

        string htmlDocument = Console.ReadLine();

        var extractedMessage = new StringBuilder();
        string encryptedMessage = string.Empty;
        var matches = regex.Matches(htmlDocument);
        
        foreach (Match match in matches)
        {
            extractedMessage.Append(Regex.Replace(match.Groups[1].Value,@"[^a-z0-9]"," "));
        }
       
        encryptedMessage = Regex.Replace(extractedMessage.ToString(), @"\s+", " ").Trim();
        
        var decryptedMessage = new StringBuilder();
        for (int i = 0; i < encryptedMessage.Length; i++)
        {
            char currentSymbol = encryptedMessage[i];       
            if (char.IsLetter(currentSymbol))
            {
                if (currentSymbol < (char)110)
                {
                    currentSymbol = (char)((currentSymbol - 'a') + 'n');               
                }
                else
                {
                    currentSymbol = (char)((currentSymbol - 'n') + 'a');
                }
            }
            decryptedMessage.Append(currentSymbol);
        }
        Console.WriteLine(decryptedMessage);
    }
}
