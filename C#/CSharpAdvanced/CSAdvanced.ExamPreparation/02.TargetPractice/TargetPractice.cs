using System;

class TargetPractice
{
    static void Main()
    {
        string[] matrixParameter = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int rows = int.Parse(matrixParameter[0]);
        int cols = int.Parse(matrixParameter[1]);

        string snake = Console.ReadLine();

        string[] shotParameters = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int impactRow = int.Parse(shotParameters[0]);
        int impactColumn = int.Parse(shotParameters[1]);
        int radius = int.Parse(shotParameters[2]);

        char[,] matrix = new char[rows, cols];
        matrix = FillMatrix(matrix, snake);
        matrix = Blast(matrix, impactRow, impactColumn, radius);
        matrix = FallingDown(matrix);
        PrintMatrix(matrix);
    }
    static char[,] FillMatrix(char[,] matrix, string snake)
    {
        int index = 0;
        bool reverseRow = true;
        for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
        {
            if (reverseRow)
            {
                for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                {
                    if (index >= snake.Length)
                    {
                        index = 0;
                    }
                    matrix[row, col] = snake[index];
                    index++;
                }
            }
            else
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (index >= snake.Length)
                    {
                        index = 0;
                    }
                    matrix[row, col] = snake[index];
                    index++;
                }
            }
            reverseRow = !reverseRow;
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
    static char[,] Blast(char[,] matrix, int impacRow, int impactColumn, int radius)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                bool isInTheBlastArea = (Math.Pow(impacRow - row, 2) + Math.Pow(impactColumn - col, 2)) <= Math.Pow(radius, 2);
                if (isInTheBlastArea)
                {
                    matrix[row, col] = ' ';
                }
            }
        }
        return matrix;
    }
    static char[,] FallingDown(char[,] matrix)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            while (true)
            {
                bool hasFallen = false;
                for (int row = 1; row < matrix.GetLength(0); row++)
                {
                    char topChar = matrix[row - 1, col];
                    char currentChar = matrix[row, col];
                    if (currentChar == ' ' && topChar != ' ')
                    {
                        matrix[row, col] = topChar;
                        matrix[row - 1, col] = ' ';
                        hasFallen = true;
                    }
                }
                if (!hasFallen)
                {
                    break;
                }
            }
        }
        return matrix;
    }
}