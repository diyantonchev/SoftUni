using System;
using System.Collections.Generic;

class Lists
{
    static void Main()
    {
        List<int> list = new List<int>();
        list.Add(5);
        list.Add(3);
        list.Add(4);
        list.Add(0);
        list.Add(1);
        list.Remove(5);

        foreach (var element in list)
        {
            System.Console.Write(element + " ");
        }

        Console.WriteLine();

        List<DateTime> listDate = new List<DateTime>();
        listDate.Add(new DateTime(2015, 4, 23, 13, 30, 0));
        listDate.Add(new DateTime(2014, 4, 26, 22, 30, 15));

        for (int i = 0; i < listDate.Count; i++)
        {
            Console.WriteLine(listDate[i]);
        }
    }
}
