using System;
using System.Text.RegularExpressions;
using System.Text;
using System.Linq;

class LittleJohn
{
    static void Main()
    {
        const string smallArrow = ">----->";
        const string mediumArrow = ">>----->";
        const string largeArrow = ">>>----->>";

       StringBuilder sb = new StringBuilder();
        for (int i = 0; i < 4; i++)
			{
			  sb.AppendFormat(" {0}",Console.ReadLine());
			}
        string arrowPattern = @">>>----->>|>>----->|>----->";

        Regex arrowMatcher = new Regex(arrowPattern);

        var arrows = arrowMatcher.Matches(sb.ToString());

        int smallArrowCounter = 0;
        int mediumArrowCounter = 0;
        int largeArrowCounter = 0;

        foreach (var arrow in arrows)
        {
            if (arrow.ToString() == smallArrow)
            {
                smallArrowCounter++;
            }
            else if (arrow.ToString() == mediumArrow)
            {
                mediumArrowCounter++;
            }
            else if (arrow.ToString() == largeArrow)
            {
                largeArrowCounter++;
            }
        }

        StringBuilder concatenateCountDecimal = new StringBuilder();

        concatenateCountDecimal.Append(smallArrowCounter.ToString());
        concatenateCountDecimal.Append(mediumArrowCounter.ToString());
        concatenateCountDecimal.Append(largeArrowCounter.ToString());

        int concatenateInt = int.Parse(concatenateCountDecimal.ToString());
       
        string binary = Convert.ToString(concatenateInt, 2);

        string reversedBinary = new string(binary.Reverse().ToArray());

        string concatenateBinary = binary + reversedBinary;

        int result = Convert.ToInt32(concatenateBinary, 2);

        Console.WriteLine(result);
    }
}

