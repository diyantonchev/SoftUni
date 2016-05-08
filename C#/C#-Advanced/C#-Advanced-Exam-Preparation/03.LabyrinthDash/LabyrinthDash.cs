using System;
using System.Collections.Generic;

class LabyrinthDash
{
    private static void Main()
    {
        int labyrinthRows = int.Parse(Console.ReadLine());
        var labyrinth = new List<char[]>();

        for (int rows = 0; rows < labyrinthRows; rows++)
        {
            labyrinth.Add(Console.ReadLine().ToCharArray());
        }

        var moveCommands = new List<char>(Console.ReadLine().ToCharArray());

        int row = 0;
        int col = 0;
        int lives = 3;
        int moves = 0;       
        
        foreach (char command in moveCommands)
        {
            int[] direction = GetDirection(row, col, command);
            row = direction[0];
            col = direction[1];
            if (row >= labyrinthRows || row < 0 || col < 0 || col >= labyrinth[row].Length)
            {
                moves++;
                Console.WriteLine("Fell off a cliff! Game Over!");
                break;
            }

            char currentSymbol = labyrinth[row][col];
            switch (currentSymbol)
            {
                case '.':
                    Console.WriteLine("Made a move!");
                    moves++;
                    break;
                case '|':
                    switch (command)
                    {
                        case '>':
                            col--;
                            break;
                        case'<':
                            col++;
                            break;
                        case '^':
                            row++;
                            break;
                        case 'v':
                            row--;
                            break;
                    }
                    Console.WriteLine("Bumped a wall.");
                    break;
                case '_':
                    switch (command)
                    {
                        case '>':
                            col--;
                            break;
                        case '<':
                            col++;
                            break;
                        case '^':
                            row++;
                            break;
                        case 'v':
                            row--;
                            break;
                    }
                    Console.WriteLine("Bumped a wall.");
                    break;
                case '@':
                    lives--;
                    Console.WriteLine("Ouch! That hurt! Lives left: {0}",lives);                
                    moves++;
                    break;
                case '#':
                    lives--;
                    Console.WriteLine("Ouch! That hurt! Lives left: {0}", lives);
                    moves++;
                    break;
                case '*':
                    lives--;
                    Console.WriteLine("Ouch! That hurt! Lives left: {0}", lives);
                    moves++;
                    break; 
                case '$':
                    lives++;
                    Console.WriteLine("Awesome! Lives left: {0}",lives);
                    moves++;
                    labyrinth[row][col] = '.';
                    break;
            }
            if (lives <= 0)
            {
                Console.WriteLine("No lives left! Game Over!");
                break;
            }
        }
        Console.WriteLine("Total moves made: {0}", moves);
    }

    private static int[] GetDirection(int row, int col, char move)
    {
        var direction = new int[2];
        switch (move)
        {
            case '^':
                row--;
                break; ;
            case 'v':
                row++;
                break;
            case '>':
                col++;
                break;
            case '<':
                col--;
                break;
        }
        direction[0] = row;
        direction[1] = col;
        return direction;
    }
}