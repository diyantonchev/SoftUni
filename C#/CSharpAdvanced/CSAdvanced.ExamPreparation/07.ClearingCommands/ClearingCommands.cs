using System;
using System.Collections.Generic;
using System.Security;

class ClearingCommands
{
    static void Main()
    {
        string input = Console.ReadLine();
        var matrix = new List<char[]>();

        while (input != "END")
        {
            matrix.Add(input.ToCharArray());
            input = Console.ReadLine();
        }

        CleanMatrix(matrix);

        PrintMatrix(matrix);
    }

    private static void CleanMatrix(List<char[]> matrix)
    {
        for (int row = 0; row < matrix.Count; row++)
        {
            for (int col = 0; col < matrix[row].Length; col++)
            {
                int index = 0;

                switch (matrix[row][col])
                {
                    case '^':
                        index = row - 1;
                        while (index >= 0 && !IsSpecialSymbol(matrix[index][col]))
                        {
                            matrix[index][col] = ' ';
                            index--;
                        }
                        break;
                    case 'v':
                        index = row + 1;
                        while (index < matrix.Count && !IsSpecialSymbol(matrix[index][col]))
                        {
                            matrix[index][col] = ' ';
                            index++;
                        }
                        break;
                    case '>':
                        index = col + 1;
                        while (index < matrix[row].Length && !IsSpecialSymbol(matrix[row][index]))
                        {
                            matrix[row][index] = ' ';
                            index++;
                        }
                        break;
                    case '<':
                        index = col - 1;
                        while (index >= 0 && !IsSpecialSymbol(matrix[row][index]))
                        {
                            matrix[row][index] = ' ';
                            index--;
                        }
                        break;
                }
            }
        }
    }

    private static bool IsSpecialSymbol(char symbol)
    {
        switch (symbol)
        {
            case '^':
                return true;
            case 'v':
                return true;
            case '>':
                return true;
            case '<':
                return true;
            default:
                return false;
        }
    }

    public static void PrintMatrix(List<char[]> matrix)
    {
        for (int row = 0; row < matrix.Count; row++)
        {
            Console.Write("<p>");
            for (int col = 0; col < matrix[row].Length; col++)
            {
                Console.Write(SecurityElement.Escape(matrix[row][col].ToString()));
            }
            Console.WriteLine("</p>");
        }
    }
}