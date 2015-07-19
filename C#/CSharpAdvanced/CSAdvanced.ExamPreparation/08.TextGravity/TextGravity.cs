using System;
using System.Collections.Generic;
using System.Security;

internal class TextGravity
{
    private static void Main()
    {
        int lineLength = int.Parse(Console.ReadLine());
        string text = Console.ReadLine();

        var table = new List<char[]>();
        int textLenght = text.Length;
        int currentIndex = 0;

        while (currentIndex < textLenght)
        {
            var currentRow = new char[lineLength];
            for (int col = 0; col < currentRow.Length; col++)
            {
                if (currentIndex >= textLenght)
                {
                    currentRow[col] = ' ';
                }
                else
                {
                    currentRow[col] = text[currentIndex];
                    currentIndex++;
                }
            }
            table.Add(currentRow);
        }

        RunGravity(table, lineLength);
        PrintTable(table);
    }

    private static void RunGravity(List<char[]> table, int lineLength)
    {
        for (int col = 0; col < lineLength; col++)
        {
            bool hasFallen = true;
            while (hasFallen)
            {
                hasFallen = false;
                for (int row = table.Count - 1; row > 0; row--)
                {
                    char currentSymbol = table[row][col];
                    char upperSymbol = table[row - 1][col];

                    if (currentSymbol == ' ' && upperSymbol != ' ')
                    {
                        table[row][col] = upperSymbol;
                        table[row - 1][col] = currentSymbol;
                        hasFallen = true;
                    }
                }
            }
        }
    }

    private static void PrintTable(List<char[]> table)
    {
        Console.Write("<table>");
        for (int row = 0; row < table.Count; row++)
        {
            Console.Write("<tr>");
            for (int col = 0; col < table[row].Length; col++)
            {
                Console.Write("{0}{1}{2}", "<td>", SecurityElement.Escape(table[row][col].ToString()), "</td>");
            }
            Console.Write("</tr>");
        }
        Console.Write("</table>");
    }
}