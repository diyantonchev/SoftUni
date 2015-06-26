using System;
using System.Collections.Generic;


class JoinLists
{
    static void Main()
    {
        string[] firstInput = Console.ReadLine().Split();
        string[] secondInput = Console.ReadLine().Split();

        var first = new List<int>();
        var second = new List<int>();
        var result = new List<int>();

        first = FillListWith(firstInput);
        second = FillListWith(secondInput);

        result = JoinTwoLists(first, second);
        result = RemoveRepeatingNumbers(result);
        result = SortList(result);

        Console.WriteLine(string.Join(" ", result));
    }

    static List<int> FillListWith(string[] array)
    {
        var list = new List<int>();

        for (int i = 0; i < array.Length; i++)
        {
            list.Add(int.Parse(array[i]));
        }
        return list;
    }

    static List<int> JoinTwoLists(List<int> first, List<int> second)
    {
        var numbers = new List<int>();

        for (int i = 0; i < first.Count; i++)
        {
            numbers.Add(first[i]);
        }

        for (int i = 0; i < second.Count; i++)
        {
            numbers.Add(second[i]);
        }
        return numbers;
    }

    static List<int> RemoveRepeatingNumbers(List<int> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            for (int j = i + 1; j < list.Count; j++)
            {
                if (list[j] == list[i])
                {
                    list.Remove(list[j]);
                    j -= 1;
                }
            }
        }
        for (int i = 0; i < list.Count; i++)
        {
            for (int j = i + 1; j < list.Count; j++)
            {
                if (list[j] == list[i])
                {
                    list.Remove(list[j]);
                    j -= 1;
                }
            }
        }
        return list;
    }

    static List<int> SortList(List<int> list)
    {
        int temp = 0;
        for (int i = 0; i < list.Count; i++)
        {
            for (int j = 0; j < list.Count - 1; j++)
            {
                if (list[j] > list[j + 1])
                {
                    temp = list[j + 1];
                    list[j + 1] = list[j];
                    list[j] = temp;
                }
            }
        }
        return list;
    }
}
