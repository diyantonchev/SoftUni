using System;
using System.Collections.Generic;

class Test
{
    static void Main()
    {
        var collection = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

        int first = collection.FirstOrDefault(Even);

        Console.WriteLine(first);
        Console.WriteLine(collection.FirstOrDefault(x => x > 4));

        var allEven = collection.TakeWhile(Even);
        Console.WriteLine(string.Join(" ",allEven));
        Console.WriteLine(string.Join(" ", collection.TakeWhile(x => x < 10)));

        collection.ForEach(Console.WriteLine);
    }

    static bool Even(int number)
    {
        if (number % 2 == 0)
        {
            return true;
        }
        return false;
    }
}