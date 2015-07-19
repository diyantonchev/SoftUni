using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

class PhoneNumbers
{
    static void Main()
    {
        const string Pattern = @"([A-Z][a-zA-Z]*)[^a-zA-Z0-9+]*(\+?\d[\d\(\)\/\,\.\-\s]{1,})";
        var regex = new Regex(Pattern);

        var phonebook = new Dictionary<string, string>();

        var input = Console.ReadLine();
        var text = new StringBuilder();

        while (input != "END")
        {
            text.Append(input);
            input = Console.ReadLine();
        }
        var phonebookMatches = regex.Matches(text.ToString());
      
        if (phonebookMatches.Count == 0)
        {
            Console.WriteLine("<p>No matches!</p>");
            return;
        }

        foreach (Match match in phonebookMatches)
        {
            string name = match.Groups[1].Value;
            string phone = match.Groups[2].Value;
            string currentPhone = Regex.Replace(phone, @"[\,\.\-\s()\/]+", "");
            phonebook[name] = currentPhone;
        }

        Console.Write("<ol>");
        foreach (var couple in phonebook)
        {
            var output = new StringBuilder();
            output.AppendFormat("<li><b>{0}:</b> {1}</li>", couple.Key, couple.Value);
            Console.Write(output);
        }
        Console.Write("</ol>");
    }
}