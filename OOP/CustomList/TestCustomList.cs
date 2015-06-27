using System;

class TestCustomList
{
    static void Main()
    {
        var doubleList = new CustomList<double>();

        doubleList.Add(5.5);
        doubleList.Add(6.9);
        doubleList.Add(6.4);
        doubleList.Add(6.7);
        doubleList.Add(5.6);

        int count = doubleList.Count;
        double max = doubleList.Max();
        double min = doubleList.Min();

        Console.WriteLine(doubleList);
        Console.WriteLine("Max: {0}; Min: {1}; Count: {2}", max, min, count);

        doubleList.Remove(6.4);
        doubleList.Remove(5.5);
        doubleList.RemoveAt(1);

        count = doubleList.Count;
        max = doubleList.Max();
        min = doubleList.Min();

        Console.WriteLine(doubleList);
        Console.WriteLine("Max: {0}; Min: {1} Count: {2}", max, min, count);

        doubleList.Clear();
        bool isEmpty = doubleList.isEmpty;
        Console.WriteLine(isEmpty);
        Console.WriteLine(doubleList);

        var stringList = new CustomList<string>();

        stringList.Add("Kircho");
        stringList.Add("Jecho");
        stringList.Add("Mecho");
        stringList.Add("Vulcho");

        bool jecho = stringList.Contais("Jecho");
        bool nencho = stringList.Contais("Nencho");

        string who = stringList.ElementOf(0);
        int index = stringList.IndexOf("Vulcho");
        string maxString = stringList.Max();

        Console.WriteLine(stringList);
        Console.WriteLine("jecho: {0} \nnencho: {1} \nElement of 0 index: {2} \nIndex of Vulcho: {3} \nMax: {4}"
            , jecho, nencho,who, index, maxString);

        string indexer = stringList[3];
        Console.WriteLine(indexer);
    }
}

