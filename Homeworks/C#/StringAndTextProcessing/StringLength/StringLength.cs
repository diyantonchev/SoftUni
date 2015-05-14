using System;
using System.Collections.Generic;
using System.Text;

class StringLength
{
    static void Main()
    {
        
        string input = Console.ReadLine();
        var output = new StringBuilder(20,20);

        if (input.Length > 20)
        {
           output.Append(input.Remove(20, input.Length - 20));
        }
        else if (input.Length < 20)
        {
            output.Append(input);
            output.Append(new string('*', 20 - input.Length));
        }
        Console.WriteLine(output);
    }
}
