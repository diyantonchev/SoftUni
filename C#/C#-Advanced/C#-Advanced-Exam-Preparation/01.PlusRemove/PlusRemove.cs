using System;
using System.Collections.Generic;

class PlusRemove
{
    static void Main()
    {
        string input = Console.ReadLine();

        var matrix = new List<List<char>>();

        while (input != "END")
        {
            var innerList = new List<char>(input.ToCharArray());
            matrix.Add(innerList);
            input = Console.ReadLine();
        }

        matrix = FindPlusShapes(matrix);

        PrintMatrix(matrix);
    }


    private static List<List<char>> FindPlusShapes(List<List<char>> matrix)
    {
        var newMatrix = new List<List<char>>();

        FillMatrix(newMatrix, matrix);

        for (int row = 1; row < matrix.Count - 1; row++)
        {
            for (int col = 1; col < matrix[row].Count - 1; col++)
            {
                if (col > matrix[row - 1].Count - 1 || col > matrix[row + 1].Count - 1)
                {
                    break;
                }
                string upperElement = matrix[row - 1][col].ToString().ToLower();
                string center = matrix[row][col].ToString().ToLower();
                string leftElement = matrix[row][col - 1].ToString().ToLower();
                string rightElement = matrix[row][col + 1].ToString().ToLower();
                string downElement = matrix[row + 1][col].ToString().ToLower();

                if (PlusShapeChek(upperElement, center, leftElement, rightElement, downElement))
                {
                    newMatrix[row][col] = ' ';
                    newMatrix[row - 1][col] = ' ';
                    newMatrix[row + 1][col] = ' ';
                    newMatrix[row][col - 1] = ' ';
                    newMatrix[row][col + 1] = ' ';
                }
            }
        }
        return newMatrix;
    }

    private static bool PlusShapeChek(string upperElement, string center, string leftElement, string rightElement, string downElement)
    {
        return upperElement == center && center == rightElement && rightElement == upperElement
               && rightElement == leftElement && leftElement == downElement && center == downElement
               && upperElement == center;
    }

    private static void FillMatrix(List<List<char>> newMatrix, List<List<char>> matrix)
    {
        for (int row = 0; row < matrix.Count; row++)
        {
            var currentCharList = new List<char>();
            for (int col = 0; col < matrix[row].Count; col++)
            {
                char currentElement = matrix[row][col];
                currentCharList.Add(currentElement);
            }
            newMatrix.Add(currentCharList);
        }
    }

    private static void PrintMatrix(List<List<char>> matrix)
    {
        for (int row = 0; row < matrix.Count; row++)
        {
            for (int col = 0; col < matrix[row].Count; col++)
            {
                if (matrix[row][col] != ' ')
                {
                    Console.Write(matrix[row][col]);
                }
            }
            Console.WriteLine();
        }
    }
}