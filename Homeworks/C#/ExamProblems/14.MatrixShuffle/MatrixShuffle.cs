using System;
using System.Collections.Generic;

class MatrixShuffle
{
    static void Main()
    {
        int sizeOfMatrix = int.Parse(Console.ReadLine());
        string text = Console.ReadLine();

        char[,] matrix = new char[sizeOfMatrix, sizeOfMatrix];

        int index = 0;
        int filledRows = 0;
        int filledCols = 0;
        int emptyColsIndex = matrix.GetLength(1) - 1;
        int emptyRowsIndex = matrix.GetLength(0) - 1;

        while (index <= text.Length - 1)
        {        
            for (int col = filledCols; col <= emptyColsIndex; col++)
            {
                if (index > text.Length - 1)
                {
                    break;
                }
                matrix[filledRows, col] = text[index];
                index++;             
            }
            filledRows++;
            for (int row = filledRows; row < sizeOfMatrix; row++)
            {
                if (index > text.Length - 1)
                {
                    break;
                }
                matrix[row, emptyColsIndex] = text[index];
                index++;              
            }
            emptyColsIndex--;
            for (int col = emptyColsIndex; col <= filledCols; col--)
            {
                if (index > text.Length - 1)
                {
                    break;
                }
                matrix[emptyRowsIndex, col] = text[index];
                index++;
            }
            emptyRowsIndex--;
            for (int row = emptyRowsIndex; row <= filledRows; row--)
            {
                if (index > text.Length - 1)
                {
                    break;
                }
                matrix[row, filledCols] = text[index];
                index++;          
            }
            filledCols++;
        }
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write(matrix[row,col]);
            }
            Console.WriteLine();
        }
    }
}
