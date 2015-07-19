using System;
using System.Collections.Generic;
using System.Linq;

class BunkerBuster
{
    static void Main()
    {
        int[] size = Console.ReadLine().Trim()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int numberOfRows = size[0];
        int numberOfCols = size[1];

        var matrix = new List<double[]>();
        for (int i = 0; i < numberOfRows; i++)
        {
            double[] currentRow = Console.ReadLine().Trim()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            matrix.Add(currentRow);
        }

        string commands = Console.ReadLine().Trim();
        while (commands != "cease fire!")
        {
            string[] bomb = commands.Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries);

            int impactRow = int.Parse(bomb[0]);
            int impactCol = int.Parse(bomb[1]);
            char symbol = bomb[2][0]; 
            int power = symbol;

            matrix[impactRow][impactCol] -= power;
            int firstCase = power;
            double halfedPower = Math.Ceiling((double)power / 2);  

            for (int row = 0; row < matrix.Count; row++)
            {
                
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    bool isAdjacentCol = (col == impactCol - 1 ) || (col == impactCol + 1) ||
                        col == impactCol;
                    bool isAdjacentRow = (row == impactRow - 1)
                        || (row == impactRow + 1) || row == impactRow;
                    bool isInside = isAdjacentRow && isAdjacentCol;

                    if (isInside)
                    {                      
                           matrix[row][col] -= halfedPower;   
                    }
                }   
            }
            if (Math.Abs(firstCase - matrix[impactRow][impactCol]) > 0.02)
            {
                matrix[impactRow][impactCol] += halfedPower;
            }
          
            commands = Console.ReadLine();
        }

        int destroyedCells = GetDestroyedCellsCount(matrix);
        int cellstCount = numberOfRows * numberOfCols;
        double statistic = ((double)destroyedCells / cellstCount) * 100;

        Console.WriteLine("Destroyed bunkers: {0}",destroyedCells);
        Console.WriteLine("Damage done: {0:F1} %",statistic);
        // PrintMatrix(matrix);
    }

    private static int GetDestroyedCellsCount(List<double[]> matrix)
    {
        int counter = 0;
        foreach (double[] t in matrix)
        {
            for (int col = 0; col < t.Length; col++)
            {
                if (t[col] <= 0)
                {
                    counter++;
                }   
            }
        }

        return counter;
    }

    static void PrintMatrix(List<double[]> matrix)
    {
        for (int row = 0; row < matrix.Count; row++)
        {
            for (int col = 0; col < matrix[row].Length; col++)
            {
                Console.Write(" {0} ",matrix[row][col]);
            }

            Console.WriteLine();
        }
    }
}