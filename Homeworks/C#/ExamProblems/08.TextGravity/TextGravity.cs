using System;
using System.Security;
using System.Text;

class TextGravity
{
    static void Main()
    {
        int totalCols = int.Parse(Console.ReadLine());
        string text = Console.ReadLine();

        int rows = text.Length / totalCols;
        if (text.Length % totalCols != 0)
        {
            rows += 1;
        }

        char[][] matrix = new char[rows][];
        int currentCharIndex = 0;
        for (int row = 0; row < rows; row++)
        {
            matrix[row] = new char[totalCols];
            for (int col = 0; col < totalCols; col++)
            {
                if (currentCharIndex < text.Length)
                {
                    matrix[row][col] = text[currentCharIndex];
                    currentCharIndex++;
                }
                else
                {
                    matrix[row][col] = ' ';
                }
            }
        }
        for (int col = 0; col < totalCols; col++)
        {
            RunGravity(matrix, col);
        }
       
        var output = new StringBuilder();
        output.Append("<table>");
        for (int row = 0; row < matrix.Length; row++)
        {
            output.Append("<tr>");
            for (int col = 0; col < totalCols; col++)
            {
                output.AppendFormat("<td>{0}</td>",SecurityElement.Escape(matrix[row][col].ToString()));
            }
            output.Append("</tr>");
        }
        output.Append("</table>");
        Console.WriteLine(output.ToString());
    }

    private static void RunGravity(char[][] matrix, int col)
    {
        while (true)
        {
            bool hasFallen = false;
            for (int row = 1; row < matrix.Length; row++)
            {
                char topChar = matrix[row - 1][col];
                char currentChar = matrix[row][col];
                if (currentChar == ' ' && topChar != ' ')
                {
                    matrix[row][col] = topChar;
                    matrix[row - 1][col] = ' ';
                    hasFallen = true;
                }
            }
            if (!hasFallen)
            {
                break;
            }
        }
    }
}
