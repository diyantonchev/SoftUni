using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class PlusRemove
{
    static void Main()
    {
        string input = Console.ReadLine();
        var matrix = new List<char[]>();

        var outputMatrix = new List<char[]>();
        while (input != "END")
        {
            matrix.Add(input.ToLower().ToCharArray());
            outputMatrix.Add(input.ToCharArray());
            input = Console.ReadLine();
        }

        for (int row = 0; row < matrix.Count - 2; row++)
        {
           for (int col = 1; col < matrix[row].Length; col++)
            {
                char firstElement = matrix[row][col];
                char secondElement = matrix[Math.Min(row + 1, matrix.Count-1)][col - 1];
                char thirdElement = matrix[Math.Min(row + 1, matrix.Count-1)][Math.Min(col, matrix[row + 1].Length - 1)];
                char fourthElement = matrix[Math.Min(row + 1, matrix.Count-1)][Math.Min(col + 1, matrix[row + 1].Length - 1)];
                char fifthElement = matrix[Math.Min(row + 2, matrix.Count-1)][Math.Min(col, matrix[row + 2].Length - 1)];
               
                if ((firstElement == secondElement) && (secondElement == thirdElement) && (thirdElement == fourthElement) && (fourthElement == fifthElement))
                {
                    outputMatrix[row][col] = ' ';
                    outputMatrix[Math.Min(row + 1, matrix.Count - 1)][col - 1] = ' ';
                    outputMatrix[Math.Min(row + 1, matrix.Count - 1)][Math.Min(col, matrix[row + 1].Length - 1)] = ' ';
                    outputMatrix[Math.Min(row + 1, matrix.Count - 1)][Math.Min(col + 1, matrix[row + 1].Length - 1)] = ' ';
                    outputMatrix[Math.Min(row + 2, matrix.Count - 1)][Math.Min(col, matrix[row + 2].Length - 1)] = ' ';
                }
            }
        }
        foreach (var row in outputMatrix)
        {
            foreach (var cell in row)
            {
                if (cell != ' ')
                {
                    Console.Write(cell);
                }
            }
            Console.WriteLine();
        }

    }
}