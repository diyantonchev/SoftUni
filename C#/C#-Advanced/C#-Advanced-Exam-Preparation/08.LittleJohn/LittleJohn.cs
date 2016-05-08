using System;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;

class LittleJohn
{
    private const string SmallArrow = ">----->";

    private const string MediumArrow = ">>----->";

    private const string LargeArrow = ">>>----->>";

    private const int InputRowsCount = 4;

    static void Main()
    {
        var input = new StringBuilder();
       
        for (int i = 1; i <= InputRowsCount; i++)
        {
            input.AppendFormat(" {0}",Console.ReadLine());
        }

        var arrowPattern = ">>>----->>|>>----->|>----->";
        var arrowsMatcher = new Regex(arrowPattern);

        MatchCollection arrows = arrowsMatcher.Matches(input.ToString());

        int smallArrowCount = 0;
        int mediumArrowCount = 0;
        int largeArrowCount = 0;

        foreach (var arrow in arrows)
        {
            if (arrow.ToString() == SmallArrow)
            {
                smallArrowCount++;
            }
            else if (arrow.ToString() == MediumArrow)
            {
                mediumArrowCount++;
            }
            else if(arrow.ToString() == LargeArrow)
            {
                largeArrowCount++;
            }
        }

        var concatenateArrowsCount = new StringBuilder();
        concatenateArrowsCount.AppendFormat("{0}{1}{2}", smallArrowCount,mediumArrowCount,largeArrowCount);

        int decimalConcatenateArrowsCount = int.Parse(concatenateArrowsCount.ToString());

        string binaryArrowsCount = Convert.ToString(decimalConcatenateArrowsCount,2);

        string reversedBinaryArrowsCount = new string( binaryArrowsCount.Reverse().ToArray());

        var concatenateBinaryArrowsCount = new StringBuilder();
        concatenateBinaryArrowsCount.AppendFormat("{0}{1}",binaryArrowsCount,reversedBinaryArrowsCount);

        int encryptedArrowsCount = Convert.ToInt32(concatenateBinaryArrowsCount.ToString(), 2);

        Console.WriteLine(encryptedArrowsCount);
    }
}