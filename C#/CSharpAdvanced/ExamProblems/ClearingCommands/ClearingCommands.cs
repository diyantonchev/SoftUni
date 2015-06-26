using System;
using System.Collections.Generic;
using System.Security;

class ClearingCommands
{
    static void Main()
    {
        const string commandSymbols = "<>^v";
        string inputLine = Console.ReadLine();
        List<char[]> matrix = new List<char[]>();

        while (inputLine != "END")
        {
            matrix.Add(inputLine.ToCharArray());
            inputLine = Console.ReadLine();
        }

        for (int row = 0; row < matrix.Count; row++)
        {
            for (int col = 0; col < matrix[row].Length; col++)
            {
                int currentRow = row;
                int currentCol = col;
                switch (matrix[row][col])
                {
                    case '<':
                        currentRow = row;
                        currentCol = col - 1;
                        while (currentCol >= 0 && !commandSymbols.Contains(matrix[currentRow][currentCol].ToString()))
                        {
                            matrix[currentRow][currentCol] = ' ';
                            currentCol--;
                        }
                        break;
                    case '>':
                        currentRow = row;
                        currentCol = col + 1;
                        while (currentCol <= matrix[row].Length - 1  && !commandSymbols.Contains(matrix[currentRow][currentCol].ToString()))
                        {
                            matrix[currentRow][currentCol] = ' ';
                            currentCol++;
                        }
                        break;
                    case 'v':
                        currentRow = row + 1;
                        currentCol = col;
                        while (currentRow <= matrix.Count - 1 && !commandSymbols.Contains(matrix[currentRow][currentCol].ToString()))
                        {
                            matrix[currentRow][currentCol] = ' ';
                            currentRow++;
                        }
                        break;
                    case '^':
                        currentRow = row - 1;
                        currentCol = col;
                        while (currentRow >= 0 && !commandSymbols.Contains(matrix[currentRow][currentCol].ToString()))
                        {
                            matrix[currentRow][currentCol] = ' ';
                            currentRow--;
                        }
                        break;
                }
            }
        }
        PrintMatrix(matrix);
    }
    private static void PrintMatrix(List<char[]> matrix)
    {
        for (int row = 0; row < matrix.Count; row++)
        {
            Console.WriteLine("<p>{0}</p>",SecurityElement.Escape(new string(matrix[row])));
        }
    }
}
