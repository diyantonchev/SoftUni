using System;
using System.Collections.Generic;

class XRemoval
{
    static void Main()
    {
        List<char[]> matrix = new List<char[]>();

        var inputLine = Console.ReadLine();

        var outputMatrix = new List<char[]>();
        while (inputLine != "END")
        {
            var charArray = inputLine.ToCharArray();
            outputMatrix.Add(charArray);
            matrix.Add(inputLine.ToLower().ToCharArray());
            inputLine = Console.ReadLine();
        }

        for (int row = 0; row < matrix.Count-2; row++)
        {
            var maxLength = Math.Min(matrix[row].Length - 2,
                Math.Min(matrix[row + 1].Length - 1, matrix[row + 2].Length - 2));
            for (int col = 0; col < maxLength; col++)
            {
                var firstElement = matrix[row][col];
                var secondElement = matrix[row][col + 2];
                var thirdElement= matrix[row + 1][col + 1];
                var fourthElement = matrix[row + 2][col];
                var fifthElement = matrix[row + 2][col + 2];
                
                if ((firstElement == secondElement) && (secondElement == thirdElement) && (thirdElement == fourthElement) && fourthElement == fifthElement )
                {
                    outputMatrix[row][col] = '\0';
                    outputMatrix[row][col + 2] = '\0';
                    outputMatrix[row + 1][col + 1] ='\0';
                    outputMatrix[row + 2][col] = '\0';
                    outputMatrix[row + 2][col + 2] = '\0';
                }
            }         
        }
        for (int row = 0; row < matrix.Count; row++)
        {
            for (int col = 0; col < matrix[row].Length; col++)
            {
                if (outputMatrix[row][col]!= '\0')
                {
                    Console.Write(outputMatrix[row][col]);
                }          
            }
            Console.WriteLine();
        }
    }
}

