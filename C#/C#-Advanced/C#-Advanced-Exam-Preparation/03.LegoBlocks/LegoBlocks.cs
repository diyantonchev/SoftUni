using System;
using System.Collections.Generic;
using System.Text;

class LegoBlocks
{
    static void Main()
    {
        int rows = int.Parse(Console.ReadLine());

        var firstArray = new List<string[]>();
        var secondArray = new List<string[]>();

        for (int i = 1; i <= rows * 2; i++)
        {
            if (i <= rows)
            {
                firstArray.Add(Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
            }
            else
            {
                secondArray.Add(Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
            }
        }

        if (!MatchCheck(firstArray, secondArray))
        {
            int cellsCount = CountCells(firstArray) + CountCells(secondArray);
            Console.WriteLine("The total number of cells is: {0}", cellsCount);
        }
        else
        {
            List<string[]> newArray = MergeArrays(firstArray, secondArray);
            PrintMatrix(newArray);
        }
    }

    private static bool MatchCheck(List<string[]> firstArray, List<string[]> secondArray)
    {
        if (firstArray.Count != secondArray.Count)
        {
            return false;
        }

        bool isEqual = true;
        int previousColsCount = firstArray[0].Length + secondArray[0].Length;

        for (int row = 0; row < firstArray.Count; row++)
        {
            int currentColsCount = firstArray[row].Length + secondArray[row].Length;

            if (currentColsCount != previousColsCount)
            {
                isEqual = false;
                break;
            }

            previousColsCount = currentColsCount;
        }

        return isEqual;
    }

    private static List<string[]> MergeArrays(List<string[]> firstArray, List<string[]> secondArray)
    {
        var newArray = new List<string[]>();
        int colsCount = firstArray[0].Length + secondArray[0].Length;

        for (int row = 0; row < firstArray.Count; row++)
        {
            newArray.Add(new string[colsCount]);

            for (int col = 0; col < colsCount; col++)
            {
                if (col < firstArray[row].Length)
                {
                    newArray[row][col] = firstArray[row][col];
                }
                else
                {
                    newArray[row][col] = secondArray[row][(colsCount - 1) - col];

                }
            }
        }

        return newArray;
    }

    private static int CountCells(List<string[]> jaggedArray)
    {
        int counter = 0;

        for (int row = 0; row < jaggedArray.Count; row++)
        {
            for (int col = 0; col < jaggedArray[row].Length; col++)
            {
                counter++;
            }
        }

        return counter;
    }

    private static void PrintMatrix(List<string[]> matrix)
    {
        var currentRow = new StringBuilder();
        var output = new StringBuilder();

        for (int row = 0; row < matrix.Count; row++)
        {
            currentRow.Append("[");
            for (int col = 0; col < matrix[row].Length; col++)
            {
                currentRow.AppendFormat("{0}, ", matrix[row][col]);
            }

            output.Append(currentRow.ToString().Trim().Trim(',')).AppendLine("]");
            currentRow.Clear();
        }

        Console.WriteLine(output.ToString().Trim());
    }
}