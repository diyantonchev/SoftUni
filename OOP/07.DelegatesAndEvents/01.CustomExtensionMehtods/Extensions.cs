using System;
using System.Collections.Generic;

public static class Extensions 
{
    public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collection, Func<T,bool> predicate)
    {
        var result = new List<T>();
        foreach (var element in collection)
        {
            if (!predicate(element))
            {
                result.Add(element);
            }
        }
        return result;
    }

    public static TSelector Max<TSource,TSelector>(
        this IEnumerable<TSource> collection, Func<TSource,TSelector> selectFunction)
        where TSelector : IComparable<TSelector>
    {
        TSelector max = default(TSelector);
        foreach (var element in collection)
        {
            TSelector currentElement = selectFunction(element);
           
            if (currentElement.CompareTo(max) == 1)
            {
                max = currentElement;
            }
        }
        return max;
    }

    public static TSelector Min<TSource, TSelector>(
        this IEnumerable<TSource> collection, Func<TSource, TSelector> selectFunction)
        where TSelector : IComparable<TSelector>
    {
        TSelector min = collection.Max(selectFunction);
        foreach (var element in collection)
        {
            TSelector currentElement = selectFunction(element);

            if (currentElement.CompareTo(min) < 0)
            {
                min = currentElement;
            }
        }
        return min;
    }
}