using System;
using System.Collections.Generic;

class CollectTheCoin
{
    static void Main()
    {
        char[][] board = new char[4][];

        board = FillTheJaggedArray(board);
        //PrinTheJaggedArray(board);
        string movements = Console.ReadLine();

        int row = 0;
        int col = 0;
        int coins = 0;
        int wallsHit = 0;
        for (int i = 0; i < movements.Length; i++)
        {         
            switch (movements[i])
            {
                case 'V': row += 1;
                    try
                    {
                        if (board[row][col] == '$')
                        {
                            coins++;
                        }
                    }
                    catch (Exception)
                    {
                        row -= 1;
                        wallsHit++;
                    }
                    break;
                case '^': row -= 1;
                    try
                    {
                        if (board[row][col] == '$')
                        {
                            coins++;
                        }
                    }
                    catch (Exception)
                    {
                        row += 1;
                        wallsHit++;
                    }
                    break;
                case '>': col += 1;
                    try
                    {
                        if (board[row][col] == '$')
                        {
                            coins++;
                        }
                    }
                    catch (Exception)
                    {
                        col -= 1;
                        wallsHit++;
                    }
                    break;
                case '<': col -= 1;
                    try
                    {
                        if (board[row][col] == '$')
                        {
                            coins++;
                        }
                    }
                    catch (Exception)
                    {
                        col += 1;
                        wallsHit++;
                    }
                    break;
                default:
                    break;
            }
        }
        Console.WriteLine();
        Console.WriteLine("Coins collected: {0}", coins);
        Console.WriteLine("Walls hit: {0}", wallsHit);
    }
    static char[][] FillTheJaggedArray(char[][] jaggedArray)
    {
        for (int i = 0; i < jaggedArray.GetLength(0); i++)
        {
            string input = Console.ReadLine();
            jaggedArray[i] = new char[input.Length];

            for (int j = 0; j < input.Length; j++)
            {
                jaggedArray[i][j] = input[j];
            }
        }
        return jaggedArray;
    }

    static void PrinTheJaggedArray(char[][] jaggedArray)
    {
        for (int i = 0; i < jaggedArray.GetLength(0); i++)
        {
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                Console.Write(jaggedArray[i][j]);
            }
            Console.WriteLine();
        }
    }
}


