using System;

class MatrixShuffling
{
    static void Main()
    {
        string[,] matrix = ReadMatrix();

        string input = string.Empty;
        bool isNotTheEnd = true;

        while (isNotTheEnd)
        {
            try
            {
                input = Console.ReadLine();
                string[] inputArray = input.Split();

                if (inputArray[0] != "swap" || inputArray.Length < 5 || inputArray.Length > 5)
                {
                    if (inputArray[0] == "END")
                    {
                        isNotTheEnd = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Invalid input!");
                        Console.WriteLine();
                    }
                }

                int xOne = int.Parse(inputArray[1]);
                int yOne = int.Parse(inputArray[2]);
                int xTwo = int.Parse(inputArray[3]);
                int yTwo = int.Parse(inputArray[4]);

                string temp = string.Empty;

                temp = matrix[xOne, yOne];
                matrix[xOne, yOne] = matrix[xTwo, yTwo];
                matrix[xTwo, yTwo] = temp;

                Console.WriteLine();
                PrintMatrix(matrix);
                Console.WriteLine();

            }
            catch (Exception)
            {
                Console.WriteLine();
                Console.WriteLine("Invalid input!");
                Console.WriteLine();
            }
        }
    }
    static string[,] ReadMatrix()
    {
        int rows = Int32.Parse(Console.ReadLine());
        int cols = Int32.Parse(Console.ReadLine());

        string[,] matrix = new string[rows, cols];


        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = Console.ReadLine();
            }
        }
        return matrix;
    }

    static string[,] PrintMatrix(string[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,-1} ",matrix[row,col]);
            }
            Console.WriteLine();
        }
        return matrix;
    }
}
