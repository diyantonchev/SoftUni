using System;
using System.Collections.Generic;

class Sequence
{
    static void Main()
    {
        string[,] matrixOne = 
            {
                {"ha","fifi","ho","hi"},
                {"fo","ha","ha","xx"},
                {"xxx","ho","ha","xx"},
            };

        string[,] matrixTwo =
            {
                {"s","qq","s"},
                {"pp","pp","s"},
                {"pp","pp","s"},
            };

        var longestSequence = new List<string>();
        var column = new List<string>();
        var line = new List<string>();
        var diagonal = new List<string>();

        column = CheckColumn(matrixOne);
        line = CheckLine(matrixOne);
        diagonal = CheckDiagonal(matrixOne);

        longestSequence = GetLongestSequence(column, line, diagonal);
        Console.WriteLine(string.Join(", ", longestSequence));

        column = CheckColumn(matrixTwo);
        line = CheckLine(matrixTwo);
        diagonal = CheckDiagonal(matrixTwo);

        longestSequence = GetLongestSequence(column, line, diagonal);
        Console.WriteLine(string.Join(", ", longestSequence));    
    }

    static List<string> FillTheListWith(string element, int count)
    {
        var list = new List<string>();
        for (int i = 0; i <= count; i++)
        {
            list.Add(element);
        }
        return list;
    }

    static List<string> CheckColumn(string[,] matrix)
    {
        var column = new List<string>();
        string element = string.Empty;
        int count = 0;

        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                if (matrix[row, col] == matrix[row + 1, col])
                {
                    element = matrix[row, col];
                    count++;
                }
            }

            if (count >= column.Count)
            {
                column.Clear();
                column = FillTheListWith(element, count);
            }
            count = 0;
            element = string.Empty;
        }
        return column;
    }

    static List<string> CheckLine(string[,] matrix)
    {
        var line = new List<string>();
        string element = string.Empty;
        int count = 0;

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                if (matrix[row, col] == matrix[row, col + 1])
                {
                    element = matrix[row, col];
                    count++;
                }
            }

            if (count >= line.Count)
            {
                line.Clear();
                line = FillTheListWith(element, count);
            }
            count = 0;
            element = string.Empty;
        }
        return line;
    }

    static List<string> CheckDiagonal(string[,] matrix)
    {
        var diagonal = new List<string>();
        string element = string.Empty;
        int count = 0;

        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                for (int rows = row, cols = col; rows < matrix.GetLength(0) - 1 && cols < matrix.GetLength(1) - 1; rows++, cols++)
                {
                    if (matrix[rows, cols] == matrix[rows + 1, cols + 1])
                    {
                        element = matrix[rows, cols];
                        count++;
                    }
                }
                if (count >= diagonal.Count)
                {
                    diagonal.Clear();
                    diagonal = FillTheListWith(element, count);
                }
                element = string.Empty;
                count = 0;
            }
        }
        return diagonal;
    }

    static List<string> GetLongestSequence(List<string> column, List<string> line, List<string> diagonal)
    {
        if (column.Count > line.Count && column.Count > diagonal.Count )
        {
            return column;
        }
        else if (line.Count > column.Count && line.Count > diagonal.Count)
        {
            return line;   
        }
        else
        {
            return diagonal;
        }
    }
}

