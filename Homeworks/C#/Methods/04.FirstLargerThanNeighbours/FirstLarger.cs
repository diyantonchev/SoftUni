using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FirstLarger
{
    static void Main(string[] args)
    {
        int[] sequenceOne = { 1, 3, 4, 5, 1, 0, 5 };
        int[] sequenceTwo = { 1, 2, 3, 4, 5, 6, 6 };
        int[] sequenceThree = { 1, 1, 1 };
        int[] sequenceFour = {10, 1, 3, 5, 53, 2 ,3};

        Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceOne));
        Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceTwo));
        Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceThree));
        Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceFour));
    }

    static int GetIndexOfFirstElementLargerThanNeighbours(int[] numbers)
    {
        int index = -1;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (isLargerThanNeighbours(numbers, i))
            {
                index = i;
                break;
            }
        }
        return index;
    }

    static bool isLargerThanNeighbours(int[] numbers, int index)
    {
        bool isLarger = false;

        if (numbers[index] != numbers[0] && numbers[index] != numbers[numbers.Length - 1])
        {
            if (numbers[index] > numbers[index - 1] && numbers[index] > numbers[index + 1])
            {
                isLarger = true;
            }
        }
        else
        {
            if (numbers[index] == numbers[0])
            {
                if (numbers[0] > numbers[1])
                {
                    isLarger = true;
                }
            }
            else if (numbers[index] == numbers[numbers.Length - 1])
            {
                if (numbers[numbers.Length - 1] > numbers[numbers.Length - 2])
                {
                    isLarger = true;
                }
            }
        }
        return isLarger;
    }
}


