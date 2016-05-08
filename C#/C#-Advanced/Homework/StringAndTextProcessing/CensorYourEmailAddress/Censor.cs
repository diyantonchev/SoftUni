using System;
using System.Text;
using System.Text.RegularExpressions;

class Censor
{
    static void Main()
    {
        string[] eMailAddress = Console.ReadLine().Split('@');
        string eMail = Console.ReadLine();

        string username = eMailAddress[0];
        string domain = eMailAddress[1];

        string replacement = new string('*', username.Length);
        Regex rgx = new Regex(username);
        string result = rgx.Replace(eMail, replacement);

        Console.WriteLine();
        Console.WriteLine(result);
    }
}

