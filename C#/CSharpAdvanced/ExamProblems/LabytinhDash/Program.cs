using System;

class LabyrinthDash
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        char[][] labyrinth = new char[n][];
        for (int i = 0; i < n; i++)
        {
            string inputString = Console.ReadLine();
            labyrinth[i] = new char[inputString.Length];
            for (int j = 0; j < inputString.Length; j++)
            {
                labyrinth[i][j] = inputString[j];
            }
        }

        string moveCommands = Console.ReadLine();
        int lives = 3;
        int moves = 0;
        int row = 0;
        int col = 0;

        foreach (var directrion in moveCommands)
        {
            int previousRow = row;
            int previousCol = col;        

            switch (directrion)
            {
                case 'v': row++;
                    break;
                case '^': row--;
                    break;
                case '>': col++;
                    break;
                case '<': col--;
                    break;
            }

            if (isCellInsideOfTheMatrix(row, col, labyrinth))
            {
                if (labyrinth[row][col] == '.')
                {
                    moves++;
                    Console.WriteLine("Made a move!");
                }               
                if (labyrinth[row][col] == '@' || labyrinth[row][col] == '#' || labyrinth[row][col] == '*')
                {
                    lives -= 1;
                    moves++;
                    Console.WriteLine("Ouch! That hurt! Lives left: {0}", lives);
                    if (lives <= 0)
                    {
                        Console.WriteLine("No lives left! Game Over!");
                        break;
                    }
                }
                if (labyrinth[row][col] == '$')
                {
                    lives++;
                    moves++;
                    labyrinth[row][col] = '.';
                    Console.WriteLine("Awesome! Lives left: {0}", lives);
                }          
                if (labyrinth[row][col] == ' ')
                {
                    moves++;
                    Console.WriteLine("Fell off a cliff! Game Over!");
                    break;
                }
                if (labyrinth[row][col] == '|' || labyrinth[row][col] == '_')
                {
                    Console.WriteLine("Bumped a wall.");
                    col = previousCol;
                    row = previousRow;
                }
            }
            else
            {
                moves++;
                Console.WriteLine("Fell off a cliff! Game Over!");
                break;
            }
        }
        Console.WriteLine("Total moves made: {0}", moves);
    }

    static bool isCellInsideOfTheMatrix(int row, int col, char[][] labyrinth)
    {
        bool isRowInside = 0 <= row && row < labyrinth.Length;

        if (!isRowInside)
        {
            return false;
        }

        return 0 <= col && col < labyrinth[row].Length;
    }
}

