using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ReversedString
{
    static void Main()
    {
        string input = Console.ReadLine();
        string reversed = ReverseString(input);
        Console.WriteLine(reversed);
    }
    static string ReverseString(string forReverse)
    {
        var reversed = new StringBuilder();

        for (int i = forReverse.Length - 1; i >=0; i--)
			{
                reversed.Append(forReverse[i]);                   
			}
        return reversed.ToString();
    }
}