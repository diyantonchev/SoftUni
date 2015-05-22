using System;
using System.Collections.Generic;
using System.Text;

class MatrixRotation
{
    static void Main()
    {
        string[] inputDegrees = Console.ReadLine().Split('(', ')');

        int rotationDegrees = int.Parse(inputDegrees[1]);
        var lineOfTheMatrix = new List<string>();
        string inputLine = Console.ReadLine();

        while (inputLine != "END")
        {
            lineOfTheMatrix.Add(inputLine);
            inputLine = Console.ReadLine();
        }
        int maxLength = 0;
        foreach (var stringElement in lineOfTheMatrix)
        {
            if (stringElement.Length > maxLength)
            {
                maxLength = stringElement.Length;
            }
        }
        var matrix = new char[lineOfTheMatrix.Count, maxLength];
        matrix = FillMatrix(matrix, lineOfTheMatrix);

        int rotation = rotationDegrees / 90;
        for (int i = 1; i <= rotation; i++)
        {
            matrix = RotateMatrix(matrix);       
        }      
        PrintMatrix(matrix);
    }
    static char[,] RotateMatrix(char[,] matrix)
    {
        char[,] newMatrix = new char[matrix.GetLength(1), matrix.GetLength(0)];

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
            {
                newMatrix[col, row] = matrix[row, col];
            }
        }
        char[,] rotatedMatrix = new char[newMatrix.GetLength(0), newMatrix.GetLength(1)];
        for (int row = 0; row < newMatrix.GetLength(0); row++)
        {
            int newCol = 0;
            for (int col = newMatrix.GetLength(1) - 1; col >= 0; col--)
            {
                rotatedMatrix[row, newCol] = newMatrix[row, col];
                newCol++;
            }
        }
        return rotatedMatrix;
    }
    static char[,] FillMatrix(char[,] matrix, List<string> list)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            string temp = list[row];
            StringBuilder template = new StringBuilder();
            template.Append(temp);
            while (template.Length < matrix.GetLength(1))
            {
                template.Append(' ');
            }
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = template[col];
            }
        }
        return matrix;
    }
    static void PrintMatrix(char[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write(matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}
