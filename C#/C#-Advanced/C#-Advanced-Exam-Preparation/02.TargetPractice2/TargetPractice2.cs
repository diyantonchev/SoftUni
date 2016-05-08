using System;

class TargetPractice2
{
    static void Main()
    {
        string[] dimensions = Console.ReadLine().Split();

        int rows = int.Parse(dimensions[0]);
        int cols = int.Parse(dimensions[1]);
        var matrx = new char[rows, cols];

        string snake = Console.ReadLine();

        string[] shotParameters = Console.ReadLine().Split();
        int impactRow = int.Parse(shotParameters[0]);
        int impactCol = int.Parse(shotParameters[1]);
        int radius = int.Parse(shotParameters[2]);

        FillMatrix(matrx, snake);
        ClearMatrix(matrx, impactRow, impactCol, radius);
        RunGravity(matrx);
        PrintMatrix(matrx);
    }


    private static void FillMatrix(char[,] matrx, string text)
    {
        int currentIndex = 0;
        int maxIndex = text.Length - 1;
        bool isEven = true;

        for (int row = matrx.GetLength(0) - 1; row >= 0; row--)
        {
            if (isEven)
            {
                for (int col = matrx.GetLength(1) - 1; col >= 0; col--)
                {
                    if (currentIndex > maxIndex)
                    {
                        currentIndex = 0;
                    }

                    matrx[row, col] = text[currentIndex];
                    currentIndex++;
                }
            }
            else
            {
                for (int col = 0; col < matrx.GetLength(1); col++)
                {
                    if (currentIndex > maxIndex)
                    {
                        currentIndex = 0;
                    }

                    matrx[row, col] = text[currentIndex];
                    currentIndex++;
                }
            }

            isEven = !isEven;
        }
    }

    private static void ClearMatrix(char[,] matrix, int impactRow, int impactCol, int radius)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                bool isInCircle = (impactRow - row) * (impactRow - row) +
                    (impactCol - col) * (impactCol - col) <= radius * radius;

                if (isInCircle)
                {
                    matrix[row, col] = ' ';
                }
            }
        }
    }

    private static void RunGravity(char[,] matrx)
    {
        for (int col = 0; col < matrx.GetLength(1); col++)
        {
            bool hasFallen = true;
            while (hasFallen)
            {
                hasFallen = false;
                for (int row = 1; row < matrx.GetLength(0); row++)
                {
                    if (matrx[row - 1, col] != ' ' && matrx[row,col] == ' ')
                    {
                        matrx[row, col] = matrx[row - 1, col];
                        matrx[row - 1, col] = ' ';
                        hasFallen = true;
                    }
                }
            }
        }
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