using System;
using System.Collections.Generic;

class PascalTriangle
{
    static void Main()
    {
        int height = int.Parse(Console.ReadLine());

        int[][] triangle = new int[height][];

        triangle[0] = new int[1];
        triangle[0][0] = 1;

        for (int row = 1; row < height; row++)
        {
            triangle[row] = new int[row + 1];
            triangle[row][0] = 1;

            for (int col = 1; col <= row - 1; col++)
            {
                triangle[row][col] = triangle[row - 1][col - 1] + triangle[row - 1][col];
            }
            triangle[row][row] = 1;
        }

        for (int row = 0; row < triangle.Length; row++)
        {
            Console.Write("".PadLeft((height - row) * 2));
            for (int col = 0; col < triangle[row].Length; col++)
            {
                Console.Write("{0,3} ", triangle[row][col]);
            }
            Console.WriteLine();
        }
    }
}
