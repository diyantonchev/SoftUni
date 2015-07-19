using System;

namespace CommandInterpreter
{
    using System.Collections.Generic;
    using System.Linq;

    class CommandInterpreter
    {
        static void Main()
        {
            string[] collection = Console.ReadLine().Split(new char[] { ' ','\t' }, StringSplitOptions.RemoveEmptyEntries);

            string inputInstructions = Console.ReadLine();
            while (inputInstructions != "end")
            {
                string[] commands = inputInstructions.Split();

                try
                {
                    collection = ProcessCommands(commands, collection);

                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input parameters.");
                }
                
                inputInstructions = Console.ReadLine();
            }

            Console.WriteLine("[{0}]", string.Join(", ", collection));
        }

        private static string[] ProcessCommands(string[] commands, string[] collection)
        {
            string command = commands[0];
            int startIndex;
            int count;
            switch (command)
            {
                case "reverse":
                    startIndex = int.Parse(commands[2]);
                    count = int.Parse(commands[4]);
                    if (!InputParametersIsValid(count,startIndex,collection.Length))
                    {
                        Console.WriteLine("Invalid input parameters.");
                        return collection;
                    }
                    return ProcessReverseCommand(startIndex, count, collection);
                case "sort":
                    startIndex = int.Parse(commands[2]);
                    count = int.Parse(commands[4]);
                    if (!InputParametersIsValid(count, startIndex, collection.Length))
                    {
                        Console.WriteLine("Invalid input parameters.");
                        return collection;
                    }
                    return ProcessSortCommand(startIndex, count, collection);
                case "rollLeft":
                    count = int.Parse(commands[1]);
                    if (!InputParametersIsValid(count))
                    {
                        Console.WriteLine("Invalid input parameters.");
                        return collection;
                    }               
                    return ProcessRollLeftCommand(count, collection);
                case "rollRight":
                    count = int.Parse(commands[1]);
                    if (!InputParametersIsValid(count))
                    {
                        Console.WriteLine("Invalid input parameters.");
                        return collection;
                    }               
                    return ProcessRollRightCommand(count, collection);
                default:
                    return collection;
            }
        }

        private static bool InputParametersIsValid(int count, int startIndex, int lenght)
        {
            if (!InputParametersIsValid(count))
            {
                return false;
            }
            
            if (startIndex < 0 || startIndex >= lenght)
            {
                return false;
            }
            if (startIndex + count > lenght)
            {
                return false;
            }
            return true;
        }

        private static bool InputParametersIsValid(int count)
        {
            if (count < 0)
            {
                return false;
            }
            return true;
        }

        private static string[] ProcessReverseCommand(int startIndex, int count, string[] collection)
        {

            string[] portion = new string[count];
            int lastIndex = startIndex + count - 1;
            int currentIndex = 0;

            for (int i = lastIndex; i >= startIndex; i--)
            {
                portion[currentIndex] = collection[i];
                currentIndex++;
            }

            currentIndex = 0;
            for (int i = startIndex; i <= lastIndex; i++)
            {
                collection[i] = portion[currentIndex];
                currentIndex++;
            }

            return collection;
        }

        private static string[] ProcessSortCommand(int startIndex, int count, string[] collection)
        {
            string[] portion = new string[count];
            int lastIndex = startIndex + count - 1;
            int currentIndex = 0;

            for (int i = startIndex; i <= lastIndex; i++)
            {
                portion[currentIndex] = collection[i];
                currentIndex++;
            }

            portion = Sort(portion);

            currentIndex = 0;
            for (int i = startIndex; i <= lastIndex; i++)
            {
                collection[i] = portion[currentIndex];
                currentIndex++;
            }

            return collection;
        }

        private static string[] ProcessRollLeftCommand(int count, string[] collection)
        {
            var collectionToManipulate = new List<string>(collection);

            for (int i = 0; i < collection.Length; i++)
            {
                string currentElement = collection[i];

                int lastPosition = collection.Length - 1;
                int nextPosition = i - count;
                if (nextPosition < 0)
                {
                    nextPosition = lastPosition - (lastPosition - Math.Abs(1 - count));
                }

                collectionToManipulate.Insert(nextPosition, currentElement);
            }

            collection = collectionToManipulate.Distinct().ToArray();
            return collection;
        }

        private static string[] ProcessRollRightCommand(int count, string[] collection)
        {
            var collectionToManipulate = new List<string>(collection);

            for (int i = 0; i < collection.Length; i++)
            {
                string currentElement = collection[i];
                int movementPositions = count;
                int nextPosition = (i + movementPositions) % collection.Length;
                collectionToManipulate.Insert(nextPosition, currentElement);
            }

            collection = collectionToManipulate.Distinct().ToArray();
            return collection;
        }

        private static string[] Sort(string[] collection)
        {
            bool hasSwaped = true;

            while (hasSwaped)
            {
                hasSwaped = false;

                for (int i = 1; i < collection.Length; i++)
                {
                    string currentElement = collection[i];
                    string previousElemennt = collection[i - 1];

                    if (string.Compare(previousElemennt, currentElement, StringComparison.InvariantCulture) > 0)
                    {
                        collection[i] = previousElemennt;
                        collection[i - 1] = currentElement;
                        hasSwaped = true;
                    }
                }
            }

            return collection;
        }
    }
}