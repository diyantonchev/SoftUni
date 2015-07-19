using System;
using System.Collections.Generic;

class CommandInterpreter
{
    static void Main()
    {
        char[] separator = new char[] { ' ', '\t' };
        var collection = new List<string>(Console.ReadLine()
            .Split(separator, StringSplitOptions.RemoveEmptyEntries));

        var input = Console.ReadLine();
        while (input != "end")
        {
            var commands = input.Split(separator, StringSplitOptions.RemoveEmptyEntries);

            string command = commands[0];
            int index;
            int count;

            switch (command)
            {
                case "reverse":
                    index = int.Parse(commands[2]);
                    count = int.Parse(commands[4]);

                    if (index < 0 ||
                        index > collection.Count - 1 ||
                        count < 0 ||
                        count > collection.Count ||
                        count + index > collection.Count)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        break;
                    }

                    ExecuteReverseCommand(collection, index, count);
                    break;
                case "sort":
                    index = int.Parse(commands[2]);
                    count = int.Parse(commands[4]);

                    if (index < 0 ||
                       index > collection.Count - 1 ||
                       count < 0 ||
                       count > collection.Count||
                       count + index > collection.Count)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        break;
                    }

                    ExecuteSortCommand(collection, index, count);
                    break;
                case "rollLeft":
                    count = int.Parse(commands[1]);

                    if (count < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        break;
                    }

                    ExecuteRollLeftCommand(collection, count);
                    break;
                case "rollRight":
                    count = int.Parse(commands[1]);

                    if (count < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        break;
                    }

                    ExecuteRollRightCommand(collection, count);
                    break;
            }

            input = Console.ReadLine();
        }

        Console.WriteLine("[{0}]", string.Join(", ", collection));
    }

    private static void ExecuteRollRightCommand(List<string> collection, int count)
    {
        int rolls = count % collection.Count;
        while (rolls > 0)
        {
            int lastIndex = collection.Count - 1;
            string lastElement = collection[lastIndex];

            collection.RemoveAt(lastIndex);
            collection.Insert(0, lastElement);

            rolls--;
        }
    }

    private static void ExecuteRollLeftCommand(List<string> collection, int count)
    {
        int rolls = count % collection.Count;
        while (rolls > 0)
        {
            int lastIndex = collection.Count - 1;
            string firstElement = collection[0];

            collection.RemoveAt(0);
            collection.Insert(lastIndex, firstElement);

            rolls--;
        }
    }

    private static void ExecuteSortCommand(List<string> collection, int index, int count)
    {
        collection.Sort(index, count, StringComparer.InvariantCulture);
    }

    private static void ExecuteReverseCommand(List<string> collection, int index, int count)
    {
        collection.Reverse(index,count);
    }
}
