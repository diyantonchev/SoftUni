using System;
using System.Linq;

class ToTheStars
{
    static void Main()
    {

        string[] firstStarSystem = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string firstStarSystemName = firstStarSystem[0].ToLower();
        double firstStartSystemX = double.Parse(firstStarSystem[1]);
        double firstStartSystemY = double.Parse(firstStarSystem[2]);

        string[] secondStarSystem = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string secondStarSystemName = secondStarSystem[0].ToLower();
        double secondStartSystemX = double.Parse(secondStarSystem[1]);
        double secondStartSystemY = double.Parse(secondStarSystem[2]);

        string[] thirdStarSystem = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string thirdStarSystemName = thirdStarSystem[0].ToLower();
        double thirdStartSystemX = double.Parse(thirdStarSystem[1]);
        double thirdStartSystemY = double.Parse(thirdStarSystem[2]);

        double[] normandyCoordinates = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(double.Parse)
            .ToArray();
        double normadyX = normandyCoordinates[0];
        double normadyY = normandyCoordinates[1];

        int turns = int.Parse(Console.ReadLine());

        for (int i = 0; i <= turns; i++)
        {
            bool isInsideFirstStarSystem =
                (normadyX >= firstStartSystemX - 1) &&
                (normadyX <= firstStartSystemX + 1) &&
                (normadyY >= firstStartSystemY - 1) &&
                (normadyY <= firstStartSystemY + 1);

            bool isInsideSecondStarSystem =
               (normadyX >= secondStartSystemX - 1) &&
               (normadyX <= secondStartSystemX + 1) &&
               (normadyY >= secondStartSystemY - 1) &&
               (normadyY <= secondStartSystemY + 1);

            bool isInsideThirdStarSystem =
               (normadyX >= thirdStartSystemX - 1) &&
               (normadyX <= thirdStartSystemX + 1) &&
               (normadyY >= thirdStartSystemY - 1) &&
               (normadyY <= thirdStartSystemY + 1);

            if (isInsideFirstStarSystem)
            {
                Console.WriteLine(firstStarSystemName);
            }
            else if (isInsideSecondStarSystem)
            {
                Console.WriteLine(secondStarSystemName);
            }
            else if (isInsideThirdStarSystem)
            {
                Console.WriteLine(thirdStarSystemName);
            }
            else
            {
                Console.WriteLine("space");
            }
            normadyY++;
        }
    }
}