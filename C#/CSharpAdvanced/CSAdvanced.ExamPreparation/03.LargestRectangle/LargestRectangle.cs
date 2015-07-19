using System;
using System.Linq;
using System.Text.RegularExpressions;

class LargestRectangle
{
    static void Main()
    {
        const string Pattern = @"\d+\s*x\s*\d+";
        var rectanglesMatcher = new Regex(Pattern);

        var input = Console.ReadLine();
        var rectangles = rectanglesMatcher.Matches(input);

        decimal totalArea = 0;
        for (int i = 0; i < rectangles.Count - 2; i++)
        {
            string firstRectangle = Regex.Replace(rectangles[i].ToString(), @"\s+", "");
            string secondRectangle = Regex.Replace(rectangles[i + 1].ToString(), @"\s+", "");
            string thirdRectangle = Regex.Replace(rectangles[i + 2].ToString(), @"\s+", "");

            int[] firstSides = firstRectangle.Split('x').Select(int.Parse).ToArray();
            int[] secondSides = secondRectangle.Split('x').Select(int.Parse).ToArray();
            int[] thirdSides = thirdRectangle.Split('x').Select(int.Parse).ToArray();
 
            int firstWidth = firstSides[0];
            int firstHeight = firstSides[1];

            int secondleWidth = secondSides[0];
            int secondleHeight = secondSides[1];

            int thirdWidth = thirdSides[0];
            int thirdHeight = thirdSides[1];

            decimal area =
                CalculateArea(firstWidth, firstHeight)
                + CalculateArea(secondleWidth, secondleHeight)
                + CalculateArea(thirdWidth, thirdHeight);

            if (area > totalArea)
            {
                totalArea = area;
            }
        }
        Console.WriteLine(totalArea);
    }

    private static decimal CalculateArea(int width, int height)
    {
        return width * (decimal)height;
    }
}