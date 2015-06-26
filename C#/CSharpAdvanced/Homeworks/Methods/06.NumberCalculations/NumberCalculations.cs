using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class NumberCalculations
{
    static void Main(string[] args)
    {
        Console.Write("Insert set of numbers separated by a space: ");
        var numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

        HashSet<double> setDouble = new HashSet<double>();

        for (int i = 0; i < numbers.Length; i++)
        {
            setDouble.Add(numbers[i]);
        }

        double sum = Sum(numbers);
        double average = Average(numbers);
        double product = Product(numbers);
        double min = Min(numbers);
        double max = Max(numbers);

        Console.WriteLine("The sum of numbers is: {0}", sum);
        Console.WriteLine("The average of numbers is: {0}", average);
        Console.WriteLine("The product of numbers is: {0}", product);
        Console.WriteLine("The min number is: {0}", min);
        Console.WriteLine("The max number is: {0}", max);

        var setInt = new int[] { 1, 2, 3, 4 };
        
        int sumInt = Sum(setInt);
        float averageInt = Average(setInt);
        int productInt = Product(setInt);
        int minInt = Min(setInt);
        int maxInt = Max(setInt);

        Console.WriteLine();
        Console.WriteLine("Sum {0}; Average: {1}, Product: {2};  Min: {3}; Max: {4};", sumInt, averageInt, productInt, minInt, maxInt);
    }

    static double Sum(params double[] set)
    {
        double sum = 0;
        for (int i = 0; i < set.Length; i++)
        {
            sum += set[i];
        }
        return sum;
    }

    static double Average(params double[] set)
    {
        double sum = 0;
        for (int i = 0; i < set.Length; i++)
        {
            sum += set[i];
        }
        double average = sum / set.Length;
        return average;
    }

    static double Product(params double[] set)
    {
        double product = 1;
        for (int i = 0; i < set.Length; i++)
        {
            product *= set[i];
        }
        return product;
    }

    static double Min(params double[] set)
    {
        double min = double.MaxValue;
        for (int i = 0; i < set.Length; i++)
        {
            if (min > set[i])
            {
                min = set[i];
            }
        }
        return min;
    }

    static double Max(params double[] set)
    {
        double max = double.MinValue;
        for (int i = 0; i < set.Length; i++)
        {
            if (max < set[i])
            {
                max = set[i];
            }
        }
        return max;
    }

    static int Sum(params int[] set)
    {
        int sum = 0;
        for (int i = 0; i < set.Length; i++)
        {
            sum += set[i];
        }
        return sum;
    }

    static float Average(params int[] set)
    {
        int sum = 0;
        for (int i = 0; i < set.Length; i++)
        {
            sum += set[i];
        }
        float average = (float)sum / set.Length;
        return average;
    }

    static int Product(params int[] set)
    {
        int product = 1;
        for (int i = 0; i < set.Length; i++)
        {
            product *= set[i];
        }
        return product;
    }

    static int Min(params int[] set)
    {
        int min = int.MaxValue;
        for (int i = 0; i < set.Length; i++)
        {
            if (min > set[i])
            {
                min = set[i];
            }
        }
        return min;
    }

    static int Max(params int[] set)
    {
        int max = int.MinValue;
        for (int i = 0; i < set.Length; i++)
        {
            if (max < set[i])
            {
                max = set[i];
            }
        }
        return max;
    }
}
