using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

class ArraySlider
{
    static void Main()
    {
        List<BigInteger> collection =
            Console.ReadLine()
                .Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(BigInteger.Parse)
                .ToList();

        int currentIndex = 0;
        string input = Console.ReadLine();
        while (input != "stop")
        {
            string[] commands = input.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            int offset = int.Parse(commands[0]);
            string operation = commands[1];
            int operand = int.Parse(commands[2]);

            currentIndex += offset;
            if (currentIndex > collection.Count - 1)
            {
                int newIndex =  (currentIndex) % collection.Count;
                currentIndex = newIndex;
            }

            if (currentIndex < 0)
            {
                int newIndex = (Math.Abs(currentIndex) % collection.Count);
                if (newIndex == 0)
                {
                    currentIndex = newIndex;
                }
                else
                {
                    currentIndex = collection.Count - newIndex;
                }        
            }

            switch (operation)
            {
                case "&":
                    collection[currentIndex] &= operand;
                    break;
                case "|":
                    collection[currentIndex] |=  (long)operand;
                    break;
                case "^":
                    collection[currentIndex] ^= (long)operand;
                    break;
                case "+":
                    collection[currentIndex] += operand;
                    break;
                case "-":
                    collection[currentIndex] -= operand;
                    if (collection[currentIndex] < 0)
                    {
                        collection[currentIndex] = 0;
                    }
                    break;
                case "/":
                    collection[currentIndex] /= (long)operand;
                    break;
                case "*":
                    collection[currentIndex] *= operand;
                    break;
            }

            input = Console.ReadLine();
        }

        var output = new StringBuilder();
        output.AppendFormat("[{0}]", string.Join(", ", collection));
        Console.WriteLine(output);
   }
}