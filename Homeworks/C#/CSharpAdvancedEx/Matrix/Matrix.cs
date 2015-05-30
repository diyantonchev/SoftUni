using System;

class Matrix
{
    static void Main()
    {
        int[,] matrix = new int[4, 5];

        int num = 1;
        bool bin = true;

        for (int row = 0; row < 4; row++)
        {
            for (int col = 0; col < 5; col++)
            {
                matrix[row, col] = num;
                
                if (bin)
                {
                    num--;
                }
                else
                {
                    num = 1;
                }
                
                bin = !bin;

            }
        }
        for (int row = 0; row < 4; row++)
        {
            for (int col = 0; col < 5; col++)
            {
                Console.Write(matrix[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
}

