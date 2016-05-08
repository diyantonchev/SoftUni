using System;
using System.Text;
using System.Text.RegularExpressions;

class MatrixShuffle
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        string text = Console.ReadLine();

        char[,] matrix = new char[size, size];

        FillSpiralMatrix(matrix, text, size);

        string sentence = ExtractSentenceFromMatrix(matrix);

        Console.WriteLine(
            isPalindrome(sentence)
                ? "<div style='background-color:#4FE000'>{0}</div>"
                : "<div style='background-color:#E0000F'>{0}</div>",
            sentence);
    }

    static void FillSpiralMatrix(char[,] matrix, string text, int size)
    {
        int currentRow = 0;
        int currentCol = 0;
        int currentIndex = 0;

        while (currentIndex < text.Length)
        {
            while (currentCol < size && matrix[currentRow, currentCol] == '\0')
            {
                matrix[currentRow, currentCol] = text[currentIndex];

                currentIndex++;
                currentCol++;
            }

            currentCol--;
            currentRow++;

            if (currentIndex > text.Length - 1)
            {
                break;
            }

            while (currentRow < size && matrix[currentRow, currentCol] == '\0')
            {
                matrix[currentRow, currentCol] = text[currentIndex];

                currentIndex++;
                currentRow++;
            }

            currentRow--;
            currentCol--;

            if (currentIndex > text.Length - 1)
            {
                break;
            }

            while (currentCol >= 0 && matrix[currentRow, currentCol] == '\0')
            {
                matrix[currentRow, currentCol] = text[currentIndex];

                currentIndex++;
                currentCol--;
            }

            currentCol++;
            currentRow--;

            if (currentIndex > text.Length - 1)
            {
                break;
            }

            while (currentRow >= 0 && matrix[currentRow, currentCol] == '\0')
            {
                matrix[currentRow, currentCol] = text[currentIndex];

                currentIndex++;
                currentRow--;
            }

            currentRow++;
            currentCol++;
        }
    }

    static string ExtractSentenceFromMatrix(char[,] matrix)
    {
        var firstPart = new StringBuilder();
        var secondPart = new StringBuilder();
               
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (row % 2 == 0 && col % 2 == 0)
                {
                    firstPart.Append(matrix[row, col]);
                }
                else if(row % 2 != 0 && col % 2 != 0)
                {
                    firstPart.Append(matrix[row, col]);
                }
                else
                {
                    secondPart.Append(matrix[row, col]);
                }
            }
        }

        return firstPart.Append(secondPart).ToString();
    }

    private static bool isPalindrome(string text)
    {
        string sentence = Regex.Replace(text.ToLower(), @"[^\w]","");

        var reversedSentence = new StringBuilder();
        for (int i = sentence.Length - 1; i >= 0; i--)
        {
            reversedSentence.Append(sentence[i]);
        }

        return sentence == reversedSentence.ToString();
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