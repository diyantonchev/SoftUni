using System;

class FillMatrix
{
    static void Main()
    {
        int n = Int32.Parse(Console.ReadLine());

        var firstMatrix = new double[n, n];
        var secondMatrix = new double[n, n];

        int count = 1;
 
        for (int col = 0; col < firstMatrix.GetLength(1); col++)
        {
            for (int row = 0; row < firstMatrix.GetLength(0); row++)
            {
                firstMatrix[row, col] = count;
                count++;
            }
        }

        PrintMatrix(firstMatrix);
       
        Console.WriteLine();
        Console.WriteLine();

        count = 1;
        for (int col = 0; col < secondMatrix.GetLength(1); col++)
        {
            for (int row = 0; row < secondMatrix.GetLength(0); row++)
            {
                if (col % 2 == 0)
                {
                    secondMatrix[row, col] = count;
                    count++;
                }
                else
                {
                    secondMatrix[(firstMatrix.GetLength(0) - 1) - row, col] = count;
                    count++;
                }
            }
        }
       
        PrintMatrix(secondMatrix);
    }
    static void PrintMatrix(double[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,-4}", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}

